using Newtonsoft.Json;
using System.Text.Json;

namespace StudentApp
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string School { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, School: {School}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("1. Lisää oppilas");
                Console.WriteLine("2. Tallenna oppilaat tiedostoon");
                Console.WriteLine("3. Lataa oppilaat tiedostosta");
                Console.WriteLine("4. poista oppilas");
                Console.WriteLine("5. Listaa oppilaat");
                Console.WriteLine("6. Lopeta");

                Console.Write("Syötä vaihtoehto: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Student newStudent = new Student();

                    Console.Write("Syötä oppilaan nimi: ");
                    newStudent.Name = Console.ReadLine();

                    Console.Write("Syötä oppilaan ikä: ");
                    newStudent.Age = int.Parse(Console.ReadLine());

                    Console.Write("Syötä opiskelijan opiskelupaikka: ");
                    newStudent.School = Console.ReadLine();

                    students.Add(newStudent);
                    Console.WriteLine("Oppilas lisätty!");
                }
                else if (choice == "2")
                {
                    Console.Write("Syötä tiedoston nimi: ");
                    string filename = Console.ReadLine();

                    try
                    {
                        string json = JsonConvert.SerializeObject(students);

                        using (StreamWriter writer = new StreamWriter(filename))
                        {
                            writer.Write(json);
                        }

                        Console.WriteLine("Oppilas tallennettiin tiedostoon!");
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("Virhe oppilasta ei tallennettu tiedostoon: " + e.Message);
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Syötä tiedoston nimi: ");
                    string filename = Console.ReadLine();

                    try
                    {
                        string json = "";

                        using (StreamReader reader = new StreamReader(filename))
                        {
                            json = reader.ReadToEnd();
                        }

                        students = JsonConvert.DeserializeObject<List<Student>>(json);

                        Console.WriteLine("Oppilaat ladattu tiedostosa!");
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("Virhe Oppilaita ei voitu ladata tiedostosta..: " + e.Message);
                    }
                    catch (Newtonsoft.Json.JsonException e)
                    {
                        Console.WriteLine("Oppilasta ei voitu ladata tiedostosta: " + e.Message);
                    }
                }
                else if (choice == "4")
                {
                    Console.Write("Syötä poistettavan oppilaan nimi: ");
                    string nameToRemove = Console.ReadLine();

                    Student studentToRemove = students.Find(s => s.Name == nameToRemove);

                    if (studentToRemove != null)
                    {
                        students.Remove(studentToRemove);
                        Console.WriteLine("Oppilas poistettu!");
                    }
                    else
                    {
                        Console.WriteLine("Oppilasta ei löydetty!");
                    }
                }
                else if (choice == "5")
                {
                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                    }
                }
                else if (choice == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("virheellinen vaihtoehto, yritä uudelleen!");
                }

                Console.WriteLine();
            }
        }
    }
}
