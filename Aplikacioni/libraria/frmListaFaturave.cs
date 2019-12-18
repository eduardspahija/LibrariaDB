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
    public partial class frmListaFaturave : BaseForm
    {
        OracleConnection conn;
        public frmListaFaturave()
        {
            InitializeComponent();
        }

        private void frmListaFaturave_Load(object sender, EventArgs e)
        {
            conn = CreateConnection();


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToAddRows = false;

            foreach (DataGridViewColumn gridColumn in dataGridView1.Columns)
            {
                if (gridColumn.Name == "ColumnVlera")
                {
                    gridColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Format = "N2";
                }
            }


            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = true;
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView2.AllowUserToAddRows = false;

            foreach (DataGridViewColumn gridColumn in dataGridView2.Columns)
            {
                if (gridColumn.Name == "ColumnSasia" || gridColumn.Name == "ColumnQmimi")
                {
                    gridColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Format = gridColumn.Name == "ColumnSasia" ? "N0" : "N2";
                }
            }


            string sdata1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sdata2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            bool bsipasDatave = chkKerkoSipas.Checked;

            LoadData(bsipasDatave, conn, sdata1, sdata2);

        }


        private void LoadData(bool bsipasDatave, OracleConnection conn1, string data1, string data2)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn1;
            cmd.CommandType = CommandType.Text;



            if (bsipasDatave == true)
                cmd.CommandText = "SELECT f.faturaID, f.data_fatures, " +
                "CASE FATURA_LLOJI WHEN 'H' THEN 'FATURË HYRËSE' WHEN 'D' THEN 'FATURË DALËSE' END FATURA_LLOJI, " +
                "concat(concat(p.emri.emri, ' '), p.emri.mbiemri) as KlientiEmri, " +
                "concat(concat(p1.emri.emri, ' '), p1.emri.mbiemri) as PuntoriEmri, " +
                "vf.vlera from fatura f inner join personat p on f.KLIENTIID = p.PERSONID " +
                "inner join personat p1 on f.PUNTORIID = p1.PERSONID inner join VW_VLERAFATURES vf on vf.FATURAID = f.FATURAID " +
                "where f.data_fatures between date '" + data1 + "' and date '" + data2 + "' order by f.faturaId";
            else
                cmd.CommandText = "SELECT f.faturaID, f.data_fatures, " +
                            "CASE FATURA_LLOJI WHEN 'H' THEN 'FATURË HYRËSE' WHEN 'D' THEN 'FATURË DALËSE' END FATURA_LLOJI, " +
                            "concat(concat(p.emri.emri, ' '), p.emri.mbiemri) as KlientiEmri, " +
                            "concat(concat(p1.emri.emri, ' '), p1.emri.mbiemri) as PuntoriEmri, " +
                            "vf.vlera from fatura f inner join personat p on f.KLIENTIID = p.PERSONID " +
                            "inner join personat p1 on f.PUNTORIID = p1.PERSONID inner join VW_VLERAFATURES vf on vf.FATURAID = f.FATURAID " +
                            "order by f.faturaId";

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                bindingSource1.DataSource = ds.Tables[0].DefaultView;
                dataGridView1.DataSource = bindingSource1;
            }
        }


        private void LoadData1(OracleConnection conn1, int faturaId)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn1;
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "SELECT l.barkodi, l.titulli, " +
            "fd.sasia, fd.qmimi from fatura_detajet fd inner join libri l " +
            "on fd.libriID = l.libriID " +
            "where fd.faturaID = '" + faturaId.ToString() + "'";


            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                bindingSource2.DataSource = ds.Tables[0].DefaultView;
                dataGridView2.DataSource = bindingSource2;
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

            if (bindingSource1.Count != 0)
            {
                DataRow row = ((DataRowView)bindingSource1.Current).Row;

                int nfaturaID = Convert.ToInt32(row["faturaId"]);

                LoadData1(conn, nfaturaID);
            }
            else
            {
                int nfaturaID = 0;

                LoadData1(conn, nfaturaID);
            }

        }

        private void btnFiltroFaturat_Click(object sender, EventArgs e)
        {
            string sdata1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sdata2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            bool bsipasDatave = chkKerkoSipas.Checked;
            LoadData(bsipasDatave, conn, sdata1, sdata2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaFaturave_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
