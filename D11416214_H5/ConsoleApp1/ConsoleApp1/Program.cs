using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.name);
            Person pl=new Person("帶入後參數的名字");
            Console.WriteLine(pl.name);
            Student std1=new Student("主程式視帶入參數的名字");
            Console.WriteLine(std1.name);
        }

        public class Person
        {
            public string name;
            public Person()
            {
                name = "Person的名字";
            }
            public Person(string name)
            {
                this.name = name;
            }
        }

        public class Student:Person
        {

            static string name = "Std靜態資料型別預設";
            public Student():base(name)
            {

            }
            public Student(string name) : base(name)
            {

            }
        }
    }
}
