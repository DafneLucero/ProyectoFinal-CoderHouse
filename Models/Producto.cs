using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerAPI
{
    public class Producto
    {
        // Atributos:

        private long _id;
        private string _descripciones;
        private decimal _costo;
        private decimal _precioVenta;
        private int _stock;
        private long _idUsuario;

        //getters&setters

        public long Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripciones; set => _descripciones = value; }
        public decimal Costo { get => _costo; set => _costo = value; }
        public decimal PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public long IdUsuario { get => _idUsuario; set => _idUsuario = value; }


        public override string ToString()
        {
            return $" ID: {_id}\t Descripcion: {_descripciones}\t Costo: {_costo}\t Precio de Venta: {_precioVenta}\t Stock: {_stock}\t Cargado por usuario: {_idUsuario}";
        }

    }
}
