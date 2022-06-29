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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alexphoneDataSet.keterangan_penjualan' table. You can move, or remove it, as needed.
            this.keterangan_penjualanTableAdapter.Fill(this.alexphoneDataSet.keterangan_penjualan);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.insertketjual'" + masuk_idNota.Text + "','" + masuk_Harga.Text + "','" + masuk_jumlahBarang.Text + "','" + masuk_idBarang.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }
        void tampilkan()
        {
            SqlCommand com = new SqlCommand("exec dbo.tampilketjual", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.updateketjual'" + masuk_idNota.Text + "','" + masuk_Harga.Text + "','" + masuk_jumlahBarang.Text + "','" + masuk_idBarang.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.deleteketjual'" + masuk_idNota.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.searchketjual'" + masuk_idNota.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
