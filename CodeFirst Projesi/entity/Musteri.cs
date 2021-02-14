using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Projesi.entity
{
    public class Musteri
    {
        [Key]
        public int Musteriid { get; set; }
        public string Musteriad { get; set; }
        public string Musterisoyad { get; set; }
        public string Musterisehir { get; set; }
    }

}
