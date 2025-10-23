//Task 10
//c
const int NumberOfNumbers = 4;

var numbers = new List<int>();

for (var i = 0; i < NumberOfNumbers; i++)
{
    Console.WriteLine($"Enter the number {i + 1}");
    var number = int.Parse(Console.ReadLine());

    numbers.Add(number);
}

var sum = 0;

for (var i = 0; i < numbers.Count; i++)
    sum += numbers[i];

var average = 1.0 * sum / numbers.Count;
Console.WriteLine($"The sum is {sum} and the average is {average}");


//b
//var numbers = new int[4];

//for (var i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine($"Enter the number {i+1}");
//    var number = int.Parse(Console.ReadLine());

//    numbers[i] = number;
//}

//var sum = 0;

//for (var i = 0; i < numbers.Length; i++)
//    sum += numbers[i];

//var average = 1.0 * sum / numbers.Length;
//Console.WriteLine($"The sum is {sum} and the average is {average}");

//a
//Console.WriteLine("Enter the first number");
//var a = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the second number");
//var b = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the third number");
//var c = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the fourth number");
//var d = int.Parse(Console.ReadLine());

//var sum = a + b + c + d;
//var average = sum / 4.0;

//Console.WriteLine($"The sum is {sum} and the average is {average}");

//Task 8
//Console.WriteLine("What is length of side a?");
//var a = double.Parse(Console.ReadLine());

//Console.WriteLine("What is length of side b?");
//var b = double.Parse(Console.ReadLine());

//Console.WriteLine("What is length of side c?");
//var c = double.Parse(Console.ReadLine());

//var perimeter = a + b + c;

//var s = perimeter / 2;
//var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

//Console.WriteLine($"The perimeter is {perimeter} and the area is {area}");

//Task 5
//Console.WriteLine("What is the radius of the circle?");

//var radius = double.Parse(Console.ReadLine());

//var area = Math.PI * radius * radius;

//Console.WriteLine($"The area is {area}");

//Task 4
//Console.WriteLine("What is your name?");

//string name = Console.ReadLine();

//Console.WriteLine($"Hello {name}");

//Task 3
//string name = "Marcin";
//a
//Console.Write("Hello ");
//Console.Write(name);

//b  don't use concatenation
//Console.Write("Hello " + name);

//c avoid string.Format
//Console.WriteLine(string.Format("Hello {0}", name));

//d
//Console.WriteLine($"Hello {name}");

//Task 2
//string name = "Marcin";

//Console.WriteLine(name);

//Task 1
//Console.WriteLine("Hello");
