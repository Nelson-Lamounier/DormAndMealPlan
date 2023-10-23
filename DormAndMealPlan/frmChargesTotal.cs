using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealPlan
{
    public partial class frmChargesTotal : Form
    {
        public frmChargesTotal()
        {
            InitializeComponent();
        }

        private void frmChargesTotal_Load(object sender, EventArgs e)
        {
            Display(); // Calling the method
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method to display user selected on to the list box by accessing the properties of the dorm object
        private void Display()
        {
            textBoxForm2.Text += Form1.dormList[Dorm.UserChoiceDormIndex].ToString(); // Append user selection on form 1
            textBoxForm2.Text += Form1.mealsList[PlanMeal.UserChoiseMeanIndex].ToString();
            textBoxForm2.Text +=  "Total Cost: " + TotalCal().ToString("C");
        }

        // Method to calculate the total of the user choice
        private int TotalCal()
        {
            int costDorm = Form1.dormList[Dorm.UserChoiceDormIndex].CostDorm;
            int costMeam = Form1.mealsList[PlanMeal.UserChoiseMeanIndex].CostMeal;

            return costDorm + costMeam;
        }

        private void textBoxForm2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
