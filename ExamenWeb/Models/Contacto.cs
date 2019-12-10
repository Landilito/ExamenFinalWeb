using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenWeb.Models
{
    public class Contacto
    {
        [Key]
        public int ContactoID { get; set; }
        public string Nombre { get; set; }
        public string DocumentoIdentidad { get; set; }
        [DataType(DataType.Date)]
        public string FechaCreacion { get; set; }
    }
}