using System;
using OpenUI.Mathematics;

public static class Program {
  public static void Main(string[] args) {
    var pos = new Vector2(0, 0);
    int VectorByteSize = Vector2.SizeInBytes;
    Console.WriteLine(VectorByteSize);
    Console.WriteLine(pos);
    Console.WriteLine(pos.GetHashCode());
  }
}
