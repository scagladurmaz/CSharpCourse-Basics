//string student1 = "Çağla";
//string student2 = "Özgü";
//string student3 = "Damla";

//string[] students = new string[3];
//students[0] = "Çağla";
//students[1] = "Özgü";
//students[2] = "Damla";


//string[] students2 = {"Çağla","Özgü","Damla"};
//students2[3] = "Sinop";


////bir arrayi gezerken kullanıyoruz
//foreach (var student in students)
//{
//    Console.WriteLine(student);
//}

string[,] regions = new string[3, 3]
{
    {"İstanbul","İzmit","Balıkesir"},
    {"Ankara","Konya","Kırıkkale"},
    {"Sinop","Ordu","Tokat"}
};

for (int i= 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j= 0; j <= regions.GetUpperBound(1) ; j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("********");
}


Console.WriteLine();
Console.ReadLine();