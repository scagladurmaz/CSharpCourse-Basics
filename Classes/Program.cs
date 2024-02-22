namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Sinop";
            customer.Id = 1;
            customer.FirstName = "Çağla";
            customer.LastName = "Durmaz";


            Customer customer2 = new Customer
            {
                Id = 2, City = "Trabzon", FirstName = "Özgü", LastName="Durmaz"
            };


            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }
}

