using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string ?Title { get; set; }

        public int ISBN { get; set; }

        public decimal Price { get; set; }

        public int NumOfPages { get; set; }

        public DateTime PublishDate { get; set; }

        public bool InStock { get; set; }
    }
}
