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

        // DESIGN ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        string _whichDesign = "";

        Random random = new Random();
        
        public void ResearchIfEngineer(string occupation, int intelligence, int whichSurvivor)
        {
            AllDesignComplete();
            if (NewSimSetup.infoMaster1.allDesignComplete == true)
            {
                return;
            }
            else if (NewSimSetup.infoMaster1.allDesignComplete == false)
            {
                WhichDesign();
                if (_whichDesign == "null")
                {
                    return;
                }
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
        }

        private void WhichDesign()
        {
            //THIS IS INFINITE LOOP. MAYBE I SHOULD REFACTOR THIS!
            int designChoice = random.Next(1, 5);
            if (designChoice == 1)
            {
                if (NewSimSetup.infoMaster1.axeDesignComplete == false &&
                    NewSimSetup.createSurvivorForm1.survivor1.currentTaskString != "axe" &&
                    NewSimSetup.createSurvivorForm2.survivor2.currentTaskString != "axe" &&
                    NewSimSetup.createSurvivorForm3.survivor3.currentTaskString != "axe" &&
                    NewSimSetup.createSurvivorForm4.survivor4.currentTaskString != "axe" &&
                    NewSimSetup.createSurvivorForm5.survivor5.currentTaskString != "axe" &&
                    NewSimSetup.createSurvivorForm6.survivor6.currentTaskString != "axe")
                {
                    busyTickDuration = 3;
                    _whichDesign = "axe";
                }
                else if (NewSimSetup.infoMaster1.axeDesignComplete == true ||
                         NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "axe" ||
                         NewSimSetup.createSurvivorForm2.survivor2.currentTaskString == "axe" ||
                         NewSimSetup.createSurvivorForm3.survivor3.currentTaskString == "axe" ||
                         NewSimSetup.createSurvivorForm4.survivor4.currentTaskString == "axe" ||
                         NewSimSetup.createSurvivorForm5.survivor5.currentTaskString == "axe" ||
                         NewSimSetup.createSurvivorForm6.survivor6.currentTaskString == "axe")
                {
                    WhichDesign();
                }
            }
            else if (designChoice == 2)
            {
                if (NewSimSetup.infoMaster1.leanToDesignComplete == false &&
                    NewSimSetup.createSurvivorForm1.survivor1.currentTaskString != "lean-to" &&
                    NewSimSetup.createSurvivorForm2.survivor2.currentTaskString != "lean-to" &&
                    NewSimSetup.createSurvivorForm3.survivor3.currentTaskString != "lean-to" &&
                    NewSimSetup.createSurvivorForm4.survivor4.currentTaskString != "lean-to" &&
                    NewSimSetup.createSurvivorForm5.survivor5.currentTaskString != "lean-to" &&
                    NewSimSetup.createSurvivorForm6.survivor6.currentTaskString != "lean-to")
                {
                   busyTickDuration = 6;
                   _whichDesign = "lean-to";
                }
                else if (NewSimSetup.infoMaster1.leanToDesignComplete == true ||
                         NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "lean-to" ||
                         NewSimSetup.createSurvivorForm2.survivor2.currentTaskString == "lean-to" ||
                         NewSimSetup.createSurvivorForm3.survivor3.currentTaskString == "lean-to" ||
                         NewSimSetup.createSurvivorForm4.survivor4.currentTaskString == "lean-to" ||
                         NewSimSetup.createSurvivorForm5.survivor5.currentTaskString == "lean-to" ||
                         NewSimSetup.createSurvivorForm6.survivor6.currentTaskString == "lean-to")
                {
                    WhichDesign();
                }
            }
            else if (designChoice == 3)
            {
                if (NewSimSetup.infoMaster1.fishingPoleDesignComplete == false &&
                    NewSimSetup.createSurvivorForm1.survivor1.currentTaskString != "fishing pole" &&
                    NewSimSetup.createSurvivorForm2.survivor2.currentTaskString != "fishing pole" &&
                    NewSimSetup.createSurvivorForm3.survivor3.currentTaskString != "fishing pole" &&
                    NewSimSetup.createSurvivorForm4.survivor4.currentTaskString != "fishing pole" &&
                    NewSimSetup.createSurvivorForm5.survivor5.currentTaskString != "fishing pole" &&
                    NewSimSetup.createSurvivorForm6.survivor6.currentTaskString != "fishing pole")
                {
                    busyTickDuration = 6;
                    _whichDesign = "fishing pole";
                }
                else if (NewSimSetup.infoMaster1.fishingPoleDesignComplete == true ||
                         NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "fishing pole" ||
                         NewSimSetup.createSurvivorForm2.survivor2.currentTaskString == "fishing pole" ||
                         NewSimSetup.createSurvivorForm3.survivor3.currentTaskString == "fishing pole" ||
                         NewSimSetup.createSurvivorForm4.survivor4.currentTaskString == "fishing pole" ||
                         NewSimSetup.createSurvivorForm5.survivor5.currentTaskString == "fishing pole" ||
                         NewSimSetup.createSurvivorForm6.survivor6.currentTaskString == "fishing pole")
                {
                    WhichDesign();
                }             
            }
            else if (designChoice == 4)
            {
                _whichDesign = "null";
            }
        }

        public void DesignComplete(int whichSurvivor)
        {
            if (whichSurvivor == 1)
            {
                if (NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "axe")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "axe " + "\r\n";
                    NewSimSetup.infoMaster1.axeDesignComplete = true;
                    Debug.WriteLine("axe: " + NewSimSetup.infoMaster1.axeDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "lean-to")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "lean-to " + "\r\n";
                    NewSimSetup.infoMaster1.leanToDesignComplete = true;
                    Debug.WriteLine("lean-to: " + NewSimSetup.infoMaster1.leanToDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm1.survivor1.currentTaskString == "fishing pole")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "fishing pole " + "\r\n";
                    NewSimSetup.infoMaster1.fishingPoleDesignComplete = true;
                    Debug.WriteLine("fishing pole: " + NewSimSetup.infoMaster1.fishingPoleDesignComplete);
                }
            }
            else if (whichSurvivor == 2)
            {
                if (NewSimSetup.createSurvivorForm2.survivor2.currentTaskString == "axe")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "axe " + "\r\n";
                    NewSimSetup.infoMaster1.axeDesignComplete = true;
                    Debug.WriteLine("axe: " + NewSimSetup.infoMaster1.axeDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm2.survivor2.currentTaskString == "lean-to")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "lean-to " + "\r\n";
                    NewSimSetup.infoMaster1.leanToDesignComplete = true;
                    Debug.WriteLine("lean-to: " + NewSimSetup.infoMaster1.leanToDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm2.survivor2.currentTaskString == "fishing pole")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "fishing pole " + "\r\n";
                    NewSimSetup.infoMaster1.fishingPoleDesignComplete = true;
                    Debug.WriteLine("fishing pole: " + NewSimSetup.infoMaster1.fishingPoleDesignComplete);
                }
            }
            else if (whichSurvivor == 3)
            {
                if (NewSimSetup.createSurvivorForm3.survivor3.currentTaskString == "axe")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "axe " + "\r\n";
                    NewSimSetup.infoMaster1.axeDesignComplete = true;
                    Debug.WriteLine("axe: " + NewSimSetup.infoMaster1.axeDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm3.survivor3.currentTaskString == "lean-to")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "lean-to " + "\r\n";
                    NewSimSetup.infoMaster1.leanToDesignComplete = true;
                    Debug.WriteLine("lean-to: " + NewSimSetup.infoMaster1.leanToDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm3.survivor3.currentTaskString == "fishing pole")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "fishing pole " + "\r\n";
                    NewSimSetup.infoMaster1.fishingPoleDesignComplete = true;
                    Debug.WriteLine("fishing pole: " + NewSimSetup.infoMaster1.fishingPoleDesignComplete);
                }
            }
            else if (whichSurvivor == 4)
            {
                if (NewSimSetup.createSurvivorForm4.survivor4.currentTaskString == "axe")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "axe " + "\r\n";
                    NewSimSetup.infoMaster1.axeDesignComplete = true;
                    Debug.WriteLine("axe: " + NewSimSetup.infoMaster1.axeDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm4.survivor4.currentTaskString == "lean-to")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "lean-to " + "\r\n";
                    NewSimSetup.infoMaster1.leanToDesignComplete = true;
                    Debug.WriteLine("lean-to: " + NewSimSetup.infoMaster1.leanToDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm4.survivor4.currentTaskString == "fishing pole")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "fishing pole " + "\r\n";
                    NewSimSetup.infoMaster1.fishingPoleDesignComplete = true;
                    Debug.WriteLine("fishing pole: " + NewSimSetup.infoMaster1.fishingPoleDesignComplete);
                }
            }
            else if (whichSurvivor == 5)
            {
                if (NewSimSetup.createSurvivorForm5.survivor5.currentTaskString == "axe")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "axe " + "\r\n";
                    NewSimSetup.infoMaster1.axeDesignComplete = true;
                    Debug.WriteLine("axe: " + NewSimSetup.infoMaster1.axeDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm5.survivor5.currentTaskString == "lean-to")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "lean-to " + "\r\n";
                    NewSimSetup.infoMaster1.leanToDesignComplete = true;
                    Debug.WriteLine("lean-to: " + NewSimSetup.infoMaster1.leanToDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm5.survivor5.currentTaskString == "fishing pole")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "fishing pole " + "\r\n";
                    NewSimSetup.infoMaster1.fishingPoleDesignComplete = true;
                    Debug.WriteLine("fishing pole: " + NewSimSetup.infoMaster1.fishingPoleDesignComplete);
                }
            }
            else if (whichSurvivor == 6)
            {
                if (NewSimSetup.createSurvivorForm6.survivor6.currentTaskString == "axe")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "axe " + "\r\n";
                    NewSimSetup.infoMaster1.axeDesignComplete = true;
                    Debug.WriteLine("axe: " + NewSimSetup.infoMaster1.axeDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm6.survivor6.currentTaskString == "lean-to")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "lean-to " + "\r\n";
                    NewSimSetup.infoMaster1.leanToDesignComplete = true;
                    Debug.WriteLine("lean-to: " + NewSimSetup.infoMaster1.leanToDesignComplete);
                }
                else if (NewSimSetup.createSurvivorForm6.survivor6.currentTaskString == "fishing pole")
                {
                    NewSimSetup.colonyInfoForm1.blueprintsTextBox.Text += "fishing pole " + "\r\n";
                    NewSimSetup.infoMaster1.fishingPoleDesignComplete = true;
                    Debug.WriteLine("fishing pole: " + NewSimSetup.infoMaster1.fishingPoleDesignComplete);
                }
            }
        }

        public void AllDesignComplete()
        {
            if (NewSimSetup.infoMaster1.axeDesignComplete == true && NewSimSetup.infoMaster1.leanToDesignComplete == true && NewSimSetup.infoMaster1.fishingPoleDesignComplete == true)
            {
                NewSimSetup.infoMaster1.allDesignComplete = true;
                Debug.WriteLine("all design: " + NewSimSetup.infoMaster1.allDesignComplete);
            }
        }
        // DESIGN END ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // CRAFTING -------------------------------------------------------------------------------------------------------------

        string _whichItem = "";

        /*public void CraftingMethod(string occupation, int fitness, int whichSurvivor)
        {
            if (occupation == "Engineer" || fitness > 5)
            {
                WhichItem();
                if (_whichItem == "null")
                {
                    return;
                }
                int chanceToCraft = random.Next(0, 101);
                if (chanceToCraft <= 35)
                {
                    //successful
                }
            }
            else
            {
                return;
            }        
        }

        WhichItem()
        {
            //THIS IS INFINITE LOOP. MAYBE I SHOULD REFACTOR THIS!
            int axeQuantity;
            NewSimSetup.infoMaster1.itemsDict.TryGetValue("axe", out axeQuantity);
            int leanToQuantity;
            NewSimSetup.infoMaster1.itemsDict.TryGetValue("lean-to", out leanToQuantity);
            int fishingPoleQuantity;
            NewSimSetup.infoMaster1.itemsDict.TryGetValue("fishing pole", out fishingPoleQuantity);


            int craftChoice = random.Next(1, 5);
            if (craftChoice == 1)
            {
                if (NewSimSetup.infoMaster1.axeDesignComplete == true &&
                    axeQuantity < newSimSetup.survivorQuantity)
                {
                    busyTickDuration = 6;
                    _whichItem = "axe";
                }
                else if (NewSimSetup.infoMaster1.axeDesignComplete == false)
                {
                    WhichItem();
                }
            }
            else if (craftChoice == 2)
            {
                if (NewSimSetup.infoMaster1.leanToDesignComplete == false &&
                    leanToQuantity < newSimSetup.survivorQuantity)
                {
                    busyTickDuration = 10;
                    _whichItem = "lean-to";
                }
                else if (NewSimSetup.infoMaster1.leanToDesignComplete == false)
                {
                    WhichItem();
                }
            }
            else if (craftChoice == 3)
            {
                if (NewSimSetup.infoMaster1.fishingPoleDesignComplete == true &&
                    fishingPoleQuantity < newSimSetup.survivorQuantity)
                {
                    busyTickDuration = 6;
                    _whichItem = "fishing pole";
                }
                else if (NewSimSetup.infoMaster1.fishingPoleDesignComplete == false)
                {
                    WhichItem();
                }
            }
            else if (craftChoice == 4)
            {
                _whichItem = "null";
            }
        }*/
    }
}
