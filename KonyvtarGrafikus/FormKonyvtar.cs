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
    public partial class FormKonyvtar : Form
    {
        string command;
        public FormKonyvtar(string command)
        {
            InitializeComponent();
            this.command = command;
        }

        private void FormKonyvtar_Load(object sender, EventArgs e)
        {
            switch (command)
            {
                case "new":
                    this.Text = "New Book";
                    btnCommand.Text = "Add New Book";
                    btnCommand.BackColor = Color.LightGreen;
                    btnCommand.Click += new EventHandler(newBook);
                    break;
                case "edit":
                    this.Text = "Edit";
                    btnCommand.Text = "Edit Book";
                    btnCommand.BackColor = Color.Aqua;
                    btnCommand.Click += new EventHandler(updateBook);
                    DataLoad();
                    break;
                case "delete":
                    this.Text = "Delete";
                    btnCommand.Text = "Delete Book";
                    btnCommand.BackColor = Color.Red;
                    btnCommand.ForeColor = Color.White;
                    btnCommand.Click += new EventHandler(deleteBook);
                    DataLoad();
                    break;
            }
        }

        private void deleteBook(object sender, EventArgs e)
        {
            Book book = createBook();
            Program.stat.deleteBook(book);
            this.Close();
        }

        private void updateBook(object sender, EventArgs e)
        {
            Book book = createBook();
            Program.stat.updateBook(book);
            this.Close();
        }

        private void DataLoad()
        {
            Book book = (Book)Program.form1.lbBooks.SelectedItem;
            numId.Value = (int)book.Id;
            tbAuthor.Text = book.Author.ToString();
            tbTitle.Text = book.Title.ToString();
            numPageCount.Value = (int)book.Page_count;
            numPublished.Value = (int)book.Publish_year;
        }

        private void newBook(object sender, EventArgs e)
        {
            Book book = createBook();
            Program.stat.newBook(book);
            this.Close();
        }

        private Book createBook()
        {
            Book book = new Book();
            book.Id = (int)numId.Value;
            book.Title = tbTitle.Text;
            book.Author = tbAuthor.Text;
            book.Publish_year = (int)numPublished.Value;
            book.Page_count = (int)numPageCount.Value;
            return book;
        }
    }
}
