import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html'
})
export class DetailComponent {
  public cliente: Clientes;
  public id: number;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string,private route:ActivatedRoute) {
  this.route.params.subscribe(params => {
    this.id = +params['id'];
  http.get<Clientes>(baseUrl + 'api/Clientes/' + this.id).subscribe(result => {
    this.cliente = result;
  });
    }, error => console.error(error));
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
