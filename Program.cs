using System;
using System.Threading;

namespace beepy2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //Здравствуй
      Console.Beep(587, 300);
      Console.Beep(587, 300);
      Console.Beep(587, 300);
      Console.Beep(523, 300);
      Console.Beep(493, 300);
      Console.Beep(523, 300);
      Console.Beep(440, 300);
      Thread.Sleep(700);

      Console.Beep(587, 300);
      Console.Beep(587, 300);
      Console.Beep(587, 300);
      Console.Beep(523, 300);
      Console.Beep(493, 300);
      Console.Beep(523, 300);
      Console.Beep(659, 300);
      Thread.Sleep(700);

      Console.Beep(587, 300);
      Console.Beep(587, 300);
      Console.Beep(587, 300);
      Console.Beep(523, 300);
      Console.Beep(493, 300);
      Console.Beep(523, 300);
      Console.Beep(440, 300);
      Thread.Sleep(700);



      Console.Beep(587, 300);
      Console.Beep(587, 300);
      Console.Beep(587, 300);
      Console.Beep(523, 300);
      Console.Beep(493, 300);
      Console.Beep(523, 300);
      Console.Beep(659, 300);
      Thread.Sleep(700);
      //Эх
      Console.Beep(659, 300);
      Console.Beep(523, 300);
      Console.Beep(440, 300);
      Console.Beep(349, 500);
      Console.Beep(440, 500);
      Console.Beep(523, 500);
      Thread.Sleep(700);
    }
  }
}
