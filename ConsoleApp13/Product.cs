using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        //no hello

        public string Price { get; set; }

        public string Description { get; set; }

        public DateTime Cretaedate { get; set; }


    }
}
