using System;

class PotionManager{
  public static void usePotion(int potionnum)
  {
    //Healing Potion
    if (potionnum == 1)
    {
      PlayerManager.health = PlayerManager.health + 40;
      PotionManager.healthPot = PotionManager.healthPot - 1;
      Console.WriteLine("One Health Potion Has Been Used.               "+PotionManager.healthPot.ToString()+" Remaining");
    }
    
  }
  public static void addPotion(int potionNum, bool silentAdd){
    if (potionNum == 1 && !silentAdd)
    {
      PotionManager.healthPot = PotionManager.healthPot + 1;
      Console.WriteLine("One Health Potion Has Been Added To Your Inventory. "+PotionManager.healthPot+" Remaining");
    }
    if (potionNum == 1 && silentAdd){
      PotionManager.healthPot = PotionManager.healthPot + 1;
    }
  }
  public static int healthPot = 0;
  public static int poisonPot = 0;
}