using System;
using OpenUI.Mathematics;

public static class Program {
  public static void Main(string[] args) {
    var pos = new Vector2(0, 0);
    pos.X = sizeof(int);
    Console.WriteLine(pos);
  }
}
