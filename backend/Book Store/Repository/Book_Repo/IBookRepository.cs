﻿using Book_Store.Models;

namespace Book_Store.Repository.Books_Repo
{
    public interface IBookRepository
    {
        void Delete(int id);
        void Edit(Book book, int id);
        List<Book> GetAll();
        Book GetById(int id);
        void Insert(Book book);
    }
}