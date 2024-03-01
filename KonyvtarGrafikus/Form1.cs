using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarGrafikus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            foreach (Book item in Program.books)
            {
                lbBooks.Items.Add(item);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormKonyvtar formKonyvtar = new FormKonyvtar("new");
            formKonyvtar.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedIndex < 0)
            {
                MessageBox.Show("Nothing is selected!");
                return;
            }
            FormKonyvtar formKonyvtar = new FormKonyvtar("edit");
            formKonyvtar.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedIndex < 0)
            {
                MessageBox.Show("Nothing is selected!");
                return;
            }
            if (MessageBox.Show("Are you sure?") == DialogResult.OK) 
            {
                Book book = (Book)lbBooks.SelectedItem;
                Program.stat.deleteBook(book);
            }
        }
    }
}
