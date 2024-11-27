using System.Windows.Input;
using Calculator.Commands;
namespace Calculator.ViewModels
{
    internal class CalculatorViewModel : ViewModelBase 
    {

		public RelayCommand StoreNumberCommand => new RelayCommand(param =>
		{
			if (StoreNumber.xyFlag == 0)
			{
				//StoreNumber_x(param);
				_relayCommandFunctions.StoreNumber_x(param);
				DisplayCalculation = StoreNumber.calculationDisplay;
			}
			else if (StoreNumber.xyFlag == 1)
			{
                _relayCommandFunctions.StoreNumber_y(param);
				DisplayCalculation = StoreNumber.calculationDisplay;
            }
		});


		public RelayCommand CalculateCommand => new RelayCommand(execute => DisplayCalculation = _relayCommandFunctions.CalculationCommand());




		public ICommand StoreFunction { get; set; }

		


		public StoreNumber StoreNumber { get;}

		private readonly RelayCommandFunctions _relayCommandFunctions;

		public CalculatorViewModel () 
		{
			
			StoreNumber = new StoreNumber();
			

			StoreFunction = new StoreFunctionCommand();

			

			_relayCommandFunctions = new RelayCommandFunctions();

		}


		private string displayCalculation;

		public string DisplayCalculation
		{
			get { return displayCalculation; }
			set 
			{ 
				displayCalculation = value;
				OnPropertyChanged();
			}
		}


       

    }
}
