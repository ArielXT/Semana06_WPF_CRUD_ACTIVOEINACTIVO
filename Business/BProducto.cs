using System;
using System.Collections.Generic;
using Data;
using Entity;

namespace Business
{
    public class BProducto
    {
        private DProducto DProducto = null;

        public List<Producto> Listar(int IdProducto)
        {
            List<Producto> productos = null;
            try
            {
                DProducto = new DProducto();
                productos = DProducto.Listar(new Producto { IdProducto = IdProducto });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productos;
        }

        public List<Producto> ListarActivo(bool EsActivo)
        {
            List<Producto> productos = null;
            try
            {
                DProducto = new DProducto();
                productos = DProducto.ListarActivo(new Producto { EsActivo = true });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productos;
        }

        public List<Producto> ListarInactivo(bool EsActivo)
        {
            List<Producto> productos = null;
            try
            {
                DProducto = new DProducto();
                productos = DProducto.ListarInactivo(new Producto { EsActivo = false });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productos;
        }

        public bool Insertar(Producto producto)
        {
            bool result = true;
            try
            {
                DProducto = new DProducto();
                DProducto.Insertar(producto);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        public bool Actualizar(Producto producto)
        {
            bool result = true;
            try
            {
                DProducto = new DProducto();
                DProducto.Actualizar(producto);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool Eliminar(int IdProducto)
        {
            bool result = true;
            try
            {
                DProducto = new DProducto();
                DProducto.Eliminar(IdProducto);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
