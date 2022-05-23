using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFrameworkCodeFirst.Lesson
{
    public class Program
    {
        static void Main(string[] args)
        {

            Post post = new Post
            {
                Name = "Mario",
                Body = "Ciao Mondo",
                DatePublished = DateTime.Now

            };
            ChangeDB(post); //  -> post

            using (var db = new CorsoDbContext())
            {
                Post item = (from p in db.Post where p.Name == "Mario" select p)
                  .ToList().FirstOrDefault();
                Console.WriteLine(item.Name);
            }


            //}


        }
        public static void ChangeDB(Post post)
        {
            using (CorsoDbContext db = new CorsoDbContext())
            {
                db.Post.Add(post);
                try
                {
                    db.SaveChanges(); // -> 
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DatePublished { get; set; }
        public string Body { get; set; }
    }
    public class Corso
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DatePublished { get; set; } 
        //public List<Student> Students { get; set; }
    }
}
    

    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Corso corso { get; set; }

    //}


