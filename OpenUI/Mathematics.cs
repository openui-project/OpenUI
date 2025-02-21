namespace OpenUI.Mathematics {
  public class Vector2 {
    public float X;
    public float Y;
    
    public Vector2(float x, float y) {
      X = x;
      Y = y;
    }

    public static readonly Vector2 Zero = new Vector2(0, 0);
    
    public override string ToString() {
      return $"({X}, {Y})";
    }
  }
}
