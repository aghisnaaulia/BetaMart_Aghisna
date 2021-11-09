using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BetaMartAghisnaA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tBBetaMartTableAdapter.Fill(this.dBBetaMartDataSet.TBBetaMart);
            tBBetaMartBindingSource.DataSource = this.dBBetaMartDataSet.TBBetaMart;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tBBetaMartBindingSource.RemoveCurrent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBBetaMartDataSet.TBBetaMart' table. You can move, or remove it, as needed.
            this.tBBetaMartTableAdapter.Fill(this.dBBetaMartDataSet.TBBetaMart);
            tBBetaMartBindingSource.DataSource = this.dBBetaMartDataSet.TBBetaMart;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                tBBetaMartBindingSource.EndEdit();
                tBBetaMartTableAdapter.Update(this.dBBetaMartDataSet.TBBetaMart);
                panel4.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBBetaMartBindingSource.ResetBindings(false);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Enabled = false;
            tBBetaMartBindingSource.ResetBindings(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                panel4.Enabled = true;
                textBox1.Focus();
                this.dBBetaMartDataSet.TBBetaMart.AddTBBetaMartRow(this.dBBetaMartDataSet.TBBetaMart.NewTBBetaMartRow());
                tBBetaMartBindingSource.MoveLast();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBBetaMartBindingSource.ResetBindings(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(button1.Text))
                    dataGridView1.DataSource = tBBetaMartBindingSource;
                else
                {
                    var query = from o in this.dBBetaMartDataSet.TBBetaMart
                                where o.Kode_Barang.Contains(textBox1.Text) || o.Nama_Barang == textBox2.Text || o.Jumlah == textBox3.Text || o.Satuan == textBox4.Text || o.Harga.Contains(textBox5.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private class pictureBox
        {
            internal static Image Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
