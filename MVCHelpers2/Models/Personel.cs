using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHelpers2.Models
{
    public class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }


    }
}