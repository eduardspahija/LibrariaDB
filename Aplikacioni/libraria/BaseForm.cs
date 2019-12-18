using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Libraria
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                //SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }
        public OracleConnection CreateConnection()
        {           
            string ConString = "Data source=localhost:1521/FIEKDB;User Id=libraria;Password=123456";
            OracleConnection conn = new OracleConnection(ConString);                       
            return conn;
        }

        protected bool ValidateEmail(string sEmail)
        {
            bool bStatus = true;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(sEmail);
            if (!match.Success)
                bStatus = false;
            return bStatus;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

    }
}
