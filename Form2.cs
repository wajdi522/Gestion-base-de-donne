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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gestionDocBD.accdb;Persist Security Info=False;";
            string req = "select * from DOC";
            OleDbCommand cmd = new OleDbCommand(req, con);
            con.Open();
           OleDbDataReader res = cmd.ExecuteReader();
            for(int i=0;i<res.FieldCount;i++)
            {
                dataGridView1.Columns.Add(res.GetName(i), res.GetName(i));
            }
            while(res.Read())
            {
                dataGridView1.Rows.Add(res["id"], res[1], res[2], res[3]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gestionDocBD.accdb;Persist Security Info=False;";
            string req = "delete from DOC where ID='"+ dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+"';"  ;
            MessageBox.Show(req);
            OleDbCommand cmd = new OleDbCommand(req, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
                using (Form2 f = new Form2())
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        f.Refresh();
                   //   f.Update();
                    }
                } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gestionDocBD.accdb;Persist Security Info=False;";
            string req = "select * from DOC where Proprietaire='" + richTextBox1.SelectedText + "';";
            MessageBox.Show(req);
            OleDbCommand cmd = new OleDbCommand(req, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            using (Form2 f = new Form2())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    f.Refresh();
                    //   f.Update();
                }
            } 
        }

        }
    }

