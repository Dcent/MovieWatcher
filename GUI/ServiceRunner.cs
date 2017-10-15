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
            int x = 0;
            int y = 0;
            for (int i = 0; i < 20; i++)
            {
                Button b = new Button
                {
                    Text = "...",
                    Size = new Size(30,20),
                    Location = new Point(x +150,y)
                    
                };
                TextBox tb = new TextBox
                {
                    Text = i +"",
                    Size = new Size(150, 10),
                    Location = new Point( x, y)
                };
                x = (x == 210 ? 0 : 210);
                
                y += (x == 0 ? 25 : 0);
                MainPanel.Controls.Add(tb);
                MainPanel.Controls.Add(b);
                this.Controls.Add(MainPanel);
            }
        }

        private void GenerteBtn(TextBox tb)
        {
            
        }
    }
}
