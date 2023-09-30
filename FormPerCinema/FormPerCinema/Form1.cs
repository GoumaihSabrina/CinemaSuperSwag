using System.Data;

namespace FormPerCinema
{
    public partial class Form1 : Form
    {


        public Form1()
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
        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("FILM");
            dt.Columns.Add("SALA");
            dt.Columns.Add("ORE");
            dt.Rows.Add("ciao");
            MessageBox.Show("PIPO");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.ShowDialog();
        }
    }
}