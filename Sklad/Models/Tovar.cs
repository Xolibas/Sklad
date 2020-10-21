using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklad.Models
{
    public class Tovar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Vlas { get; set; }
        public int Price { get; set; }
    }
}