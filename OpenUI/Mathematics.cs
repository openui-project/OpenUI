using System.Runtime.CompilerServices;

namespace OpenUI.Mathematics {
  public unsafe class Vector2 {
    public float X;
    public float Y;

    public Vector2(float x, float y) {
      X = x;
      Y = y;
    }

    /// <summary>
    /// Defines the size of the Vector2 struct in bytes.
    /// </summary>
    public static readonly int SizeInBytes = sizeof(Vector2);

    public override string ToString() {
      return $"({X}, {Y})";
    }
  }
}
