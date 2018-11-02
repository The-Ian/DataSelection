using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

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

                SqlCommand work = new SqlCommand("select name from sys.tables");
                SqlDataAdapter data = new SqlDataAdapter(work);
                data.Fill(Vets,"name");
                DataTable table = Vets.Tables[0];
                

                listBox1.Items.Clear();
               
               foreach(DataTable tables in Vets.Tables)
                {
                    listBox1.Items.Add(table.TableName);
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
