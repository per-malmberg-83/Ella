using System.Runtime.InteropServices;

namespace CsGame.Bindings
{
    public static class GL
    {
        [DllImport("opengl32.dll")]
        public static extern void glClearColor(float red, float green, float blue, float alpha);
    }
}
