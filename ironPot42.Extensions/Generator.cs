using System;
using System.Threading.Tasks;

namespace ironPot42.Extensions
{
  public static class Generator
  {
    public static Task<string> MongoObjectId()
    {
      Int64 val = 0;
      var st = new DateTime(1970, 1, 1);
      TimeSpan t = (DateTime.Now.ToUniversalTime() - st);
      val = (Int64)(t.TotalMilliseconds + 0.5);
      char[] startVal = val.ToString("X").ToCharArray();
      string timestamp = "";
      for (int i = 0; i < 10; i++)
      {
        timestamp += startVal[i];
      }
      int num = 0;
      Random rand = new Random();
      for (int i = 0; i < 14; i++)
      {
        num = rand.Next(1, 16);
        timestamp += num.ToString("X");
      }
      return Task.FromResult(timestamp.ToLower());
    }
  }
}
