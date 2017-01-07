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
        public static ColonyInfoForm colonyInfoForm1;
        public CraftingandDesign craftingAndDesign1;

        public static CreateSurvivorForm createSurvivorForm1 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm2 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm3 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm4 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm5 = new CreateSurvivorForm();
        public static CreateSurvivorForm createSurvivorForm6 = new CreateSurvivorForm();

        public static SurvivorInfoForm survivorInfoForm1;
        public static SurvivorInfoForm survivorInfoForm2;
        public static SurvivorInfoForm survivorInfoForm3;
        public static SurvivorInfoForm survivorInfoForm4;
        public static SurvivorInfoForm survivorInfoForm5;
        public static SurvivorInfoForm survivorInfoForm6;

        public static int whichSurvivorInt;
        public int survivorQuantity;  //was static but I changed it
        public bool okToClose;

        //Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void ThreeMethod()
        {
          if (createSurvivorForm1.survivor1.isFormComplete != true || createSurvivorForm2.survivor2.isFormComplete != true || 
                createSurvivorForm3.survivor3.isFormComplete != true)
            {
                MessageBox.Show("Please complete ALL survivor forms.");
            }
          else
            {
                //SetSurvivorInfoMethod();
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

        private void SetSurvivorInfoMethod()
        {
            if (survivorQuantity == 3)
            {
                //create new form instances
                survivorInfoForm1 = new SurvivorInfoForm();
                survivorInfoForm2 = new SurvivorInfoForm();
                survivorInfoForm3 = new SurvivorInfoForm();

                //button visibility
                Form1.frm1.survivor1ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor2ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor3ToolStripMenuItem.Visible = true;

                //rename toolstrip buttons
                Form1.frm1.survivor1ToolStripMenuItem.Text = createSurvivorForm1.survivor1.name;
                Form1.frm1.survivor2ToolStripMenuItem.Text = createSurvivorForm2.survivor2.name;
                Form1.frm1.survivor3ToolStripMenuItem.Text = createSurvivorForm3.survivor3.name;

                //Set Info for Survivor 1
                survivorInfoForm1.survivorInfoNameLabel.Text        = createSurvivorForm1.survivor1.name;
                survivorInfoForm1.survivorInfoOccupationLabel.Text  = createSurvivorForm1.survivor1.occupation;
                survivorInfoForm1.survivorInfoAgeStat.Text          = createSurvivorForm1.survivor1.age.ToString();
                survivorInfoForm1.survivorInfoCharismaStat.Text     = createSurvivorForm1.survivor1.charisma.ToString();
                survivorInfoForm1.survivorInfoFitnessStat.Text      = createSurvivorForm1.survivor1.fitness.ToString();
                survivorInfoForm1.survivorInfoIntelligenceStat.Text = createSurvivorForm1.survivor1.intelligence.ToString();
                //Set Info for Survivor 2
                survivorInfoForm2.survivorInfoNameLabel.Text        = createSurvivorForm2.survivor2.name;
                survivorInfoForm2.survivorInfoOccupationLabel.Text  = createSurvivorForm2.survivor2.occupation;
                survivorInfoForm2.survivorInfoAgeStat.Text          = createSurvivorForm2.survivor2.age.ToString();
                survivorInfoForm2.survivorInfoCharismaStat.Text     = createSurvivorForm2.survivor2.charisma.ToString();
                survivorInfoForm2.survivorInfoFitnessStat.Text      = createSurvivorForm2.survivor2.fitness.ToString();
                survivorInfoForm2.survivorInfoIntelligenceStat.Text = createSurvivorForm2.survivor2.intelligence.ToString();
                //Set Info for Survivor 3
                survivorInfoForm3.survivorInfoNameLabel.Text        = createSurvivorForm3.survivor3.name;
                survivorInfoForm3.survivorInfoOccupationLabel.Text  = createSurvivorForm3.survivor3.occupation;
                survivorInfoForm3.survivorInfoAgeStat.Text          = createSurvivorForm3.survivor3.age.ToString();
                survivorInfoForm3.survivorInfoCharismaStat.Text     = createSurvivorForm3.survivor3.charisma.ToString();
                survivorInfoForm3.survivorInfoFitnessStat.Text      = createSurvivorForm3.survivor3.fitness.ToString();
                survivorInfoForm3.survivorInfoIntelligenceStat.Text = createSurvivorForm3.survivor3.intelligence.ToString();
            }
            else if (survivorQuantity == 4)
            {
                survivorInfoForm1 = new SurvivorInfoForm();
                survivorInfoForm2 = new SurvivorInfoForm();
                survivorInfoForm3 = new SurvivorInfoForm();
                survivorInfoForm4 = new SurvivorInfoForm();

                //button visibility
                Form1.frm1.survivor1ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor2ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor3ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor4ToolStripMenuItem.Visible = true;

                //rename toolstrip buttons
                Form1.frm1.survivor1ToolStripMenuItem.Text = createSurvivorForm1.survivor1.name;
                Form1.frm1.survivor2ToolStripMenuItem.Text = createSurvivorForm2.survivor2.name;
                Form1.frm1.survivor3ToolStripMenuItem.Text = createSurvivorForm3.survivor3.name;
                Form1.frm1.survivor4ToolStripMenuItem.Text = createSurvivorForm4.survivor4.name;

                //Set Info for Survivor 1
                survivorInfoForm1.survivorInfoNameLabel.Text = createSurvivorForm1.survivor1.name;
                survivorInfoForm1.survivorInfoOccupationLabel.Text = createSurvivorForm1.survivor1.occupation;
                survivorInfoForm1.survivorInfoAgeStat.Text = createSurvivorForm1.survivor1.age.ToString();
                survivorInfoForm1.survivorInfoCharismaStat.Text = createSurvivorForm1.survivor1.charisma.ToString();
                survivorInfoForm1.survivorInfoFitnessStat.Text = createSurvivorForm1.survivor1.fitness.ToString();
                survivorInfoForm1.survivorInfoIntelligenceStat.Text = createSurvivorForm1.survivor1.intelligence.ToString();
                //Set Info for Survivor 2
                survivorInfoForm2.survivorInfoNameLabel.Text = createSurvivorForm2.survivor2.name;
                survivorInfoForm2.survivorInfoOccupationLabel.Text = createSurvivorForm2.survivor2.occupation;
                survivorInfoForm2.survivorInfoAgeStat.Text = createSurvivorForm2.survivor2.age.ToString();
                survivorInfoForm2.survivorInfoCharismaStat.Text = createSurvivorForm2.survivor2.charisma.ToString();
                survivorInfoForm2.survivorInfoFitnessStat.Text = createSurvivorForm2.survivor2.fitness.ToString();
                survivorInfoForm2.survivorInfoIntelligenceStat.Text = createSurvivorForm2.survivor2.intelligence.ToString();
                //Set Info for Survivor 3
                survivorInfoForm3.survivorInfoNameLabel.Text = createSurvivorForm3.survivor3.name;
                survivorInfoForm3.survivorInfoOccupationLabel.Text = createSurvivorForm3.survivor3.occupation;
                survivorInfoForm3.survivorInfoAgeStat.Text = createSurvivorForm3.survivor3.age.ToString();
                survivorInfoForm3.survivorInfoCharismaStat.Text = createSurvivorForm3.survivor3.charisma.ToString();
                survivorInfoForm3.survivorInfoFitnessStat.Text = createSurvivorForm3.survivor3.fitness.ToString();
                survivorInfoForm3.survivorInfoIntelligenceStat.Text = createSurvivorForm3.survivor3.intelligence.ToString();
                //Set Info for Survivor 4
                survivorInfoForm4.survivorInfoNameLabel.Text        = createSurvivorForm4.survivor4.name;
                survivorInfoForm4.survivorInfoOccupationLabel.Text  = createSurvivorForm4.survivor4.occupation;
                survivorInfoForm4.survivorInfoAgeStat.Text          = createSurvivorForm4.survivor4.age.ToString();
                survivorInfoForm4.survivorInfoCharismaStat.Text     = createSurvivorForm4.survivor4.charisma.ToString();
                survivorInfoForm4.survivorInfoFitnessStat.Text      = createSurvivorForm4.survivor4.fitness.ToString();
                survivorInfoForm4.survivorInfoIntelligenceStat.Text = createSurvivorForm4.survivor4.intelligence.ToString();
            }
            else if (survivorQuantity == 5)
            {
                survivorInfoForm1 = new SurvivorInfoForm();
                survivorInfoForm2 = new SurvivorInfoForm();
                survivorInfoForm3 = new SurvivorInfoForm();
                survivorInfoForm4 = new SurvivorInfoForm();
                survivorInfoForm5 = new SurvivorInfoForm();

                //button visibility
                Form1.frm1.survivor1ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor2ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor3ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor4ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor5ToolStripMenuItem.Visible = true;

                //rename toolstrip buttons
                Form1.frm1.survivor1ToolStripMenuItem.Text = createSurvivorForm1.survivor1.name;
                Form1.frm1.survivor2ToolStripMenuItem.Text = createSurvivorForm2.survivor2.name;
                Form1.frm1.survivor3ToolStripMenuItem.Text = createSurvivorForm3.survivor3.name;
                Form1.frm1.survivor4ToolStripMenuItem.Text = createSurvivorForm4.survivor4.name;
                Form1.frm1.survivor5ToolStripMenuItem.Text = createSurvivorForm5.survivor5.name;

                //Set Info for Survivor 1
                survivorInfoForm1.survivorInfoNameLabel.Text = createSurvivorForm1.survivor1.name;
                survivorInfoForm1.survivorInfoOccupationLabel.Text = createSurvivorForm1.survivor1.occupation;
                survivorInfoForm1.survivorInfoAgeStat.Text = createSurvivorForm1.survivor1.age.ToString();
                survivorInfoForm1.survivorInfoCharismaStat.Text = createSurvivorForm1.survivor1.charisma.ToString();
                survivorInfoForm1.survivorInfoFitnessStat.Text = createSurvivorForm1.survivor1.fitness.ToString();
                survivorInfoForm1.survivorInfoIntelligenceStat.Text = createSurvivorForm1.survivor1.intelligence.ToString();
                //Set Info for Survivor 2
                survivorInfoForm2.survivorInfoNameLabel.Text = createSurvivorForm2.survivor2.name;
                survivorInfoForm2.survivorInfoOccupationLabel.Text = createSurvivorForm2.survivor2.occupation;
                survivorInfoForm2.survivorInfoAgeStat.Text = createSurvivorForm2.survivor2.age.ToString();
                survivorInfoForm2.survivorInfoCharismaStat.Text = createSurvivorForm2.survivor2.charisma.ToString();
                survivorInfoForm2.survivorInfoFitnessStat.Text = createSurvivorForm2.survivor2.fitness.ToString();
                survivorInfoForm2.survivorInfoIntelligenceStat.Text = createSurvivorForm2.survivor2.intelligence.ToString();
                //Set Info for Survivor 3
                survivorInfoForm3.survivorInfoNameLabel.Text = createSurvivorForm3.survivor3.name;
                survivorInfoForm3.survivorInfoOccupationLabel.Text = createSurvivorForm3.survivor3.occupation;
                survivorInfoForm3.survivorInfoAgeStat.Text = createSurvivorForm3.survivor3.age.ToString();
                survivorInfoForm3.survivorInfoCharismaStat.Text = createSurvivorForm3.survivor3.charisma.ToString();
                survivorInfoForm3.survivorInfoFitnessStat.Text = createSurvivorForm3.survivor3.fitness.ToString();
                survivorInfoForm3.survivorInfoIntelligenceStat.Text = createSurvivorForm3.survivor3.intelligence.ToString();
                //Set Info for Survivor 4
                survivorInfoForm4.survivorInfoNameLabel.Text = createSurvivorForm4.survivor4.name;
                survivorInfoForm4.survivorInfoOccupationLabel.Text = createSurvivorForm4.survivor4.occupation;
                survivorInfoForm4.survivorInfoAgeStat.Text = createSurvivorForm4.survivor4.age.ToString();
                survivorInfoForm4.survivorInfoCharismaStat.Text = createSurvivorForm4.survivor4.charisma.ToString();
                survivorInfoForm4.survivorInfoFitnessStat.Text = createSurvivorForm4.survivor4.fitness.ToString();
                survivorInfoForm4.survivorInfoIntelligenceStat.Text = createSurvivorForm4.survivor4.intelligence.ToString();
                //Set Info for Survivor 5
                survivorInfoForm5.survivorInfoNameLabel.Text        = createSurvivorForm5.survivor5.name;
                survivorInfoForm5.survivorInfoOccupationLabel.Text  = createSurvivorForm5.survivor5.occupation;
                survivorInfoForm5.survivorInfoAgeStat.Text          = createSurvivorForm5.survivor5.age.ToString();
                survivorInfoForm5.survivorInfoCharismaStat.Text     = createSurvivorForm5.survivor5.charisma.ToString();
                survivorInfoForm5.survivorInfoFitnessStat.Text      = createSurvivorForm5.survivor5.fitness.ToString();
                survivorInfoForm5.survivorInfoIntelligenceStat.Text = createSurvivorForm5.survivor5.intelligence.ToString();
            }
            else if (survivorQuantity == 6)
            {
                survivorInfoForm1 = new SurvivorInfoForm();
                survivorInfoForm2 = new SurvivorInfoForm();
                survivorInfoForm3 = new SurvivorInfoForm();
                survivorInfoForm4 = new SurvivorInfoForm();
                survivorInfoForm5 = new SurvivorInfoForm();
                survivorInfoForm6 = new SurvivorInfoForm();

                //button visibility
                Form1.frm1.survivor1ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor2ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor3ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor4ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor5ToolStripMenuItem.Visible = true;
                Form1.frm1.survivor6ToolStripMenuItem.Visible = true;

                //rename toolstrip buttons
                Form1.frm1.survivor1ToolStripMenuItem.Text = createSurvivorForm1.survivor1.name;
                Form1.frm1.survivor2ToolStripMenuItem.Text = createSurvivorForm2.survivor2.name;
                Form1.frm1.survivor3ToolStripMenuItem.Text = createSurvivorForm3.survivor3.name;
                Form1.frm1.survivor4ToolStripMenuItem.Text = createSurvivorForm4.survivor4.name;
                Form1.frm1.survivor5ToolStripMenuItem.Text = createSurvivorForm5.survivor5.name;
                Form1.frm1.survivor6ToolStripMenuItem.Text = createSurvivorForm6.survivor6.name;

                //Set Info for Survivor 1
                survivorInfoForm1.survivorInfoNameLabel.Text = createSurvivorForm1.survivor1.name;
                survivorInfoForm1.survivorInfoOccupationLabel.Text = createSurvivorForm1.survivor1.occupation;
                survivorInfoForm1.survivorInfoAgeStat.Text = createSurvivorForm1.survivor1.age.ToString();
                survivorInfoForm1.survivorInfoCharismaStat.Text = createSurvivorForm1.survivor1.charisma.ToString();
                survivorInfoForm1.survivorInfoFitnessStat.Text = createSurvivorForm1.survivor1.fitness.ToString();
                survivorInfoForm1.survivorInfoIntelligenceStat.Text = createSurvivorForm1.survivor1.intelligence.ToString();
                //Set Info for Survivor 2
                survivorInfoForm2.survivorInfoNameLabel.Text = createSurvivorForm2.survivor2.name;
                survivorInfoForm2.survivorInfoOccupationLabel.Text = createSurvivorForm2.survivor2.occupation;
                survivorInfoForm2.survivorInfoAgeStat.Text = createSurvivorForm2.survivor2.age.ToString();
                survivorInfoForm2.survivorInfoCharismaStat.Text = createSurvivorForm2.survivor2.charisma.ToString();
                survivorInfoForm2.survivorInfoFitnessStat.Text = createSurvivorForm2.survivor2.fitness.ToString();
                survivorInfoForm2.survivorInfoIntelligenceStat.Text = createSurvivorForm2.survivor2.intelligence.ToString();
                //Set Info for Survivor 3
                survivorInfoForm3.survivorInfoNameLabel.Text = createSurvivorForm3.survivor3.name;
                survivorInfoForm3.survivorInfoOccupationLabel.Text = createSurvivorForm3.survivor3.occupation;
                survivorInfoForm3.survivorInfoAgeStat.Text = createSurvivorForm3.survivor3.age.ToString();
                survivorInfoForm3.survivorInfoCharismaStat.Text = createSurvivorForm3.survivor3.charisma.ToString();
                survivorInfoForm3.survivorInfoFitnessStat.Text = createSurvivorForm3.survivor3.fitness.ToString();
                survivorInfoForm3.survivorInfoIntelligenceStat.Text = createSurvivorForm3.survivor3.intelligence.ToString();
                //Set Info for Survivor 4
                survivorInfoForm4.survivorInfoNameLabel.Text = createSurvivorForm4.survivor4.name;
                survivorInfoForm4.survivorInfoOccupationLabel.Text = createSurvivorForm4.survivor4.occupation;
                survivorInfoForm4.survivorInfoAgeStat.Text = createSurvivorForm4.survivor4.age.ToString();
                survivorInfoForm4.survivorInfoCharismaStat.Text = createSurvivorForm4.survivor4.charisma.ToString();
                survivorInfoForm4.survivorInfoFitnessStat.Text = createSurvivorForm4.survivor4.fitness.ToString();
                survivorInfoForm4.survivorInfoIntelligenceStat.Text = createSurvivorForm4.survivor4.intelligence.ToString();
                //Set Info for Survivor 5
                survivorInfoForm5.survivorInfoNameLabel.Text = createSurvivorForm5.survivor5.name;
                survivorInfoForm5.survivorInfoOccupationLabel.Text = createSurvivorForm5.survivor5.occupation;
                survivorInfoForm5.survivorInfoAgeStat.Text = createSurvivorForm5.survivor5.age.ToString();
                survivorInfoForm5.survivorInfoCharismaStat.Text = createSurvivorForm5.survivor5.charisma.ToString();
                survivorInfoForm5.survivorInfoFitnessStat.Text = createSurvivorForm5.survivor5.fitness.ToString();
                survivorInfoForm5.survivorInfoIntelligenceStat.Text = createSurvivorForm5.survivor5.intelligence.ToString();
                //Set Info for Survivor 6
                survivorInfoForm6.survivorInfoNameLabel.Text        = createSurvivorForm6.survivor6.name;
                survivorInfoForm6.survivorInfoOccupationLabel.Text  = createSurvivorForm6.survivor6.occupation;
                survivorInfoForm6.survivorInfoAgeStat.Text          = createSurvivorForm6.survivor6.age.ToString();
                survivorInfoForm6.survivorInfoCharismaStat.Text     = createSurvivorForm6.survivor6.charisma.ToString();
                survivorInfoForm6.survivorInfoFitnessStat.Text      = createSurvivorForm6.survivor6.fitness.ToString();
                survivorInfoForm6.survivorInfoIntelligenceStat.Text = createSurvivorForm6.survivor6.intelligence.ToString();
            }
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

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
                SetSurvivorInfoMethod();
                
                colonyInfoForm1 = new ColonyInfoForm();
                infoMaster1 = new InfoMaster();
                craftingAndDesign1 = new CraftingandDesign();

                infoMaster1.hasJustBegun = true;
                //Form1.frm1.Show();
                Form1.frm1.newSimulationToolStripMenuItem.Enabled = false;
                Form1.frm1.colonyInformationToolStripMenuItem.Enabled = true;
                Form1.frm1.mainTimer.Enabled = true;
                Form1.frm1.mainTimer.Start();
                Close();
            }
            
        }
    }
    
}
