using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace MUNICIPALIDAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t1 = typeof(Person);
            Console.WriteLine("Person");
            //t1.GetProperties() t1.GetMethods()
            foreach (var i in t1.GetMethods())
            {
                Console.WriteLine("{0}", i);
            }

            Type t2 = typeof(Car);
            Console.WriteLine("_CAR");
            foreach (var i in t2.GetMethods())
            {
                Console.WriteLine("{0}", i);
            }

            Type t3 = typeof(Address);
            Console.WriteLine("adress");
            foreach (var i in t3.GetMethods())
            {
                Console.WriteLine("{0}", i);
            }
            

            List<Person> personas = new List<Person>();
            List<Car> cares = new List<Car>();
            List<Address> addresses = new List<Address>();

            inicio:
            Console.WriteLine("Agregar:\n"+"(1)Personas\n"+"(2)Vehiculos\n"+"(3)Propiedades");
            string res = Console.ReadLine();
            Console.Clear();
        
            if (res == "1")
            {
                Console.Clear();
                Console.WriteLine("FIRST NAME");
                string r1 = Console.ReadLine();
                Console.WriteLine("LAST NAME");
                string r2 = Console.ReadLine();
                Console.WriteLine("BIRTH DATE"); //DATE TIME
                string r3 = Console.ReadLine();
                DateTime birth = Convert.ToDateTime(r3);
                try
                {
                    DateTime birth = Convert.ToDateTime(r3);
                    
                }
                catch(FormatException)
                {
                    Console.WriteLine("ese no es el formato, debe ser 01/01/1111"); 
                }
                

                Console.WriteLine("ADDRESS");
                string r4 = Console.ReadLine();

                Console.WriteLine("RUT");
                string r5 = Console.ReadLine();

                Console.WriteLine("PARENT 1");
                string r6 = Console.ReadLine();
                Console.WriteLine("PARENT 2");
                string r7 = Console.ReadLine();

                Person p1 = new Person(r1,r2,birth, null ,r5,null,null );
                personas.Add(p1);

            }
            if (res == "2")
            {
                Console.Clear();
                Console.WriteLine("BRAND");
                string r1 = Console.ReadLine();
                Console.WriteLine("MODEL");
                string r2 = Console.ReadLine();
                Console.WriteLine("YEAR"); //INT
                string r3 = Console.ReadLine();
                Console.WriteLine("OWNER"); //INT
                string r7 = Console.ReadLine();
                Console.WriteLine("LISENCE PLATE");
                string r4 = Console.ReadLine();
                Console.WriteLine("SEATBELTS"); // INT
                string r5 = Console.ReadLine();
                Console.WriteLine("DIESEL"); //BOOL
                string r6 = Console.ReadLine();

                //Car c1 = new Car();
                //cares.Add(c1);

            }

            if (res == "3")
            {
                Console.Clear();
                Console.WriteLine("STREET");
                string r1 = Console.ReadLine();
                Console.WriteLine("NUMBER"); //INT32
                string r2 = Console.ReadLine();
                Console.WriteLine("COMMUNE");
                string r3 = Console.ReadLine();
                Console.WriteLine("CITY");
                string r4 = Console.ReadLine();
                Console.WriteLine("OWNER"); //person (?)
                string r5 = Console.ReadLine();
                Console.WriteLine("YEAR OF CONSTRUCTION"); //INT
                string r6 = Console.ReadLine();
                Console.WriteLine("BEDROOMS"); //INT
                string r7 = Console.ReadLine();
                Console.WriteLine("BATHROOMS"); //INT
                string r8 = Console.ReadLine();
                Console.WriteLine("BACKYARD"); //bOOL
                string r9 = Console.ReadLine();

                //Address a1 = new Address(r1);
                //addresses.Add(a1);
            }
            
            else
            {
                goto inicio;
            }



            Console.ReadLine();

        }
        public static void imp1(List<Person> list)
        {
            foreach (var t in list)
            {
                Console.WriteLine(t);
            }
        }
        public static void imp2(List<Car> list)
        {
            foreach (var t in list)
            {
                Console.WriteLine(t);
            }
        }
        public static void imp3(List<Address> list)
        {
            foreach (var t in list)
            {
                Console.WriteLine(t);
            }
        }
    }   
}
