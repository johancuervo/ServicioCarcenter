import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html'
})
export class EditComponent {

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
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute, private router: Router, private formBuilder: FormBuilder) {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      http.get<Clientes>(baseUrl + 'api/Clientes/' + this.id).subscribe(result => {
        this.checkoutForm.patchValue({
          tipoDocumento: result.tipoDocumento,
          documento: result.documento,
          primerNombre: result.primerNombre,
          segundoNombre: result.segundoNombre,
          primerApellido: result.primerApellido,
          segundoApellido: result.segundoApellido,
          celular: result.celular,
          direccion: result.direccion,
          correo: result.correo,
        });
      });
    }, error => console.error(error));
  }

  onSubmit(): void {
    this.http.put<Clientes>(this.baseUrl + 'api/Clientes/'+this.id, this.checkoutForm.value).subscribe(result => {
      this.router.navigate([""])
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
