using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Projesi.entity
{
    public class Kategori
    {
       [Key]
        public int kategoriid { get; set; }
        public string kategoriname { get; set; }
        

        public ICollection<Urunler> Urunlers { get; set; }
    }
}
