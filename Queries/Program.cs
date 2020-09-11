using Queries.Core.Domain;
using Queries.Persistence;
using System;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                // Example1
                Course obj= new Course(); //Name,Description,Level,FullPrice,Author,AuthorId,Tags,Cover,IsBeginnerCourse
                obj.Name = "Rez";
                obj.Description = "Reza";
                obj.Level = 1;
                obj.FullPrice = 100;
                obj.AuthorId = 25;
                string QueryString = unitOfWork.Courses.GetQueryString(obj);

                Author objA = new Author();
                string QueryStringAut = unitOfWork.Authors.GetQueryString(objA);

                Console.WriteLine("Course Insert Query : " + QueryString);
                //Console.WriteLine("Author Insert Query : " + QueryStringAut);
                // Example2
                
            }
        }
    }
}
  