using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            IPerson person = new Customer();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySQLCustomerDal()
            };


            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }



            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManagaer customerManagaer = new CustomerManagaer();
            customerManagaer.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Çağla",
                LastName = "Durmaz",
                Address = "Sinop"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Özgü",
                LastName = "Durmaz",
                Department = "Performing Arts"
            };

            Worker worker = new Worker
            {
                Id = 1,
                FirstName = "Özgü",
                LastName = "Durmaz",
                Department = "Performing Arts"
            };

            manager.Add(customer);
            manager.Add(student);
            manager.Add(worker);
        }
    }

    //Interface'ler ve Abstract'lar hiçbir zaman newlenemez!!! Tek başına bir anlamı yuktur.
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

