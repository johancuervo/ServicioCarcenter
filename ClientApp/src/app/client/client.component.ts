import { HttpClient } from '@angular/common/http';
import { Component,Inject } from '@angular/core';
import { error } from 'protractor';

@Component({
  selector: 'app-client-component',
  templateUrl:"./client.component.html"
})
export class ClientComponent {
  public ltsCliente: string[];
  constructor(http: HttpClient,@Inject("Base_URL") baseUrl:string) {
    http.get <Message[]>(baseUrl + "api/Clientes/Index").subscribe(result => {
      this.ltsCliente = result;

    }, error => console.error(error));
  }
}

interface Message {
  id: number;
  primerNombre: string;
  primerApellido: string;
}
