using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace phillips_james_semesterProject
{
    static class Helpers
    {
        public static void AddMember(string name, string idNum)
        {
            // method takes in info from Add Member form and creates a new member object
            // and adds it to the list
            int memberID = Convert.ToInt32(idNum);
            Member member = new Member(name, memberID);
            Member.memberList.Add(member);
        }

        public static void RemoveMember(Member member)
        {
            // remove member deletes member from member list
            Member.memberList.Remove(member);
        }

        public static void AddBook(string title, string author, string isbn, string section,
            string pageCount, bool available)
        {
            // add book creates a new book object and adds it to the list
            int pages = Convert.ToInt32(pageCount);
            Book book = new Book(title, author, isbn, section, pages, true);
            Book.bookList.Add(book);
        }

        public static void RemoveBook(Book book)
        {
            // remove book deletes book from book list
            Book.bookList.Remove(book);
        }

        public static void AddMovie(string title, string section, bool available, string length)
        {
            // add movie creates a new movie object and adds it to the movie list
            double minutes = Convert.ToDouble(length);
            Movie movie = new Movie(title, section, true, minutes);
            Movie.movieList.Add(movie);
        }

        public static void RemoveMovie(Movie movie)
        {
            // remove movie deletes movie from movie list
            Movie.movieList.Remove(movie);
        }

        public static void AddMagazine(string title, string section, bool available, string volumeNum)
        {
            // add magazine creates a new magazine object and adds it to the magazine list
            int vol = Convert.ToInt32(volumeNum);
            Magazine magazine = new Magazine(title, section, true, vol);
            Magazine.magList.Add(magazine);
        }

        public static void RemoveMagazine(Magazine magazine)
        {
            // remove magazine removes magazine from list
            Magazine.magList.Remove(magazine);
        }

        public static void ReadMembers()
        {
            // read members reads the members file and populates the members list with
            // the objects contained in that file
            Member.memberList.Clear();
            string filename = "members.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            while (stream.Position < stream.Length)
            {
                Member member = (Member)formatter.Deserialize(stream);
                Member.memberList.Add(member);
            }
            stream.Close();
        }

        public static void WriteMembers(List<Member> memberList)
        {
            // write members writes all members to a file when a change occurs such as when
            // a member is added or deleted
            string filename = "members.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@filename, FileMode.Create, FileAccess.Write);
            foreach (Member member in memberList)
            {
                formatter.Serialize(stream, member);
            }
            Member.memberList.Clear();
            stream.Close();
        }

        public static void ReadBooks()
        {
            // read books reads the books file and populates the books list with
            // the objects contained in that file
            Book.bookList.Clear();
            string filename = "books.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            while (stream.Position < stream.Length)
            {
                Book book = (Book)formatter.Deserialize(stream);
                Book.bookList.Add(book);
            }
            stream.Close();
        }

        public static void WriteBooks(List<Book> bookList)
        {
            // write books writes all books to a file when a change occurs such as when
            // a book is added or deleted
            string filename = "books.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@filename, FileMode.Create, FileAccess.Write);
            foreach (Book book in bookList)
            {
                formatter.Serialize(stream, book);
            }
            Book.bookList.Clear();
            stream.Close();
        }

        public static void ReadMovies()
        {
            // read movies reads the movies file and populates the movies list with
            // the objects contained in that file
            Movie.movieList.Clear();
            string filename = "movies.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            while (stream.Position < stream.Length)
            {
                Movie movie = (Movie)formatter.Deserialize(stream);
                Movie.movieList.Add(movie);
            }
            stream.Close();
        }

        public static void WriteMovies(List<Movie> movieList)
        {
            // write movies writes all movies to a file when a change occurs such as when
            // a movie is added or deleted
            string filename = "movies.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@filename, FileMode.Create, FileAccess.Write);
            foreach (Movie movie in movieList)
            {
                formatter.Serialize(stream, movie);
            }
            Movie.movieList.Clear();
            stream.Close();
        }

        public static void ReadMagazines()
        {
            // read magazines reads the magazine file and populates the magazine
            // list with the objects contained in that file
            Magazine.magList.Clear();
            string filename = "magazines.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@filename, FileMode.Open, FileAccess.Read);
            while (stream.Position < stream.Length)
            {
                Magazine magazine = (Magazine)formatter.Deserialize(stream);
                Magazine.magList.Add(magazine);
            }
            stream.Close();
        }

        public static void WriteMagazines(List<Magazine> magList)
        {
            // write magazines writes all magazines to a file when a change occurs
            // such as when a magazine is added or deleted
            string filename = "magazines.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@filename, FileMode.Create, FileAccess.Write);
            foreach (Magazine magazine in magList)
            {
                formatter.Serialize(stream, magazine);
            }
            Magazine.magList.Clear();
            stream.Close();
        }
    }
}
