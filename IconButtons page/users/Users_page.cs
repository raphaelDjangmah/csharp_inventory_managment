using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace Inventory_mgmt
{
    public partial class Users_page : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Users_page()
        {
            InitializeComponent();


            UsersTable.EnableHeadersVisualStyles = false;
            UsersTable.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            UsersTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have clicked");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void UsersTable_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void UsersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

