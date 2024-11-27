using Calculator.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    public class StoreNumber : ViewModelBase
    {
        public static int x { get; set; }

        public static int y { get; set; }

        public static double z { get; set; }

        public static int xyFlag = 0;

        public static int calculationType {  get; set; }

        public static string calculationDisplay { get; set; }


    }
}
