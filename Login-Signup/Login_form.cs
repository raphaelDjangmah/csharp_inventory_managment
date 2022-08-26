using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using MySql.Data.MySqlClient.Memcached;
using Org.BouncyCastle.Asn1.Crmf;
using System.IO;
using RestSharp;
using Google.Protobuf.WellKnownTypes;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Net;
using System.Web;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;

namespace Inventory_mgmt
{
    public partial class Login_form : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Login_form()
        {
            InitializeComponent();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup_form signup = new Signup_form();
            signup.Show();
            Hide();
        }
    }
}
