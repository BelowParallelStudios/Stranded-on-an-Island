using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class CraftingandDesign : Form1
    {
        
        Random random = new Random();
        

        // RESEARCH
        public void ResearchIfEngineer(string occupation, int intelligence, int whichSurvivor)
        {
            string _whichDesign = WhichDesign();
            int designChance = random.Next(0, 101);
            if (occupation == "Engineer")
            {
                if (intelligence <= 3)  //Tier 1
                {
                    if (designChance <= 20)
                    {
                        Form1.frm1.simLogTextBox.Text += survivorNameLocal + " is working on a design called " + _whichDesign + "." + "\r\n";
                        SurvivorBusySetterMethod(whichSurvivor, busyTickDuration, _whichDesign);
                    }
                    else { return; }
                }
                else if (intelligence > 3 & intelligence <= 6)  //Tier 2
                {
                    if (designChance <= 35)
                    {
                        Form1.frm1.simLogTextBox.Text += survivorNameLocal + " is working on a design called " + _whichDesign + "." + "\r\n";
                        SurvivorBusySetterMethod(whichSurvivor, busyTickDuration, _whichDesign);
                    }
                    else { return; }
                }
                else if (intelligence > 6 & intelligence <= 8)  //Tier 3
                {
                    if (designChance <= 45)
                    {
                        Form1.frm1.simLogTextBox.Text += survivorNameLocal + " is working on a design called " + _whichDesign + "." + "\r\n";
                        SurvivorBusySetterMethod(whichSurvivor, busyTickDuration, _whichDesign);
                    }
                    else { return; }
                }
                else if (intelligence > 8)  //Tier 4
                {
                    if (designChance <= 60)
                    {
                        Form1.frm1.simLogTextBox.Text += survivorNameLocal + " is working on a design called " + _whichDesign + "." + "\r\n";
                        SurvivorBusySetterMethod(whichSurvivor, busyTickDuration, _whichDesign);
                    }
                    else { return; }
                }
            }
        }

        private string WhichDesign()
        {
            int designChoice = random.Next(1, 4);
            if (designChoice == 1)
            {
                busyTickDuration = 3;
                return "knife";
            }
            else if (designChoice == 2)
            {
                busyTickDuration = 6;
                return "lean-to";
            }
            else if (designChoice == 3)
            {
                busyTickDuration = 6;
                return "fishing pole";
            }
            else return "HOW DID WE GET HERE?";
        }

        public void DesignComplete()
        {
            if (NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "knife")
            {
                NewSimSetup.infoMaster1.knifeDesignComplete = true;
            }
            else if (NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "lean-to")
            {
                NewSimSetup.infoMaster1.leanToDesignComplete = true;
            }
            else if (NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "fishing pole")
            {
                NewSimSetup.infoMaster1.fishingPoleDesignComplete = true;
            }
        }
    }
}
