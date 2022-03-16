using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    bool redo = true;
    while(redo){
    Console.WriteLine ("Enter Player Name:");
    Program.playerName = Console.ReadLine();
    Console.WriteLine("Selected Username: "+Program.playerName);
    Console.WriteLine("Do You Wish To Use This Username? y/n");
    if (Console.ReadLine().Contains("n"))
    {
      redo = true;
    }
      else{
        redo = false;
      }
    }
    Console.WriteLine("A Guild Has Offered To Take You On A Quest! You Shall Go With Him At Once...");
    Console.WriteLine("You Head To The Caves And Discover A Goat! Do You Wish To Kill The Goat? (y/n)");
    if (Console.ReadLine().Contains("y")){
      Console.WriteLine("You Killed The Goat With One Swing And Got Five Coins!");
      Shop.money = Shop.money + 5;
      Console.WriteLine("Coin Amount: " + Shop.money.ToString()+"\n");
    }
    else
    {
      Console.WriteLine("You Decided Not To Kill The Goat. The Dungeon Master Then Looks At You And Sighs.");
      
      Console.WriteLine("He Then Says \"You Don't Have The Balls To Kill A Goat For Dinner? This Is Going To Be A Long Journey\" ");
    }
    Console.WriteLine("You And The Guild Wander Further Into The Cave...");
    Console.WriteLine("You Start Seeing Things In The Shadows, And Eventually See A Giant Spider!");
    Console.WriteLine("A Guild Member Yells \""+Program.playerName+"Watch Out! That Spider Is Poisonous! \"");
    Console.WriteLine("Would You Like To Swing At The Spider? (y/n)");
    
    if (Console.ReadLine().Contains("y"))
    {
      int dice1 = Int32.Parse(RandomNum(1));
      Console.WriteLine("You Roll A Dice, Your Number Is: "+dice1);
      if (dice1 < 3)
      {
        Console.WriteLine("You Swing And Miss!");
      }
      if (dice1 < 6 && dice1 > 3)
      {
        Console.WriteLine("You Swing And Hit It!");
        Console.WriteLine("The Spider Flees! It Runs Into A Tunnel Somewhere Beyond Your Sight.");
      }
      if (dice1 >= 6)
      {
        Console.WriteLine("You Swing And Kill It In A Single Hit!");
        Console.WriteLine("You Check Out The Corpse Of The Spider And Find 10 Coins In The Stomach.");
        Shop.money = Shop.money + 10;
        Console.WriteLine("Amount Of Coins: "+Shop.money.ToString());
      }
    }
    else {
      Console.WriteLine("The Spider Swings At You! It Attacks Your Arm And Fractures It.");
    }
    
  }
  private static Random random = new Random();
  public static string RandomNum(int length)
  {
    const string chars = "1234567890";
    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
  }
  public static string playerName;
}