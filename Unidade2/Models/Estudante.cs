using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcmeCursos.Models
{
    public class Estudante
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        [Required]
        public string Sobrenome { get;  set; }

        [Display(Name = "Data de Matricula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy",ApplyFormatInEditMode = true)]
        public DateTime DataMatricula { get; set; }
    }
}