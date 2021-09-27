using Carcenter.Models.DB;
using Carcenter.Models.Response;
using Carcenter.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carcenter.Controllers
{
    [Route("api/[controller]")]              
    public class ClientesController : Controller
    {
        [HttpGet]
        public IEnumerable<ClienteModel> Index()
        {
            List<ClienteModel> lClientes;
                using (var db = new CarcenterContext())
                {
                   lClientes = (from d in db.Clientes
                                                    select new ClienteModel
                                                    {
                                                        id = d.Id,
                                                        tipoDocumento = d.TipoDocumento,
                                                        documento = d.Documento,
                                                        primerNombre = d.PrimerNombre,
                                                        segundoNombre = d.SegundoNombre,
                                                        primerApellido = d.PrimerApellido,
                                                        segundoApellido = d.SegundoApellido,
                                                        celular = d.Celular,
                                                        direccion = d.Direccion,
                                                        correo = d.Correo


                                                    }).ToList();
                    return lClientes;

                }
         
  
        }
        //Buscar por id:
        [HttpGet("{idGetUser}")]
        public async Task<ActionResult<Cliente>> GetCLiente(int idGetUser)
        {
            CarcenterContext context = new CarcenterContext();
            var clienteItem = await context.Clientes.FindAsync(idGetUser);
            if (clienteItem == null)
            {
                return NotFound();
            }
            return clienteItem;
        }

        //Registro Cliente
        [HttpPost]
        public MyResponse Create([FromBody] ClienteModel cliente)
        {
            MyResponse oR = new MyResponse();
            try
            {

                if (ModelState.IsValid)
                {

                    using (CarcenterContext db = new CarcenterContext())
                    {
                        var clientedb = new Cliente();
                        var ultimoId = db.Clientes.Max(x => x.Id as int?) ?? 0;


                        clientedb.Id = ultimoId+1;


                        //clientedb.Id = cliente.id;
                        clientedb.TipoDocumento = cliente.tipoDocumento;
                        clientedb.Documento = cliente.documento;
                        clientedb.PrimerNombre = cliente.primerNombre;
                        clientedb.SegundoNombre = cliente.segundoNombre;
                        clientedb.PrimerApellido = cliente.primerApellido;
                        clientedb.SegundoApellido = cliente.segundoApellido;
                        clientedb.Celular = cliente.celular;
                        clientedb.Direccion = cliente.direccion;
                        clientedb.Correo = cliente.correo;
                        db.Clientes.Add(clientedb);
                        db.SaveChanges();
                        oR.Success = 1;
                    }

                }

            }
            catch (Exception ex)
            {
                oR.Success = 0;
                oR.Message = ex.Message;
                Console.WriteLine(ex);
            }
            return oR;
        }
        
        //Editar


        [HttpPut("{clienteId}")]
        public MyResponse Edit(int clienteId, [FromBody] ClienteModel cliente)
        {
            MyResponse oR = new MyResponse();
            try
            {
                using (CarcenterContext db = new CarcenterContext())
                {
                    var clientedb = db.Clientes.Find(clienteId);
                  
                        clientedb.TipoDocumento = cliente.tipoDocumento;
                        clientedb.Documento = 123;
                        clientedb.PrimerNombre = cliente.primerNombre;
                        clientedb.SegundoNombre = cliente.segundoNombre;
                        clientedb.PrimerApellido = cliente.primerApellido;
                        clientedb.SegundoApellido = cliente.segundoApellido;
                        clientedb.Celular = cliente.celular;
                        clientedb.Direccion = cliente.direccion;
                        clientedb.Correo = cliente.correo;
                        db.SaveChanges();
                        oR.Success = 1;
                    }
            }
            catch (Exception ex)
            {
                oR.Success = 0;
                oR.Message = ex.Message;
                Console.WriteLine(ex);
            }
            return oR;
        }

        [HttpDelete("{clienteId}")]
        public MyResponse Delete(int clienteId)
        {
            MyResponse oR = new MyResponse();
            try
            {
                using (CarcenterContext db = new CarcenterContext())
                {
                    var clientedb = db.Clientes.Find(clienteId);
                    db.Clientes.Remove(clientedb);
                    db.SaveChanges();
                    oR.Success = 1;
                }
            }
            catch (Exception ex)
            {
                oR.Success = 0;
                oR.Message = ex.Message;
                Console.WriteLine(ex);
            }
            return oR;
        }
    }
}