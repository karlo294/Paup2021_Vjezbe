using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paup2021_Vjezbe.Models
{
    public class Student
    {
        [Display(Name ="ID Studenta")]
        public int Id { get; set; } //prop+2 tab
        [Display(Name = "Ime Studenta")]
        public string Ime { get; set; }
        [Display(Name = "Prezime Studenta")]
        public string Prezime { get; set; }
        [Display(Name = "Spol")]
        public char Spol { get; set; }
        [Display(Name = "Oib")]
        public string Oib { get; set; }
        [Display(Name = "Datum rođenja")]
        [DisplayFormat(DataFormatString="(0:d)",ApplyFormatInEditMode =true)]
        public DateTime DatumRodenja { get; set; }
        [Display(Name = "Godina Studija")]
        public GodinaStudija GodinaStudija{ get; set; }
        [Display(Name = "Status Studenta")]
        public bool RedovniStudent { get; set; }

    }
}