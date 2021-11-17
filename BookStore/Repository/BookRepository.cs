using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return DataSource().Where(x => x.Title == bookName || x.AuthorName == authorName).ToList();
        }

        List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {   
                new BookModel(){Id=1, Title="MVC", AuthorName="APK", Description ="This is about book", Category="Programming", Language="English", TotalPages=1067 },
                new BookModel(){Id=2, Title=".Net", AuthorName="Megha", Description ="This is about book" , Category="Framework", Language="Chinese", TotalPages=967},
                new BookModel(){Id=3, Title="Java", AuthorName="Manasa", Description ="This is about book", Category="Concept", Language="English", TotalPages=1076},
                new BookModel(){Id=4, Title="PHP", AuthorName="Siddu", Description ="This is about book", Category="Programming", Language="English", TotalPages=1156},
            };
        }
    }
}
