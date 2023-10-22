using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormAndMealPlan
{
    public class Dorm // Make class public in order to access both forms
    {
        // Public constructor for Dorm which will accept Dorm Cost and Type selcted by the user (String for "Type@ and Integer for the "Cost"
        public Dorm(string type, int cost)
        {
            // Assign values to the properties
            TypeDorm = type;
            CostDorm = cost;
        }
        
        // Create property for the Dorm
        public string TypeDorm { get; set; }
        public int CostDorm { get; set;} // property for the integer, that will be the cost for the dorm per semester
        public static int UserChoiceDormIndex { get; set; }// Need to be access it without instantiating another object

        // Add string method that will display the two properties in one string
        public override string ToString()
        {
            return String.Format("Type of the Dorm: {0}" + Environment.NewLine +
                                 "Cost for the Dorm: €{1:N2} Euros" + Environment.NewLine,
                                 TypeDorm, CostDorm); // This is the two string method to display the whole object properties
        }

    }
}
