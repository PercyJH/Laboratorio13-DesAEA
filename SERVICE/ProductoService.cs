﻿using DOMAIN;
using INFRAESTRUCTURE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE
{
    public class ProductoService
    {
        public List<Producto> Get()
        {
            using (var context = new ProductContext())
            {
                return context.Productos.Where(x => x.IsEnable == true).ToList();
            }
        }

        public Producto GetById(int id)
        {
            using (var context = new ProductContext())
            {
                return context.Productos.Find(id);
            }
        }

        public void Insert(Producto producto)
        {
            using (var context = new ProductContext())
            {
                producto.IsEnable = true;
                producto.igv = producto.precioVenta * 0.18;
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }

        public void Update(Producto producto, int id)
        {
            using (var context = new ProductContext())
            {
                var productoNew = context.Productos.Find(id);

                productoNew.nombre = producto.nombre;
                productoNew.descripcion = producto.descripcion;
                productoNew.precioVenta = producto.precioVenta;
                productoNew.fechaCreacion = producto.fechaCreacion;
                productoNew.fechaVencimiento = producto.fechaVencimiento;
                productoNew.igv = producto.precioVenta * 0.18;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new ProductContext())
            {
                var producto = context.Productos.Find(id);
                //Eliminación lógica
                context.Entry(producto).State = EntityState.Modified;
                producto.IsEnable = false;
                context.Productos.Where(x => x.IsEnable == false).ToList();
                context.SaveChanges();


            }
        }
    }
}

