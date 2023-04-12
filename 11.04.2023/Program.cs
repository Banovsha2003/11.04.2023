using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace _11._04._2023
{
    ////task:1
    //public delegate double num(double number);

    ////task:2
    //public delegate int num2(int number1, int number2);

    ////task:3
    //public delegate string GroupBy(Student student);

    //task:4

    public class Program
    {

        static void Main(string[] args)
        {
            ////task:1
            //Console.WriteLine("Ededi daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //num kvadrat = Kvadrat;

            //Console.WriteLine(kvadrat(number));


            ////task:2
            //Console.WriteLine("Birinci ededi daxil edin: ");
            //int number1=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ikinci ededi daxil edin: ");
            //int number2=Convert.ToInt32(Console.ReadLine());

            //num2 cem = Sum;
            //Console.WriteLine(cem.Invoke(number1,number2));


            ////task:3
            //List<Student> list = new List<Student>();

            //list.Add(new Student()
            //{
            //    Age = "17",
            //    Gender = "Female",
            //    Name = "Test",
            //    Id = 1
            //});

            //list.Add(new Student()
            //{
            //    Age = "18",
            //    Gender = "Female",
            //    Name = "Test2",
            //    Id = 2
            //});

            //list.Add(new Student()
            //{
            //    Age = "18",
            //    Gender = "Female",
            //    Name = "Test3",
            //    Id = 3
            //});

            //var group = Group(list, (s) => s.Age);



        }

        ////task:1
        //public static double Kvadrat(double number)
        //{
        //    number *= number;
        //    return number;
        //}


        ////task:2
        //public static int Sum(int number1,int number2)
        //{
        //    int sum=number1+number2;
        //    return sum;
        //}


        ////task:3
        //public static Dictionary<string, List<Student>> Group(List<Student> students, GroupBy groupBy)
        //{
        //    Dictionary<string, List<Student>> result = new Dictionary<string, List<Student>>();

        //    foreach (var student in students)
        //    {
        //        string key = groupBy?.Invoke(student);

        //        if (!result.ContainsKey(key))
        //        {
        //            result[key] = new List<Student>();
        //        }

        //        result[key].Add(student);
        //    }

        //    return result;
        //}

        //public static string GropByGender(Student student)
        //{
        //    return student.Gender;
        //}
        //t



        //task:4

    }
    //task:3
    //class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public string Age { get; set; }
    //}




}
     
   































