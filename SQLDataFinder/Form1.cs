using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace SQLDataFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = txtHost.Text;
            builder.Encrypt = true;
            builder.TrustServerCertificate = true;
            if (txtDB.Text.Length > 0)
                builder.InitialCatalog = txtDB.Text;
            builder.PersistSecurityInfo = true;
            builder.UserID = txtUser.Text;
            builder.Password = txtPass.Text;
            return builder.ToString();
        }


        public List<string> GetDatabaseList()
        {
            List<string> list = new List<string>();
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    using (IDataReader dr = cmd.ExecuteReader())
                        while (dr.Read())
                            list.Add(dr[0].ToString());

                con.Close();
            }
            return list;

        }

        private void txtDB_DropDown(object sender, EventArgs e)
        {
            List<string> dblist = GetDatabaseList();
            foreach (string db in dblist)
                txtDB.Items.Add(db);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                List<string> tables = new List<string>();

                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG='"+txtDB.Text+"'", con))
                {                    
                    using (IDataReader dr = cmd.ExecuteReader())
                        while (dr.Read())
                            tables.Add("[" + (string)dr["TABLE_SCHEMA"] + "].[" + (string)dr["TABLE_NAME"] + "]");
                }

                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = tables.Count;
                foreach (string table in tables)
                {
                    toolStripProgressBar1.Value++;
                    lblTable.Text = table;
                    statusStrip1.Refresh();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM " + table, con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                            while (dr.Read())
                                try
                                {
                                    for (int i = 0; i < dr.FieldCount; i++)
                                        if (dr.GetValue(i).ToString().Contains(textBox1.Text))
                                        {
                                            ListViewItem lit = listView1.Items.Add(table);
                                            lit.SubItems.Add(dr.GetName(i).ToLower());
                                            lit.SubItems.Add(dr.GetValue(i).ToString());
                                        }
                                }
                                catch { }
                    }
                }



                con.Close();
            }
        }
    }
}