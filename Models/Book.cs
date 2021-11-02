using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lazar_Andreea_Maria_Lab2.Models
{
        public class Book
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }

            [Column(TypeName = "decimal(6, 2)")]
            public decimal Price { get; set; }
            public ICollection<Order> Orders { get; set; }
        public ICollection<PublishedBoook> PublishedBooks { get; set; }

    }

}
