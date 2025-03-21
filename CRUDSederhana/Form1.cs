using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSederhana
{
    public partial class Form1 : Form
    {
        // Connection String untuk menghubungkan ke database SQL Server
        private string connectionString = "DESKTOP-R38C602\\ABIQQ;" +
                                         "Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        // Event saat form pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Fungsi untuk mengosongkan semua input pada TextBox
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNAMA.Clear();
            txtEMAIL.Clear();
            txtTELEPON.Clear();
            txtALAMAT.Clear();

            //Fokus kembali ke NIM agar user siap memasukkan data baru
            txtNIM.Focus();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
             
