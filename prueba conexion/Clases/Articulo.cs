using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_conexion.Clases
{
    class Articulo
    {
        public string id_articulo;
        public string art_nomb;
        public string art_codi;
        public int id_rubro;
        public int id_proveedor;
        public int id_marca;
        public int id_unidad;
        public float art_stock;
        public string art_esta;
        public int created_by;
        public DateTime created_at;
        public int deleted_by;
        public DateTime deleted_at;
        public int updated_by;
        public DateTime updated_at;

        public void set_art_nomb(String value) {
            this.art_nomb = value;
        }

        public void set_art_nomb(String value){
            this.art_nomb = value;
        }

        public void set_art_codi(String value){
            this.art_codi = value;
        }
        public void set_id_rubro(int value){
            this.id_rubro = value;
        }
        public void set_id_proveedor(int value)
        {
            this.id_proveedor = value;
        }

        public void set_id_marca(int value)
        {
            this.id_marca = value;
        }

        public void set_id_unidad(int value)
        {
            this.id_unidad = value;
        }

        public void set_art_stock(float value) {
            this.art_stock = value;
        }   

        public void set_art_esta(string value)
        {
            this.art_esta = value;
        }

        public void set_created_by(int value)
        {
            this.art_stock = value;
        }

//###########################juan
        public void set_created_at(DateTime value)
        {
            this.created_at = value;
        }

        public void set_updated_by(int value)
        {
            this.updated_by = value;
        }

    //################3 juan
<<<<<<< HEAD
////############################ juan2.0
=======
        //dasdasdasdasdas ezequiel
>>>>>>> ec7c5d53c32f8b899b33cd92d7a4d0d136b712dd



    }
}

