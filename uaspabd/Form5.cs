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

namespace uaspabd
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=ANDITAKHRH\\ANDITAKHRH;Initial Catalog=alexphone;User ID=sa;Password=Bangtan26032003");

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 call = new Form2();
            call.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form2 call = new Form2();
            call.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.updateketbeli'" + masuk_idBarang.Text + "','" + masuk_jumlahBarang.Text + "','" + masuk_Harga.Text + "','" + masuk_idNota.Text + "','" + masuk_idPegawai.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alexphoneDataSet.keterangan_pembelian' table. You can move, or remove it, as needed.
            this.keterangan_pembelianTableAdapter.Fill(this.alexphoneDataSet.keterangan_pembelian);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.insertketbeli'" + masuk_idBarang.Text + "','" + masuk_jumlahBarang.Text + "','" + masuk_Harga.Text + "','" + masuk_idNota.Text + "','" + masuk_idPegawai.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }
        void tampilkan()
        {
            SqlCommand com = new SqlCommand("exec dbo.tampilketbeli", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampilkan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.deleteketbeli'" + masuk_idBarang.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.searchketbeli'" + masuk_idBarang.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
