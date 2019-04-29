using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Globalization;
using Tutorial.SqlConn;

namespace GestionActivitePlanificateur
{
    public partial class FormGestionEnfant : Form
    {

        MySqlDataReader reader;
        int idASupp;


        public FormGestionEnfant()
        {  
            InitializeComponent();
        }

        private void populate(String id, String prenom, String nom, String tel, String status, String informations, String dateInscription, String dateFinInscription)
        {
            dataGridViewListeEnfant.Rows.Add(id, prenom, nom, tel, status, informations, dateInscription, dateFinInscription);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewListeEnfant.Rows.Clear();
            MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", 3306, "ram", "root","root");
            DataTable dt = new DataTable();
            conn.Open();

            AfficherEnfants();
            conn.Close();
        }

    
  
        private void btnAjouterEnfant_Click(object sender, EventArgs e)
        {

            string nom = txtBoxNomEnfant.Text;
            string prenom = txtBoxPrenomEnfant.Text;
            string informations = txtBoxInformationsEnfant.Text;
            string telephone = txtBoxNumParent.Text;
            string status = lstBoxStatutEnfant.Text;
            DateTime dateInscription = dateTimePickerDateInscription.Value;
            DateTime dateFinInscription = dateTimePickerFinInscription.Value;


            add(prenom, nom, telephone, status, informations, dateInscription, dateFinInscription);

            dataGridViewListeEnfant.DataSource = null;
            dataGridViewListeEnfant.Rows.Clear();
            dataGridViewListeEnfant.Refresh();

            AfficherEnfants();

        }


