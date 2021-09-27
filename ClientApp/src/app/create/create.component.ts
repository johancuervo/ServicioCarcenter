import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html'
})
export class CreateComponent {

  public cliente: Clientes;
  public id: number;
  checkoutForm = this.formBuilder.group({
    tipoDocumento: '',
    documento: '',
    primerNombre: '',
    segundoNombre: '',
    primerApellido: '',
    segundoApellido: '',
    celular: '',
    direccion: '',
    correo:''
  });
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: Router,private formBuilder: FormBuilder) {
   
  }

  onSubmit(): void {
    this.http.post<Clientes>(this.baseUrl + 'api/Clientes', this.checkoutForm.value).subscribe(result => {
      this.route.navigate([""])
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
