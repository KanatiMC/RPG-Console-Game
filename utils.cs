using System;
using System.Linq;

class MyUtils {
    private static Random random = new Random();
  public static string RandomStringNum(int length)
  {
    const string chars = "1234567890";
    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
  }
  public static int RandomIntNum(int length)
  {
    const string chars = "1234567890";
    return int.Parse(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
  }
  public static string RandomString(int length)
  {
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
  }
}