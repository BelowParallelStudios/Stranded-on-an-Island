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
    public partial class Form1 : Form
    {
        public static Form1 frm1;
        public Form1()
        {
            //frm1 = this;  //If you do it this way, frm1 will be set to equal the "this" of CraftingandDesign once that is called, since it is in the constructor
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm1 = this;
        }

        private int tickCount = 0;
        private int dayCount = 0;
        private string currentTime;

        
        public static NewSimSetup newSimSetup;

        private static Random random = new Random();

        //MENU STRIP ------------------------------------------------------------------------------------------------------------------
        private void newSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newSimSetup = new NewSimSetup();
            newSimSetup.ShowDialog();
        }

        private void survivor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSimSetup.survivorInfoForm1.Show();
        }

        private void survivor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSimSetup.survivorInfoForm2.Show();
        }

        private void survivor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSimSetup.survivorInfoForm3.Show();
        }

        private void survivor4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSimSetup.survivorInfoForm4.Show();
        }

        private void survivor5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSimSetup.survivorInfoForm5.Show();
        }

        private void survivor6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSimSetup.survivorInfoForm6.Show();
        }

        private void colonyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSimSetup.colonyInfoForm1.Show();
        }

        //MENU STRIP END --------------------------------------------------------------------------------------------

        private void simLogTextBox_TextChanged(object sender, EventArgs e)
        {
            simLogTextBox.SelectionStart = simLogTextBox.Text.Length;
            simLogTextBox.ScrollToCaret();
        }

        /// --------------TIMER--------------------------------TIMER----------------------------------------TIMER------------------------------
        
        // MUST PUT MAIN STUFF IN HERE
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            tickCount++;
            //this.simLogTextBox.Text += currentTime + "\r\n";
            JustBegunMethod();
            DayTracker();
            OverarchingMethod();
        }

        //NOT PART OF OVERARCHING METHOD
        private void DayTracker()
        {
            if ((tickCount - 2) % 3 == 0)
            {
                currentTime = "Mid-day";
                this.timeOfDayLabel.Text = currentTime;
            }
            else if ((tickCount - 1) % 3 == 0)
            {
                currentTime = "Morning";
                dayCount++;
                this.simLogTextBox.Text += "Day " + dayCount + " begins." + "\r\n";
                this.timeOfDayLabel.Text = currentTime;
                this.dayLabel.Text = "Day " + dayCount + ":";
                this.dayLabel.Visible = true;
                this.timeOfDayLabel.Visible = true;
            }
            else if (tickCount % 3 == 0)
            {
                currentTime = "Night";
                this.timeOfDayLabel.Text = currentTime;
            }

        }

        private void JustBegunMethod()
        {
            if (NewSimSetup.infoMaster1.hasJustBegun == true)
            {
                Debug.WriteLine("just begun executed");
                this.simLogTextBox.Text += "From amidst the wreckage, " + newSimSetup.survivorQuantity  + " brave survivors emerge." + "\r\n";
                Debug.WriteLine(simLogTextBox.Text);
                //this.simLogTextBox.Text += "Day 1 begins." + "\r\n";
                NewSimSetup.infoMaster1.hasJustBegun = false;
            }
        }

        //OVERARCHING METHOD CONTROLLING ENVIRONMENT GENERATION/EVENTS AND SURVIVOR DECISIONS
        private void OverarchingMethod()
        {
            //Environment();
            SurvivorActions();
            //update colony info form
            UpdateColonyInfoFormMethod();
        }

        // private void Environment(/*int environmentHarshness*/)
        /*{
            if (currentTime == "Morning")
            {

            }
        }*/

        private void SurvivorActions()
        {
            WhichSurvivorTurnLoop();
           /* //survivor1
            if (CreateSurvivorForm.survivor1.isBusy == false)
            {
                //RestGatherOrInteract()
            }
            else if (CreateSurvivorForm.survivor1.isBusy == true)
            {
                //move on....is this necessary to have here?
            }*/
        }

        //SOME VARIABLES
        // -------------------------------------------------------------
        protected static string survivorNameLocal;
        protected static string survivorOccupationLocal;
        protected static int survivorCharismaLocal = 0;
        protected static int survivorFitnessLocal = 0;
        protected static int survivorIntelligenceLocal = 0;

        //For isBusy Logic
        protected static bool isBusyLocal;
        protected static int busyTickDuration;

        // -------------------------------------------------------------
        

        private void WhichSurvivorTurnLoop()
        {
            
            for (int thisSurvivor = 1; thisSurvivor < newSimSetup.survivorQuantity + 1; thisSurvivor++)
            {
                //put everything in here
                if (thisSurvivor == 1)
                {
                    isBusyLocal = NewSimSetup.createSurvivorForm1.survivor1.isBusy;
                    survivorNameLocal = NewSimSetup.createSurvivorForm1.survivor1.name;
                    survivorOccupationLocal = NewSimSetup.createSurvivorForm1.survivor1.occupation;
                    survivorCharismaLocal = NewSimSetup.createSurvivorForm1.survivor1.charisma;
                    survivorFitnessLocal = NewSimSetup.createSurvivorForm1.survivor1.fitness;
                    survivorIntelligenceLocal = NewSimSetup.createSurvivorForm1.survivor1.intelligence;

                    if (isBusyLocal == false)
                    {
                        newSimSetup.craftingAndDesign1.ResearchIfEngineer(survivorOccupationLocal, survivorIntelligenceLocal, thisSurvivor);
                        //CraftingMethod();
                        RestorGather();
                    }
                    else if (isBusyLocal == true)
                    {
                        NewSimSetup.createSurvivorForm1.survivor1.busyTickDuration -= 1;
                        if (NewSimSetup.createSurvivorForm1.survivor1.busyTickDuration < 1)
                        {
                            newSimSetup.craftingAndDesign1.DesignComplete(thisSurvivor);
                            this.simLogTextBox.Text += survivorNameLocal + " has finished drawing up the blueprint for " + NewSimSetup.createSurvivorForm1.survivor1.currentTaskString + "." + "\r\n";
                            NewSimSetup.createSurvivorForm1.survivor1.isBusy = false;
                        }
                    }
                }
                else if (thisSurvivor == 2)
                {
                    isBusyLocal = NewSimSetup.createSurvivorForm2.survivor2.isBusy;
                    survivorNameLocal = NewSimSetup.createSurvivorForm2.survivor2.name;
                    survivorOccupationLocal = NewSimSetup.createSurvivorForm2.survivor2.occupation;
                    survivorCharismaLocal = NewSimSetup.createSurvivorForm2.survivor2.charisma;
                    survivorFitnessLocal = NewSimSetup.createSurvivorForm2.survivor2.fitness;
                    survivorIntelligenceLocal = NewSimSetup.createSurvivorForm2.survivor2.intelligence;

                    if (isBusyLocal == false)
                    {
                        newSimSetup.craftingAndDesign1.ResearchIfEngineer(survivorOccupationLocal, survivorIntelligenceLocal, thisSurvivor);
                        //ResearchIfEngineer(survivorOccupationLocal, survivorIntelligenceLocal, thisSurvivor);
                        RestorGather();
                    }
                    else if (isBusyLocal == true)
                    {
                        NewSimSetup.createSurvivorForm2.survivor2.busyTickDuration -= 1;
                        if (NewSimSetup.createSurvivorForm2.survivor2.busyTickDuration < 1)
                        {
                            newSimSetup.craftingAndDesign1.DesignComplete(thisSurvivor);
                            this.simLogTextBox.Text += survivorNameLocal + " has finished drawing up the blueprint for " + NewSimSetup.createSurvivorForm2.survivor2.currentTaskString + "." + "\r\n";
                            NewSimSetup.createSurvivorForm2.survivor2.isBusy = false;
                        }
                    }
                }
                else if (thisSurvivor == 3)
                {
                    isBusyLocal = NewSimSetup.createSurvivorForm3.survivor3.isBusy;

                    survivorNameLocal = NewSimSetup.createSurvivorForm3.survivor3.name;
                    survivorOccupationLocal = NewSimSetup.createSurvivorForm3.survivor3.occupation;
                    survivorCharismaLocal = NewSimSetup.createSurvivorForm3.survivor3.charisma;
                    survivorFitnessLocal = NewSimSetup.createSurvivorForm3.survivor3.fitness;
                    survivorIntelligenceLocal = NewSimSetup.createSurvivorForm3.survivor3.intelligence;

                    if (isBusyLocal == false)
                    {
                        newSimSetup.craftingAndDesign1.ResearchIfEngineer(survivorOccupationLocal, survivorIntelligenceLocal, thisSurvivor);
                        RestorGather();
                    }
                    else if (isBusyLocal == true)
                    {
                        NewSimSetup.createSurvivorForm3.survivor3.busyTickDuration -= 1;
                        if (NewSimSetup.createSurvivorForm3.survivor3.busyTickDuration < 1)
                        {
                            newSimSetup.craftingAndDesign1.DesignComplete(thisSurvivor);
                            this.simLogTextBox.Text += survivorNameLocal + " has finished drawing up the blueprint for " + NewSimSetup.createSurvivorForm3.survivor3.currentTaskString + "." + "\r\n";
                            NewSimSetup.createSurvivorForm3.survivor3.isBusy = false;
                        }
                    }
                }
                else if (thisSurvivor == 4)
                {
                    isBusyLocal = NewSimSetup.createSurvivorForm4.survivor4.isBusy;

                    survivorNameLocal = NewSimSetup.createSurvivorForm4.survivor4.name;
                    survivorOccupationLocal = NewSimSetup.createSurvivorForm4.survivor4.occupation;
                    survivorCharismaLocal = NewSimSetup.createSurvivorForm4.survivor4.charisma;
                    survivorFitnessLocal = NewSimSetup.createSurvivorForm4.survivor4.fitness;
                    survivorIntelligenceLocal = NewSimSetup.createSurvivorForm4.survivor4.intelligence;

                    if (isBusyLocal == false)
                    {
                        newSimSetup.craftingAndDesign1.ResearchIfEngineer(survivorOccupationLocal, survivorIntelligenceLocal, thisSurvivor);
                        RestorGather();
                    }
                    else if (isBusyLocal == true)
                    {
                        NewSimSetup.createSurvivorForm4.survivor4.busyTickDuration -= 1;
                        if (NewSimSetup.createSurvivorForm4.survivor4.busyTickDuration < 1)
                        {
                            newSimSetup.craftingAndDesign1.DesignComplete(thisSurvivor);
                            this.simLogTextBox.Text += survivorNameLocal + " has finished drawing up the blueprint for " + NewSimSetup.createSurvivorForm4.survivor4.currentTaskString + "." + "\r\n";
                            NewSimSetup.createSurvivorForm4.survivor4.isBusy = false;
                        }
                    }
                }
                else if (thisSurvivor == 5)
                {
                    isBusyLocal = NewSimSetup.createSurvivorForm5.survivor5.isBusy;

                    survivorNameLocal = NewSimSetup.createSurvivorForm5.survivor5.name;
                    survivorOccupationLocal = NewSimSetup.createSurvivorForm5.survivor5.occupation;
                    survivorCharismaLocal = NewSimSetup.createSurvivorForm5.survivor5.charisma;
                    survivorFitnessLocal = NewSimSetup.createSurvivorForm5.survivor5.fitness;
                    survivorIntelligenceLocal = NewSimSetup.createSurvivorForm5.survivor5.intelligence;

                    if (isBusyLocal == false)
                    {
                        newSimSetup.craftingAndDesign1.ResearchIfEngineer(survivorOccupationLocal, survivorIntelligenceLocal, thisSurvivor);
                        RestorGather();
                    }
                    else if (isBusyLocal == true)
                    {
                        NewSimSetup.createSurvivorForm5.survivor5.busyTickDuration -= 1;
                        if (NewSimSetup.createSurvivorForm5.survivor5.busyTickDuration < 1)
                        {
                            newSimSetup.craftingAndDesign1.DesignComplete(thisSurvivor);
                            this.simLogTextBox.Text += survivorNameLocal + " has finished drawing up the blueprint for " + NewSimSetup.createSurvivorForm5.survivor5.currentTaskString + "." + "\r\n";
                            NewSimSetup.createSurvivorForm5.survivor5.isBusy = false;
                        }
                    }
                }
                else if (thisSurvivor == 6)
                {
                    isBusyLocal = NewSimSetup.createSurvivorForm6.survivor6.isBusy;

                    survivorNameLocal = NewSimSetup.createSurvivorForm6.survivor6.name;
                    survivorOccupationLocal = NewSimSetup.createSurvivorForm6.survivor6.occupation;
                    survivorCharismaLocal = NewSimSetup.createSurvivorForm6.survivor6.charisma;
                    survivorFitnessLocal = NewSimSetup.createSurvivorForm6.survivor6.fitness;
                    survivorIntelligenceLocal = NewSimSetup.createSurvivorForm6.survivor6.intelligence;

                    if (isBusyLocal == false)
                    {
                        newSimSetup.craftingAndDesign1.ResearchIfEngineer(survivorOccupationLocal, survivorIntelligenceLocal, thisSurvivor);
                        RestorGather();
                    }
                    else if (isBusyLocal == true)
                    {
                        NewSimSetup.createSurvivorForm6.survivor6.busyTickDuration -= 1;
                        if (NewSimSetup.createSurvivorForm6.survivor6.busyTickDuration < 1)
                        {
                            newSimSetup.craftingAndDesign1.DesignComplete(thisSurvivor);
                            this.simLogTextBox.Text += survivorNameLocal + " has finished drawing up the blueprint for " + NewSimSetup.createSurvivorForm6.survivor6.currentTaskString + "." + "\r\n";
                            NewSimSetup.createSurvivorForm6.survivor6.isBusy = false;
                        }
                    }
                }

            }
        }

        //GATHERING
        private void RestorGather()
        {
            int fitnessTier;
            int choiceChance = random.Next(0, 101);
            if (isBusyLocal == false)
            {
                if (survivorFitnessLocal < 3) //weak fitness
                {
                    fitnessTier = 1;
                    if (choiceChance <= 20)
                    {
                        //decide to gather     
                        this.simLogTextBox.Text += survivorNameLocal + " has decided to GATHER." + "\r\n";
                        //gather success?
                        GatherMethod(fitnessTier);

                    }
                    else if (choiceChance > 20)
                    {
                        //decide to rest
                        this.simLogTextBox.Text += survivorNameLocal + " has decided to REST." + "\r\n";

                    }
                }
                else if (survivorFitnessLocal >= 3 && survivorFitnessLocal < 7) //medium fitness
                {
                    fitnessTier = 2;
                    if (choiceChance <= 40)
                    {
                        //decide to gather
                        this.simLogTextBox.Text += survivorNameLocal + " has decided to GATHER." + "\r\n";
                        //gather success?
                        GatherMethod(fitnessTier);
                    }
                    else if (choiceChance > 40)
                    {
                        //decide to rest
                        this.simLogTextBox.Text += survivorNameLocal + " has decided to REST." + "\r\n";
                    }
                }
                else if (survivorFitnessLocal >= 7) //high fitness
                {
                    fitnessTier = 3;
                    if (choiceChance <= 65)
                    {
                        //decide to gather
                        this.simLogTextBox.Text += survivorNameLocal + " has decided to GATHER." + "\r\n";
                        //gather success?
                        GatherMethod(fitnessTier);
                    }
                    else if (choiceChance > 65)
                    {
                        //decide to rest
                        this.simLogTextBox.Text += survivorNameLocal + " has decided to REST." + "\r\n";
                    }
                }
            }
        }

        private void GatherMethod(int fitnessTierArgument)
        {
            if (fitnessTierArgument == 1)
            {
              int gatherChance = random.Next(0, 101);
                        if (gatherChance <= 40)
                        {
                    //wood, stone, or food?
                    string _whichResource = WhichResource();
                    this.simLogTextBox.Text += survivorNameLocal + " has successfully gathered " + _whichResource + "." + "\r\n";
                }
                        if (gatherChance > 40)
                {
                    this.simLogTextBox.Text += survivorNameLocal + " was unable to gather anything." + "\r\n";
                }
            }
            if (fitnessTierArgument == 2)
            {
                int gatherChance = random.Next(0, 101);
                if (gatherChance <= 55)
                {
                    //wood, stone, or food?
                    string _whichResource = WhichResource();
                    this.simLogTextBox.Text += survivorNameLocal + " has successfully gathered " + _whichResource + "." + "\r\n";
                }
                if (gatherChance > 55)
                {
                    this.simLogTextBox.Text += survivorNameLocal + " was unable to gather anything." + "\r\n";
                }
            }
            if (fitnessTierArgument == 3)
            {
                int gatherChance = random.Next(0, 101);
                if (gatherChance <= 65)
                {
                    //wood, stone, or food?
                    string _whichResource = WhichResource();
                    this.simLogTextBox.Text += survivorNameLocal + " has successfully gathered " + _whichResource + "." + "\r\n";
                }
                if (gatherChance > 65)
                {
                    this.simLogTextBox.Text += survivorNameLocal + " was unable to gather anything." + "\r\n";
                }
            }
        }

        private string WhichResource()
        {
            int resourceChoice = random.Next(1, 4);
            if (resourceChoice == 1)
            {
                NewSimSetup.infoMaster1.woodQuantity += 1;
                return "wood";
            }
            else if (resourceChoice == 2)
            {
                NewSimSetup.infoMaster1.stoneQuantity += 1;
                return "stone";
            }
            else if (resourceChoice == 3)
            {
                NewSimSetup.infoMaster1.foodQuantity += 1;
                return "food";
            }
            else return "HOW DID WE GET HERE?";
        }

        private void UpdateColonyInfoFormMethod()
        {
            //update colony info form
            NewSimSetup.colonyInfoForm1.woodQuantityLabel.Text = NewSimSetup.infoMaster1.woodQuantity.ToString();
            NewSimSetup.colonyInfoForm1.stoneQuantityLabel.Text = NewSimSetup.infoMaster1.stoneQuantity.ToString();
            NewSimSetup.colonyInfoForm1.foodQuantityLabel.Text = NewSimSetup.infoMaster1.foodQuantity.ToString();
        }

        //MIGHT NEED THIS IN REST OR GATHER METHOD AS WELL
        protected void SurvivorBusySetterMethod(int whichSurvivor, int tickDuration, string currentTask = "default")
        {
            if (whichSurvivor == 1)
            {
                isBusyLocal = true;
                NewSimSetup.createSurvivorForm1.survivor1.isBusy = true;
                NewSimSetup.createSurvivorForm1.survivor1.busyTickDuration = tickDuration;
                NewSimSetup.createSurvivorForm1.survivor1.currentTaskString = currentTask;
            }
            else if (whichSurvivor == 2)
            {
                isBusyLocal = true;
                NewSimSetup.createSurvivorForm2.survivor2.isBusy = true;
                NewSimSetup.createSurvivorForm2.survivor2.busyTickDuration = tickDuration;
                NewSimSetup.createSurvivorForm2.survivor2.currentTaskString = currentTask;
            }
            else if (whichSurvivor == 3)
            {
                isBusyLocal = true;
                NewSimSetup.createSurvivorForm3.survivor3.isBusy = true;
                NewSimSetup.createSurvivorForm3.survivor3.busyTickDuration = tickDuration;
                NewSimSetup.createSurvivorForm3.survivor3.currentTaskString = currentTask;
            }
            else if (whichSurvivor == 4)
            {
                isBusyLocal = true;
                NewSimSetup.createSurvivorForm4.survivor4.isBusy = true;
                NewSimSetup.createSurvivorForm4.survivor4.busyTickDuration = tickDuration;
                NewSimSetup.createSurvivorForm4.survivor4.currentTaskString = currentTask;
            }
            else if (whichSurvivor == 5)
            {
                isBusyLocal = true;
                NewSimSetup.createSurvivorForm5.survivor5.isBusy = true;
                NewSimSetup.createSurvivorForm5.survivor5.busyTickDuration = tickDuration;
                NewSimSetup.createSurvivorForm5.survivor5.currentTaskString = currentTask;
            }
            else if (whichSurvivor == 6)
            {
                isBusyLocal = true;
                NewSimSetup.createSurvivorForm6.survivor6.isBusy = true;
                NewSimSetup.createSurvivorForm6.survivor6.busyTickDuration = tickDuration;
                NewSimSetup.createSurvivorForm6.survivor6.currentTaskString = currentTask;
            }
        }

        
    }
}
