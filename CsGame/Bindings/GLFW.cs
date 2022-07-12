using System.Runtime.InteropServices;
public unsafe static class Glfw {
	public const int GLFW_VERSION_MAJOR = 3;
	public const int GLFW_VERSION_MINOR = 3;
	public const int GLFW_VERSION_REVISION = 7;
	public const int GLFW_TRUE = 1;
	public const int GLFW_FALSE = 0;
	public const int GLFW_RELEASE = 0;
	public const int GLFW_PRESS = 1;
	public const int GLFW_REPEAT = 2;
	public const int GLFW_HAT_CENTERED = 0;
	public const int GLFW_HAT_UP = 1;
	public const int GLFW_HAT_RIGHT = 2;
	public const int GLFW_HAT_DOWN = 4;
	public const int GLFW_HAT_LEFT = 8;
	public const int GLFW_HAT_RIGHT_UP = (GLFW_HAT_RIGHT|GLFW_HAT_UP);
	public const int GLFW_HAT_RIGHT_DOWN = (GLFW_HAT_RIGHT|GLFW_HAT_DOWN);
	public const int GLFW_HAT_LEFT_UP = (GLFW_HAT_LEFT|GLFW_HAT_UP);
	public const int GLFW_HAT_LEFT_DOWN = (GLFW_HAT_LEFT|GLFW_HAT_DOWN);
	public const int GLFW_KEY_UNKNOWN = -1;
	public const int GLFW_KEY_SPACE = 32;
	public const int GLFW_KEY_APOSTROPHE = 39;
	public const int GLFW_KEY_COMMA = 44;
	public const int GLFW_KEY_MINUS = 45;
	public const int GLFW_KEY_PERIOD = 46;
	public const int GLFW_KEY_SLASH = 47;
	public const int GLFW_KEY_0 = 48;
	public const int GLFW_KEY_1 = 49;
	public const int GLFW_KEY_2 = 50;
	public const int GLFW_KEY_3 = 51;
	public const int GLFW_KEY_4 = 52;
	public const int GLFW_KEY_5 = 53;
	public const int GLFW_KEY_6 = 54;
	public const int GLFW_KEY_7 = 55;
	public const int GLFW_KEY_8 = 56;
	public const int GLFW_KEY_9 = 57;
	public const int GLFW_KEY_SEMICOLON = 59;
	public const int GLFW_KEY_EQUAL = 61;
	public const int GLFW_KEY_A = 65;
	public const int GLFW_KEY_B = 66;
	public const int GLFW_KEY_C = 67;
	public const int GLFW_KEY_D = 68;
	public const int GLFW_KEY_E = 69;
	public const int GLFW_KEY_F = 70;
	public const int GLFW_KEY_G = 71;
	public const int GLFW_KEY_H = 72;
	public const int GLFW_KEY_I = 73;
	public const int GLFW_KEY_J = 74;
	public const int GLFW_KEY_K = 75;
	public const int GLFW_KEY_L = 76;
	public const int GLFW_KEY_M = 77;
	public const int GLFW_KEY_N = 78;
	public const int GLFW_KEY_O = 79;
	public const int GLFW_KEY_P = 80;
	public const int GLFW_KEY_Q = 81;
	public const int GLFW_KEY_R = 82;
	public const int GLFW_KEY_S = 83;
	public const int GLFW_KEY_T = 84;
	public const int GLFW_KEY_U = 85;
	public const int GLFW_KEY_V = 86;
	public const int GLFW_KEY_W = 87;
	public const int GLFW_KEY_X = 88;
	public const int GLFW_KEY_Y = 89;
	public const int GLFW_KEY_Z = 90;
	public const int GLFW_KEY_LEFT_BRACKET = 91;
	public const int GLFW_KEY_BACKSLASH = 92;
	public const int GLFW_KEY_RIGHT_BRACKET = 93;
	public const int GLFW_KEY_GRAVE_ACCENT = 96;
	public const int GLFW_KEY_WORLD_1 = 161;
	public const int GLFW_KEY_WORLD_2 = 162;
	public const int GLFW_KEY_ESCAPE = 256;
	public const int GLFW_KEY_ENTER = 257;
	public const int GLFW_KEY_TAB = 258;
	public const int GLFW_KEY_BACKSPACE = 259;
	public const int GLFW_KEY_INSERT = 260;
	public const int GLFW_KEY_DELETE = 261;
	public const int GLFW_KEY_RIGHT = 262;
	public const int GLFW_KEY_LEFT = 263;
	public const int GLFW_KEY_DOWN = 264;
	public const int GLFW_KEY_UP = 265;
	public const int GLFW_KEY_PAGE_UP = 266;
	public const int GLFW_KEY_PAGE_DOWN = 267;
	public const int GLFW_KEY_HOME = 268;
	public const int GLFW_KEY_END = 269;
	public const int GLFW_KEY_CAPS_LOCK = 280;
	public const int GLFW_KEY_SCROLL_LOCK = 281;
	public const int GLFW_KEY_NUM_LOCK = 282;
	public const int GLFW_KEY_PRINT_SCREEN = 283;
	public const int GLFW_KEY_PAUSE = 284;
	public const int GLFW_KEY_F1 = 290;
	public const int GLFW_KEY_F2 = 291;
	public const int GLFW_KEY_F3 = 292;
	public const int GLFW_KEY_F4 = 293;
	public const int GLFW_KEY_F5 = 294;
	public const int GLFW_KEY_F6 = 295;
	public const int GLFW_KEY_F7 = 296;
	public const int GLFW_KEY_F8 = 297;
	public const int GLFW_KEY_F9 = 298;
	public const int GLFW_KEY_F10 = 299;
	public const int GLFW_KEY_F11 = 300;
	public const int GLFW_KEY_F12 = 301;
	public const int GLFW_KEY_F13 = 302;
	public const int GLFW_KEY_F14 = 303;
	public const int GLFW_KEY_F15 = 304;
	public const int GLFW_KEY_F16 = 305;
	public const int GLFW_KEY_F17 = 306;
	public const int GLFW_KEY_F18 = 307;
	public const int GLFW_KEY_F19 = 308;
	public const int GLFW_KEY_F20 = 309;
	public const int GLFW_KEY_F21 = 310;
	public const int GLFW_KEY_F22 = 311;
	public const int GLFW_KEY_F23 = 312;
	public const int GLFW_KEY_F24 = 313;
	public const int GLFW_KEY_F25 = 314;
	public const int GLFW_KEY_KP_0 = 320;
	public const int GLFW_KEY_KP_1 = 321;
	public const int GLFW_KEY_KP_2 = 322;
	public const int GLFW_KEY_KP_3 = 323;
	public const int GLFW_KEY_KP_4 = 324;
	public const int GLFW_KEY_KP_5 = 325;
	public const int GLFW_KEY_KP_6 = 326;
	public const int GLFW_KEY_KP_7 = 327;
	public const int GLFW_KEY_KP_8 = 328;
	public const int GLFW_KEY_KP_9 = 329;
	public const int GLFW_KEY_KP_DECIMAL = 330;
	public const int GLFW_KEY_KP_DIVIDE = 331;
	public const int GLFW_KEY_KP_MULTIPLY = 332;
	public const int GLFW_KEY_KP_SUBTRACT = 333;
	public const int GLFW_KEY_KP_ADD = 334;
	public const int GLFW_KEY_KP_ENTER = 335;
	public const int GLFW_KEY_KP_EQUAL = 336;
	public const int GLFW_KEY_LEFT_SHIFT = 340;
	public const int GLFW_KEY_LEFT_CONTROL = 341;
	public const int GLFW_KEY_LEFT_ALT = 342;
	public const int GLFW_KEY_LEFT_SUPER = 343;
	public const int GLFW_KEY_RIGHT_SHIFT = 344;
	public const int GLFW_KEY_RIGHT_CONTROL = 345;
	public const int GLFW_KEY_RIGHT_ALT = 346;
	public const int GLFW_KEY_RIGHT_SUPER = 347;
	public const int GLFW_KEY_MENU = 348;
	public const int GLFW_KEY_LAST = GLFW_KEY_MENU;
	public const int GLFW_MOD_SHIFT = 0x0001;
	public const int GLFW_MOD_CONTROL = 0x0002;
	public const int GLFW_MOD_ALT = 0x0004;
	public const int GLFW_MOD_SUPER = 0x0008;
	public const int GLFW_MOD_CAPS_LOCK = 0x0010;
	public const int GLFW_MOD_NUM_LOCK = 0x0020;
	public const int GLFW_MOUSE_BUTTON_1 = 0;
	public const int GLFW_MOUSE_BUTTON_2 = 1;
	public const int GLFW_MOUSE_BUTTON_3 = 2;
	public const int GLFW_MOUSE_BUTTON_4 = 3;
	public const int GLFW_MOUSE_BUTTON_5 = 4;
	public const int GLFW_MOUSE_BUTTON_6 = 5;
	public const int GLFW_MOUSE_BUTTON_7 = 6;
	public const int GLFW_MOUSE_BUTTON_8 = 7;
	public const int GLFW_MOUSE_BUTTON_LAST = GLFW_MOUSE_BUTTON_8;
	public const int GLFW_MOUSE_BUTTON_LEFT = GLFW_MOUSE_BUTTON_1;
	public const int GLFW_MOUSE_BUTTON_RIGHT = GLFW_MOUSE_BUTTON_2;
	public const int GLFW_MOUSE_BUTTON_MIDDLE = GLFW_MOUSE_BUTTON_3;
	public const int GLFW_JOYSTICK_1 = 0;
	public const int GLFW_JOYSTICK_2 = 1;
	public const int GLFW_JOYSTICK_3 = 2;
	public const int GLFW_JOYSTICK_4 = 3;
	public const int GLFW_JOYSTICK_5 = 4;
	public const int GLFW_JOYSTICK_6 = 5;
	public const int GLFW_JOYSTICK_7 = 6;
	public const int GLFW_JOYSTICK_8 = 7;
	public const int GLFW_JOYSTICK_9 = 8;
	public const int GLFW_JOYSTICK_10 = 9;
	public const int GLFW_JOYSTICK_11 = 10;
	public const int GLFW_JOYSTICK_12 = 11;
	public const int GLFW_JOYSTICK_13 = 12;
	public const int GLFW_JOYSTICK_14 = 13;
	public const int GLFW_JOYSTICK_15 = 14;
	public const int GLFW_JOYSTICK_16 = 15;
	public const int GLFW_JOYSTICK_LAST = GLFW_JOYSTICK_16;
	public const int GLFW_GAMEPAD_BUTTON_A = 0;
	public const int GLFW_GAMEPAD_BUTTON_B = 1;
	public const int GLFW_GAMEPAD_BUTTON_X = 2;
	public const int GLFW_GAMEPAD_BUTTON_Y = 3;
	public const int GLFW_GAMEPAD_BUTTON_LEFT_BUMPER = 4;
	public const int GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER = 5;
	public const int GLFW_GAMEPAD_BUTTON_BACK = 6;
	public const int GLFW_GAMEPAD_BUTTON_START = 7;
	public const int GLFW_GAMEPAD_BUTTON_GUIDE = 8;
	public const int GLFW_GAMEPAD_BUTTON_LEFT_THUMB = 9;
	public const int GLFW_GAMEPAD_BUTTON_RIGHT_THUMB = 10;
	public const int GLFW_GAMEPAD_BUTTON_DPAD_UP = 11;
	public const int GLFW_GAMEPAD_BUTTON_DPAD_RIGHT = 12;
	public const int GLFW_GAMEPAD_BUTTON_DPAD_DOWN = 13;
	public const int GLFW_GAMEPAD_BUTTON_DPAD_LEFT = 14;
	public const int GLFW_GAMEPAD_BUTTON_LAST = GLFW_GAMEPAD_BUTTON_DPAD_LEFT;
	public const int GLFW_GAMEPAD_BUTTON_CROSS = GLFW_GAMEPAD_BUTTON_A;
	public const int GLFW_GAMEPAD_BUTTON_CIRCLE = GLFW_GAMEPAD_BUTTON_B;
	public const int GLFW_GAMEPAD_BUTTON_SQUARE = GLFW_GAMEPAD_BUTTON_X;
	public const int GLFW_GAMEPAD_BUTTON_TRIANGLE = GLFW_GAMEPAD_BUTTON_Y;
	public const int GLFW_GAMEPAD_AXIS_LEFT_X = 0;
	public const int GLFW_GAMEPAD_AXIS_LEFT_Y = 1;
	public const int GLFW_GAMEPAD_AXIS_RIGHT_X = 2;
	public const int GLFW_GAMEPAD_AXIS_RIGHT_Y = 3;
	public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER = 4;
	public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
	public const int GLFW_GAMEPAD_AXIS_LAST = GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER;
	public const int GLFW_NO_ERROR = 0;
	public const int GLFW_NOT_INITIALIZED = 0x00010001;
	public const int GLFW_NO_CURRENT_CONTEXT = 0x00010002;
	public const int GLFW_INVALID_ENUM = 0x00010003;
	public const int GLFW_INVALID_VALUE = 0x00010004;
	public const int GLFW_OUT_OF_MEMORY = 0x00010005;
	public const int GLFW_API_UNAVAILABLE = 0x00010006;
	public const int GLFW_VERSION_UNAVAILABLE = 0x00010007;
	public const int GLFW_PLATFORM_ERROR = 0x00010008;
	public const int GLFW_FORMAT_UNAVAILABLE = 0x00010009;
	public const int GLFW_NO_WINDOW_CONTEXT = 0x0001000A;
	public const int GLFW_FOCUSED = 0x00020001;
	public const int GLFW_ICONIFIED = 0x00020002;
	public const int GLFW_RESIZABLE = 0x00020003;
	public const int GLFW_VISIBLE = 0x00020004;
	public const int GLFW_DECORATED = 0x00020005;
	public const int GLFW_AUTO_ICONIFY = 0x00020006;
	public const int GLFW_FLOATING = 0x00020007;
	public const int GLFW_MAXIMIZED = 0x00020008;
	public const int GLFW_CENTER_CURSOR = 0x00020009;
	public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A;
	public const int GLFW_HOVERED = 0x0002000B;
	public const int GLFW_FOCUS_ON_SHOW = 0x0002000C;
	public const int GLFW_RED_BITS = 0x00021001;
	public const int GLFW_GREEN_BITS = 0x00021002;
	public const int GLFW_BLUE_BITS = 0x00021003;
	public const int GLFW_ALPHA_BITS = 0x00021004;
	public const int GLFW_DEPTH_BITS = 0x00021005;
	public const int GLFW_STENCIL_BITS = 0x00021006;
	public const int GLFW_ACCUM_RED_BITS = 0x00021007;
	public const int GLFW_ACCUM_GREEN_BITS = 0x00021008;
	public const int GLFW_ACCUM_BLUE_BITS = 0x00021009;
	public const int GLFW_ACCUM_ALPHA_BITS = 0x0002100A;
	public const int GLFW_AUX_BUFFERS = 0x0002100B;
	public const int GLFW_STEREO = 0x0002100C;
	public const int GLFW_SAMPLES = 0x0002100D;
	public const int GLFW_SRGB_CAPABLE = 0x0002100E;
	public const int GLFW_REFRESH_RATE = 0x0002100F;
	public const int GLFW_DOUBLEBUFFER = 0x00021010;
	public const int GLFW_CLIENT_API = 0x00022001;
	public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;
	public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;
	public const int GLFW_CONTEXT_REVISION = 0x00022004;
	public const int GLFW_CONTEXT_ROBUSTNESS = 0x00022005;
	public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00022006;
	public const int GLFW_OPENGL_DEBUG_CONTEXT = 0x00022007;
	public const int GLFW_OPENGL_PROFILE = 0x00022008;
	public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
	public const int GLFW_CONTEXT_NO_ERROR = 0x0002200A;
	public const int GLFW_CONTEXT_CREATION_API = 0x0002200B;
	public const int GLFW_SCALE_TO_MONITOR = 0x0002200C;
	public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x00023001;
	public const int GLFW_COCOA_FRAME_NAME = 0x00023002;
	public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x00023003;
	public const int GLFW_X11_CLASS_NAME = 0x00024001;
	public const int GLFW_X11_INSTANCE_NAME = 0x00024002;
	public const int GLFW_NO_API = 0;
	public const int GLFW_OPENGL_API = 0x00030001;
	public const int GLFW_OPENGL_ES_API = 0x00030002;
	public const int GLFW_NO_ROBUSTNESS = 0;
	public const int GLFW_NO_RESET_NOTIFICATION = 0x00031001;
	public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002;
	public const int GLFW_OPENGL_ANY_PROFILE = 0;
	public const int GLFW_OPENGL_CORE_PROFILE = 0x00032001;
	public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00032002;
	public const int GLFW_CURSOR = 0x00033001;
	public const int GLFW_STICKY_KEYS = 0x00033002;
	public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00033003;
	public const int GLFW_LOCK_KEY_MODS = 0x00033004;
	public const int GLFW_RAW_MOUSE_MOTION = 0x00033005;
	public const int GLFW_CURSOR_NORMAL = 0x00034001;
	public const int GLFW_CURSOR_HIDDEN = 0x00034002;
	public const int GLFW_CURSOR_DISABLED = 0x00034003;
	public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;
	public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;
	public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002;
	public const int GLFW_NATIVE_CONTEXT_API = 0x00036001;
	public const int GLFW_EGL_CONTEXT_API = 0x00036002;
	public const int GLFW_OSMESA_CONTEXT_API = 0x00036003;
	public const int GLFW_ARROW_CURSOR = 0x00036001;
	public const int GLFW_IBEAM_CURSOR = 0x00036002;
	public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;
	public const int GLFW_HAND_CURSOR = 0x00036004;
	public const int GLFW_HRESIZE_CURSOR = 0x00036005;
	public const int GLFW_VRESIZE_CURSOR = 0x00036006;
	public const int GLFW_CONNECTED = 0x00040001;
	public const int GLFW_DISCONNECTED = 0x00040002;
	public const int GLFW_JOYSTICK_HAT_BUTTONS = 0x00050001;
	public const int GLFW_COCOA_CHDIR_RESOURCES = 0x00051001;
	public const int GLFW_COCOA_MENUBAR = 0x00051002;
	public const int GLFW_DONT_CARE = -1;
public delegate void GLFWglproc ();
public delegate void GLFWvkproc ();
public struct GLFWmonitor {}
public struct GLFWwindow {}
public struct GLFWcursor {}
public delegate void  GLFWerrorfun (int error_code,  string description);
public delegate void  GLFWwindowposfun (GLFWwindow* window, int xpos, int ypos);
public delegate void  GLFWwindowsizefun (GLFWwindow* window, int width, int height);
public delegate void  GLFWwindowclosefun (GLFWwindow* window);
public delegate void  GLFWwindowrefreshfun (GLFWwindow* window);
public delegate void  GLFWwindowfocusfun (GLFWwindow* window, int focused);
public delegate void  GLFWwindowiconifyfun (GLFWwindow* window, int iconified);
public delegate void  GLFWwindowmaximizefun (GLFWwindow* window, int maximized);
public delegate void  GLFWframebuffersizefun (GLFWwindow* window, int width, int height);
public delegate void  GLFWwindowcontentscalefun (GLFWwindow* window, float xscale, float yscale);
public delegate void  GLFWmousebuttonfun (GLFWwindow* window, int button, int action, int mods);
public delegate void  GLFWcursorposfun (GLFWwindow* window, double xpos, double ypos);
public delegate void  GLFWcursorenterfun (GLFWwindow* window, int entered);
public delegate void  GLFWscrollfun (GLFWwindow* window, double xoffset, double yoffset);
public delegate void  GLFWkeyfun (GLFWwindow* window, int key, int scancode, int action, int mods);
public delegate void  GLFWcharfun (GLFWwindow* window, uint codepoint);
public delegate void  GLFWcharmodsfun (GLFWwindow* window, uint codepoint, int mods);
public delegate void  GLFWdropfun (GLFWwindow* window, int path_count,  string[] paths);
public delegate void  GLFWmonitorfun (GLFWmonitor* monitor, int evt);
public delegate void  GLFWjoystickfun (int jid, int evt);
public struct GLFWvidmode
{
/*! The width, in screen coordinates, of the video mode.
*/
int width;
/*! The height, in screen coordinates, of the video mode.
*/
int height;
/*! The bit depth of the red channel of the video mode.
*/
int redBits;
/*! The bit depth of the green channel of the video mode.
*/
int greenBits;
/*! The bit depth of the blue channel of the video mode.
*/
int blueBits;
/*! The refresh rate, in Hz, of the video mode.
*/
int refreshRate;
}
public struct GLFWgammaramp
{
/*! An array of value describing the response of the red channel.
*/
ushort* red;
/*! An array of value describing the response of the green channel.
*/
ushort* green;
/*! An array of value describing the response of the blue channel.
*/
ushort* blue;
/*! The number of elements in each array.
*/
uint size;
}
public struct GLFWimage
{
/*! The width, in pixels, of this image.
*/
int width;
/*! The height, in pixels, of this image.
*/
int height;
/*! The pixel data of this image, arranged left-to-right, top-to-bottom.
*/
byte* pixels;
}
public struct GLFWgamepadstate
{
/*! The states of each [gamepad button](@ref gamepad_buttons), `GLFW_PRESS`
*  or `GLFW_RELEASE`.
*/
fixed byte buttons[15];
/*! The states of each [gamepad axis](@ref gamepad_axes), in the range -1.0
*  to 1.0 inclusive.
*/
fixed float axes[6];
}
	[DllImport("glfw3.dll")]
	public static extern int glfwInit ();
	[DllImport("glfw3.dll")]
	public static extern void glfwTerminate ();
	[DllImport("glfw3.dll")]
	public static extern void glfwInitHint (int hint, int value);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetVersion (int* major, int* minor, int* rev);
	[DllImport("glfw3.dll")]
	public static extern  string glfwGetVersionString ();
	[DllImport("glfw3.dll")]
	public static extern int glfwGetError ( ref string description);
	[DllImport("glfw3.dll")]
	public static extern GLFWerrorfun glfwSetErrorCallback (GLFWerrorfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWmonitor** glfwGetMonitors (int* count);
	[DllImport("glfw3.dll")]
	public static extern GLFWmonitor* glfwGetPrimaryMonitor ();
	[DllImport("glfw3.dll")]
	public static extern void glfwGetMonitorPos (GLFWmonitor* monitor, int* xpos, int* ypos);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetMonitorWorkarea (GLFWmonitor* monitor, int* xpos, int* ypos, int* width, int* height);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetMonitorPhysicalSize (GLFWmonitor* monitor, int* widthMM, int* heightMM);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetMonitorContentScale (GLFWmonitor* monitor, float* xscale, float* yscale);
	[DllImport("glfw3.dll")]
	public static extern  string glfwGetMonitorName (GLFWmonitor* monitor);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetMonitorUserPointer (GLFWmonitor* monitor, void* pointer);
	[DllImport("glfw3.dll")]
	public static extern void* glfwGetMonitorUserPointer (GLFWmonitor* monitor);
	[DllImport("glfw3.dll")]
	public static extern GLFWmonitorfun glfwSetMonitorCallback (GLFWmonitorfun callback);
	[DllImport("glfw3.dll")]
	public static extern  GLFWvidmode* glfwGetVideoModes (GLFWmonitor* monitor, int* count);
	[DllImport("glfw3.dll")]
	public static extern  GLFWvidmode* glfwGetVideoMode (GLFWmonitor* monitor);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetGamma (GLFWmonitor* monitor, float gamma);
	[DllImport("glfw3.dll")]
	public static extern  GLFWgammaramp* glfwGetGammaRamp (GLFWmonitor* monitor);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetGammaRamp (GLFWmonitor* monitor,  GLFWgammaramp* ramp);
	[DllImport("glfw3.dll")]
	public static extern void glfwDefaultWindowHints ();
	[DllImport("glfw3.dll")]
	public static extern void glfwWindowHint (int hint, int value);
	[DllImport("glfw3.dll")]
	public static extern void glfwWindowHintString (int hint,  string value);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindow* glfwCreateWindow (int width, int height,  string title, GLFWmonitor* monitor, GLFWwindow* share);
	[DllImport("glfw3.dll")]
	public static extern void glfwDestroyWindow (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern int glfwWindowShouldClose (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowShouldClose (GLFWwindow* window, int value);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowTitle (GLFWwindow* window,  string title);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowIcon (GLFWwindow* window, int count,  GLFWimage* images);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetWindowPos (GLFWwindow* window, int* xpos, int* ypos);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowPos (GLFWwindow* window, int xpos, int ypos);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetWindowSize (GLFWwindow* window, int* width, int* height);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowSizeLimits (GLFWwindow* window, int minwidth, int minheight, int maxwidth, int maxheight);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowAspectRatio (GLFWwindow* window, int numer, int denom);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowSize (GLFWwindow* window, int width, int height);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetFramebufferSize (GLFWwindow* window, int* width, int* height);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetWindowFrameSize (GLFWwindow* window, int* left, int* top, int* right, int* bottom);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetWindowContentScale (GLFWwindow* window, float* xscale, float* yscale);
	[DllImport("glfw3.dll")]
	public static extern float glfwGetWindowOpacity (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowOpacity (GLFWwindow* window, float opacity);
	[DllImport("glfw3.dll")]
	public static extern void glfwIconifyWindow (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwRestoreWindow (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwMaximizeWindow (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwShowWindow (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwHideWindow (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwFocusWindow (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwRequestWindowAttention (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern GLFWmonitor* glfwGetWindowMonitor (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowMonitor (GLFWwindow* window, GLFWmonitor* monitor, int xpos, int ypos, int width, int height, int refreshRate);
	[DllImport("glfw3.dll")]
	public static extern int glfwGetWindowAttrib (GLFWwindow* window, int attrib);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowAttrib (GLFWwindow* window, int attrib, int value);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetWindowUserPointer (GLFWwindow* window, void* pointer);
	[DllImport("glfw3.dll")]
	public static extern void* glfwGetWindowUserPointer (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindowposfun glfwSetWindowPosCallback (GLFWwindow* window, GLFWwindowposfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindowsizefun glfwSetWindowSizeCallback (GLFWwindow* window, GLFWwindowsizefun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindowclosefun glfwSetWindowCloseCallback (GLFWwindow* window, GLFWwindowclosefun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindowrefreshfun glfwSetWindowRefreshCallback (GLFWwindow* window, GLFWwindowrefreshfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindowfocusfun glfwSetWindowFocusCallback (GLFWwindow* window, GLFWwindowfocusfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindowiconifyfun glfwSetWindowIconifyCallback (GLFWwindow* window, GLFWwindowiconifyfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindowmaximizefun glfwSetWindowMaximizeCallback (GLFWwindow* window, GLFWwindowmaximizefun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWframebuffersizefun glfwSetFramebufferSizeCallback (GLFWwindow* window, GLFWframebuffersizefun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindowcontentscalefun glfwSetWindowContentScaleCallback (GLFWwindow* window, GLFWwindowcontentscalefun callback);
	[DllImport("glfw3.dll")]
	public static extern void glfwPollEvents ();
	[DllImport("glfw3.dll")]
	public static extern void glfwWaitEvents ();
	[DllImport("glfw3.dll")]
	public static extern void glfwWaitEventsTimeout (double timeout);
	[DllImport("glfw3.dll")]
	public static extern void glfwPostEmptyEvent ();
	[DllImport("glfw3.dll")]
	public static extern int glfwGetInputMode (GLFWwindow* window, int mode);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetInputMode (GLFWwindow* window, int mode, int value);
	[DllImport("glfw3.dll")]
	public static extern int glfwRawMouseMotionSupported ();
	[DllImport("glfw3.dll")]
	public static extern  string glfwGetKeyName (int key, int scancode);
	[DllImport("glfw3.dll")]
	public static extern int glfwGetKeyScancode (int key);
	[DllImport("glfw3.dll")]
	public static extern int glfwGetKey (GLFWwindow* window, int key);
	[DllImport("glfw3.dll")]
	public static extern int glfwGetMouseButton (GLFWwindow* window, int button);
	[DllImport("glfw3.dll")]
	public static extern void glfwGetCursorPos (GLFWwindow* window, double* xpos, double* ypos);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetCursorPos (GLFWwindow* window, double xpos, double ypos);
	[DllImport("glfw3.dll")]
	public static extern GLFWcursor* glfwCreateCursor ( GLFWimage* image, int xhot, int yhot);
	[DllImport("glfw3.dll")]
	public static extern GLFWcursor* glfwCreateStandardCursor (int shape);
	[DllImport("glfw3.dll")]
	public static extern void glfwDestroyCursor (GLFWcursor* cursor);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetCursor (GLFWwindow* window, GLFWcursor* cursor);
	[DllImport("glfw3.dll")]
	public static extern GLFWkeyfun glfwSetKeyCallback (GLFWwindow* window, GLFWkeyfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWcharfun glfwSetCharCallback (GLFWwindow* window, GLFWcharfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWcharmodsfun glfwSetCharModsCallback (GLFWwindow* window, GLFWcharmodsfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWmousebuttonfun glfwSetMouseButtonCallback (GLFWwindow* window, GLFWmousebuttonfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWcursorposfun glfwSetCursorPosCallback (GLFWwindow* window, GLFWcursorposfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWcursorenterfun glfwSetCursorEnterCallback (GLFWwindow* window, GLFWcursorenterfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWscrollfun glfwSetScrollCallback (GLFWwindow* window, GLFWscrollfun callback);
	[DllImport("glfw3.dll")]
	public static extern GLFWdropfun glfwSetDropCallback (GLFWwindow* window, GLFWdropfun callback);
	[DllImport("glfw3.dll")]
	public static extern int glfwJoystickPresent (int jid);
	[DllImport("glfw3.dll")]
	public static extern  float* glfwGetJoystickAxes (int jid, int* count);
	[DllImport("glfw3.dll")]
	public static extern  byte* glfwGetJoystickButtons (int jid, int* count);
	[DllImport("glfw3.dll")]
	public static extern  byte* glfwGetJoystickHats (int jid, int* count);
	[DllImport("glfw3.dll")]
	public static extern  string glfwGetJoystickName (int jid);
	[DllImport("glfw3.dll")]
	public static extern  string glfwGetJoystickGUID (int jid);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetJoystickUserPointer (int jid, void* pointer);
	[DllImport("glfw3.dll")]
	public static extern void* glfwGetJoystickUserPointer (int jid);
	[DllImport("glfw3.dll")]
	public static extern int glfwJoystickIsGamepad (int jid);
	[DllImport("glfw3.dll")]
	public static extern GLFWjoystickfun glfwSetJoystickCallback (GLFWjoystickfun callback);
	[DllImport("glfw3.dll")]
	public static extern int glfwUpdateGamepadMappings ( string str);
	[DllImport("glfw3.dll")]
	public static extern  string glfwGetGamepadName (int jid);
	[DllImport("glfw3.dll")]
	public static extern int glfwGetGamepadState (int jid, GLFWgamepadstate* state);
	[DllImport("glfw3.dll")]
	public static extern void glfwSetClipboardString (GLFWwindow* window,  string str);
	[DllImport("glfw3.dll")]
	public static extern  string glfwGetClipboardString (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern double glfwGetTime ();
	[DllImport("glfw3.dll")]
	public static extern void glfwSetTime (double time);
	[DllImport("glfw3.dll")]
	public static extern ulong glfwGetTimerValue ();
	[DllImport("glfw3.dll")]
	public static extern ulong glfwGetTimerFrequency ();
	[DllImport("glfw3.dll")]
	public static extern void glfwMakeContextCurrent (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern GLFWwindow* glfwGetCurrentContext ();
	[DllImport("glfw3.dll")]
	public static extern void glfwSwapBuffers (GLFWwindow* window);
	[DllImport("glfw3.dll")]
	public static extern void glfwSwapInterval (int interval);
	[DllImport("glfw3.dll")]
	public static extern int glfwExtensionSupported ( string extension);
	[DllImport("glfw3.dll")]
	public static extern GLFWglproc glfwGetProcAddress ( string procname);
	[DllImport("glfw3.dll")]
	public static extern int glfwVulkanSupported ();
	[DllImport("glfw3.dll")]
	public static extern  ref string glfwGetRequiredInstanceExtensions (uint* count);
	[DllImport("glfw3.dll")]
	public static extern GLFWvkproc glfwGetInstanceProcAddress (IntPtr instance,  string procname);
	[DllImport("glfw3.dll")]
	public static extern int glfwGetPhysicalDevicePresentationSupport (IntPtr instance, IntPtr device, uint queuefamily);
	[DllImport("glfw3.dll")]
	public static extern IntPtr glfwCreateWindowSurface (IntPtr instance, GLFWwindow* window,  IntPtr allocator, IntPtr surface);
}
