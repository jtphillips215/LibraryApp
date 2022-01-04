using System;
using System.Collections.Generic;
using System.Text;

namespace phillips_james_semesterProject
{
    [Serializable]
    abstract class Media
    {
        // media covers books, magazines, and movies. These instance variables are shared between them
        private string title;
        private string section;
        private bool available;

        public Media(string title, string section, bool available)
        {
            this.Title = title;
            this.Section = section;
            this.Available = available;
        }

        public string Title { get; set; }
        public string Section { get; set; }
        public bool Available { get; set; }

        // check in and check out mark the media types as available or not
        public void CheckIn()
        {
            this.Available = true;
        }

        public void CheckOut()
        {
            this.Available = false;
        }

        public abstract override string ToString();
    }

    [Serializable]
    class Book : Media
    {
        // book adds instance variables in the form of author, isbn & page count
        private string author;
        private string isbn;
        private int pageCount;
        public static List<Book> bookList = new List<Book>();

        public Book(string title, string author, string isbn, string section,
            int pageCount, bool available) : base(title, section, available)
        {
            this.Title = title;
            this.Author = author;
            this.Isbn = isbn;
            this.Section = section;
            this.PageCount = pageCount;
            this.Available = available;
        }

        public string Author { get; set; }
        public string Isbn { get; set; }
        public int PageCount { get; set; }

        public override string ToString()
        {
            string bookString = string.Format("{0} - {1} - {2} - ", this.Title, this.Author,
                this.Section);
            if (this.Available)
            {
                bookString += "Available";
            }
            else
            {
                bookString += "Checked out";
            }
            return bookString;
        }
    }

    [Serializable]
    class Movie : Media
    {
        // movie adds a length field to the base media class
        private double length;
        public static List<Movie> movieList = new List<Movie>();

        public Movie(string title, string section, bool available, double length) : base(title,
            section, available)
        {
            this.Title = title;
            this.Section = section;
            this.Available = available;
            this.Length = length;
        }

        public double Length { get; set; }

        public override string ToString()
        {
            string movieString = string.Format("{0} - {1} - ", this.Title,
                this.Section);
            if (this.Available)
            {
                movieString += "Available";
            }
            else
            {
                movieString += "Checked out";
            }
            return movieString;
        }
    }

    [Serializable]
    class Magazine : Media
    {
        // magazine adds a volume number field to the base class
        private int volumeNum;
        public static List<Magazine> magList = new List<Magazine>();

        public Magazine(string title, string section, bool available, int volumeNum) : base(title,
            section, available)
        {
            this.Title = title;
            this.Section = section;
            this.Available = available;
            this.VolumeNum = volumeNum;
        }

        public int VolumeNum { get; set; }

        public override string ToString()
        {
            string magString = string.Format("{0} - {1} - {2}", this.Title, this.VolumeNum.ToString(),
                this.Section);
            return magString;
        }
    }
}
