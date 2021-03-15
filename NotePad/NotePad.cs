using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    //this project was created by Abdessamad-Y feel free to use it 
    public partial class NotePad : Form
    {
        DataTable table;

        public NotePad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));
            dataGridView1.DataSource = table;

            dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Columns["Title"].Width = 280;
        }

        private void New_Click(object sender, EventArgs e)
        {
            TitleTxt.Clear();
            MessageTxt.Clear();
        }


        private void Save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TitleTxt.Text, MessageTxt.Text);
            TitleTxt.Clear();
            MessageTxt.Clear();

        }

        
        private void Delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();

        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index >-1)
            {
                TitleTxt.Text = table.Rows[index].ItemArray[0].ToString();
                MessageTxt.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
