using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phillips_james_semesterProject
{
    public partial class FindMediaForm : Form
    {
        public FindMediaForm()
        {
            InitializeComponent();
            Helpers.ReadMovies();
            Helpers.ReadMagazines();
            Helpers.ReadBooks();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            FindMediaForm.ActiveForm.Close();
        }

        public void PopulateMedia()
        {
            if (bookRadioButton.Checked)
            {
                resultsBox.Items.Clear();
                Helpers.ReadBooks();
                // sorting and populating results listbox by title
                Book.bookList.Sort(delegate (Book x, Book y)
                {
                    return x.Title.CompareTo(y.Title);
                });
                resultsBox.Items.AddRange(Book.bookList.ToArray());
            }
            if (movieRadioButton.Checked)
            {
                resultsBox.Items.Clear();
                Helpers.ReadMovies();
                // sorting and populating results listbox by title
                Movie.movieList.Sort(delegate (Movie x, Movie y)
                {
                    return x.Title.CompareTo(y.Title);
                });
                resultsBox.Items.AddRange(Movie.movieList.ToArray());
            }
            if (magRadioButton.Checked)
            {
                resultsBox.Items.Clear();
                Helpers.ReadMagazines();
                // sorting and populating results listbox by title
                Magazine.magList.Sort(delegate (Magazine x, Magazine y)
                {
                    return x.Title.CompareTo(y.Title);
                });
                resultsBox.Items.AddRange(Magazine.magList.ToArray());
            }
        }

        private void mediaSearchButton_Click(object sender, EventArgs e)
        {
            PopulateMedia();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (bookRadioButton.Checked)
            {
                // defining selected item as book to delete
                Book book = resultsBox.SelectedItem as Book;

                // deleting that book and refreshing the list box
                resultsBox.Items.Remove(book);
                Helpers.RemoveBook(book);
                Helpers.WriteBooks(Book.bookList);
                PopulateMedia();
                DeletedLabel.Visible = true;
            }
            else if (magRadioButton.Checked)
            {
                // defining selected item as magazine to delete
                Magazine magazine = resultsBox.SelectedItem as Magazine;

                // deleting that magazine and refreshing the list box
                resultsBox.Items.Remove(magazine);
                Helpers.RemoveMagazine(magazine);
                Helpers.WriteMagazines(Magazine.magList);
                PopulateMedia();
                DeletedLabel.Visible = true;
            }
            else if (movieRadioButton.Checked)
            {
                // defining selected item as movie to delete
                Movie movie = resultsBox.SelectedItem as Movie;

                // deleting that movie and refreshing the list box
                resultsBox.Items.Remove(movie);
                Helpers.RemoveMovie(movie);
                Helpers.WriteMovies(Movie.movieList);
                PopulateMedia();
                DeletedLabel.Visible = true;
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (bookRadioButton.Checked)
            {
                // defining selected item as book to check out
                Book book = resultsBox.SelectedItem as Book;

                // changing value for book to false
                book.Available = false;
                Helpers.WriteBooks(Book.bookList);
                CheckOutLabel.Visible = true;
            }
            else if (movieRadioButton.Checked)
            {
                // defining selected item as movie to check out
                Movie movie = resultsBox.SelectedItem as Movie;

                // changing value for book to false
                movie.Available = false;
                Helpers.WriteMovies(Movie.movieList);
                CheckOutLabel.Visible = true;
            }
        }
    }
}
