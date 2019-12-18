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
using System.Globalization;

namespace Libraria
{
    public partial class frmPersonat : BaseForm
    {

        OracleConnection conn;
        public frmPersonat()
        {
            InitializeComponent();
        }

        private void frmPersonat_Load(object sender, EventArgs e)
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

            cboGjinia.DisplayMember = "Text";
            cboGjinia.ValueMember = "Value";
            var itemsGjinia = new[] {
                new {Text = "M", Value = "M"},
                new {Text = "F", Value = "F"},
                };
            cboGjinia.DataSource = itemsGjinia;


            cboKerkimiSipas.DisplayMember = "Text";
            cboKerkimiSipas.ValueMember = "Value";
            var itemsKerkimi = new[] {
                new {Text = "Emrit", Value = 0},
                new {Text = "Mbiemrit", Value = 1},
                new {Text = "Emrit dhe Mbiemrit", Value = 2},
                new {Text = "Numrit Personal", Value = 3},
                };
            cboKerkimiSipas.DataSource = itemsKerkimi;

            LoadData(conn, !chkKerkoSipas.Checked, (int)cboKerkimiSipas.SelectedValue);
            txtid.DataBindings.Add("Text", bindingSource1, "PersonId");
            txtemri.DataBindings.Add("Text", bindingSource1, "Emri");
            txtmbiemri.DataBindings.Add("Text", bindingSource1, "Mbiemri");
            cboGjinia.DataBindings.Add("Text", bindingSource1, "Gjinia");
            txtnrpersonal.DataBindings.Add("Text", bindingSource1, "nr_personal");
            txtadresa.DataBindings.Add("Text", bindingSource1, "adresa");
            txtemail.DataBindings.Add("Text", bindingSource1, "email");
            txtkodipostal.DataBindings.Add("Text", bindingSource1, "kodi_postal");
            txtqyteti.DataBindings.Add("Text", bindingSource1, "qyteti");
            txttelefoni.DataBindings.Add("Text", bindingSource1, "telefoni");
            txtshteti.DataBindings.Add("Text", bindingSource1, "shteti");
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
                    cmd.CommandText = "SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                     "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email " +
                     "from personat p";

                }
                else

                    if (KerkimiSipas == 0)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                        "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email " +
                        "from personat p where lower(p.emri.emri) like '%" + sKerkimi + "%'";
                }
                else if (KerkimiSipas == 1)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                    "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email " +
                    "from personat p where lower(p.emri.mbiemri) like '%" + sKerkimi + "%'";
                }
                else if (KerkimiSipas == 2)
                {

                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    if (sKerkimi != "")
                    {
                        string[] sKerkimi1 = sKerkimi.Split();
                        String sEmri = sKerkimi1[0];
                        if (sKerkimi1.Count() == 1)
                        {
                            cmd.CommandText = "SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                            "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email " +
                            "from personat p where lower(p.emri.emri) like '%" + sEmri + "%'";
                        }
                        else
                        {
                            String sMbiemri = sKerkimi1[1];

                            cmd.CommandText = "SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                            "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email " +
                            "from personat p where lower(p.emri.emri) like '%" + sEmri + "%' and lower(p.emri.mbiemri) like '%" + sMbiemri + "%'";
                        }
                    }
                }
                else if (KerkimiSipas == 3)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                    "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email " +
                    "from personat p where p.nr_personal = '" + sKerkimi + "'";

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            txtshteti.Text = "Kosovë";
            cboGjinia.Text = "M";
            txtemri.Focus();
        }

        private void txtemri_Validated(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            txtemri.Text = textInfo.ToTitleCase(txtemri.Text); 
        }

        private void txtmbiemri_Validated(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            txtmbiemri.Text = textInfo.ToTitleCase(txtmbiemri.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sEmri = txtemri.Text.Trim();
            string sMbiemri = txtmbiemri.Text.Trim();
            string sNrPersonal = txtnrpersonal.Text.Trim();
            string sGjinia = cboGjinia.Text;
            string sAdresa = txtadresa.Text.Trim();
            string sQyteti = txtqyteti.Text.Trim();
            string sKodiPostal = txtkodipostal.Text.Trim();
            string sShteti = txtshteti.Text.Trim();
            string sTelefoni = txttelefoni.Text.Trim();
            string sEmail = txtemail.Text.Trim();

            if (sEmri != "" && sMbiemri != "" && sNrPersonal != "" && sEmail != "" && sTelefoni != "")
            {
                if (!ValidateEmail(sEmail))
                    MessageBox.Show("Email adresa nuk eshte valide!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    int lPersonId;
                    if (txtid.Text != "")
                        lPersonId = Convert.ToInt32(txtid.Text);
                    else
                        lPersonId = 0;
                    if (lPersonId == 0)
                        cmd.CommandText = "INSERT INTO personat(emri, nr_personal, gjinia, email, telefoni, adresa)" +
                                        "Values(emri('" + sEmri + "', '" + sMbiemri + "'), '" + sNrPersonal + "', '" + sGjinia + "', '" + sEmail + "'," +
                                         "'" + sTelefoni + "',adresa('" + sAdresa + "', '" + sQyteti + "', '" + sShteti + "', '" + sKodiPostal + "'))";
                    else
                    {
                        cmd.CommandText = "UPDATE personat p SET p.emri.emri = '" + sEmri + "', p.emri.mbiemri = '" + sMbiemri + "'," +
                                                                 " p.nr_personal = '" + sNrPersonal + "', p.gjinia = '" + sGjinia + "'," +
                                                                 " p.email = '" + sEmail + "', p.adresa.adresa = '" + sAdresa + "'," +
                                                                 " p.adresa.qyteti = '" + sQyteti + "', p.adresa.kodi_Postal = '" + sKodiPostal + "', " +
                                                                 " p.adresa.shteti = '" + sShteti + "', p.telefoni=  '" + sTelefoni + "'" +
                                                                 " where p.PersonId = '" + lPersonId.ToString() + "'";

                    }


                    try
                    {
                        conn.Open();
                        int recordsAffected = cmd.ExecuteNonQuery();
                        if (recordsAffected == 0)
                            MessageBox.Show("Të dhënat nuk u ruajtën!");
                        else
                        {
                            MessageBox.Show("Të dhënat u ruajtën me sukses!");
                            cboKerkimiSipas.SelectedValue = 3;
                            txtKerkimi.Text = sNrPersonal;
                            LoadData(conn, !chkKerkoSipas.Checked, 3);
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
                MessageBox.Show("Të dhënat jovalide!", "Verejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void frmPersonat_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
    }

