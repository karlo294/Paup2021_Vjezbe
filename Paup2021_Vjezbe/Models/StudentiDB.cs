using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paup2021_Vjezbe.Models
{
    public class StudentiDB
    {
        private static List<Student> lista = new List<Student>();
        private static bool listaInicijalizirana = false;

        public StudentiDB() //ctor+2 tab
        {
            if(listaInicijalizirana==false)
            {
                lista.Add(new Student()
                {
                    Id = 1,
                    Prezime = "Perić",
                    Ime = "Petar",
                    DatumRodenja = new DateTime(1995, 10, 15),
                    Spol = 'M',
                    GodinaStudija = GodinaStudija.Druga,
                    Oib = "12345678911",
                    RedovniStudent = true
                });
                lista.Add(new Student()
                {
                    Id = 2,
                    Prezime = "Cukman",
                    Ime = "Ana",
                    DatumRodenja = new DateTime(2000, 12, 4),
                    Spol = 'Z',
                    GodinaStudija = GodinaStudija.Druga,
                    Oib = "12345678911",
                    RedovniStudent = true
                });
                lista.Add(new Student()
                {
                    Id = 3,
                    Prezime = "Ivo",
                    Ime = "Ivic",
                    DatumRodenja = new DateTime(1996, 8, 15),
                    Spol = 'M',
                    GodinaStudija = GodinaStudija.Treca,
                    Oib = "12345678911",
                    RedovniStudent = false
                });
                lista.Add(new Student()
                {
                    Id = 4,
                    Prezime = "Lucic",
                    Ime = "Luka",
                    DatumRodenja = new DateTime(2001, 10, 20),
                    Spol = 'M',
                    GodinaStudija = GodinaStudija.Prva,
                    Oib = "12345678911",
                    RedovniStudent = true
                });
                lista.Add(new Student()
                {
                    Id = 5,
                    Prezime = "Cukman",
                    Ime = "Karlo",
                    DatumRodenja = new DateTime(2000, 10, 15),
                    Spol = 'M',
                    GodinaStudija = GodinaStudija.Prva,
                    Oib = "12345678911",
                    RedovniStudent = true
                });
                listaInicijalizirana = true;
            }





        }
        public List<Student> VratiListu()
        {
            return lista;
        }
        public void AzurirajStudenta(Student student)
        {
            int studentIndex = lista.FindIndex(x => x.Id == student.Id);
            lista[studentIndex] = student;
        }
    }
}