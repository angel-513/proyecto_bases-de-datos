using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Faq
    {
        public int Faqid { get; set; }
        public string Pregunta { get; set; } = null!;
        public string Respuesta { get; set; } = null!;
    }
}
