using creatingEntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                //this will create the database
                Student stud = new Student() { StudentName = "New Student" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                //this will delete the database
                try
                {                   
                    if (ctx.Database.Exists())
                        ctx.Database.Delete();
                    else {
                        Console.Write("database Not Available");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.Write("database NOt deleted");
                    Console.ReadKey();
                }
            }
        }
    }
}
