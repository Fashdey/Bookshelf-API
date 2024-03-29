﻿using BookshelfAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace BookshelfAPI.Services
{
    public class BookService
    {
        private readonly IMongoCollection<Book> _books;

        public BookService(IBookshelfDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Book>(settings.BooksCollectionName);
        }

        public List<Book> Get() =>
            _books.Find(book => true).ToList();

        public Book Get(string id) =>
            _books.Find<Book>(book => book.Id == id).FirstOrDefault();

        public List<Book> GetByYear(int year) =>
            _books.Find(book => book.PublishYear == year).ToList();

        public List<Book> GetByAuthor(string author) =>
            _books.Find(book => book.Author == author).ToList();

        public Book Create(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        //Return to this to make real update
        public void Update(string id, Book bookIn) =>
            _books.ReplaceOne(book => book.Id == id, bookIn);

        public void Remove(Book bookIn) =>
            _books.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            _books.DeleteOne(book => book.Id == id);
    }
}
