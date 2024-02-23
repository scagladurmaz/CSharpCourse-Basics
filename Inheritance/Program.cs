namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Çağla"}, new Student{FirstName="Özgü"}, new Person{FirstName="Damla"} 
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    //Bir nesneyi sadece bir kere inheritance yapabilirsiniz ama birden fazla implenetasyon(interface olacak yani) gerçekleştirebilirsiniz.
    //Inheritance(classlardan) önce yazılır sonrasında kaç tane interface varsa yazabiliriz.
    //classların tek başına bir anlamı var ancak interface'in tek başına bir anlamı yoktur.

    //Senaryoya göre class veya interface implementasyonunu seçeceğiz.
    //Amma zorunlu bir class(inheritance) dahilasyonu olduğunu düşünmüyorsak interface'lere yönelebiliriz

    class Customer:Person 
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

}