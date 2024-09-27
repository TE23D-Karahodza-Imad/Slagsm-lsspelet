int hpBlue = 100;
int hpRed = 100;
string playerBlue;
string playerRed;

Random random = new Random();



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


while (hpBlue > 0 || hpRed > 0)
{
    //Player blue punching
    int damage1 = random.Next(10, 30);
    Console.WriteLine("It is Blues turn to punch so.. - press enter.");
    Console.ReadLine();
    hpRed -= damage1;
    Console.WriteLine("Reds HP left:" + hpRed);
    //
    if (hpRed <= 0)
    {
        Console.WriteLine("Red has died and Blue won the game.. Congratulations!");
        Console.ReadLine();
        break;
    }

    //Player red punching
    int damage2 = random.Next(10, 30);
    Console.WriteLine("It is Reds turn to slay Blue! - press enter.");
    Console.ReadLine();
    hpBlue -= damage2;
    Console.WriteLine("Blues HP left:" + hpBlue);

    if (hpBlue <= 0)
    {
        Console.WriteLine("Blue has died and Red won the game.. Congratulations!");
        Console.ReadLine();
        break;
    }


}










//------------------------------------//
Console.ReadLine();