using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PasoValores2.Models
{
    #region EFactura
    public class EFactura
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string Fecha { get; set; }

        public string Serie { get; set; }
        public int Importe { get; set; }
    }
    #endregion
}