using System;
using System.Windows.Forms;
using System.Drawing;

namespace lambda_discards
{
    class MyForm : Form
    {
        private FlowLayoutPanel flowPanel;

        public MyForm()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            Text = "Quit button";
            ClientSize = new Size(800, 450);

            flowPanel = new FlowLayoutPanel();

            flowPanel.Dock = DockStyle.Fill;
            flowPanel.BorderStyle = BorderStyle.FixedSingle;

            var button = new Button();
            button.Margin = new Padding(10, 10, 0, 0);

            button.Text = "Quit";
            button.AutoSize = true;
            button.Click += (_, _) => Close();

            flowPanel.Controls.Add(button);
            Controls.Add(flowPanel);

            CenterToScreen();
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new MyForm());
        }
    }
}