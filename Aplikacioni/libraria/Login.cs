using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Libraria
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (OracleConnection conn = CreateConnection())
            {
                OracleCommand cmd = new OracleCommand("SELECT * from puntoret", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables[0].DefaultView.Count == 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    string lblUserName = txtUserName.Text.Trim().ToLower();
                    string lblPassword = txtPasword.Text.Trim();
                    cmd = new OracleCommand("SELECT * from puntoret where lower(userName) = '" + lblUserName + "' and fjalekalimi = '" + lblPassword + "'", conn);
                    oda = new OracleDataAdapter(cmd);
                    ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables[0].DefaultView.Count == 0)
                    {
                        MessageBox.Show("UserName " + lblUserName + " nuk ekziston ose passwordi gabim!" + System.Environment.NewLine +
                                 "Provoni përsëri!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int userId = Convert.ToInt32(ds.Tables[0].DefaultView[0][0]);
                        string userName = ds.Tables[0].DefaultView[0][3].ToString();
                        UserInfo userinfo = new UserInfo(userId, userName);
                        GlobalInfo.CurrentUser = userinfo;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
