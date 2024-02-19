
//FOR
//bu i değişkenini sadece bu blokta kullanabiliriz
//for (int i = 2; i <= 100; i+=2)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Finished!");

//WHILE
//int number = 100;
//while(number>= 0)
//{
//    Console.WriteLine(number);
//    number--;
//}

//Console.WriteLine("Now number is {0}",number);

//DO-WHILE
//int number = 10;
//do
//{
//    Console.WriteLine(number);
//    number--;
//} while (number>=0);

//FOREACH
//string[] students = {"Çağla", "Özgü", "Damla"};

//foreach (var student in students)
//{
//    //db'den tablo çektiğimizde elemanları gezmek için kullanırız çoğunlukla -IEnumaable-
//    //elelmanları bu döngünün içinde değiştiremeyiz
//    Console.WriteLine(student); 
//}

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number-1 ; i++)
    {
        if (number % i == 0)
        {
            result = false;
        }    
    }return result;
}

Console.ReadLine();
