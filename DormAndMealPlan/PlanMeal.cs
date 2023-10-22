using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormAndMealPlan
{
    public class PlanMeal // Public class in order to access both forms
    {
        // Costructor to set the below properties
        public PlanMeal(string type, int cost) // String for "Type" and Integer for "Cost"
        {
            TypeMeanPlan = type; // Pass users selection to the constructor which sets the cost for the property
            CostMeal = cost;
        }
        // Properties
        public string TypeMeanPlan { get; set; }
        public int CostMeal { get; set; } // Integer to refer to cost associated with each mean plan
        public static int UserChoiseMeanIndex { get; set; }

        // Public overrride string method to return formatted string
        public override string ToString()
        {
            return String.Format("The meal Type: {0}" + Environment.NewLine +
                                 "The meal Cost: €{1:N2} Euros" + Environment.NewLine,
                                 TypeMeanPlan, CostMeal);
        }
    }
}
