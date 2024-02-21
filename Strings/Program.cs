//string city = "Ankara";
////Console.WriteLine(city[0]);

//foreach(var item in city)
//{
//    Console.WriteLine(item);
//}

//string city2 = "İstanbul";
//string result = city + city2;

//Console.WriteLine(String.Format("{0} {1}", city,city2));


string sentence = "My name is Çağla";


var result = sentence.Length;
var result2 = sentence.Clone();

sentence = "This is the way!";



bool result3 = sentence.EndsWith("a");
bool result4 = sentence.StartsWith("My name");

//bulamadığımızda -1 döndürür mesela 'name'
var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf("");
//Saymaya sONDAN BAŞLAR
var result7 = sentence.LastIndexOf("");

var result8 = sentence.Insert(0, "Say, ");
var result9 = sentence.Substring(3,4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ",">");
var result13 = sentence.Remove(5,3);


Console.WriteLine(result12);

Console.ReadLine();