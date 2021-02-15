using System.ComponentModel.DataAnnotations;

namespace comp2139_lab2_wednesday.Models
{
    public class TipCalculator
    {

        [Required(ErrorMessage="Please enter a value for the cost of the Meal.")]
        [Range(0.0,10000.0, ErrorMessage ="Please enter a value greater than zero.")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue)
            {
                var tip = MealCost.Value * percent;
                return tip;
            }
            else
            {
                return 0;
            }
        }

    }
}
