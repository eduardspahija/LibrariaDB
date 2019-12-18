using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Libraria
{
    public partial class QueryForm : BaseForm
    {
        OracleConnection conn;
        public QueryForm()
        {
            
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            
            if (txtQuery.Text.Trim() == "")
            {
                MessageBox.Show("nuk keni shënuar select query Komandën!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = txtQuery.Text.Trim();                

                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    bindingSource1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.DataSource = bindingSource1;
                }
                else
                    MessageBox.Show("nuk ka të dhëna nga serveri!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            conn = CreateConnection();
        }
    }
}
