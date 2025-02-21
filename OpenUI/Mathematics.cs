using System;

namespace OpenUI.Mathematics {
  public unsafe class Vector2 {
    public float X, Y;

    public Vector2(float x, float y) {
      X = x;
      Y = y;
    }

    public readonly float Length => Math.Sqrt(X * X + Y * Y);

    public static readonly int SizeInBytes = sizeof(Vector2);

    public override string ToString() => $"({X}, {Y})";
  }
}
