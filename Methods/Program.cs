

//Add();
//var result = Add2(4);

//int number1 = 20;
//int number2 = 100;
//var result2 = Add3(ref number1, number2);

////out keywordunde referans veerilecek tipin önceden set edilmesine gerek yok
 
//Console.WriteLine(result2);
//Console.WriteLine(number1);

Console.WriteLine(Multiply(2, 4)); 
Console.WriteLine(Multiply2(3, 5, 9));

Console.WriteLine(Add4(1,2,3,4,5,6));
Console.ReadLine();


static void Add()
{
    Console.WriteLine("Added!!!!!");
}

//void -> bir işlem yap demek git bir yere bi şey yaz


// default değerler metodun son kısmında verilir. birden fazla metod olduğunda
static int Add2(int x, int number1=20,int number2=30)
{
    var result = number1 + number2;
    return result;
}


//ref keyword değer tiplerin refereans olarak çağrılmasını sağlar
static int Add3(ref int number1,int number2)
{
    number1 = 30;
    return number1 + number2;
}

static int Multiply(int number1, int number2)
{
    return number1 * number2;
}

static int Multiply2(int number1,int number2,int number3)
{
    return number1 * number2 * number3;
}


//PARAMS  ile birden fazla parametreyi array notasyonu kullanarak işlemi gerçekleştirdik
static int Add4(params int[] numbers)
{
    return numbers.Sum();
}