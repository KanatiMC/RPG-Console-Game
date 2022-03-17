using System;
using System.Linq;
using System.Threading.Tasks;

class Program {
  public static void Main (string[] args) {
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Title = "Console RPG Game";
    while(Program.usernameYN){
    Console.WriteLine ("Enter Player Name:");
    Program.playerName = Console.ReadLine();
    Console.WriteLine("Selected Username: "+Program.playerName);
    Console.WriteLine("Do You Wish To Use This Username? y/n");
    Program.string1 = Console.ReadLine();
      if (!Program.string1.Contains("n") || !Program.string1.Contains("y")){
      Console.WriteLine("Syntax Error: Wrong Character.");
      Program.usernameYN = true;
    }
      else{
    if (Program.string1.Contains("n"))
    {
      Program.usernameYN = true;
    }
      else{
        Program.usernameYN = false;
      }
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
    Console.WriteLine("A Guild Member Yells \""+Program.playerName+" Watch Out! That Spider Is Poisonous! \"");
    Console.WriteLine("Would You Like To Swing At The Spider? (y/n)");
    if (Console.ReadLine().Contains("y"))
    {
      int dice1 = MyUtils.RandomIntNum(1);
      Console.WriteLine("You Roll A Dice, Your Number Is: "+dice1);
      if (dice1 <= 3)
      {
        Console.WriteLine("You Swing And Miss!");
        Console.WriteLine("The Spider Attacks You And You Lose 6 Health Points!");
        Console.WriteLine("You Have: "+PlayerManager.health.ToString() + " Health Points Left");
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
      Console.WriteLine("You've Lost 5 Health Points!");
      PlayerManager.health = PlayerManager.health - 5;
      Console.WriteLine("You Have: "+PlayerManager.health.ToString() + "Health Points Left");
    }
    Console.WriteLine("\n\n");
    Console.WriteLine("As You And Your Guild Wander Further Into The Cave, You Light A Torch And Notice That There's Writing On The Walls");
    Console.WriteLine("You Begin To Translate The Scripture On The Walls, And It Reads \"Death Is Among Us All, Beware! Goblins Ahead!\"");
    Console.WriteLine("Suddenly, Goblins Appear! You Decide To Take Them On, But You're Surrounded! Do You Wish To Attack? (y/n)");
    if (Console.ReadLine().Contains("n")){
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("The Goblins Attack You And Kill You!");
        Console.WriteLine(" /$$$$$$$$ /$$                       /$$$$$$$$                 /$$");
        Console.WriteLine("|__  $$__/| $$                      | $$_____/                | $$");
        Console.WriteLine("   | $$   | $$$$$$$   /$$$$$$       | $$       /$$$$$$$   /$$$$$$$");
        Console.WriteLine("   | $$   | $$__  $$ /$$__  $$      | $$$$$   | $$__  $$ /$$__  $$");
        Console.WriteLine("   | $$   | $$  "+"\u005c"+" $$| $$$$$$$$      | $$__/   | $$  "+"\u005c"+" $$| $$  | $$");
        Console.WriteLine("   | $$   | $$  | $$| $$_____/      | $$      | $$  | $$| $$  | $$");
        Console.WriteLine("   | $$   | $$  | $$|  $$$$$$$      | $$$$$$$$| $$  | $$|  $$$$$$$");
        Console.WriteLine("   |__/   |__/  |__/ "+"\u005c"+"_______/      |________/|__/  |__/ "+"\u005c"+"_______/");
       Console.ReadLine();
      }
    else{
      int dice1 = MyUtils.RandomIntNum(1);
      Console.WriteLine("You Roll A Dice, Your Number Is: "+dice1);
      if (dice1 <= 2)
      {
        Console.WriteLine("You Swing And Miss!");
        Console.WriteLine("The Group Of Goblins Attacks You And You Lose 12 Health Points!");
        PlayerManager.health = PlayerManager.health - 12;
        Console.WriteLine("You Have: "+PlayerManager.health.ToString() + " Health Points Left");
      }
      if (dice1 < 6 && dice1 > 2)
      {
        Console.WriteLine("You Swing And Hit It!");
        Console.WriteLine("The Goblins Split And You Now Face One. It Attacks! You Lift Up Your Shield And Begin To Defend!\n\n");
        int dice2 = MyUtils.RandomIntNum(1);
        Console.WriteLine("You Roll A Dice, Your Number Is: "+dice2);
        if (dice2 <= 4)
        {
          Console.WriteLine("You Dont Lift Up Your Shield In Time,  And And The Goblin Damages You!");
          Console.WriteLine("The Goblin Attacks You And You Lose 10 Health Points!");
          PlayerManager.health = PlayerManager.health - 10;
          Console.WriteLine("You Have: "+PlayerManager.health.ToString() + " Health Points Left");
        }
        if (dice2 >= 5)
        {
          Console.WriteLine("You Lift Up Your Shield And Block! You Then Swing At The Goblin And Take Of It's Head.");
          Console.WriteLine("You've Been Awarded 15 Coins.");
        }
      }
      if (dice1 >= 6)
      {
        Console.WriteLine("You Swing And Slash, Killing Most Of The Goblins. The Others Flee In Fear!");
        Console.WriteLine("You Check Out The Satchels Of The Goblins And Find 15 Coins.");
        Shop.money = Shop.money + 15;
        Console.WriteLine("Amount Of Coins: "+Shop.money.ToString());
      }
      Console.WriteLine("\n\n");
      Console.WriteLine("One Of Your Guild Members Notices A Door, And Calls For The Group To Come Check It Out.");
      Console.WriteLine("When Checking It Out, You Notice There's A Potion On The Ground. A Health Potion!");
      Console.WriteLine("Do You Wish To Use This Potion? Not Using It Will Put It In Your Inventory. (y/n)");
      if (Console.ReadLine().Contains("y"))
      {
        PotionManager.addPotion(1, true);
        PotionManager.usePotion(1);
      }
      else {
        Console.WriteLine("You Decided Not To Use Your Health Pot.");
        PotionManager.addPotion(1, false);
      }
      Console.ReadLine();
    }
  }
  public static bool usernameYN = true;
  public static string string1;
  public static string playerName;
}