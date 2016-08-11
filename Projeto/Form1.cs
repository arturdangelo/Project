using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class Form1 : Form
    {
        private MySqlConnection bdConn; //Conexão com o banco de dados
        private DataSet bdDataSet; //MySQL

        public Form1()
        {

            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;

            //Definição do dataset
            bdDataSet = new DataSet();
            //Define string de conexão
            bdConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=bdSystem;uid=root;pwd=''");

            //Abre conexão
            try
            {
                bdConn.Open();
                MessageBox.Show("Conexão aberta");
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
