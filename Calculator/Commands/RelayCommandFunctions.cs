using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Calculator.Commands
{
    public class RelayCommandFunctions
    {
        public void StoreNumber_x(object param)
        {
            if (param is string number)
            {
                StoreNumber.x = int.Parse(StoreNumber.x.ToString() + number);
                StoreNumber.calculationDisplay = StoreNumber.x.ToString();

            }
        }

        public void StoreNumber_y(object param)
        {
            if (param is string number)
            {
                StoreNumber.y = int.Parse(StoreNumber.y.ToString() + number);
                StoreNumber.calculationDisplay = StoreNumber.y.ToString();
            }

            string temp = DisplayCalculationFunction();
        }

        public string DisplayCalculationFunction()
        {
            string DisplayCalculation = string.Empty;

            if (StoreNumber.xyFlag == 0)
            {
                DisplayCalculation = StoreNumber.x.ToString();
            }
            else if (StoreNumber.xyFlag == 1)
            {
                switch (StoreNumber.calculationType)
                {
                    case 0: //addition
                        DisplayCalculation = StoreNumber.x.ToString() + " + " + StoreNumber.y.ToString();
                        break;
                    case 1: //subtraction
                        DisplayCalculation = StoreNumber.x.ToString() + " - " + StoreNumber.y.ToString();
                        break;
                    case 2: //multiplication
                        DisplayCalculation = StoreNumber.x.ToString() + " * " + StoreNumber.y.ToString();
                        break;
                    case 3: //division
                        DisplayCalculation = StoreNumber.x.ToString() + " / " + StoreNumber.y.ToString();
                        break;
                }
            }
            else if (StoreNumber.xyFlag == 2)
            {
                switch (StoreNumber.calculationType)
                {
                    case 0: //addition
                        DisplayCalculation = StoreNumber.x.ToString() + " + " + StoreNumber.y.ToString() + " = " + StoreNumber.z;
                        break;
                    case 1: //subtraction
                        DisplayCalculation = StoreNumber.x.ToString() + " - " + StoreNumber.y.ToString() + " = " + StoreNumber.z;
                        break;
                    case 2: //multiplication
                        DisplayCalculation = StoreNumber.x.ToString() + " * " + StoreNumber.y.ToString() + " = " + StoreNumber.z;
                        break;
                    case 3: //division
                        DisplayCalculation = StoreNumber.x.ToString() + " / " + StoreNumber.y.ToString() + " = " + StoreNumber.z;
                        break;
                }
            }



            StoreNumber.calculationDisplay = DisplayCalculation;

            return DisplayCalculation;
        }

        public string CalculationCommand()
        {
            StoreNumber.xyFlag = 2;

            switch (StoreNumber.calculationType)
            {
                case 0: //addition
                    StoreNumber.z = StoreNumber.x + StoreNumber.y;
                    break;
                case 1: //subtraction
                    StoreNumber.z = StoreNumber.x - StoreNumber.y;
                    break;
                case 2: //mulitplication
                    StoreNumber.z = StoreNumber.x * StoreNumber.y;
                    break;
                case 3: //division
                    StoreNumber.z = StoreNumber.x / StoreNumber.y;
                    break;
            }

           return DisplayCalculationFunction();
        }

        public void clearCommand()
        {
            StoreNumber.x = 0;
            StoreNumber.y = 0;
            StoreNumber.xyFlag = 0;
            StoreNumber.calculationDisplay = string.Empty;
        }
       
    }
}
