using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class InfoMaster
    {

        public bool hasJustBegun;
        

        // resources
        public int woodQuantity { get; set; }
        public int stoneQuantity { get; set; }
        public int foodQuantity { get; set; }

        // items

        //blueprint bools
        public bool allDesignComplete;

        public bool knifeDesignComplete;
        public bool leanToDesignComplete;
        public bool fishingPoleDesignComplete;

    }
}
