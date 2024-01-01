﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class BookStore
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        Hashtable ht = new Hashtable();

        public Hashtable AddBook(int bookId, string bookName)
        {
            ht.Add(bookId, bookName);
            return ht;
        }

    }
    internal class Qn4
    {
        static void Main(string[] args)
        {
            /* Create a class called BookStore with fields Bookid and Bookname.Accept and display the details using 
 HashTable.*/
            BookStore b = new BookStore();
            Hashtable ht = new Hashtable();

            Console.WriteLine("Enter the number of books:");
            int num=int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Book Id:");
                b.BookId=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Book Name:");
                b.BookName=Console.ReadLine();
                ht= b.AddBook(b.BookId, b.BookName);
            }
            foreach(var i in  ht.Keys)
            {
                Console.WriteLine($"Book Id:{i} Name:{ht[i]}");
            }




        }
    }
}
