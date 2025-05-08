namespace Calculator.View
{
    partial class CalculatorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            calculateFromAFileToolStripMenuItem = new ToolStripMenuItem();
            exportToAFileToolStripMenuItem = new ToolStripMenuItem();
            calculatorTableLayoutPanel = new TableLayoutPanel();
            buttonZero = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonPoint = new Button();
            buttonLeftBracket = new Button();
            buttonRightBracket = new Button();
            buttonEqual = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonModulo = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            textBoxDisplay = new TextBox();
            tabControl = new TabControl();
            calculatorTabPage = new TabPage();
            historyTabPage = new TabPage();
            deleteSelectedRowsToolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            menuStrip.SuspendLayout();
            calculatorTableLayoutPanel.SuspendLayout();
            tabControl.SuspendLayout();
            calculatorTabPage.SuspendLayout();
            historyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.MenuBar;
            menuStrip.Dock = DockStyle.Left;
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { toolsToolStripMenuItem });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.RightToLeft = RightToLeft.No;
            menuStrip.Size = new Size(54, 683);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            menuStrip.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculateFromAFileToolStripMenuItem, exportToAFileToolStripMenuItem, deleteSelectedRowsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(41, 64);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculateFromAFileToolStripMenuItem
            // 
            calculateFromAFileToolStripMenuItem.Name = "calculateFromAFileToolStripMenuItem";
            calculateFromAFileToolStripMenuItem.Size = new Size(329, 40);
            calculateFromAFileToolStripMenuItem.Text = "Calculate from a File";
            // 
            // exportToAFileToolStripMenuItem
            // 
            exportToAFileToolStripMenuItem.Name = "exportToAFileToolStripMenuItem";
            exportToAFileToolStripMenuItem.Size = new Size(329, 40);
            exportToAFileToolStripMenuItem.Text = "Export to a File";
            // 
            // calculatorTableLayoutPanel
            // 
            calculatorTableLayoutPanel.BackColor = Color.Transparent;
            calculatorTableLayoutPanel.ColumnCount = 5;
            calculatorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            calculatorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            calculatorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            calculatorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            calculatorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            calculatorTableLayoutPanel.Controls.Add(buttonZero, 0, 5);
            calculatorTableLayoutPanel.Controls.Add(buttonOne, 0, 4);
            calculatorTableLayoutPanel.Controls.Add(buttonTwo, 2, 4);
            calculatorTableLayoutPanel.Controls.Add(buttonThree, 3, 4);
            calculatorTableLayoutPanel.Controls.Add(buttonFour, 0, 3);
            calculatorTableLayoutPanel.Controls.Add(buttonFive, 2, 3);
            calculatorTableLayoutPanel.Controls.Add(buttonSix, 3, 3);
            calculatorTableLayoutPanel.Controls.Add(buttonSeven, 0, 2);
            calculatorTableLayoutPanel.Controls.Add(buttonEight, 2, 2);
            calculatorTableLayoutPanel.Controls.Add(buttonNine, 3, 2);
            calculatorTableLayoutPanel.Controls.Add(buttonPoint, 2, 5);
            calculatorTableLayoutPanel.Controls.Add(buttonLeftBracket, 0, 1);
            calculatorTableLayoutPanel.Controls.Add(buttonRightBracket, 1, 1);
            calculatorTableLayoutPanel.Controls.Add(buttonEqual, 3, 5);
            calculatorTableLayoutPanel.Controls.Add(buttonAdd, 4, 5);
            calculatorTableLayoutPanel.Controls.Add(buttonSubtract, 4, 4);
            calculatorTableLayoutPanel.Controls.Add(buttonMultiply, 4, 3);
            calculatorTableLayoutPanel.Controls.Add(buttonDivide, 4, 2);
            calculatorTableLayoutPanel.Controls.Add(buttonModulo, 4, 1);
            calculatorTableLayoutPanel.Controls.Add(buttonClear, 2, 1);
            calculatorTableLayoutPanel.Controls.Add(buttonDelete, 3, 1);
            calculatorTableLayoutPanel.Controls.Add(textBoxDisplay, 0, 0);
            calculatorTableLayoutPanel.Dock = DockStyle.Fill;
            calculatorTableLayoutPanel.Location = new Point(3, 3);
            calculatorTableLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            calculatorTableLayoutPanel.Name = "calculatorTableLayoutPanel";
            calculatorTableLayoutPanel.RowCount = 6;
            calculatorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calculatorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calculatorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calculatorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calculatorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calculatorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            calculatorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            calculatorTableLayoutPanel.Size = new Size(646, 634);
            calculatorTableLayoutPanel.TabIndex = 1;
            // 
            // buttonZero
            // 
            buttonZero.BackColor = SystemColors.ControlLightLight;
            calculatorTableLayoutPanel.SetColumnSpan(buttonZero, 2);
            buttonZero.Dock = DockStyle.Fill;
            buttonZero.FlatAppearance.BorderSize = 0;
            buttonZero.FlatStyle = FlatStyle.Flat;
            buttonZero.Location = new Point(4, 527);
            buttonZero.Margin = new Padding(4, 2, 4, 2);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(152, 105);
            buttonZero.TabIndex = 0;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = SystemColors.ControlLightLight;
            calculatorTableLayoutPanel.SetColumnSpan(buttonOne, 2);
            buttonOne.Dock = DockStyle.Fill;
            buttonOne.FlatAppearance.BorderSize = 0;
            buttonOne.FlatStyle = FlatStyle.Flat;
            buttonOne.Location = new Point(4, 422);
            buttonOne.Margin = new Padding(4, 2, 4, 2);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(152, 101);
            buttonOne.TabIndex = 1;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = SystemColors.ControlLightLight;
            buttonTwo.Dock = DockStyle.Fill;
            buttonTwo.FlatAppearance.BorderSize = 0;
            buttonTwo.FlatStyle = FlatStyle.Flat;
            buttonTwo.Location = new Point(164, 422);
            buttonTwo.Margin = new Padding(4, 2, 4, 2);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(153, 101);
            buttonTwo.TabIndex = 2;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            // 
            // buttonThree
            // 
            buttonThree.BackColor = SystemColors.ControlLightLight;
            buttonThree.Dock = DockStyle.Fill;
            buttonThree.FlatAppearance.BorderSize = 0;
            buttonThree.FlatStyle = FlatStyle.Flat;
            buttonThree.Location = new Point(325, 422);
            buttonThree.Margin = new Padding(4, 2, 4, 2);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(153, 101);
            buttonThree.TabIndex = 3;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            // 
            // buttonFour
            // 
            buttonFour.BackColor = SystemColors.ControlLightLight;
            calculatorTableLayoutPanel.SetColumnSpan(buttonFour, 2);
            buttonFour.Dock = DockStyle.Fill;
            buttonFour.FlatAppearance.BorderSize = 0;
            buttonFour.FlatStyle = FlatStyle.Flat;
            buttonFour.Location = new Point(4, 317);
            buttonFour.Margin = new Padding(4, 2, 4, 2);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(152, 101);
            buttonFour.TabIndex = 4;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            // 
            // buttonFive
            // 
            buttonFive.BackColor = SystemColors.ControlLightLight;
            buttonFive.Dock = DockStyle.Fill;
            buttonFive.FlatAppearance.BorderSize = 0;
            buttonFive.FlatStyle = FlatStyle.Flat;
            buttonFive.Location = new Point(164, 317);
            buttonFive.Margin = new Padding(4, 2, 4, 2);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(153, 101);
            buttonFive.TabIndex = 5;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            // 
            // buttonSix
            // 
            buttonSix.BackColor = SystemColors.ControlLightLight;
            buttonSix.Dock = DockStyle.Fill;
            buttonSix.FlatAppearance.BorderSize = 0;
            buttonSix.FlatStyle = FlatStyle.Flat;
            buttonSix.Location = new Point(325, 317);
            buttonSix.Margin = new Padding(4, 2, 4, 2);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(153, 101);
            buttonSix.TabIndex = 6;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = SystemColors.ControlLightLight;
            calculatorTableLayoutPanel.SetColumnSpan(buttonSeven, 2);
            buttonSeven.Dock = DockStyle.Fill;
            buttonSeven.FlatAppearance.BorderSize = 0;
            buttonSeven.FlatStyle = FlatStyle.Flat;
            buttonSeven.Location = new Point(4, 212);
            buttonSeven.Margin = new Padding(4, 2, 4, 2);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(152, 101);
            buttonSeven.TabIndex = 7;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            // 
            // buttonEight
            // 
            buttonEight.BackColor = SystemColors.ControlLightLight;
            buttonEight.Dock = DockStyle.Fill;
            buttonEight.FlatAppearance.BorderSize = 0;
            buttonEight.FlatStyle = FlatStyle.Flat;
            buttonEight.Location = new Point(164, 212);
            buttonEight.Margin = new Padding(4, 2, 4, 2);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(153, 101);
            buttonEight.TabIndex = 8;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            // 
            // buttonNine
            // 
            buttonNine.BackColor = SystemColors.ControlLightLight;
            buttonNine.Dock = DockStyle.Fill;
            buttonNine.FlatAppearance.BorderSize = 0;
            buttonNine.FlatStyle = FlatStyle.Flat;
            buttonNine.Location = new Point(325, 212);
            buttonNine.Margin = new Padding(4, 2, 4, 2);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(153, 101);
            buttonNine.TabIndex = 9;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            // 
            // buttonPoint
            // 
            buttonPoint.BackColor = SystemColors.Window;
            buttonPoint.Dock = DockStyle.Fill;
            buttonPoint.FlatAppearance.BorderSize = 0;
            buttonPoint.FlatStyle = FlatStyle.Flat;
            buttonPoint.Location = new Point(164, 527);
            buttonPoint.Margin = new Padding(4, 2, 4, 2);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(153, 105);
            buttonPoint.TabIndex = 10;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = false;
            // 
            // buttonLeftBracket
            // 
            buttonLeftBracket.BackColor = SystemColors.Window;
            buttonLeftBracket.Dock = DockStyle.Fill;
            buttonLeftBracket.FlatAppearance.BorderSize = 0;
            buttonLeftBracket.FlatStyle = FlatStyle.Flat;
            buttonLeftBracket.Location = new Point(4, 107);
            buttonLeftBracket.Margin = new Padding(4, 2, 4, 2);
            buttonLeftBracket.Name = "buttonLeftBracket";
            buttonLeftBracket.Size = new Size(72, 101);
            buttonLeftBracket.TabIndex = 11;
            buttonLeftBracket.Text = "(";
            buttonLeftBracket.UseVisualStyleBackColor = false;
            // 
            // buttonRightBracket
            // 
            buttonRightBracket.BackColor = SystemColors.Window;
            buttonRightBracket.Dock = DockStyle.Fill;
            buttonRightBracket.FlatAppearance.BorderSize = 0;
            buttonRightBracket.FlatStyle = FlatStyle.Flat;
            buttonRightBracket.Location = new Point(84, 107);
            buttonRightBracket.Margin = new Padding(4, 2, 4, 2);
            buttonRightBracket.Name = "buttonRightBracket";
            buttonRightBracket.Size = new Size(72, 101);
            buttonRightBracket.TabIndex = 12;
            buttonRightBracket.Text = ")";
            buttonRightBracket.UseVisualStyleBackColor = false;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.Window;
            buttonEqual.Dock = DockStyle.Fill;
            buttonEqual.FlatAppearance.BorderSize = 0;
            buttonEqual.FlatStyle = FlatStyle.Flat;
            buttonEqual.Location = new Point(325, 527);
            buttonEqual.Margin = new Padding(4, 2, 4, 2);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(153, 105);
            buttonEqual.TabIndex = 13;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.Window;
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(486, 527);
            buttonAdd.Margin = new Padding(4, 2, 4, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(156, 105);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = SystemColors.Window;
            buttonSubtract.Dock = DockStyle.Fill;
            buttonSubtract.FlatAppearance.BorderSize = 0;
            buttonSubtract.FlatStyle = FlatStyle.Flat;
            buttonSubtract.Location = new Point(486, 422);
            buttonSubtract.Margin = new Padding(4, 2, 4, 2);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(156, 101);
            buttonSubtract.TabIndex = 15;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.Window;
            buttonMultiply.Dock = DockStyle.Fill;
            buttonMultiply.FlatAppearance.BorderSize = 0;
            buttonMultiply.FlatStyle = FlatStyle.Flat;
            buttonMultiply.Location = new Point(486, 317);
            buttonMultiply.Margin = new Padding(4, 2, 4, 2);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(156, 101);
            buttonMultiply.TabIndex = 16;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = false;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.Window;
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.FlatAppearance.BorderSize = 0;
            buttonDivide.FlatStyle = FlatStyle.Flat;
            buttonDivide.Location = new Point(486, 212);
            buttonDivide.Margin = new Padding(4, 2, 4, 2);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(156, 101);
            buttonDivide.TabIndex = 17;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            // 
            // buttonModulo
            // 
            buttonModulo.BackColor = SystemColors.Window;
            buttonModulo.Dock = DockStyle.Fill;
            buttonModulo.FlatAppearance.BorderSize = 0;
            buttonModulo.FlatStyle = FlatStyle.Flat;
            buttonModulo.Location = new Point(486, 107);
            buttonModulo.Margin = new Padding(4, 2, 4, 2);
            buttonModulo.Name = "buttonModulo";
            buttonModulo.Size = new Size(156, 101);
            buttonModulo.TabIndex = 18;
            buttonModulo.Text = "%";
            buttonModulo.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.Window;
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Location = new Point(164, 107);
            buttonClear.Margin = new Padding(4, 2, 4, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(153, 101);
            buttonClear.TabIndex = 19;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Window;
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(325, 107);
            buttonDelete.Margin = new Padding(4, 2, 4, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(153, 101);
            buttonDelete.TabIndex = 20;
            buttonDelete.Text = "D";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.BackColor = SystemColors.Window;
            textBoxDisplay.BorderStyle = BorderStyle.None;
            calculatorTableLayoutPanel.SetColumnSpan(textBoxDisplay, 5);
            textBoxDisplay.Dock = DockStyle.Fill;
            textBoxDisplay.Font = new Font("Segoe UI", 19.875F);
            textBoxDisplay.Location = new Point(4, 2);
            textBoxDisplay.Margin = new Padding(4, 2, 4, 2);
            textBoxDisplay.Multiline = true;
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.Size = new Size(638, 101);
            textBoxDisplay.TabIndex = 21;
            textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(calculatorTabPage);
            tabControl.Controls.Add(historyTabPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(54, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(660, 683);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 2;
            // 
            // calculatorTabPage
            // 
            calculatorTabPage.Controls.Add(calculatorTableLayoutPanel);
            calculatorTabPage.Location = new Point(4, 39);
            calculatorTabPage.Name = "calculatorTabPage";
            calculatorTabPage.Padding = new Padding(3);
            calculatorTabPage.Size = new Size(652, 640);
            calculatorTabPage.TabIndex = 0;
            calculatorTabPage.Text = "Calculator";
            calculatorTabPage.UseVisualStyleBackColor = true;
            // 
            // historyTabPage
            // 
            historyTabPage.Controls.Add(dataGridView);
            historyTabPage.Location = new Point(4, 39);
            historyTabPage.Name = "historyTabPage";
            historyTabPage.Padding = new Padding(3);
            historyTabPage.Size = new Size(652, 640);
            historyTabPage.TabIndex = 1;
            historyTabPage.Text = "History";
            historyTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedRowsToolStripMenuItem
            // 
            deleteSelectedRowsToolStripMenuItem.Name = "deleteSelectedRowsToolStripMenuItem";
            deleteSelectedRowsToolStripMenuItem.Size = new Size(329, 40);
            deleteSelectedRowsToolStripMenuItem.Text = "Delete Selected Rows";
            // 
            // dataGridView
            // 
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 72;
            dataGridView.Size = new Size(646, 634);
            dataGridView.TabIndex = 3;
            // 
            // CalculatorView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 683);
            Controls.Add(tabControl);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 2, 4, 2);
            MinimumSize = new Size(340, 556);
            Name = "CalculatorView";
            Text = "Caluclator";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            calculatorTableLayoutPanel.ResumeLayout(false);
            calculatorTableLayoutPanel.PerformLayout();
            tabControl.ResumeLayout(false);
            calculatorTabPage.ResumeLayout(false);
            historyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem calculateFromAFileToolStripMenuItem;
        private TableLayoutPanel calculatorTableLayoutPanel;
        private Button buttonZero;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonPoint;
        private Button buttonLeftBracket;
        private Button buttonRightBracket;
        private Button buttonEqual;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonModulo;
        private Button buttonClear;
        private Button buttonDelete;
        private TextBox textBoxDisplay;
        private TabControl tabControl;
        private TabPage calculatorTabPage;
        private TabPage historyTabPage;
        private ToolStripMenuItem exportToAFileToolStripMenuItem;
        private ToolStripMenuItem deleteSelectedRowsToolStripMenuItem;
        private DataGridView dataGridView;
    }
}