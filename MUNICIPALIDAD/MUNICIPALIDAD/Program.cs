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
            /*
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
            */

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
                fecha:
                Console.WriteLine("BIRTH DATE (AAAA/MM/DD)"); //DATE TIME
                string r3 = Console.ReadLine();
                try
                {
                    DateTime birth = Convert.ToDateTime(r3);
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("ese no es el formato, debe ser (1111/11/30)");
                    goto fecha;
                }
                DateTime b2 = Convert.ToDateTime(r3);
                Console.WriteLine("ADDRESS");
                string r4 = Console.ReadLine();
                Console.WriteLine("RUT");
                string r5 = Console.ReadLine();
                Console.WriteLine("PARENT 1");
                string r6 = Console.ReadLine();
                Console.WriteLine("PARENT 2");
                string r7 = Console.ReadLine();

                Person p1 = new Person(r1,r2,b2, null ,r5,null,null );
                personas.Add(p1);

            }
            if (res == "2")
            {
                Console.Clear();
                Console.WriteLine("BRAND");
                string r1 = Console.ReadLine();
                Console.WriteLine("MODEL");
                string r2 = Console.ReadLine();
                otravez:
                Console.WriteLine("YEAR"); //INT
                string r3 = Console.ReadLine();
                try
                {
                    int i = Convert.ToInt32(r3);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Solo numeros");
                    goto otravez;
                }
                Int32 r33 = Convert.ToInt32(r3);
                Console.WriteLine("OWNER");
                string r7 = Console.ReadLine();
                Console.WriteLine("LISENCE PLATE");
                string r4 = Console.ReadLine();
                esenomen:
                Console.WriteLine("SEATBELTS"); // INT
                string r5 = Console.ReadLine();
                try
                {
                    Int32 i1 = Convert.ToInt32(r5);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Solo numeros");
                    goto esenomen;
                }
                Int32 r55 = Convert.ToInt32(r5);

                Console.WriteLine("DIESEL: (1)si, (2)no"); //BOOL
                string r6 = Console.ReadLine();
                bool di = false;
                if (r6 == "1")
                {
                    di = true;
                }
                Car c1 = new Car(r1,r2,r33,null,r4,r55,di);
                cares.Add(c1);
            }

            if (res == "3")
            {
                Console.Clear();
                Console.WriteLine("STREET");
                string r1 = Console.ReadLine();
                esenomen1:
                Console.WriteLine("NUMBER"); //INT32
                string r2 = Console.ReadLine();
                try
                {
                    Int32 i2 = Convert.ToInt32(r2);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Solo numeros");
                    goto esenomen1;
                }
                Int32 r22 = Convert.ToInt32(r2);
                Console.WriteLine("COMMUNE");
                string r3 = Console.ReadLine();
                Console.WriteLine("CITY");
                string r4 = Console.ReadLine();
                Console.WriteLine("OWNER"); //person (?)
                string r5 = Console.ReadLine();
                esenomen3:
                Console.WriteLine("YEAR OF CONSTRUCTION"); //INT
                string r6 = Console.ReadLine();
                Console.WriteLine("BEDROOMS"); //INT
                string r7 = Console.ReadLine();
                Console.WriteLine("BATHROOMS"); //INT
                string r8 = Console.ReadLine();
                try
                {
                    Int32 i3 = Convert.ToInt32(r6);
                    Int32 i4 = Convert.ToInt32(r7);
                    Int32 i5 = Convert.ToInt32(r8);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Solo numeros");
                    goto esenomen3;
                }
                Int32 r66 = Convert.ToInt32(r6);
                Int32 r77 = Convert.ToInt32(r7);
                Int32 r88 = Convert.ToInt32(r8);
                Console.WriteLine("BACKYARD: (1)si(2)no"); //bOOL
                string r9 = Console.ReadLine();
                bool back = true;
                if (r9 == "2")
                {
                    back = false;
                }
                Console.WriteLine("POOL: (1)si(2)no"); //bOOL
                string r10 = Console.ReadLine();
                bool pul = true;
                if (r9 == "2")
                {
                    pul = false;
                }
                Address a1 = new Address(r1,r22,r3,r4,null,r66,r77,r88,back,pul);
                addresses.Add(a1);
            }
            
            else
            {
                imp1(personas);
                imp2(cares);
                imp3(addresses);
                Console.ReadLine();
                goto inicio;
            }


            Console.ReadLine();

        }
        public static void imp1(List<Person> list)
        {
            foreach (var t in list)
            {
                Console.WriteLine("First Name: "+ t.First_name);
                Console.WriteLine("Last Name: "+ t.Last_name);
                Console.WriteLine("Birth: "+ t.Birth_date);
                Console.WriteLine("rut: "+ t.Rut);
            }
        }
        public static void imp2(List<Car> list)
        {
            foreach (var t in list)
            { 
                Console.WriteLine("brand " + t.Brand);
                Console.WriteLine("model "+ t.Model);
                Console.WriteLine("year "+ t.Year);
                Console.WriteLine("license plate "+ t.License_plate);
                Console.WriteLine("seatbelts "+ t.Seatbelts);
                Console.WriteLine("diesel "+ t.Diesel);
            }
        }
        public static void imp3(List<Address> list)
        {
            foreach (var t in list)
            {
                Console.WriteLine("Street: "+ t.Street);
                Console.WriteLine("number: "+ t.Number);
                Console.WriteLine("commune: "+ t.Commune);
                Console.WriteLine("city: "+ t.City);
                Console.WriteLine("Year of contuction: "+ t.Year_of_contruction);
                Console.WriteLine("bedrooms: "+ t.Bedrooms);
                Console.WriteLine("bathrooms: "+ t.Bathrooms);
                Console.WriteLine("backyard: "+ t.Backyard);
            }
        }
    }   
}
