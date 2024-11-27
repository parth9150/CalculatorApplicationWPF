using Calculator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    internal class StoreFunctionCommand : CommandBase
    {

        


        public override void Execute(object? parameter)
        {
            StoreNumber.xyFlag = 1;
            
            switch (parameter) 
            {
                case "0":
                    //addition
                    StoreNumber.calculationType = 0;

                    break;
                case "1":
                    StoreNumber.calculationType = 1;
                    //subtraction
                    break;
                case "2":
                    StoreNumber.calculationType = 2;
                    //multiplication
                    break;
                case "3":
                    StoreNumber.calculationType = 3;
                    //division
                    break;
            }

        }



        public StoreNumber StoreNumber { get; }

        public StoreFunctionCommand()
        {
            StoreNumber = new StoreNumber();

        }
    }
}
