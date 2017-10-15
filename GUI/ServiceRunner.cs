using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ServiceRunnerForm : Form
    {

        private int _yaxes = 0;
        private int _xaxes = 0;

        public ServiceRunnerForm()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            if (serviceStatusLbl.Text.Equals("Service is stopped") || serviceStatusLbl.Text.Equals(""))
            {
                serviceStatusLbl.Text = "Service is running";
            }
            else
            {
                serviceStatusLbl.Text = "Service is stopped";
            }
        }

        private void ServiceRunnerForm_Load(object sender, EventArgs e)
        {
            CreateMoreLines(20);
        }

        private void GenerteBtn(TextBox tb)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CreateMoreLines(2);
        }

        private void CreateMoreLines(int numberOfBoxs)
        {
            for (int i = 0;i < numberOfBoxs; i++)
            {
                if (numberOfBoxs % 2 != 0)
                {
                    Button delete = new Button
                    {
                        Text = "X",
                        Size = new Size(30, 20),
                        Location = new Point(_xaxes + 180, _yaxes)
                    };
                    MainPanel.Controls.Add(delete);
                }
                Button b = new Button
                {
                    Text = "...",
                    Size = new Size(30, 20),
                    Location = new Point(_xaxes + 150, _yaxes)
                };
                TextBox tb = new TextBox
                {
                    Text = numberOfBoxs + "",
                    Size = new Size(150, 10),
                    Location = new Point(_xaxes, _yaxes)
                };
                _xaxes = (_xaxes == 210 ? 0 : 210);

                _yaxes += (_xaxes == 0 ? 25 : 0);
                MainPanel.Controls.Add(tb);
                MainPanel.Controls.Add(b);
                this.Controls.Add(MainPanel);
            }
        }
    }
}
