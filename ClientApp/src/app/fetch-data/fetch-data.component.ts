import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {  Router } from '@angular/router';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public clientes: Clientes[];

  constructor(private http: HttpClient, @Inject('BASE_URL')  private baseUrl: string, private route: Router) {
    http.get<Clientes[]>(baseUrl + 'api/Clientes').subscribe(result => {
      this.clientes = result;
    }, error => console.error(error));
  }
  redirectDetail(id: number): void {
    this.route.navigate(["detail/", id]);
  }
  delete(id: number): void {
    this.http.delete<Clientes[]>(this.baseUrl + 'api/Clientes/' + id).subscribe(result => {
      this.clientes = this.clientes.filter(cliente => cliente.id !== id);
    }, error => console.error(error));
  }
  redirectToCreate(): void {
    this.route.navigate(["create"]);
  }
redirectToEdit(id: number): void {
    this.route.navigate(["edit/", id]);
  }
}


interface Clientes {
  id: number;
  tipoDocumento: String;
  documento: number;
  primerNombre: String;
  segundoNombre: String;
  primerApellido: String;
  segundoApellido: String;
  celular: number;
  direccion: String;
  correo: String;


}
