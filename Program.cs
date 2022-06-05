using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTo
{
    class Program
    {
        class Person: IComparable<Person>
        {
            public string Name { get; set; }
            public int Grade { get; set; }

            public int CompareTo(Person other)
            {
                return other.Grade-this.Grade;
            }
            public Person(string name,int grade)
            {
                Name = name;
                Grade = grade;
            }
        }
        





        static void Main(string[] args)
        {
            var ogr2 = new Person("sungur", 95);
            var ogr1 = new Person("ali",78);            
            var ogr3 = new Person("mustafa", 88);

            var persons = new List<Person>();
            persons.Add(ogr3);
            persons.Add(ogr1);
            persons.Add(ogr2);

            foreach (var item in persons)
            {
                Console.WriteLine(item.Name+"\t"+item.Grade);
            }

            persons.Sort(); // compareTo ile listeyi sıralar.
           
            Console.WriteLine("");
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name + "\t" + item.Grade);
            }

            int k= ogr2.CompareTo(ogr1); // iki person instance sını karşılaştırır.
 
            Console.WriteLine(k); 
            Console.ReadKey();
            
        }
    }
}
