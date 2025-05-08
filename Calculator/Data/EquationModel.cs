using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data
{
    internal class EquationModel
    {
        private int id;
        private string equation = null!;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Equation
        {
            get { return equation; }
            set { equation = value; }
        }
    }
}
