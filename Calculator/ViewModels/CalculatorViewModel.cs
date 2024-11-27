using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Calculator.Commands;
using Calculator.ViewModels;
namespace Calculator.ViewModels
{
    internal class CalculatorViewModel : ViewModelBase 
    {

		public string temp_x = string.Empty;
		public string temp_y = string.Empty;

		

		public RelayCommand StoreNumberCommand => new RelayCommand(param =>
		{
			if (StoreNumber.xyFlag == 0)
			{
				StoreNumber_x(param);
			}
			else if (StoreNumber.xyFlag == 1)
			{
				StoreNumber_y(param);
			}
		});

		
		public ICommand StoreFunction { get; set; }

		public ICommand CalculationFunction { get; set; }


		


		private void StoreNumber_x (object param)
		{
			if (param is string number)
			{
				temp_x += number;
				StoreNumber.x = int.Parse(temp_x);
				StoreNumber.calculationDisplay = StoreNumber.x.ToString();
                //DisplayCalculationFunction(StoreNumber.x, StoreNumber.y);

            }
		}

        private void StoreNumber_y(object param)
        {
            if (param is string number)
            {
                temp_y += number;
                
                StoreNumber.y = int.Parse(temp_y);
				DisplayCalculationFunction(StoreNumber.x, StoreNumber.y);
            }
        }

       public void DisplayCalculationFunction(int x, int y)
		{
			if(StoreNumber.xyFlag == 0)
			{
				DisplayCalculation = StoreNumber.x.ToString();
			}
			else if (StoreNumber.xyFlag == 1)
			{
				switch (StoreNumber.calculationType)
				{
					case 0: //addition
						DisplayCalculation = StoreNumber.x.ToString()+ " + " + StoreNumber.y.ToString();
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
		}

		public StoreNumber StoreNumber { get;}

		

		public CalculatorViewModel () 
		{
			
			StoreNumber = new StoreNumber();

			StoreFunction = new StoreFunctionCommand();

			CalculationFunction = new CalculationCommand(this);
		}


		private string displayCalculation;

		public string DisplayCalculation
		{
			get { return displayCalculation; }
			set 
			{ 
				displayCalculation = value;
				displayCalculation = StoreNumber.calculationDisplay;
				OnPropertyChanged();
			}
		}

	}
}