        private void add(String prenom, String nom, String telephone, String status, String informations, DateTime dateInscription, DateTime dateFinInscription)
        {
            //SQL STMT
            MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", "ram", "root", "root");
            conn.Open();
            String sql = "CALL `creer_Enfant`(@prenom , @nom, @telephone, @status, @informations, @dateInscription, @dateFinInscription );";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //ADD PARAMETERS
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@informations", informations);
            cmd.Parameters.AddWithValue("@dateInscription", dateInscription);
            cmd.Parameters.AddWithValue("@dateFinInscription", dateFinInscription);
            //OPEN CON AND EXEC insert
            try
            {

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully Inserted");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void delete(int pId)
        {
            int id = pId;
            //SQL STMT
            MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", "ram", "root", "root");
            conn.Open();
            Console.WriteLine("ok2");
            String sql = "CALL `supprimer_Enfant`(@id);";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //ADD PARAMETERS
            cmd.Parameters.AddWithValue("@id", id);
            //OPEN CON AND EXEC insert
            try
            {

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully Inserted");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void AfficherEnfants()
        {
            try
            {
                MySqlConnection conn = null;
                conn = DBMySQLUtils.GetDBConnection("localhost", "ram", "root", "root");
                conn.Open();
                String recupEnfant = null;
                recupEnfant = "CALL `recup_Enfant`();";
                MySqlCommand afficherEnfant = null;
                afficherEnfant = conn.CreateCommand();
                afficherEnfant.CommandText = recupEnfant;

                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = null;
                adapter = new MySqlDataAdapter(afficherEnfant);
                adapter.Fill(dt);
                dataGridViewListeEnfant.DataSource = null;
                dataGridViewListeEnfant.Rows.Clear();
                dataGridViewListeEnfant.Refresh();
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                }
                // Terminez la connexion.
                conn.Close();
                // Disposez un objet, libérez des ressources.
                conn.Dispose();


            }
            catch (Exception e5)
            {
                Console.WriteLine("Error: " + e5);
                Console.WriteLine(e5.StackTrace);
            }
            
            Console.Read();
        }

        private void btnSupprimerEnfant_Click(object sender, EventArgs e)
        {
            if (idASupp>0)
            {
                delete(idASupp);
                Console.WriteLine("ok1");
            }
            else
            {
            }
        }

        private void dateTimePickerJourConcerne_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewListeEnfant.Rows.Clear();
            MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", 3306, "ram", "root", "root");
            DataTable dt = new DataTable();
            conn.Open();
            DateTime pDate = dateTimePickerJourConcerne.Value;

            AfficherEnfantsDate(pDate);
        }
        private void AfficherEnfantsDate(DateTime pDate)
        {
            try
            {
                MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", "ram", "root", "root");
                conn.Open();
               // DateTime date = DateTime.ParseExact(pDate.ToString(), "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                String americanFormat = pDate.Date.ToString("yyyy-MM-dd");
                //Console.WriteLine(pDate);
                Console.WriteLine(americanFormat);
                String recupEnfant = "CALL `recup_Enfant_Date`(@pdate);";
                MySqlCommand afficherEnfant = conn.CreateCommand();
                afficherEnfant.Parameters.AddWithValue("@pdate", americanFormat);
                afficherEnfant.CommandText = recupEnfant;

                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter(afficherEnfant);
                adapter.Fill(dt);
                dataGridViewListeEnfant.Rows.Clear();
                dataGridViewListeEnfant.Refresh();
                
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                }
                // Terminez la connexion.
                conn.Close();
                // Disposez un objet, libérez des ressources.
                conn.Dispose();


            }
            catch (Exception e5)
            {
                Console.WriteLine("Error: " + e5);
                Console.WriteLine(e5.StackTrace);
            }

            Console.Read();
        }


        private void dataGridViewListeEnfant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewListeEnfant.SelectedRows)
            {
                Console.WriteLine(row.Cells[0].Value.ToString());
                idASupp = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtBoxPrenomEnfant.Text = row.Cells[1].Value.ToString();
                txtBoxNomEnfant.Text = dataGridViewListeEnfant.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxNumParent.Text = dataGridViewListeEnfant.SelectedRows[0].Cells[3].Value.ToString();
                lstBoxStatutEnfant.Text = dataGridViewListeEnfant.SelectedRows[0].Cells[4].Value.ToString();
                txtBoxInformationsEnfant.Text = dataGridViewListeEnfant.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePickerDateInscription.Text = dataGridViewListeEnfant.SelectedRows[0].Cells[6].Value.ToString();
                dateTimePickerFinInscription.Text = dataGridViewListeEnfant.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(dataGridViewListeEnfant.SelectedCells.Count != 0)
            {

            String selected = dataGridViewListeEnfant.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            String nom = txtBoxNomEnfant.Text;
            String prenom = txtBoxPrenomEnfant.Text;
            String informations = txtBoxInformationsEnfant.Text;
            String telephone = txtBoxNumParent.Text;
            String status = lstBoxStatutEnfant.Text;
            DateTime dateInscription = dateTimePickerDateInscription.Value;
            DateTime dateFinInscription = dateTimePickerFinInscription.Value;

            update(id, prenom, nom, telephone, status, informations, dateInscription, dateFinInscription);
            }

            else
            {

            }
            
            
        }
        private void update(int id, String prenom, String nom, String telephone, String status, String informations, DateTime dateInscription, DateTime dateFinInscription)
        {
            MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", 3306, "ram", "root", "root");
            DataTable dt = new DataTable();
            conn.Open();
            //SQL STMT
            String sql = "call `update_Enfant`(@prenom , @nom, @telephone, @status, @informations, @dateInscription, @dateFinInscription, @id );";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //ADD PARAMETERS
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@informations", informations);
            cmd.Parameters.AddWithValue("@dateInscription", dateInscription);
            cmd.Parameters.AddWithValue("@dateFinInscription", dateFinInscription);
            cmd.Parameters.AddWithValue("@id", id);

            //OPEN CON,UPDATE,RETRIEVE DGVIEW
            try
            {

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully Inserted");
                    AfficherEnfants();
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }


        }
    }
}
