using System;

namespace OpenUI
{
    public class ViewPort
    {   
        public ViewPort(int width, int height, string title)
        {
            WinAPI.MessageBox(IntPtr.Zero, "Hello, World!", title, 0);
        }
    }
}
