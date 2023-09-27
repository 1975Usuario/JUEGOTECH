using JuegotecH.Models;

namespace JuegotecH.Responses
{
    public class Response
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public object Data { get; set; }
    }

    public class ProductosResponse : Response
    {
        public List<Producto> Data { get; set; }
    }

    public class ProductoResponse : Response
    {
        public Producto Data { get; set; }
    }
}
