using System.Security.Cryptography;

int hp1 = 100;
int hp2 = 100;
string playerBlue;
string playerRed;

Random generator = new Random();

//------------------------------------//
Console.WriteLine("Welcome to my game where you will fight alongside another player");
Console.WriteLine("Please, two of you should type in your names:");
//--//
Console.Write("Player Blue: ");
playerBlue = Console.ReadLine();
//--//
Console.Write("Player Red: ");
playerRed = Console.ReadLine(); 
//--//
for (int i = 1; i <= 10; i++)
{
    double result = Math.Pow(5,i);
    Console.WriteLine(result);
}









//------------------------------------//
Console.ReadLine();