using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_project_Restaurants.Data.Models
{
    public class MenuMeal
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [ForeignKey(nameof(Meal))]
        public int MealId { get; set; }
        [ForeignKey(nameof(Menu))]
        public int MenuId { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual Menu Menu { get; set; }
        public override string ToString()
        {
            string result = "MenuMeal:\n";
            result += $"MealID: {MealId}\n";
            result += $"MenuId: {MenuId}\n";
            return result;
        }
    }
}
