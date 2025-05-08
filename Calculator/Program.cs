using Calculator.Presenter;
using Calculator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CalculatorView view = new CalculatorView();
            CalculatorPresenter presenter = new CalculatorPresenter(view);

            Application.Run(view);
        }
    }
}
