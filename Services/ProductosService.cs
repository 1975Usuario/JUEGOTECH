using JuegotecH.DTOs;
using JuegotecH.Models;
using JuegotecH.Responses;
using Org.BouncyCastle.Asn1.X509;

namespace JuegotecH.Services
{
    public class ProductosService
    {
        public async Task<ProductosResponse> ListaProductos()
        {
            ProductosResponse response = new();
            using (var context = new administrajuegotechContext())
            {
                try
                {
                    await Task.Run(() =>
                    {
                        var productos = (from u in context.Productos select u).ToList();

                        response.Data = productos;
                        response.Status = true;
                        response.Code = 200;
                        response.Message = "OK";
                    });
                }
                catch (Exception ex)
                {
                    response.Status = false;
                    response.Code = 400;
                    response.Message = "Error: " + ex.Message;
                }
            }
            return response;
        } //fin public async.

        public async Task<ProductoResponse> CrearProducto(ProductosDTO data)
        {
            ProductoResponse response = new();
            using (var context = new administrajuegotechContext())
            {
                try
                {
                    await Task.Run(() =>
                    {
                        var nombreExiste = (from u in context.Productos
                                            where u.ProNombre == data.Nombre
                                            select u.ProNombre).FirstOrDefault();
                        if (nombreExiste != null)
                        {
                            throw new Exception("Nombre de Producto, YA EXISTE.");
                        }

                        Producto producto = new()
                        {
                            ProNombre = data.Nombre,
                            ProDescripcion = data.Descripcion,
                            ProStock = int.Parse(data.Stock),
                            ProUnidad = int.Parse(data.Unidad),
                            ProPrecioUnitario = int.Parse(data.PrecioUnitario)
                        };

                        context.Productos.Add(producto);
                        context.SaveChanges();

                        response.Data = producto;
                        response.Status = true;
                        response.Code = 200;
                        response.Message = "OK";
                    });
                }
                catch (Exception ex)
                {
                    response.Status = false;
                    response.Code = 400;
                    response.Message = "Error: " + ex.Message;
                }
            }
            return response;
        }

    }//
}//
