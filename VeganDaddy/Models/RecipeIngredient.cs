using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganDaddy.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public int IngredientId { get; set; }

        public int MeasureId { get; set; }

        public int Amount { get; set; }

        public bool IsDeleted { get; set; }
    }
}
