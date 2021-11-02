using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace TP05
{
    public partial class Form1 : Form
    {
        static string connexionString = ConfigurationManager.ConnectionStrings["conString"].ToString();
        SqlConnection con = new SqlConnection(connexionString);
        BindingSource bs = new BindingSource();
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] comboArray = { "Tout", "Commencent par", "Ne Commencent pas par", "Se terminent par", "Ne Se terminent pas par", "Contiennent", "Ne contiennent pas" };
            cmbxChercher.Items.AddRange(comboArray);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            void execute()
            {
                con.Open();
                dr = cmd.ExecuteReader();
                bs.DataSource = dr;
                dgv.DataSource = bs;
            }
            switch (cmbxChercher.SelectedIndex)
            {
                //Tout
                case 0:
                    try
                    {
                        cmd.CommandText = "SELECT * FROM Client";
                        execute();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }        
                    break;
                //Commencent par
                case 1:
                    try
                    {
                        cmd.CommandText = "SELECT * FROM Client WHERE nomClient LIKE @nom";
                        cmd.Parameters.AddWithValue("@nom", txtbxChercher.Text +"%");
                        execute();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    break;
                //Ne Commencent pas par
                case 2:
                    try
                    {
                        cmd.CommandText = "SELECT * FROM Client WHERE nomClient NOT LIKE @nom";
                        cmd.Parameters.AddWithValue("@nom", txtbxChercher.Text + "%");
                        execute();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    break;
                //Se terminent par
                case 3:
                    try
                    {
                        cmd.CommandText = "SELECT * FROM Client WHERE nomClient LIKE @nom";
                        cmd.Parameters.AddWithValue("@nom", "%"+txtbxChercher.Text);
                        execute();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    break;
                //Ne Se terminent pas par
                case 4:
                    try
                    {
                        cmd.CommandText = "SELECT * FROM Client WHERE nomClient NOT LIKE @nom";
                        cmd.Parameters.AddWithValue("@nom", "%" + txtbxChercher.Text);
                        execute();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    break;
                //Contiennent
                case 5:
                    try
                    {
                        cmd.CommandText = "SELECT * FROM Client WHERE nomClient LIKE @nom";
                        cmd.Parameters.AddWithValue("@nom", "%" +txtbxChercher.Text+ "%");
                        execute();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    break;
                //Ne contiennent pas
                case 6:
                    try
                    {
                        cmd.CommandText = "SELECT * FROM Client WHERE nomClient NOT LIKE @nom";
                        cmd.Parameters.AddWithValue("@nom", "%" + txtbxChercher.Text + "%");
                        execute();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { con.Close(); }
                    break;
                default:
                    break;
            }
        }
    }
}
