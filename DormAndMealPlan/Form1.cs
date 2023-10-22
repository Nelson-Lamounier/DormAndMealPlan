using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealPlan
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Initialize(); 

        }
        
        // Two static lists one for Dorm and one for Meal
        // (Static beacuse have to be called and available on the second form changing them directy from both forms and not needed to create another object)
        public static List<Dorm> dormList = new List<Dorm>();
        public static List<PlanMeal> mealsList = new List<PlanMeal>(); // Populate each of from text files. 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            


        }

        private void resizeControl(Rectangle r, Control c)
        {
           

        }
        

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Capture the index and based on that catch the cost of each dorm from the txt list (Make the index from the list a property on the class / public and static)
            // Click the calc button, and display the information on the second form
            // Note: Every form is an object and needs to be instantiated (Has its own constructor and properties)
            frmChargesTotal form2 = new frmChargesTotal();
            Dorm.UserChoiceDormIndex = domList.SelectedIndex;

            // Pass it to the second form

            // Capture the selected meal index 
            if (radioButton1.Checked)
                // Access it directly on the class(static property)
                PlanMeal.UserChoiseMeanIndex = 0;
            else if (radioButton2.Checked)
                PlanMeal.UserChoiseMeanIndex = 1;
            else
                PlanMeal.UserChoiseMeanIndex = 2;
            // After second form shows, it will display users choice selected 

            form2.ShowDialog();
        }

        // Call methods initialize that will be responsible for calling those methods below
        private void Initialize()
        {
            // Wrap everything
            try
            {
                DormPopulated();
                MealsPopulated();
                DropDownDorm();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Assign the text for the dropdown list
        private void DropDownDorm()
        {
            domList.Text = "Select Dorm"; // This is the defauls text
            foreach (Dorm dorm in dormList)
            {
                domList.Items.Add(dorm.TypeDorm); 
            }
        }

        // Methods to populate the list no return needed only simple populate our lists from the file 
        private void DormPopulated()
        {
            // Varibale assigned to the path to access the file 
            StreamReader sr = new StreamReader("Dorm.txt");
            while (!sr.EndOfStream)
            {
                string[] data = sr.ReadLine().Split(',');
                // New object of dorm to add values to the properties
                dormList.Add(new Dorm(data[0], Convert.ToInt32(data[1])));
            }

            sr.Close();
        }

        private void MealsPopulated()
        {
            // Varibale assigned to the path to access the file
            StreamReader sr = new StreamReader("Meals.txt");
            while (!sr.EndOfStream)
            {
                string[] data = sr.ReadLine().Split(',');
                // New object of meal to add values to the properties
                mealsList.Add(new PlanMeal(data[0], Convert.ToInt32(data[1])));
            }

            sr.Close();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void domList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
