using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.View
{
    public partial class CalculatorView : Form, ICalculatorView
    {
        public CalculatorView()
        {
            InitializeComponent();
            AssociateEvents();
        }
        private void AssociateEvents()
        {
            buttonZero.Click += (s, e) => KeyEvent?.Invoke(this, "0");
            buttonOne.Click += (s, e) => KeyEvent?.Invoke(this, "1");
            buttonTwo.Click += (s, e) => KeyEvent?.Invoke(this, "2");
            buttonThree.Click += (s, e) => KeyEvent?.Invoke(this, "3");
            buttonFour.Click += (s, e) => KeyEvent?.Invoke(this, "4");
            buttonFive.Click += (s, e) => KeyEvent?.Invoke(this, "5");
            buttonSix.Click += (s, e) => KeyEvent?.Invoke(this, "6");
            buttonSeven.Click += (s, e) => KeyEvent?.Invoke(this, "7");
            buttonEight.Click += (s, e) => KeyEvent?.Invoke(this, "8");
            buttonNine.Click += (s, e) => KeyEvent?.Invoke(this, "9");

            buttonLeftBracket.Click += (s, e) => KeyEvent?.Invoke(this, "(");
            buttonRightBracket.Click += (s, e) => KeyEvent?.Invoke(this, ")");
            buttonPoint.Click += (s, e) => KeyEvent?.Invoke(this, ".");

            buttonAdd.Click += (s, e) => KeyEvent?.Invoke(this, "+");
            buttonSubtract.Click += (s, e) => KeyEvent?.Invoke(this, "-");
            buttonMultiply.Click += (s, e) => KeyEvent?.Invoke(this, "*");
            buttonDivide.Click += (s, e) => KeyEvent?.Invoke(this, "/");
            buttonModulo.Click += (s, e) => KeyEvent?.Invoke(this, "%");

            buttonEqual.Click += (s, e) => EqualEvent?.Invoke(this, EventArgs.Empty);

            buttonClear.Click += (s, e) => ClearEvent?.Invoke(this, EventArgs.Empty);
            buttonDelete.Click += (s, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);

            calculateFromAFileToolStripMenuItem.Click += (s, e) => CalculateFromAFileEvent?.Invoke(this, EventArgs.Empty);
            exportToAFileToolStripMenuItem.Click += (s, e) => ExportToAFileEvent?.Invoke(this, EventArgs.Empty);
            deleteSelectedRowsToolStripMenuItem.Click += (s, e) => DeleteSelectedRowsEvent?.Invoke(this, EventArgs.Empty);

            historyTabPage.Enter += (s, e) => OpenHistoryEvent?.Invoke(this, EventArgs.Empty);
        }

        public string Display
        {
            get => textBoxDisplay.Text;
            set => textBoxDisplay.Text = value;
        }

        public DataGridViewSelectedRowCollection SelectedRows
        {
            get => dataGridView.SelectedRows;
        }

        public event EventHandler<string>? KeyEvent;
        public event EventHandler? EqualEvent;
        public event EventHandler? ClearEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? CalculateFromAFileEvent;
        public event EventHandler? ExportToAFileEvent;
        public event EventHandler? DeleteSelectedRowsEvent;
        public event EventHandler? OpenHistoryEvent;

        public void SetEquationBindingSource(BindingSource equationList)
        {
            dataGridView.DataSource = equationList;
        }
    }
}
