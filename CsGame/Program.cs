// See https://aka.ms/new-console-template for more information
using CsGame.Bindings;

Console.WriteLine("Hello, World!");

Glfw.glfwInit();
Glfw.glfwWindowHint(Glfw.GLFW_CONTEXT_VERSION_MAJOR, 4);
Glfw.glfwWindowHint(Glfw.GLFW_CONTEXT_VERSION_MINOR, 6);
Glfw.glfwWindowHint(Glfw.GLFW_OPENGL_CORE_PROFILE, Glfw.GLFW_TRUE);

unsafe
{
    var window = Glfw.glfwCreateWindow(800, 600, "cool cat", null, null);
    if(window == null)
    {
        throw new InvalidOperationException("FEEEL");
    }
    Glfw.glfwMakeContextCurrent(window);
}

Console.WriteLine("hej");