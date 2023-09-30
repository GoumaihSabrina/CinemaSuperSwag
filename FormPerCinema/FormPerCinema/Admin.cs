using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPerCinema
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;

            dt.Columns.Add("FILM");
            dt.Columns.Add("ORA");
            dt.Columns.Add("PREZZO");
            dt.Columns.Add("TIPO");

            for (int i = 0; i < 30; i++)
                dt.Rows.Add();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
