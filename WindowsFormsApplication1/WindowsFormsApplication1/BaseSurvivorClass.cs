using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class BaseSurvivorClass
    {
        public string name;
        public bool isMale;
        public int age { get; set; }

        public bool isFormComplete;
        

        //STATS: these determine if a survivor can/cannot perform a task, and if so, how efficiently
        public int charisma { get; set; }
        public int fitness { get; set; }
        public int intelligence { get; set; }

        //Occupation determines starting skill bonuses
        public string occupation { get; set; }

        //setting defaults
      /*  void Start()
        {
            name = "Nobody";
            isMale = true;
            age = 25;
            charisma = 5;
            fitness = 5;
            intelligence = 5;
            occupation = "Lawyer";

        }*/

        //Skills/Abilities
        //public bool canConstruct;
        //public bool canHeal;
        //public bool canLead;

    }
}
