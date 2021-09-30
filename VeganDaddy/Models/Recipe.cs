using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeganDaddy.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Instructions { get; set; }

        public string ImageUrl { get; set; }

        [DisplayName("Posted Date")]
        [DataType(DataType.Date)]
        public DateTime PostedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
