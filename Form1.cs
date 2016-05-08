using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDocBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nouveauDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox4.Text=System.DateTime.Now.ToString();
            richTextBox2.Text="";
            richTextBox1.Text="";
            richTextBox3.Text="";
            groupBox1.Visible = true;
            
        }

        private void afficheMesDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

           Form2 fm2 = new Form2();
           fm2.ShowDialog();
            
        }

        private void enregistrerLeDocDansLaBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                string id = richTextBox1.Text;
                string Proprietaire = richTextBox2.Text;
            string dd = richTextBox4.Text;
            string txtdoc = richTextBox3.Text;

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gestionDocBD.accdb;Persist Security Info=False;";
            string req = "insert into DOC(ID,TexteDoc,DateCreation,Proprietaire) values('" + id + "','" + txtdoc + "','" + System.DateTime.Now + "','" + Proprietaire + "');";
            MessageBox.Show(req);
            OleDbCommand cmd = new OleDbCommand(req, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
        
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
        }

 


       
    }

