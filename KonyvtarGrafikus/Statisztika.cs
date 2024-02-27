using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarGrafikus
{
    internal class Statisztika
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;

        public Statisztika()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "books";
            builder.CharacterSet = "utf8";

            conn = new MySqlConnection(builder.ConnectionString);
            cmd = conn.CreateCommand();

            try
            {
                Connection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                ConnectionClose();
            }
        }

        private void ConnectionClose()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        private void Connection()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        internal List<Book> getAllBooks() 
        {
            List<Book> books = new List<Book>();
            cmd.CommandText = "SELECT * FROM `books`";
            try 
            {
                Connection();
                using (MySqlDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read())
                    {
                        int id = dr.GetInt32("id");
                        string title = dr.GetString("title");
                        string author = dr.GetString("author");
                        int publish_year = dr.GetInt32("publish_year");
                        int page_count = dr.GetInt32("page_count");
                        books.Add(new Book(id, title, author, publish_year, page_count));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectionClose();
            }
            return books;
        }

        internal void newBook(Book book) {
            cmd.CommandText = "INSERT INTO `books`(`id`, `title`, `author`, `publish_year`, `page_count`) VALUES (@id, @title, @author, @publish_year, @page_count)";
            cmd.Parameters.AddWithValue("id", book.Id);
            cmd.Parameters.AddWithValue("title", book.Title);
            cmd.Parameters.AddWithValue("author", book.Author);
            cmd.Parameters.AddWithValue("publish_year", book.Publish_year);
            cmd.Parameters.AddWithValue("page_count", book.Page_count);
            try
            {
                Connection();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectionClose();
            }
        }

        internal void deleteBook(Book book) 
        {
            cmd.CommandText = "DELETE FROM `books` WHERE `books`.`id`=@id";
            cmd.Parameters.AddWithValue("@id", book.Id);
            try
            {
                Connection();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectionClose();
            }
        }

        internal void updateBook(Book book) {
            conn.Open();
            cmd.CommandText = "UPDATE `books` SET `title`='@title',`author`='@author',`publish_year`='@publish_year',`page_count`='@page_count' WHERE `id`=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("id", book.Id);
            cmd.Parameters.AddWithValue("title", book.Title);
            cmd.Parameters.AddWithValue("author", book.Author);
            cmd.Parameters.AddWithValue("publish_year", book.Publish_year);
            cmd.Parameters.AddWithValue("page_count", book.Page_count);
            try
            {
                Connection();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectionClose();
            }
        }

        
    }
}
