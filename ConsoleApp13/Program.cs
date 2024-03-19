using System.Runtime.CompilerServices;
using System.Security;
using System.Xml.Linq;

namespace ConsoleApp13
{
    internal class Program
    {

        //public static bool MyMethod(int num)
        // {
        //     if (num % 2 == 0)
        //     {
        //         return true;
        //     }
        //     return false;
        // }
        //public static int Sahe(int v,int d) { 
        //   return(v*d);
        //}
        //public static int Perimetr(int a,int c)
        //{
        //     return(a+c)*2;  
        //}

        //    static void Main (string[] args)
        //{
        //    Console.WriteLine(Sahe(2,10));
        //    Console.WriteLine(Perimetr(2,6));
        //}

        //public static void Yekun(int a)
        //{

        //    int maas = 333;
        //    int illik = a *60/ 100;
        //    if (maas<illik)
        //    {
        //        Console.WriteLine("kredit goture bilmersiz");
        //    }
        //    else
        //    {
        //        Console.WriteLine("kredit goture bilerzsiz");
        //    }
        //    Console.WriteLine(illik);
        //}


        //static void Main()
        //{
        //    Yekun(67);

        //}
        //public static int[] List(int[] boy)
        //{
        //    for (int i = 0; i < boy.Length; i++)
        //    {
        //        return boy;
        //    }
        //    return boy;
        //}

        //int hasil = 1;
        //int[] boy = { 12, 31, 31, 31, 4141, 141, 10 };
        //int[] netice = List(boy);
        //Array.Resize(ref boy, 12);
        //int[] bb = { 3, 2, 3523, 52, 52, 2 };

        //for (int i = 0; i < netice.Length; i++)
        //{
        //    if (netice[i] % 2 == 0)
        //    {
        //        hasil *= netice[i];
        //    }
        //}
        //Console.WriteLine(hasil);



        //  public static void Main(string[] args) {

        //       int[] newArr = { 1, 2, 4, 6, 52, 3 };
        //       Resizee(ref newArr, 8);
        //       foreach (var item in newArr)
        //       {
        //           Console.Write(item + "");
        //       }

        //   }

        //public static void Resizee(ref int[]arr,int newsize)
        //   {
        //       int[]newArr = new int[newsize];   
        //       for(int i=0;i<arr.Length;i++)
        //       {
        //           newArr[i] = arr[i];
        //       }
        //       arr= newArr;
        //   }








       

        public class Human
        {


            public string Name;
            public string Surname;
            public int Age;

            public Human()
            {

            }
            public Human(string name)
            {
                Name = name;
            }
            public Human(string name, string surname)
            {
                Name = name;
                Surname = surname;
            }
            public Human(string name, string surname, int age) : this(name, surname)
            {
                Age = age;
            }

            public override string ToString()
            {
                return ShowFullData();

            }

            public string ShowFullData()
            {
                return $"Name:{Name}\nSurname:{Surname}\nAge:{Age}";
            }


            public string GetFullName()
            {
                return (Name + " " + Surname);
            }



        }


        public class User:Human
        {


            public string Username;
            public string Password;
         

            public User(string username,string password,string name,string surname) : base(name, surname)
            {
                Username = username;
                Password = password;
            }

            public override string ToString()
            {
                return $"Username:{Username}\nPassword:{Password}\nName:{Name}\nSurname:{Surname}";
            }




            static void Main(string[] args)
            {



                User user = new User("ferid", "ferid123", "Ferid", "Memmedzade");

                Console.WriteLine(user.ShowFullData());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("_____________");
                Console.WriteLine(user);



                //    Human human = new Human()
                //    {
                //        Name = "Ferid",
                //        Surname = "Memmedzade",
                //        Age = 20

                //    };
                //    Human human2 = new Human()
                //    {
                //        Name = "Ibrahim",
                //        Surname = "Asadov",
                //        Age = 19,

                //    };


                //    Console.WriteLine(human);
                //    Console.WriteLine("          ");
                //    Console.WriteLine();
                //    Console.WriteLine();
                //    Console.WriteLine(human2);

                //}


            }


        }





    }
}









