using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Calculadora.Models
{
    public class Calcular
    {
        [Required]
        public float num1 { set; get; }
        [Required]
        public float num2 { set; get; }
        public float num3 { set; get; }
    }
}