using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class CreateSurvivorForm : Form
    {
        public CreateSurvivorForm()
        {
            InitializeComponent();
            
        }

        private int whichSurvivorLocal;

        private static Random random = new Random();

        public BaseSurvivorClass survivor1 = new BaseSurvivorClass();
        public BaseSurvivorClass survivor2 = new BaseSurvivorClass();
        public BaseSurvivorClass survivor3 = new BaseSurvivorClass();
        public BaseSurvivorClass survivor4 = new BaseSurvivorClass();
        public BaseSurvivorClass survivor5 = new BaseSurvivorClass();
        public BaseSurvivorClass survivor6 = new BaseSurvivorClass();



        //LOCAL VARIABLES FOR SURVIVOR
        private string nameLocal;
        private bool isMaleLocal;
        private int ageLocal;
        private int charismaLocal = 11;
        private int fitnessLocal;
        private int intelligenceLocal;
        private string occupationLocal;

        //ASSISTS IN RANDOMIZE 
         
        
        //CUSTOM METHODS
        private void WhichSurvivorMethod(int whichSurvivor)
        {
            if (whichSurvivor == 1)
            {

                //survivor1 = new BaseSurvivorClass();

                survivor1.name = nameLocal;
                Form1.newSimSetup.name1.Text = nameLocal;

                survivor1.isMale = isMaleLocal;
                survivor1.age = ageLocal;
                survivor1.charisma = charismaLocal;
                survivor1.fitness = fitnessLocal;
                survivor1.intelligence = intelligenceLocal;
                survivor1.occupation = occupationLocal;

          
            }
            else if (whichSurvivor == 2)
            {
                //survivor2 = new BaseSurvivorClass();

                survivor2.name = nameLocal;
                Form1.newSimSetup.name2.Text = nameLocal;

                survivor2.isMale = isMaleLocal;
                survivor2.age = ageLocal;
                survivor2.charisma = charismaLocal;
                survivor2.fitness = fitnessLocal;
                survivor2.intelligence = intelligenceLocal;
                survivor2.occupation = occupationLocal;
            }
            else if (whichSurvivor == 3)
            {
                //survivor3 = new BaseSurvivorClass();

                survivor3.name = nameLocal;
                Form1.newSimSetup.name3.Text = nameLocal;

                survivor3.isMale = isMaleLocal;
                survivor3.age = ageLocal;
                survivor3.charisma = charismaLocal;
                survivor3.fitness = fitnessLocal;
                survivor3.intelligence = intelligenceLocal;
                survivor3.occupation = occupationLocal;
            }
            else if (whichSurvivor == 4)
            {
                //survivor4 = new BaseSurvivorClass();

                survivor4.name = nameLocal;
                Form1.newSimSetup.name4.Text = nameLocal;

                survivor4.isMale = isMaleLocal;
                survivor4.age = ageLocal;
                survivor4.charisma = charismaLocal;
                survivor4.fitness = fitnessLocal;
                survivor4.intelligence = intelligenceLocal;
                survivor4.occupation = occupationLocal;
            }
            else if (whichSurvivor == 5)
            {
                //survivor5 = new BaseSurvivorClass();

                survivor5.name = nameLocal;
                Form1.newSimSetup.name5.Text = nameLocal;

                survivor5.isMale = isMaleLocal;
                survivor5.age = ageLocal;
                survivor5.charisma = charismaLocal;
                survivor5.fitness = fitnessLocal;
                survivor5.intelligence = intelligenceLocal;
                survivor5.occupation = occupationLocal;
            }
            else if (whichSurvivor == 6)
            {
                //survivor6 = new BaseSurvivorClass();

                survivor6.name = nameLocal;
                Form1.newSimSetup.name6.Text = nameLocal;

                survivor6.isMale = isMaleLocal;
                survivor6.age = ageLocal;
                survivor6.charisma = charismaLocal;
                survivor6.fitness = fitnessLocal;
                survivor6.intelligence = intelligenceLocal;
                survivor6.occupation = occupationLocal;
            }
        }
        private void SurvivorFormComplete(int whichSurvivor)
        {
            if (whichSurvivor == 1)
            {
                survivor1.isFormComplete = true;
            }
            else if (whichSurvivor == 2)
            {
                survivor2.isFormComplete = true;
            }
            else if (whichSurvivor == 3)
            {
                survivor3.isFormComplete = true;
            }
            else if (whichSurvivor == 4)
            {
                survivor4.isFormComplete = true;
            }
            else if (whichSurvivor == 5)
            {
                survivor5.isFormComplete = true;
            }
            else if (whichSurvivor == 6)
            {
                survivor6.isFormComplete = true;
            }
        }
        

        //BUTTONS AND SUCH
        private void okBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(isMaleLocal);
            Debug.WriteLine(occupationLocal);
            Debug.WriteLine(ageLocal);
            whichSurvivorLocal = NewSimSetup.whichSurvivorInt;
            WhichSurvivorMethod(whichSurvivorLocal);

            if (nameLocal == null || ageLocal < 16 || charismaDropDown.SelectedIndex < 0 || fitnessDropDown == null || intelligenceDropDown == null || occupationLocal == null)
            {
                MessageBox.Show("Please complete ALL entries.");
            }
            else
            {
                SurvivorFormComplete(whichSurvivorLocal);
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameLocal = nameTextBox.Text;
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            isMaleLocal = true;
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            isMaleLocal = false;
        }

        private void ageNumeric_ValueChanged(object sender, EventArgs e)
        {
            ageLocal = (int)ageNumeric.Value;
        }

        private void charismaDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            charismaLocal = charismaDropDown.SelectedIndex + 1;
            Debug.WriteLine(charismaLocal);   
           //charismaLocal = (int)charismaDropDown.SelectedValue;
        }

        private void fitnessDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            fitnessLocal = fitnessDropDown.SelectedIndex + 1;
            //fitnessLocal = (int)fitnessDropDown.SelectedValue;
        }

        private void intelligenceDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            intelligenceLocal = intelligenceDropDown.SelectedIndex + 1;
            //intelligenceLocal = (int)intelligenceDropDown.SelectedValue;
        }

        private void occupationDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            occupationLocal = occupationDropDown.SelectedText;
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            //dictionaries
            Dictionary<int, string> nameBank = new Dictionary<int, string>();
            nameBank.Add(1, "Alex");
            nameBank.Add(2, "Blaine");
            nameBank.Add(3, "Casey");
            nameBank.Add(4, "Dylan");
            nameBank.Add(5, "Eren");
            nameBank.Add(6, "Francis");
            nameBank.Add(7, "Gerry");
            nameBank.Add(8, "Hayden");
            nameBank.Add(9, "Ira");
            nameBank.Add(10, "Jesse");
            nameBank.Add(11, "Kelly");
            nameBank.Add(12, "Leslie");
            nameBank.Add(13, "Madison");
            nameBank.Add(14, "Noel");
            nameBank.Add(15, "Orion");
            nameBank.Add(16, "Parker");
            nameBank.Add(17, "Quinn");
            nameBank.Add(18, "Riley");
            nameBank.Add(19, "Sydney");
            nameBank.Add(20, "Terry");
            nameBank.Add(21, "Umbrell");
            nameBank.Add(22, "Vick");
            nameBank.Add(23, "Winn");
            nameBank.Add(24, "Xarian");
            nameBank.Add(25, "Yokle");
            nameBank.Add(26, "Zane");

            Dictionary<int, bool> sexBank = new Dictionary<int, bool>();
            sexBank.Add(1, true);
            sexBank.Add(2, false);

            Dictionary<int, int> ageBank = new Dictionary<int, int>();
            int countAge = 99;
            for (int i = 16; i <= countAge; i++)
            {
                ageBank.Add(i, i);
            }

            Dictionary<int, int> statBank = new Dictionary<int, int>();
            //this dictionary is used for all three stats
            int countStat = 10;
            for (int i = 1; i <= countStat; i++)
            {
                statBank.Add(i, i);
            }

            Dictionary<int, string> occupationBank = new Dictionary<int, string>();
            occupationBank.Add(1, "Engineer");
            occupationBank.Add(2, "Doctor");
            occupationBank.Add(3, "Lawyer");

            //generate random numbers
            int nameChoiceInt = random.Next(1, 27);
            int sexChoiceInt = random.Next(1, 3);
            int ageChoiceInt = random.Next(16, 100);
            int charismaChoiceInt = random.Next(1, 11);
            int fitnessChoiceInt = random.Next(1, 11);
            int intelligenceChoiceInt = random.Next(1, 11);
            int occupationChoiceInt = random.Next(1, 4);


            //set local fields equal to randomly chosen values
            nameBank.TryGetValue(nameChoiceInt, out nameLocal);
            sexBank.TryGetValue(sexChoiceInt, out isMaleLocal);
            ageBank.TryGetValue(ageChoiceInt, out ageLocal);
            statBank.TryGetValue(charismaChoiceInt, out charismaLocal);
            statBank.TryGetValue(fitnessChoiceInt, out fitnessLocal);
            statBank.TryGetValue(intelligenceChoiceInt, out intelligenceLocal);
            occupationBank.TryGetValue(occupationChoiceInt, out occupationLocal);


            //put the random info into the form upon clicking randomize button
            this.nameTextBox.Text = nameLocal;
            
            if (isMaleLocal == true)
            {
                this.maleRadio.PerformClick();
            }
            else if (isMaleLocal == false)
            {
                this.femaleRadio.PerformClick();
            }
            
            this.ageNumeric.Value = ageLocal;
            this.charismaDropDown.Text = charismaLocal.ToString();
            this.fitnessDropDown.Text = fitnessLocal.ToString();
            this.intelligenceDropDown.Text = intelligenceLocal.ToString();
            this.occupationDropDown.Text = occupationLocal;

        }
        
}
}
