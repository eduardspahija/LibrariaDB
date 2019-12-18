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
    public partial class frmFatura : BaseForm
    {
        OracleConnection conn;
        string Lloji_fatures;
        public frmFatura(string lloji_fatures)
        {
            InitializeComponent();
            Lloji_fatures = lloji_fatures;
        }

        private void frmFaturaD_Load(object sender, EventArgs e)
        {
            if (Lloji_fatures == "H")
            {
                lblBleresi.Text = "Furnitori";
                this.Text = "Blerja - Faturat Hyrëse";
            }
            conn = CreateConnection();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select p.PersonId, concat(concat(p.emri.emri,' '), p.emri.mbiemri) as emrimbiemri from personat p";

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                cboBleresi.DataSource = ds.Tables[0].DefaultView;
                cboBleresi.DisplayMember = "EmriMbiemri";
                cboBleresi.ValueMember = "PersonId";
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToAddRows = false;


            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = true;
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


            foreach (DataGridViewColumn gridColumn in dataGridView1.Columns)
            {
                if (gridColumn.Name == "ColumnSasia" || gridColumn.Name == "ColumnQmimi")
                {
                    gridColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Format = gridColumn.Name == "ColumnSasia" ? "N0" : "N2";
                }
            }

            foreach (DataGridViewColumn gridColumn in dataGridView2.Columns)
            {
                if (gridColumn.Name == "ColumnSasia1" || gridColumn.Name == "ColumnQmimi1")
                {
                    gridColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridColumn.DefaultCellStyle.Format = gridColumn.Name == "ColumnSasia1"?"N0":"N2";
                }
            }


            cboMenyraPageses.DisplayMember = "Text";
            cboMenyraPageses.ValueMember = "Value";
            var itemsMenyraPag = new[] {
                new {Text = "CASH", Value = 1},
                new {Text = "Bankë", Value = 2},
                };
            cboMenyraPageses.DataSource = itemsMenyraPag;


            cboKerkimiSipas.DisplayMember = "Text";
            cboKerkimiSipas.ValueMember = "Value";
            var itemsKerkimi = new[] {
                new {Text = "Emrit", Value = 0},
                new {Text = "Mbiemrit", Value = 1},
                new {Text = "Emrit dhe Mbiemrit", Value = 2},
                new {Text = "Numrit Personal", Value = 3},
                new {Text = "Pozita", Value = 4},
                new {Text = "User Name", Value = 5 }
                };
            cboKerkimiSipas.DataSource = itemsKerkimi;

            LoadData(conn, !chkKerkoSipas.Checked, (int)cboKerkimiSipas.SelectedValue);
            LexoFaturen();
            LexoDetajetFatures();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLexoShenimet_Click(object sender, EventArgs e)
        {
            LoadData(conn, !chkKerkoSipas.Checked, (int)cboKerkimiSipas.SelectedValue);
        }

        private void LoadData(OracleConnection conn1, bool KrejtShenimet, int KerkimiSipas)
        {
            if (KrejtShenimet || txtKerkimi.Text.Trim() != "")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn1;
                cmd.CommandType = CommandType.Text;

                String sKerkimi;
                if (KrejtShenimet == true)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi, l.sasia, l.qmimi from libri l";

                }
                else

                    if (KerkimiSipas == 0)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi, l.sasia, l.qmimi from libri l where LOWER(l.titulli) like '%" + sKerkimi + "%'";
                }
                else if (KerkimiSipas == 1)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT l.libriId, l.titulli, l.barkodi, l.sasia, l.qmimi from libri l where LOWER(l.barkodi) like '%" + sKerkimi + "%'";
                }

                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    bindingSource1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.DataSource = bindingSource1;
                }
            }
        }
        private void LexoDetajetFatures()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT fd.libriId, l.titulli, l.barkodi, fd.sasia, fd.qmimi from fatura_detajet fd " +
                "inner join libri l on l.libriId = fd.libriId where fd.libriId = 0";
  
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            bindingSource2.DataSource = ds.Tables[0].DefaultView;
            dataGridView2.DataSource = bindingSource2;

            txtBarkodi.DataBindings.Add("Text", bindingSource2, "barkodi");
            //cboBleresi.DataBindings.Add("SelectedValue", bindingSource3, "klientiId");
            txtTitulli.DataBindings.Add("Text", bindingSource2, "titulli");
            txtSasia.DataBindings.Add("Text", bindingSource2, "sasia");
            txtQmimi.DataBindings.Add("Text", bindingSource2, "qmimi");
        }

        private void LexoFaturen()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT f.faturaId, f.data_fatures, f.klientiId, f.pagesa_llojiId from fatura f where faturaId = 0";

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            bindingSource3.DataSource = ds.Tables[0].DefaultView;

            dateTimePicker2.DataBindings.Add("Text", bindingSource3, "data_fatures");
            cboBleresi.DataBindings.Add("SelectedValue", bindingSource3, "klientiId");
            cboMenyraPageses.DataBindings.Add("Text", bindingSource3, "pagesa_llojiId");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            DataRow row1 = ((DataRowView)bindingSource1.Current).Row;

            int nlibriId = Convert.ToInt32(row1["libriId"]);

            int rowPoz = bindingSource2.Find("libriId", nlibriId);

            if (rowPoz != -1)
                MessageBox.Show("Ekziston Ky libër në faturë!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            { 

            bindingSource2.AddNew();
            bindingSource2.MoveLast();

            DataRow row2 = ((DataRowView)bindingSource2.Current).Row;

            row2["libriId"] = row1["libriId"];
            row2["barkodi"] = row1["barkodi"];
            row2["titulli"] = row1["titulli"];
            row2["sasia"] = 1;
            row2["qmimi"] = row1["qmimi"];

            txtSasia.Text = "1";
            decimal lqmimi = Convert.ToDecimal(row2["qmimi"]);
            txtBarkodi.Text = row2["barkodi"].ToString();
            txtTitulli.Text = row2["titulli"].ToString();
            txtQmimi.Text = lqmimi.ToString();

            txtSasia.Focus();

            LLogaritFaturen();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)bindingSource2.Current).Row;
            row.Delete();
        }

        private void LLogaritFaturen()
        {
            decimal vleraFatures = 0;
            foreach (DataRowView dataRow in bindingSource2)
            {
                int nLibriId = Convert.ToInt32(dataRow["libriId"]);
                int nSasia = Convert.ToInt32(dataRow["sasia"]);
                decimal nQmimi = Convert.ToDecimal(dataRow["qmimi"]);
                vleraFatures = vleraFatures + Math.Round(nSasia * nQmimi, 2);
            }
            txtVleraFatures.Text = string.Format("{0:#,##0.00}", double.Parse(vleraFatures.ToString()));
        }


        private void txtSasia_Validated(object sender, EventArgs e)
        {
            LLogaritFaturen();
        }

        private void txtQmimi_Validated(object sender, EventArgs e)
        {
            LLogaritFaturen();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboBleresi.SelectedValue) != 0)
            {
                int lPersonId = Convert.ToInt32(cboBleresi.SelectedValue);
            int lPagesa_lloji = Convert.ToInt32(cboMenyraPageses.SelectedValue);
            int lPuntoriId = GlobalInfo.CurrentUser.UserID;
                string dataFatures = dateTimePicker2.Value.ToString("yyyy-MM-dd"); 
                if (bindingSource2.Count == 0)
                MessageBox.Show("Nuk keni zgjedhur asnjë artikull!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                if (Lloji_fatures == "D")
                  cmd.CommandText = "INSERT INTO fatura (fatura_lloji, pagesa_llojiId, klientiId, puntoriId, data_fatures) " +
                                     "Values ('D','" + lPagesa_lloji.ToString() + "','" + lPersonId.ToString() + "','" +
                                     lPuntoriId.ToString() + "', date '" + dataFatures + "')";
                else
                        cmd.CommandText = "INSERT INTO fatura (fatura_lloji, pagesa_llojiId, klientiId, puntoriId, data_fatures) " +
                                                             "Values ('H','" + lPagesa_lloji.ToString() + "','" + lPersonId.ToString() + "','" +
                                                             lPuntoriId.ToString() + "', date '" + dataFatures + "')";
                    try
                    {
                        conn.Open();
                        int recordsAffected = cmd.ExecuteNonQuery();
                        if (recordsAffected == 0)
                            MessageBox.Show("Të dhënat nuk u ruajtën!");
                        else
                        {
                            //cmd.CommandText = "";
                            foreach (DataRowView dataRow in bindingSource2)
                            {
                                int nLibriId = Convert.ToInt32(dataRow["libriId"]);
                                int nSasia = Convert.ToInt32(dataRow["sasia"]);
                                decimal nQmimi = Convert.ToDecimal(dataRow["qmimi"]);
                                cmd.CommandText = 
                                "INSERT INTO fatura_detajet (faturaId, libriId, sasia, qmimi, tvsh) values (fatura_seq.CURRVAL, '" +
                                nLibriId.ToString() + "','" + nSasia.ToString() + "','" + nQmimi.ToString() + "', 18)";
                                recordsAffected = cmd.ExecuteNonQuery();

                                /*
                                if (recordsAffected != 0)
                                {
                                    if (Lloji_fatures == "D")                                    
                                    cmd.CommandText = "update libri l set l.sasia = l.sasia - '" + nSasia.ToString() + 
                                        "' where l.libriId = '" + nLibriId.ToString() + "'";
                                    else
                                        cmd.CommandText = "update libri l set l.sasia = l.sasia + '" + nSasia.ToString() +
                                        "' where l.libriId = '" + nLibriId.ToString() + "'";
                                    cmd.ExecuteNonQuery();  
                                }
                                */
                            }
                            if (recordsAffected == 0)
                                MessageBox.Show("Të dhënat nuk u ruajtën!");
                            else
                            {
                                MessageBox.Show("Të dhënat u ruajtën me sukses!");
                                this.Close();
                            }
                        }
                      }                

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
              }
            }
            else
                MessageBox.Show("Të dhënat jovalide!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmFatura_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
