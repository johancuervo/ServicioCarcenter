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
        [HttpGet("[action]")]
        public IEnumerable<ClienteModel> Index()
        {


            using (var db = new Models.DB.CarcenterContext())
            {
                List<ClienteModel> lClientes = (from d in db.Clientes
                                           select new ClienteModel
                                           {
                                               id = d.Id,
                                               tipoDocumento=d.TipoDocumento,
                                               documento=d.Documento,
                                               primerNombre = d.PrimerNombre,
                                               segundoNombre=d.SegundoNombre,
                                               primerApellido = d.PrimerApellido,
                                               segundoApellido= d.SegundoApellido,
                                               celular=d.Celular,
                                               direccion=d.Direccion,
                                               correo=d.Correo

                                               
                                           }).ToList();
                return lClientes;
            }

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
                        clientedb.Id = cliente.id;
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

        [HttpPut("[action]")]
        public ActionResult Edit(int Id)
            {
                ClienteModel cliente = new ClienteModel();
                using (CarcenterContext db = new CarcenterContext())
                {
                    var clientedb = db.Clientes.Find(Id);
                    cliente.id = Id;
                    cliente.tipoDocumento = clientedb.TipoDocumento;
                    cliente.documento = clientedb.Documento;
                    cliente.primerNombre = clientedb.PrimerNombre;
                    cliente.segundoNombre = clientedb.SegundoNombre;
                    cliente.primerApellido = clientedb.PrimerApellido;
                    cliente.segundoApellido = clientedb.SegundoApellido;
                    cliente.celular = clientedb.Celular;
                    cliente.direccion = clientedb.Direccion;
                    cliente.correo = clientedb.Correo;
                }

                return View(cliente);
            }

            [HttpPut("[action]")]
            public ActionResult Edit(ClienteModel cliente)
            {
                try
                {

                    if (ModelState.IsValid)
                    {
                        using (CarcenterContext db = new CarcenterContext())
                        {
                            var clientedb = db.Clientes.Find(cliente.id);
                            clientedb.Id = cliente.id;
                            clientedb.TipoDocumento = cliente.tipoDocumento;
                            clientedb.Documento = cliente.documento;
                            clientedb.PrimerNombre = cliente.primerNombre;
                            clientedb.SegundoNombre = cliente.segundoNombre;
                            clientedb.PrimerApellido = cliente.primerApellido;
                            clientedb.Celular = cliente.celular;
                            clientedb.Direccion = cliente.direccion;
                            clientedb.Correo = cliente.correo;
                            db.Entry(clientedb).State = (Microsoft.EntityFrameworkCore.EntityState)System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            [HttpDelete("[action]")]
            public ActionResult Delete(int Id)
            {
                Cliente cliente = new Cliente();
                using (CarcenterContext db = new CarcenterContext())
                {
                    var clientedb = db.Clientes.Find(Id);
                    db.Clientes.Remove(clientedb);
                    db.SaveChanges();
                }

                return View(cliente);
            }

        }
    }