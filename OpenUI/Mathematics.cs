using System;
using System.Runtime.InteropServices;

namespace OpenUI.Mathematics {
  public unsafe class Vector2 {
    public float X, Y;

    public Vector2(float x, float y) {
      X = x;
      Y = y;
    }

    public static readonly int SizeInBytes = Marshal.SizeOf<Vector2>();

    public override string ToString() => $"({X}, {Y})";
  }
}
