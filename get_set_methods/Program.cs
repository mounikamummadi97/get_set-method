
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace myApplication
{
    public class student
    {
        int id;
        private int Marks;
        private string Name;
        private int passmark = 35;

        public void SetMarks (int Marks)
        {
            if (Marks <= passmark)
            {

                throw new Exception("" +
                    "empty"); 

            }

            this.Marks = Marks;

        }
        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("name cannot be null or empty");

            } this.Name = Name;
        }
        public string GetName()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                return "no Name";
                
            }
            return this.Name;
        }
        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("student id cannot be negative");
               
            }
            this.id = Id;
        }

            int GetId() 
            {
                return this.id;
            }
        int GetMarks()
        {
            return this.Marks;
        }
        public class program
        {
            public static void Main()
            {
                student c1 = new student();
                c1.SetId(111);
                c1.SetName("mouni");
                c1.SetMarks(50);

                Console.WriteLine("Student Id = {0}", c1.GetId());
                Console.WriteLine("Student Name = {0}", c1.GetName());
                Console.WriteLine("Student Marks = {0}", c1.GetMarks());
            }
        }
        
    }
}