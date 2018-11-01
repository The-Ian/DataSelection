using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedItem.Equals("Veterinary"))
            {
                VeterinaryDataSet Vets = new VeterinaryDataSet();
                DataTable vetDT = new DataTable();
                vetDT = Vets.Billing; 

                listBox1.Items.Clear();
               
               foreach(DataTable tables in Vets.Tables)
                {
                    listBox1.Items.Add(Vets);
                }

                //listBox1.Items.Add(vetDT.Columns.ToString());
            }

            else if (comboBox1.SelectedItem.Equals("Northwind"))
            {

            }

            else if (comboBox1.SelectedItem.Equals("The Library"))
            {

            }

            else
            {

            }
        }
    }
}
