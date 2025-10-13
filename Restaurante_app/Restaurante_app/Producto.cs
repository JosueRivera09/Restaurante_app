using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_app
{
    public class Producto
    {
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencias { get; set; }
        public string Categoria { get; set; }
        public string ImagenNombre { get; set; }
    }
}
