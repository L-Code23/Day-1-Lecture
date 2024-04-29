// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// This line only

/* This comment
 * Goes on
 * Multiple lines
 */


// Creatig Variables

int myAge;
myAge = 40;
int myAge2 = 40;

//Constant
const decimal TAXRATE = 0.06m;

//Getting input from user
Console.WriteLine("Enter the radius");
//string entry = Console.ReadLine();
//int result = int.Parse(entry);
int result = int.Parse(Console.ReadLine()); // this is how you combine the two lines above

//double area = 3.1415926 * result * result;//C# Math Class you can add Math.PI
double area = Math.PI * result * result;

Console.WriteLine(area);

//Math Section
double math1 = 1 + 2;
Console.WriteLine(math1);
double math2 = 1 - 2;
Console.WriteLine(math2);
double math3 = 1 * 2;
Console.WriteLine(math3);
double math4 = 1 / 2;
Console.WriteLine(math4);
double math5 = 1 % 2;
Console.WriteLine(math5);
Console.WriteLine(1 % 2 == 0);

//increment
int x = 1;
Console.WriteLine(x);
x++;//x=x+1
Console.WriteLine(x);
x--;
Console.WriteLine(x);

//Assigning variable
int y = 5;

y += 3; //y = y + 3
Console.WriteLine(y);
y -= 4;
Console.WriteLine(y);
y *= 2;
Console.WriteLine(y);
y /= 4;
Console.WriteLine(y);
y %= 1;
Console.WriteLine(y);

string name = Ramsey;
