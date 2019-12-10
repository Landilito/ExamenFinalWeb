using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenWeb.Models
{
    public class Visita
    {
        [Key]
        public int VisitaID { get; set; }
        public Motivo Motivo { get; set; }
        [DataType(DataType.Date)]
        public string FechaVisita { get; set; }
        [DataType(DataType.Time)]
        public string HoraEntrada { get; set; }
        [DataType(DataType.Time)]
        public string HoraSalida { get; set; }
        public string NombreCompleto { get; set; }
        public int ContactoID { get; set; }
        [ForeignKey("ContactoID")]
        public virtual Contacto Contacto { get; set; }

    }

    public enum Motivo
    {
        Chequeo, Consulta, Cita, Dudas, Reservacion, Compra, Quejas
    }
}