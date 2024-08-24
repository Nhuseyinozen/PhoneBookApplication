using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF.BLL;
using WF.Entities;

namespace WFUI
{
    public partial class Main : Form
    {
        WF.BLL.BusinessLogicLayer BLL;

        public Main()
        {
            InitializeComponent();
            BLL = new WF.BLL.BusinessLogicLayer();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Transfer();
        }

        private void BtnNewRecord_Click(object sender, EventArgs e)
        {
            int result = BLL.NewRecord(Guid.NewGuid(), TxtName.Text, TxtSurname.Text, TxtPhone1.Text, TxtPhone2.Text,
                 TxtPhone3.Text, TxtEmail.Text, TxtAddress.Text, TxtWebsite.Text, TxtExplanation.Text);

            if (result > 0)
            {
                MessageBox.Show("Registration Successful");
                Transfer(); //Kayıt eklendiğinde listeye aktarıyoruz.
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


        public void Transfer()
        {
            List<ContactRecord> records = BLL.Bringcontactrecords();

            if (records != null && records.Count > 0)
            {
                LstList.DataSource = records;
            }
        }

        private void LstList_DoubleClick(object sender, EventArgs e)
        {

            ListBox L = (ListBox)sender;
            ContactRecord SelectecValue = (ContactRecord)L.SelectedItem;

            TxtName.Text = SelectecValue.Name;
            TxtSurname.Text = SelectecValue.Surname;
            TxtPhone1.Text = SelectecValue.Phone1;
            TxtPhone2.Text = SelectecValue.Phone2;
            TxtPhone3.Text = SelectecValue.Phone3;
            TxtWebsite.Text = SelectecValue.WebAddress;
            TxtAddress.Text = SelectecValue.Address;
            TxtEmail.Text = SelectecValue.Email;
            TxtExplanation.Text = SelectecValue.Explanation;
            GroupRecord.Text = "Update In Progress";
            GroupRecord.ForeColor = Color.Red;


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (LstList.SelectedItems != null)
            {
                ContactRecord CR = (ContactRecord)LstList.SelectedItem;

                int result = BLL.RecordUpdate(CR.ID, TxtName.Text, TxtSurname.Text, TxtPhone1.Text, TxtPhone2.Text, TxtPhone3.Text,
                     TxtEmail.Text, TxtAddress.Text, TxtWebsite.Text, TxtExplanation.Text);

                if (result > 0)
                {
                    MessageBox.Show("Update Successful");
                    Transfer();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Guid DeleteId = ((ContactRecord)LstList.SelectedItem).ID;
            int result = BLL.DeleteRecord(DeleteId);
            if (result > 0)
            {
                MessageBox.Show("Deletion Successful !");
                Transfer();

            }
            else
            {
                MessageBox.Show("Could not delete value !");
            }
        }

        private void BtnSentXML_Click(object sender, EventArgs e)
        {
            int result = BLL.XMLSent();

            if (result > 0)
            {
                LblStatus.Text = "Statu : \"XML\" Generation successful";

            }
            else
            {
                LblStatus.Text = "Statu : Generation of \"XML\" failed";
            }

        }

        private void BtnSentCSV_Click(object sender, EventArgs e)
        {
            int result = BLL.CSVSent();

            if (result > 0)
            {
                LblStatus.Text = "Statu : \"CSV\" Generation successful";

            }
            else
            {
                LblStatus.Text = "Statu : Generation of \"CSV\" failed";
            }
        }

        private void BtnJsonSent_Click(object sender, EventArgs e)
        {
            int result = BLL.JsonSent();

            if (result > 0)
            {
                LblStatus.Text = "Statu : \"Json\" Generation successful";

            }
            else
            {
                LblStatus.Text = "Statu : Generation of \"Json\" failed";
            }
        }
    }
}
