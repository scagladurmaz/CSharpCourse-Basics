// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Value Types
int number1 = 2147483647;
long number2 = 9223372036854775807;
short number3 = 32767;
byte number4 = 255;
bool condition = false;
char character = 'A';
string City = "Ankara";
double number5 = 10.4;
decimal number6 = 10.4M;
var number7 = 10;
number7 = 'A';



Console.WriteLine("Number1 is " + number1);
Console.WriteLine("Number2 is " + number2);
Console.WriteLine("Number3 is " + number3);
Console.WriteLine("Number4 is " + number4);
Console.WriteLine("Number5 is " + number5);
Console.WriteLine("Number7 is " + number7);
Console.WriteLine("Character is : " + character);
Console.WriteLine((int)Days.Friday);
Console.ReadLine();



enum Days
{
    Monday,Tuesday, Wednesday,Thursday,Friday, Saturday,Sunday
}


/* int 32 bit
 * long 64 bit
 * short 16 bit 
 * byte 0-255 arasında (değerler dahil) veri tutan bir değişken
 * implicit divertion (decimalin tam sayı değeri alması
 * enum -> magic string
*/