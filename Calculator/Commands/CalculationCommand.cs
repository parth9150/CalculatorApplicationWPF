using Calculator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    internal class CalculationCommand : CommandBase
    {
        public override void Execute(object? parameter)
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

            _calculatorViewModel.DisplayCalculationFunction(StoreNumber.x, StoreNumber.y);


        }


        private readonly CalculatorViewModel _calculatorViewModel;

        public StoreNumber StoreNumber { get; }

        public CalculationCommand(CalculatorViewModel calculatorViewModel)
        {
            StoreNumber = new StoreNumber();
            _calculatorViewModel = calculatorViewModel ?? throw new ArgumentNullException(nameof(calculatorViewModel));
        }

        
    }

}
