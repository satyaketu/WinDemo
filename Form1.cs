using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string text = listCity.GetItemText(listCity.SelectedItem);
            //MessageBox.Show(text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string listtext = listCity.GetItemText(listCity.SelectedItem);         
            MessageBox.Show(name + address + listtext);
        }
    }
}
