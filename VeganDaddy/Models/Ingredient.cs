using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganDaddy.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

    }
}
