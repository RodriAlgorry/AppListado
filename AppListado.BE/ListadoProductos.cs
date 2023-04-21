using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListado.BE
{
    public class clListadoProductos
    {
        public clProducto [] oProductos { get; set; } = new clProducto[10];

        public int ProximoProducto { get; set; } = 0;

        public void Agregar(string aCodigo, string aDescripcion, string aPrecio)
        {
            clProducto oProducto = new clProducto();
            oProducto.Codigo = aCodigo; 
            oProducto.Descripcion = aDescripcion;
            oProducto.Precio = System.Convert.ToDecimal(aPrecio);
            oProductos[ProximoProducto] = oProducto;
            ProximoProducto = ProximoProducto + 1;

        }
        public void Modificar(string aCodigo, string aDescripcion, string aPrecio)
        {
            int i = BuscarFila(aCodigo);
            oProductos[i].Codigo = aCodigo;
            oProductos[i].Descripcion = aDescripcion;
            oProductos[i].Precio = System.Convert.ToDecimal(aPrecio);
        }
        public void Eliminar(string aCodigo, string aDescripcion, string aPrecio)
        {
            int i = BuscarFila(aCodigo);
            oProductos[i].Codigo = null;
            oProductos[i].Descripcion = null;
            oProductos[i].Precio = System.Convert.ToDecimal (null);
        }
        public string Imprimir()
        {
            clProducto oProducto = new clProducto();

            string Respuesta = "Lista de precio";

            for (int i = 0; i < ProximoProducto; i++)
            {
                Respuesta = Respuesta
                            + "\r\n"
                            + $" {oProductos[i].Imprimir()}";
            }
            return Respuesta;
        }

        public clProducto Buscar(string aCodigo)
        {
            clProducto oProducto = null;
            for (int i = 0; i < oProductos.Length; i++)
            {
                oProducto = oProductos[i];
                if (oProducto != null && oProducto.Codigo == aCodigo)
                {
                    break;
                }
                oProducto = null;
            }
            return oProducto;
        }
        public int BuscarFila(string aCodigo)
        {
            int i = -1;
            
            for ( i = 0; i < oProductos.Length; i++)
            {
                if (oProductos[i] != null && oProductos[i].Codigo == aCodigo)
                {
                    break;
                }
                i = -1;
            }
            return i;
        }
    }

}
