// See https://aka.ms/new-console-template for more information

string str = "He is driving a red car.";

Console.WriteLine(str.Replace("red", "").Replace("  ", " "));

//user input their name and greet them by name.
string myName;
Console.WriteLine("What is your name?");
myName = Console.ReadLine();
Console.WriteLine("Hello " + myName + "!");

//program to calculate the area of a rectangle.

string inputLength;
string inputWidth;
int area;

Console.WriteLine("What is the length of the rectangle?");
inputLength = Console.ReadLine();

Console.WriteLine("What is the width of the rectangle?");
inputWidth = Console.ReadLine();

//converting string to intiger and calculate the area of rectangle.
area = Int32.Parse(inputLength) * Int32.Parse(inputWidth);
Console.WriteLine("The area of the rectangle is: " + area);

//program that asks a user for the number of miles they have driven and the
//amount of gas they’ve consumed.

Console.WriteLine("How many miles did you drive on your trip?");
string mi = Console.ReadLine();
int miles = Int32.Parse(mi);

Console.WriteLine("How many gallons of gas did you use?");
string gal = Console.ReadLine();
int gallons = Int32.Parse(gal);

int mpg = miles / gallons;
Console.WriteLine("The MPG for the trip was: " + mpg);

string alice = @"Alice was beginning to get very tired of sitting by her sister on the
   bank, and of having nothing to do: once or twice she had peeped into the
   book her sister was reading, but it had no pictures or conversations in
   it, 'and what is the use of a book,' thought Alice 'without pictures or
   conversation?'";

Console.WriteLine(alice);
Console.WriteLine("What sentence would you like to look for in the sentence above?");
string searchTerm = Console.ReadLine();
string compSearchTerm = searchTerm.ToLower();
string compAlice = alice.ToLower();

if (compAlice.IndexOf(compSearchTerm, 0) != -1)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}

int lengthOfString = compSearchTerm.Length;
Console.WriteLine("The string length is : " + lengthOfString);