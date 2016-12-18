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
    public partial class NewSimSetup : Form
    {

        public NewSimSetup()
        {
            InitializeComponent();
        }

        public static InfoMaster infoMaster1;
        public CraftingandDesign craftingAndDesign1;

        public static CreateSurvivorForm createSurvivorForm1 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm2 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm3 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm4 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm5 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm6 = new CreateSurvivorForm();

        public static int whichSurvivorInt;
        public int survivorQuantity;  //was static but I changed it
        public bool okToClose;

        //Methods
        private void ThreeMethod()
        {
          if (createSurvivorForm1.survivor1.isFormComplete != true || createSurvivorForm2.survivor2.isFormComplete != true || 
                createSurvivorForm3.survivor3.isFormComplete != true)
            {
                MessageBox.Show("Please complete ALL survivor forms.");
            }
          else
            {
                okToClose = true;
            }
        }

        private void FourMethod()
        {
            if (createSurvivorForm1.survivor1.isFormComplete != true || createSurvivorForm2.survivor2.isFormComplete != true ||
                createSurvivorForm3.survivor3.isFormComplete != true || createSurvivorForm4.survivor4.isFormComplete != true)
            {
                MessageBox.Show("Please complete ALL survivor forms.");
            }
            else
            {
                okToClose = true;
            }
        }

        private void FiveMethod()
        {
            if (createSurvivorForm1.survivor1.isFormComplete != true || createSurvivorForm2.survivor2.isFormComplete != true ||
                createSurvivorForm3.survivor3.isFormComplete != true || createSurvivorForm4.survivor4.isFormComplete != true ||
                createSurvivorForm5.survivor5.isFormComplete != true)
            {
                MessageBox.Show("Please complete ALL survivor forms.");
            }
            else
            {
                okToClose = true;
            }
        }

        private void SixMethod()
        {
            if (createSurvivorForm1.survivor1.isFormComplete != true || createSurvivorForm2.survivor2.isFormComplete != true ||
                createSurvivorForm3.survivor3.isFormComplete != true || createSurvivorForm4.survivor4.isFormComplete != true ||
                createSurvivorForm5.survivor5.isFormComplete != true || createSurvivorForm6.survivor6.isFormComplete != true)
            {
                MessageBox.Show("Please complete ALL survivor forms.");
            }
            else
            {
                okToClose = true;
            }
        }


        private void survivorQuantDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = survivorQuantDropDown.SelectedItem.ToString();

            if (selectedItem == "3")
            {
                createSurvivorBtn1.Visible = true;
                name1.Visible = true;

                createSurvivorBtn2.Visible = true;
                name2.Visible = true;

                createSurvivorBtn3.Visible = true;
                name3.Visible = true;

                createSurvivorBtn4.Visible = false;
                name4.Visible = false;

                createSurvivorBtn5.Visible = false;
                name5.Visible = false;

                createSurvivorBtn6.Visible = false;
                name6.Visible = false;

                survivorQuantity = 3;
            }
            else if (selectedItem == "4")
            {
                createSurvivorBtn1.Visible = true;
                name1.Visible = true;

                createSurvivorBtn2.Visible = true;
                name2.Visible = true;

                createSurvivorBtn3.Visible = true;
                name3.Visible = true;

                createSurvivorBtn4.Visible = true;
                name4.Visible = true;

                createSurvivorBtn5.Visible = false;
                name5.Visible = false;

                createSurvivorBtn6.Visible = false;
                name6.Visible = false;

                survivorQuantity = 4;
            }
            else if (selectedItem == "5")
            {
                createSurvivorBtn1.Visible = true;
                name1.Visible = true;

                createSurvivorBtn2.Visible = true;
                name2.Visible = true;

                createSurvivorBtn3.Visible = true;
                name3.Visible = true;

                createSurvivorBtn4.Visible = true;
                name4.Visible = true;

                createSurvivorBtn5.Visible = true;
                name5.Visible = true;

                createSurvivorBtn6.Visible = false;
                name6.Visible = false;

                survivorQuantity = 5;
            }
            else if (selectedItem == "6")
            {
                createSurvivorBtn1.Visible = true;
                name1.Visible = true;

                createSurvivorBtn2.Visible = true;
                name2.Visible = true;

                createSurvivorBtn3.Visible = true;
                name3.Visible = true;

                createSurvivorBtn4.Visible = true;
                name4.Visible = true;

                createSurvivorBtn5.Visible = true;
                name5.Visible = true;

                createSurvivorBtn6.Visible = true;
                name6.Visible = true;

                survivorQuantity = 6;
            }
        }

        private void createSurvivorBtn1_Click(object sender, EventArgs e)
        {
            //createSurvivorForm1 = new CreateSurvivorForm();
            whichSurvivorInt = 1;
            createSurvivorForm1.ShowDialog();
        }

        private void createSurvivorBtn2_Click(object sender, EventArgs e)
        {
            //createSurvivorForm2 = new CreateSurvivorForm();
            whichSurvivorInt = 2;
            createSurvivorForm2.ShowDialog();
        }

        private void createSurvivorBtn3_Click(object sender, EventArgs e)
        {
            //createSurvivorForm3 = new CreateSurvivorForm();
            whichSurvivorInt = 3;
            createSurvivorForm3.ShowDialog();
        }

        private void createSurvivorBtn4_Click(object sender, EventArgs e)
        {
            //createSurvivorForm4 = new CreateSurvivorForm();
            whichSurvivorInt = 4;
            createSurvivorForm4.ShowDialog();
        }

        private void createSurvivorBtn5_Click(object sender, EventArgs e)
        {
            //createSurvivorForm5 = new CreateSurvivorForm();
            whichSurvivorInt = 5;
            createSurvivorForm5.ShowDialog();
        }

        private void createSurvivorBtn6_Click(object sender, EventArgs e)
        {
            //createSurvivorForm6 = new CreateSurvivorForm();
            whichSurvivorInt = 6;
            createSurvivorForm6.ShowDialog();
        }

        private void startSimulationBtn_Click(object sender, EventArgs e)
        {
            
            if (survivorQuantity == 3)
            {
                ThreeMethod();
            }
            else if (survivorQuantity == 4)
            {
                FourMethod();
            }
            else if (survivorQuantity == 5)
            {
                FiveMethod();
            }
            else if (survivorQuantity == 6)
            {
                SixMethod();
            }

            if (okToClose == true)
            {
                //create instance of InfoMaster
                infoMaster1 = new InfoMaster();
                craftingAndDesign1 = new CraftingandDesign();

                infoMaster1.hasJustBegun = true;
                //Form1.frm1.Show();
                Form1.frm1.newSimulationToolStripMenuItem.Enabled = false;
                Form1.frm1.mainTimer.Enabled = true;
                Form1.frm1.mainTimer.Start();
                Close();
            }
            
        }
    }
    
}
