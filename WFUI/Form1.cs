using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUI
{
    public partial class Form1 : Form
    {
        WF.BLL.BusinessLogicLayer BLL;

        public Form1()
        {
            InitializeComponent();
            BLL = new WF.BLL.BusinessLogicLayer();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result = BLL.UserControl(txtName.Text, txtPassword.Text);
            if(result> 0) 
            {
                Main main = new Main();
                main.Show();

            }
            else if (result == -100)
            {
                
                MessageBox.Show("You have entered incomplete information !");
            }
            else
            {
                MessageBox.Show("Incorrect user");
            }
        }

    }
}
