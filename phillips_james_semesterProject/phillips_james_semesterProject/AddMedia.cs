using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phillips_james_semesterProject
{
    public partial class AddMediaForm : Form
    {
        public AddMediaForm()
        {
            InitializeComponent();
            SectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Helpers.ReadBooks();
            Helpers.ReadMagazines();
            Helpers.ReadMovies();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            AddMediaForm.ActiveForm.Close();
        }

        // the radio buttons turn on and off specific fields based on which
        // radio button is selected. For instance, the book radio button enables
        // all book fields while disabling all others
        private void BookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AuthorTextBox.Enabled = true;
            SerialTextBox.Enabled = true;
            PageCountTextBox.Enabled = true;
            LengthTextBox.Enabled = false;
            VolumeTextBox.Enabled = false;
        }

        private void MovieRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LengthTextBox.Enabled = true;
            AuthorTextBox.Enabled = false;
            SerialTextBox.Enabled = false;
            PageCountTextBox.Enabled = false;
            VolumeTextBox.Enabled = false;
        }

        private void MagRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            VolumeTextBox.Enabled = true;
            AuthorTextBox.Enabled= false;
            SerialTextBox.Enabled= false;
            PageCountTextBox.Enabled = false;
            LengthTextBox.Enabled= false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // when the add button is clicked, the program attempts to add whichever
            // media type is applicable based on which radio button is selected
            // if successfull, the media type is created and saved to file
            // and a success message is shown
            // on fail, an error message is shown
            if (BookRadioButton.Checked)
            {
                try
                {
                    Helpers.AddBook(TitleTextBox.Text, AuthorTextBox.Text,
                        SerialTextBox.Text, SectionComboBox.SelectedItem.ToString(),
                        PageCountTextBox.Text, true);
                    Helpers.WriteBooks(Book.bookList);
                    Helpers.ReadBooks();
                    AddMediaSuccess.Visible = true;
                    MediaAddFailed.Visible = false;
                }
                catch (FormatException)
                {
                    MediaAddFailed.Visible = true;
                    AddMediaSuccess.Visible = false;
                }
            }
            else if (MovieRadioButton.Checked)
            {
                try
                {
                    Helpers.AddMovie(TitleTextBox.Text, SectionComboBox.SelectedItem.ToString(),
                        true, LengthTextBox.Text);
                    Helpers.WriteMovies(Movie.movieList);
                    Helpers.ReadMovies();
                    AddMediaSuccess.Visible = true;
                    MediaAddFailed.Visible = false;
                }
                catch (FormatException)
                {
                    MediaAddFailed.Visible = true;
                    AddMediaSuccess.Visible = false;
                }
            }
            else if (MagRadioButton.Checked)
            {
                try
                {
                    Helpers.AddMagazine(TitleTextBox.Text, SectionComboBox.SelectedItem.ToString(),
                        true, VolumeTextBox.Text);
                    Helpers.WriteMagazines(Magazine.magList);
                    Helpers.ReadMagazines();
                    AddMediaSuccess.Visible = true;
                    MediaAddFailed.Visible = false;
                }
                catch (FormatException)
                {
                    MediaAddFailed.Visible = true;
                    AddMediaSuccess.Visible = false;
                }
            }
        }
    }
}
