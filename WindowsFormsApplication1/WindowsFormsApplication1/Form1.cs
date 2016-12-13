using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            frm1 = this;
        }

        private int tickCount = 0;
        private int dayCount = 0;
        private string currentTime;
        

        public static Form1 frm1;
        public static NewSimSetup newSimSetup;

        private void newSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newSimSetup = new NewSimSetup();
            newSimSetup.ShowDialog();
        }

        private void simLogTextBox_TextChanged(object sender, EventArgs e)
        {
            simLogTextBox.SelectionStart = simLogTextBox.Text.Length;
            simLogTextBox.ScrollToCaret();
        }

        // MUST PUT MAIN STUFF IN HERE
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            tickCount++;
            //this.simLogTextBox.Text += currentTime + "\r\n";
            JustBegunMethod();
            DayTracker();
            //OverarchingMethod();
        }

        //NOT PART OF OVERARCHING METHOD
        private void DayTracker()
        {
            if ((tickCount - 2) % 3 == 0)
            {
                currentTime = "Mid-day";
            }
            else if ((tickCount - 1) % 3 == 0)
            {
                currentTime = "Morning";
                dayCount++;
                this.simLogTextBox.Text += "Day " + dayCount + " begins." + "\r\n";
            }
            else if (tickCount % 3 == 0)
            {
                currentTime = "Night";
            }

        }

        private void JustBegunMethod()
        {
            if (InfoMaster.hasJustBegun == true)
            {
                this.simLogTextBox.Text += "From amidst the wreckage, " + NewSimSetup.survivorQuantity + " brave survivors emerge." + "\r\n";
                //this.simLogTextBox.Text += "Day 1 begins." + "\r\n";
                InfoMaster.hasJustBegun = false;
            }
        }

        //OVERARCHING METHOD CONTROLLING ENVIRONMENT GENERATION/EVENTS AND SURVIVOR DECISIONS
        private void OverarchingMethod()
        {
            //Environment();
            //SurvivorActions();
        }

        private void Environment(/*int environmentHarshness*/)
        {
            if (currentTime == "Morning")
            {

            }
        }
        
    }
}
