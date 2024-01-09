using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class ogrenci
    {
        [Key]
        public int Id { get; set; }
        public int OkulNo  { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
    }
}
