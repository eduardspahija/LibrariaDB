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
    public partial class frmPunetoret : BaseForm
    {
        OracleConnection conn;
        public frmPunetoret()
        {
            InitializeComponent();
        }

        private void frmPunetoret_Load(object sender, EventArgs e)
        {
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
                cboPersoni.DataSource = ds.Tables[0].DefaultView;
                cboPersoni.DisplayMember = "EmriMbiemri";
                cboPersoni.ValueMember = "PersonId";
            }

            cmd.CommandText = "select pu.puntoriId, concat(concat(p.emri.emri,' '), p.emri.mbiemri) as emrimbiemri from personat p " +
                "inner join puntoret pu on pu.personId = p.personId";
            oda = new OracleDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            oda.Fill(ds1);
            if (ds1.Tables.Count > 0)
            {
                cboMenaxheri.DataSource = ds1.Tables[0].DefaultView;
                cboMenaxheri.DisplayMember = "EmriMbiemri";
                cboMenaxheri.ValueMember = "puntoriId";
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToAddRows = false;


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

            txtid.DataBindings.Add("Text", bindingSource1, "PuntoriId");
            cboPersoni.DataBindings.Add("SelectedValue", bindingSource1, "personId");
            cboMenaxheri.DataBindings.Add("SelectedValue", bindingSource1, "menaxherid");
            txtpozita.DataBindings.Add("Text", bindingSource1, "Pozita");
            txtusername.DataBindings.Add("Text", bindingSource1, "UserName");
            txtpassword.DataBindings.Add("Text", bindingSource1, "fjalekalimi");
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
                    cmd.CommandText = "SELECT pu.puntoriID, pu.menaxherid, p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                     "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email, " +
                     "pu.pozita, pu.username, pu.fjalekalimi from personat p inner join puntoret pu on p.personid = pu.personId";

                }
                else

                    if (KerkimiSipas == 0)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT pu.puntoriID, pu.menaxherid, p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                     "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email, " +
                     "pu.pozita, pu.username, pu.fjalekalimi from personat p inner join puntoret pu on p.personid = pu.personId where lower(p.emri.emri) like '%" + sKerkimi + "%'";
                }
                else if (KerkimiSipas == 1)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT pu.puntoriID, pu.menaxherid, p.PersonId, p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                     "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email, " +
                     "pu.pozita, pu.username, pu.fjalekalimi from personat p inner join puntoret pu on p.personid = pu.personId where lower(p.emri.mbiemri) like '%" + sKerkimi + "%'";
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
                            cmd.CommandText = "SELECT pu.puntoriID, pu.menaxherid, p.PersonId, p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                            "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email, " +
                            "pu.pozita, pu.username, pu.fjalekalimi from personat p inner join puntoret pu on p.personid = pu.personId where lower(p.emri.emri) like '%" + sEmri + "%'";
                        }
                        else
                        {
                            String sMbiemri = sKerkimi1[1];

                            cmd.CommandText = "SELECT pu.puntoriID, pu.menaxherid, p.PersonId, p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                            "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email, " +
                            "pu.pozita, pu.username, pu.fjalekalimi from personat p inner join puntoret pu on p.personid = pu.personId where lower(p.emri.emri) like '%" + sEmri + "%' and lower(p.emri.mbiemri) like '%" + sMbiemri + "%'";
                        }
                    }
                }
                else if (KerkimiSipas == 3)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT pu.puntoriID, pu.menaxherid, p.PersonId, p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                     "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email, " +
                     "pu.pozita, pu.username, pu.fjalekalimi from personat p inner join puntoret pu on p.personid = pu.personId where p.nr_personal like '%" + sKerkimi + "%'";

                }
                else if (KerkimiSipas == 4)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT pu.puntoriID, pu.menaxherid, p.PersonId, p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                     "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email, " +
                     "pu.pozita, pu.username, pu.fjalekalimi from personat p inner join puntoret pu on p.personid = pu.personId where Lower(pu.pozita) like '%" + sKerkimi + "%'";

                }
                else if (KerkimiSipas == 5)
                {
                    sKerkimi = txtKerkimi.Text.Trim().ToLower();
                    cmd.CommandText = "SELECT pu.puntoriID, pu.menaxherid, p.PersonId, p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, " +
                     "p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email, " +
                     "pu.pozita, pu.username, pu.fjalekalimi from personat p inner join puntoret pu on p.personid = pu.personId where Lower(pu.userName) like '%" + sKerkimi + "%'";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int lPersonId = Convert.ToInt32(cboPersoni.SelectedValue);
            int lMenaxherId = Convert.ToInt32(cboMenaxheri.SelectedValue);
            string sPozita = txtpozita.Text.Trim();
            string sUserName = txtusername.Text.Trim();
            string sPassword = txtpassword.Text.Trim();
            string sConfirmPassword = txtconfirmpassword.Text.Trim();

            if (sPassword != sConfirmPassword)
                MessageBox.Show("Password-at nuk përputhen!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

            if (sPozita != "" && sUserName != "" && sPassword != "")
            { 
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    int lPuntoriId;
                    if (txtid.Text != "")
                         lPuntoriId = Convert.ToInt32(txtid.Text);
                    else
                       lPuntoriId = 0;
                    if (lPuntoriId == 0)
                        cmd.CommandText = "INSERT INTO puntoret (personId, pozita, username, fjalekalimi)" +
                                        "Values ('" + lPersonId.ToString() + "', '" + sPozita + "', '" + sUserName + "', '" + sPassword + "')";
                    else
                    {

                        cmd.CommandText = "UPDATE puntoret p SET p.personId = '" + lPersonId.ToString() + "', p.pozita = '" + sPozita + "'," +
                                                                 " p.username = '" + sUserName + "', p.fjalekalimi = '" + sPassword + "'," +
                                                                 " p.menaxherid = '" + lMenaxherId.ToString() + "'" +
                                                                 " where p.puntoriId = '" + lPuntoriId.ToString() + "'";
        
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
                            cboKerkimiSipas.SelectedValue = 5;
                            txtKerkimi.Text = sUserName;
                            LoadData(conn, !chkKerkoSipas.Checked, 5);
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
            else
                MessageBox.Show("Të dhënat jovalide!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            cboPersoni.Focus();
        }

        private void btnLexoShenimet_Click(object sender, EventArgs e)
        {
            LoadData(conn, !chkKerkoSipas.Checked, (int)cboKerkimiSipas.SelectedValue);
        }

        private void frmPunetoret_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
    }
