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

namespace AdatkapcsolatGyakorlas
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "orszagok";
            sb.CharacterSet = "UTF8";

            MySqlConnection con = new MySqlConnection(sb.ConnectionString);

            try
            {
                con.Open();

                MySqlCommand sqlSelect = con.CreateCommand();
                sqlSelect.CommandText = "SELECT * FROM orszagok;";

                using (MySqlDataReader dr = sqlSelect.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Orszag newOrszag = new Orszag(dr.GetInt32("id"), dr.GetString("orszag"), dr.GetString("fovaros"), dr.GetString("foldr_hely"), dr.GetFloat("terulet"), dr.GetString("allamforma"), dr.GetInt32("nepesseg"), dr.GetInt32("nep_fovaros"), dr.GetString("autojel"), dr.GetString("country"), dr.GetString("capital"), dr.GetString("penznem"), dr.GetString("penzjel"), dr.GetString("valtopenz"), dr.GetInt32("telefon"), dr.GetInt32("gdp"), dr.GetInt32("kat"));

                        lbOrszagok.Items.Add(newOrszag);
                    }
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show($"Az alábbi hiba lépett fel:\n{err}", "Hiba");
            }
        }

        private void lbOrszagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrszagok.SelectedIndex < 0)
            {
                MessageBox.Show("Válassz ki a listából egy országot!", "Hiba");
            }
            else
            {
                Orszag selectedOrszag = (Orszag)lbOrszagok.SelectedItem;

                tbFovaros.Text = selectedOrszag.Fovaros;
                tbTerulet.Text = selectedOrszag.Terulet.ToString();
                tbNepesseg.Text = selectedOrszag.Nepesseg.ToString();
                tbAutojel.Text = selectedOrszag.Autojel;
            }
        }

        private void btTorol_Click(object sender, EventArgs e)
        {
            tbFovaros.Text = String.Empty;
            tbTerulet.Text = String.Empty;
            tbNepesseg.Text = String.Empty;
            tbAutojel.Text = String.Empty;
        }

        private void újRekordFelvételeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fejlesztés alatt.");
        }

        private void meglévőFrissítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fejlesztés alatt.");
        }

        private void meglévőTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fejlesztés alatt.");
        }
    }
}
