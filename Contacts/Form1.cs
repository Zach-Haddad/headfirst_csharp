using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactsDataSet.People);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact list written by Zach Haddad", "About");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDataSet);

        }

        private void client_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
