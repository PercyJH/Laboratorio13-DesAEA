using DOMAIN;
using INFRAESTRUCTURE;
using SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using APITecsup.Models.Response;
using APITecsup.Models.Request;

namespace APITecsup.Controllers
{
    public class ProductosController : ApiController
    {
        // GET: Lista
        [HttpGet]
        public List<ProductoResponse> List()
        {
            var service = new ProductoService();
            var productos = service.Get();

            var response = productos.Select(x => new ProductoResponse
            {
                ID = x.ID,
                nombre = x.nombre,
                descripcion = x.descripcion,
                fechaCreacion = x.fechaCreacion,
                IsEnable = x.IsEnable,
                fechaVencimiento = x.fechaVencimiento,
                igv = x.igv,
                precioVenta = x.precioVenta,
            }).ToList();
            return response;
        }


        // GET: ID
        [HttpGet]
        public IHttpActionResult GetProdById(int id)
        {
            var service = new ProductoService();
            var prod = service.GetById(id);

            return Ok(prod);
        }

        // POST : INSERT
        [HttpPost]
        public bool Create(ProductoRequest request)
        {
            var response = true;
            try
            {
                var service = new ProductoService();
                service.Insert(new DOMAIN.Producto
                {
                    nombre = request.nombre,
                    descripcion = request.descripcion,
                    fechaCreacion = request.fechaCreacion,
                    fechaVencimiento = request.fechaVencimiento,
                    precioVenta = request.precioVenta
                });
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        // PUT : UPDATE
        [HttpPut]
        public bool Actualizar(int id, ProductoResponse request)
        {
            var response = true;
            try
            {
                var service = new ProductoService();
                service.Update(new DOMAIN.Producto
                {
                    nombre = request.nombre,
                    descripcion = request.descripcion,
                    fechaCreacion = request.fechaCreacion,
                    fechaVencimiento = request.fechaVencimiento,
                    precioVenta = request.precioVenta
                }, id);
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        // DELETE: DELETE
        public IHttpActionResult DeleteProduct(int id)
        {
            var response = true;
            try
            {
                var service = new ProductoService();
                service.Delete(id);

            }
            catch (Exception)
            {
                response = false;
            }
            return Ok(response);
        }



    }
}