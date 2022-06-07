using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Base");
            dt.Columns.Add("Altura");
            dt.Columns.Add("Area");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double areaT = Convert.ToDouble(txtBase.Text) * Convert.ToDouble(txtAltura.Text) / 2;

                dt.Rows.Add(txtBase.Text, txtAltura.Text, areaT);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
