using System.Runtime.InteropServices;
public unsafe static class Gl {
	public const int __gl_glcorearb_h_ = 1;

	public const int WIN32_LEAN_AND_MEAN = 1;

	public const int GL_VERSION_1_0 = 1;

	public const int GL_DEPTH_BUFFER_BIT = 0x00000100;

	public const int GL_STENCIL_BUFFER_BIT = 0x00000400;

	public const int GL_COLOR_BUFFER_BIT = 0x00004000;

	public const int GL_FALSE = 0;

	public const int GL_TRUE = 1;

	public const int GL_POINTS = 0x0000;

	public const int GL_LINES = 0x0001;

	public const int GL_LINE_LOOP = 0x0002;

	public const int GL_LINE_STRIP = 0x0003;

	public const int GL_TRIANGLES = 0x0004;

	public const int GL_TRIANGLE_STRIP = 0x0005;

	public const int GL_TRIANGLE_FAN = 0x0006;

	public const int GL_QUADS = 0x0007;

	public const int GL_NEVER = 0x0200;

	public const int GL_LESS = 0x0201;

	public const int GL_EQUAL = 0x0202;

	public const int GL_LEQUAL = 0x0203;

	public const int GL_GREATER = 0x0204;

	public const int GL_NOTEQUAL = 0x0205;

	public const int GL_GEQUAL = 0x0206;

	public const int GL_ALWAYS = 0x0207;

	public const int GL_ZERO = 0;

	public const int GL_ONE = 1;

	public const int GL_SRC_COLOR = 0x0300;

	public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;

	public const int GL_SRC_ALPHA = 0x0302;

	public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;

	public const int GL_DST_ALPHA = 0x0304;

	public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;

	public const int GL_DST_COLOR = 0x0306;

	public const int GL_ONE_MINUS_DST_COLOR = 0x0307;

	public const int GL_SRC_ALPHA_SATURATE = 0x0308;

	public const int GL_NONE = 0;

	public const int GL_FRONT_LEFT = 0x0400;

	public const int GL_FRONT_RIGHT = 0x0401;

	public const int GL_BACK_LEFT = 0x0402;

	public const int GL_BACK_RIGHT = 0x0403;

	public const int GL_FRONT = 0x0404;

	public const int GL_BACK = 0x0405;

	public const int GL_LEFT = 0x0406;

	public const int GL_RIGHT = 0x0407;

	public const int GL_FRONT_AND_BACK = 0x0408;

	public const int GL_NO_ERROR = 0;

	public const int GL_INVALID_ENUM = 0x0500;

	public const int GL_INVALID_VALUE = 0x0501;

	public const int GL_INVALID_OPERATION = 0x0502;

	public const int GL_OUT_OF_MEMORY = 0x0505;

	public const int GL_CW = 0x0900;

	public const int GL_CCW = 0x0901;

	public const int GL_POINT_SIZE = 0x0B11;

	public const int GL_POINT_SIZE_RANGE = 0x0B12;

	public const int GL_POINT_SIZE_GRANULARITY = 0x0B13;

	public const int GL_LINE_SMOOTH = 0x0B20;

	public const int GL_LINE_WIDTH = 0x0B21;

	public const int GL_LINE_WIDTH_RANGE = 0x0B22;

	public const int GL_LINE_WIDTH_GRANULARITY = 0x0B23;

	public const int GL_POLYGON_MODE = 0x0B40;

	public const int GL_POLYGON_SMOOTH = 0x0B41;

	public const int GL_CULL_FACE = 0x0B44;

	public const int GL_CULL_FACE_MODE = 0x0B45;

	public const int GL_FRONT_FACE = 0x0B46;

	public const int GL_DEPTH_RANGE = 0x0B70;

	public const int GL_DEPTH_TEST = 0x0B71;

	public const int GL_DEPTH_WRITEMASK = 0x0B72;

	public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;

	public const int GL_DEPTH_FUNC = 0x0B74;

	public const int GL_STENCIL_TEST = 0x0B90;

	public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;

	public const int GL_STENCIL_FUNC = 0x0B92;

	public const int GL_STENCIL_VALUE_MASK = 0x0B93;

	public const int GL_STENCIL_FAIL = 0x0B94;

	public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;

	public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;

	public const int GL_STENCIL_REF = 0x0B97;

	public const int GL_STENCIL_WRITEMASK = 0x0B98;

	public const int GL_VIEWPORT = 0x0BA2;

	public const int GL_DITHER = 0x0BD0;

	public const int GL_BLEND_DST = 0x0BE0;

	public const int GL_BLEND_SRC = 0x0BE1;

	public const int GL_BLEND = 0x0BE2;

	public const int GL_LOGIC_OP_MODE = 0x0BF0;

	public const int GL_DRAW_BUFFER = 0x0C01;

	public const int GL_READ_BUFFER = 0x0C02;

	public const int GL_SCISSOR_BOX = 0x0C10;

	public const int GL_SCISSOR_TEST = 0x0C11;

	public const int GL_COLOR_CLEAR_VALUE = 0x0C22;

	public const int GL_COLOR_WRITEMASK = 0x0C23;

	public const int GL_DOUBLEBUFFER = 0x0C32;

	public const int GL_STEREO = 0x0C33;

	public const int GL_LINE_SMOOTH_HINT = 0x0C52;

	public const int GL_POLYGON_SMOOTH_HINT = 0x0C53;

	public const int GL_UNPACK_SWAP_BYTES = 0x0CF0;

	public const int GL_UNPACK_LSB_FIRST = 0x0CF1;

	public const int GL_UNPACK_ROW_LENGTH = 0x0CF2;

	public const int GL_UNPACK_SKIP_ROWS = 0x0CF3;

	public const int GL_UNPACK_SKIP_PIXELS = 0x0CF4;

	public const int GL_UNPACK_ALIGNMENT = 0x0CF5;

	public const int GL_PACK_SWAP_BYTES = 0x0D00;

	public const int GL_PACK_LSB_FIRST = 0x0D01;

	public const int GL_PACK_ROW_LENGTH = 0x0D02;

	public const int GL_PACK_SKIP_ROWS = 0x0D03;

	public const int GL_PACK_SKIP_PIXELS = 0x0D04;

	public const int GL_PACK_ALIGNMENT = 0x0D05;

	public const int GL_MAX_TEXTURE_SIZE = 0x0D33;

	public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;

	public const int GL_SUBPIXEL_BITS = 0x0D50;

	public const int GL_TEXTURE_1D = 0x0DE0;

	public const int GL_TEXTURE_2D = 0x0DE1;

	public const int GL_TEXTURE_WIDTH = 0x1000;

	public const int GL_TEXTURE_HEIGHT = 0x1001;

	public const int GL_TEXTURE_BORDER_COLOR = 0x1004;

	public const int GL_DONT_CARE = 0x1100;

	public const int GL_FASTEST = 0x1101;

	public const int GL_NICEST = 0x1102;

	public const int GL_BYTE = 0x1400;

	public const int GL_UNSIGNED_BYTE = 0x1401;

	public const int GL_SHORT = 0x1402;

	public const int GL_UNSIGNED_SHORT = 0x1403;

	public const int GL_INT = 0x1404;

	public const int GL_UNSIGNED_INT = 0x1405;

	public const int GL_FLOAT = 0x1406;

	public const int GL_STACK_OVERFLOW = 0x0503;

	public const int GL_STACK_UNDERFLOW = 0x0504;

	public const int GL_CLEAR = 0x1500;

	public const int GL_AND = 0x1501;

	public const int GL_AND_REVERSE = 0x1502;

	public const int GL_COPY = 0x1503;

	public const int GL_AND_INVERTED = 0x1504;

	public const int GL_NOOP = 0x1505;

	public const int GL_XOR = 0x1506;

	public const int GL_OR = 0x1507;

	public const int GL_NOR = 0x1508;

	public const int GL_EQUIV = 0x1509;

	public const int GL_INVERT = 0x150A;

	public const int GL_OR_REVERSE = 0x150B;

	public const int GL_COPY_INVERTED = 0x150C;

	public const int GL_OR_INVERTED = 0x150D;

	public const int GL_NAND = 0x150E;

	public const int GL_SET = 0x150F;

	public const int GL_TEXTURE = 0x1702;

	public const int GL_COLOR = 0x1800;

	public const int GL_DEPTH = 0x1801;

	public const int GL_STENCIL = 0x1802;

	public const int GL_STENCIL_INDEX = 0x1901;

	public const int GL_DEPTH_COMPONENT = 0x1902;

	public const int GL_RED = 0x1903;

	public const int GL_GREEN = 0x1904;

	public const int GL_BLUE = 0x1905;

	public const int GL_ALPHA = 0x1906;

	public const int GL_RGB = 0x1907;

	public const int GL_RGBA = 0x1908;

	public const int GL_POINT = 0x1B00;

	public const int GL_LINE = 0x1B01;

	public const int GL_FILL = 0x1B02;

	public const int GL_KEEP = 0x1E00;

	public const int GL_REPLACE = 0x1E01;

	public const int GL_INCR = 0x1E02;

	public const int GL_DECR = 0x1E03;

	public const int GL_VENDOR = 0x1F00;

	public const int GL_RENDERER = 0x1F01;

	public const int GL_VERSION = 0x1F02;

	public const int GL_EXTENSIONS = 0x1F03;

	public const int GL_NEAREST = 0x2600;

	public const int GL_LINEAR = 0x2601;

	public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;

	public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;

	public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;

	public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;

	public const int GL_TEXTURE_MAG_FILTER = 0x2800;

	public const int GL_TEXTURE_MIN_FILTER = 0x2801;

	public const int GL_TEXTURE_WRAP_S = 0x2802;

	public const int GL_TEXTURE_WRAP_T = 0x2803;

	public const int GL_REPEAT = 0x2901;

public delegate void PFNGLCULLFACEPROC (int mode);
public delegate void PFNGLFRONTFACEPROC (int mode);
public delegate void PFNGLHINTPROC (int target, int mode);
public delegate void PFNGLLINEWIDTHPROC (float width);
public delegate void PFNGLPOINTSIZEPROC (float size);
public delegate void PFNGLPOLYGONMODEPROC (int face, int mode);
public delegate void PFNGLSCISSORPROC (int x, int y, uint width, uint height);
public delegate void PFNGLTEXPARAMETERFPROC (int target, int pname, float param);
public delegate void PFNGLTEXPARAMETERFVPROC (int target, int pname,  float *prms);
public delegate void PFNGLTEXPARAMETERIPROC (int target, int pname, int param);
public delegate void PFNGLTEXPARAMETERIVPROC (int target, int pname,  int *prms);
public delegate void PFNGLTEXIMAGE1DPROC (int target, int level, int internalformat, uint width, int border, int format, int type,  void *pixels);
public delegate void PFNGLTEXIMAGE2DPROC (int target, int level, int internalformat, uint width, uint height, int border, int format, int type,  void *pixels);
public delegate void PFNGLDRAWBUFFERPROC (int buf);
public delegate void PFNGLCLEARPROC (int mask);
public delegate void PFNGLCLEARCOLORPROC (float red, float green, float blue, float alpha);
public delegate void PFNGLCLEARSTENCILPROC (int s);
public delegate void PFNGLCLEARDEPTHPROC (double depth);
public delegate void PFNGLSTENCILMASKPROC (uint mask);
public delegate void PFNGLCOLORMASKPROC (int red, int green, int blue, int alpha);
public delegate void PFNGLDEPTHMASKPROC (int flag);
public delegate void PFNGLDISABLEPROC (int cap);
public delegate void PFNGLENABLEPROC (int cap);
public delegate void PFNGLFINISHPROC ();
public delegate void PFNGLFLUSHPROC ();
public delegate void PFNGLBLENDFUNCPROC (int sfactor, int dfactor);
public delegate void PFNGLLOGICOPPROC (int opcode);
public delegate void PFNGLSTENCILFUNCPROC (int func, int reference, uint mask);
public delegate void PFNGLSTENCILOPPROC (int fail, int zfail, int zpass);
public delegate void PFNGLDEPTHFUNCPROC (int func);
public delegate void PFNGLPIXELSTOREFPROC (int pname, float param);
public delegate void PFNGLPIXELSTOREIPROC (int pname, int param);
public delegate void PFNGLREADBUFFERPROC (int src);
public delegate void PFNGLREADPIXELSPROC (int x, int y, uint width, uint height, int format, int type, void *pixels);
public delegate void PFNGLGETBOOLEANVPROC (int pname, int *data);
public delegate void PFNGLGETDOUBLEVPROC (int pname, double *data);
public delegate void PFNGLGETFLOATVPROC (int pname, float *data);
public delegate void PFNGLGETINTEGERVPROC (int pname, int *data);
public delegate void PFNGLGETTEXIMAGEPROC (int target, int level, int format, int type, void *pixels);
public delegate void PFNGLGETTEXPARAMETERFVPROC (int target, int pname, float *prms);
public delegate void PFNGLGETTEXPARAMETERIVPROC (int target, int pname, int *prms);
public delegate void PFNGLGETTEXLEVELPARAMETERFVPROC (int target, int level, int pname, float *prms);
public delegate void PFNGLGETTEXLEVELPARAMETERIVPROC (int target, int level, int pname, int *prms);
public delegate void PFNGLDEPTHRANGEPROC (double n, double f);
public delegate void PFNGLVIEWPORTPROC (int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glCullFace (int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glFrontFace (int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glHint (int target, int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glLineWidth (float width);
	[DllImport("glfw3.dll")]
	public static extern  void glPointSize (float size);
	[DllImport("glfw3.dll")]
	public static extern  void glPolygonMode (int face, int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glScissor (int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glTexParameterf (int target, int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glTexParameterfv (int target, int pname,  float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTexParameteri (int target, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glTexParameteriv (int target, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTexImage1D (int target, int level, int internalformat, uint width, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTexImage2D (int target, int level, int internalformat, uint width, uint height, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawBuffer (int buf);
	[DllImport("glfw3.dll")]
	public static extern  void glClear (int mask);
	[DllImport("glfw3.dll")]
	public static extern  void glClearColor (float red, float green, float blue, float alpha);
	[DllImport("glfw3.dll")]
	public static extern  void glClearStencil (int s);
	[DllImport("glfw3.dll")]
	public static extern  void glClearDepth (double depth);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilMask (uint mask);
	[DllImport("glfw3.dll")]
	public static extern  void glColorMask (int red, int green, int blue, int alpha);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthMask (int flag);
	[DllImport("glfw3.dll")]
	public static extern  void glDisable (int cap);
	[DllImport("glfw3.dll")]
	public static extern  void glEnable (int cap);
	[DllImport("glfw3.dll")]
	public static extern  void glFinish ();
	[DllImport("glfw3.dll")]
	public static extern  void glFlush ();
	[DllImport("glfw3.dll")]
	public static extern  void glBlendFunc (int sfactor, int dfactor);
	[DllImport("glfw3.dll")]
	public static extern  void glLogicOp (int opcode);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilFunc (int func, int reference, uint mask);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilOp (int fail, int zfail, int zpass);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthFunc (int func);
	[DllImport("glfw3.dll")]
	public static extern  void glPixelStoref (int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glPixelStorei (int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glReadBuffer (int src);
	[DllImport("glfw3.dll")]
	public static extern  void glReadPixels (int x, int y, uint width, uint height, int format, int type, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetBooleanv (int pname, int *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetDoublev (int pname, double *data);
	[DllImport("glfw3.dll")]
	public static extern  int glGetError ();
	[DllImport("glfw3.dll")]
	public static extern  void glGetFloatv (int pname, float *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetIntegerv (int pname, int *data);
	[DllImport("glfw3.dll")]
	public static extern   byte  glGetString (int name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTexImage (int target, int level, int format, int type, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTexParameterfv (int target, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTexParameteriv (int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTexLevelParameterfv (int target, int level, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTexLevelParameteriv (int target, int level, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  int glIsEnabled (int cap);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthRange (double n, double f);
	[DllImport("glfw3.dll")]
	public static extern  void glViewport (int x, int y, uint width, uint height);
	public const int GL_VERSION_1_1 = 1;

	public const int GL_COLOR_LOGIC_OP = 0x0BF2;

	public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;

	public const int GL_POLYGON_OFFSET_POINT = 0x2A01;

	public const int GL_POLYGON_OFFSET_LINE = 0x2A02;

	public const int GL_POLYGON_OFFSET_FILL = 0x8037;

	public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;

	public const int GL_TEXTURE_BINDING_1D = 0x8068;

	public const int GL_TEXTURE_BINDING_2D = 0x8069;

	public const int GL_TEXTURE_INTERNAL_FORMAT = 0x1003;

	public const int GL_TEXTURE_RED_SIZE = 0x805C;

	public const int GL_TEXTURE_GREEN_SIZE = 0x805D;

	public const int GL_TEXTURE_BLUE_SIZE = 0x805E;

	public const int GL_TEXTURE_ALPHA_SIZE = 0x805F;

	public const int GL_DOUBLE = 0x140A;

	public const int GL_PROXY_TEXTURE_1D = 0x8063;

	public const int GL_PROXY_TEXTURE_2D = 0x8064;

	public const int GL_R3_G3_B2 = 0x2A10;

	public const int GL_RGB4 = 0x804F;

	public const int GL_RGB5 = 0x8050;

	public const int GL_RGB8 = 0x8051;

	public const int GL_RGB10 = 0x8052;

	public const int GL_RGB12 = 0x8053;

	public const int GL_RGB16 = 0x8054;

	public const int GL_RGBA2 = 0x8055;

	public const int GL_RGBA4 = 0x8056;

	public const int GL_RGB5_A1 = 0x8057;

	public const int GL_RGBA8 = 0x8058;

	public const int GL_RGB10_A2 = 0x8059;

	public const int GL_RGBA12 = 0x805A;

	public const int GL_RGBA16 = 0x805B;

	public const int GL_VERTEX_ARRAY = 0x8074;

public delegate void PFNGLDRAWARRAYSPROC (int mode, int first, uint count);
public delegate void PFNGLDRAWELEMENTSPROC (int mode, uint count, int type,  void *indices);
public delegate void PFNGLGETPOINTERVPROC (int pname, void **prms);
public delegate void PFNGLPOLYGONOFFSETPROC (float factor, float units);
public delegate void PFNGLCOPYTEXIMAGE1DPROC (int target, int level, int internalformat, int x, int y, uint width, int border);
public delegate void PFNGLCOPYTEXIMAGE2DPROC (int target, int level, int internalformat, int x, int y, uint width, uint height, int border);
public delegate void PFNGLCOPYTEXSUBIMAGE1DPROC (int target, int level, int xoffset, int x, int y, uint width);
public delegate void PFNGLCOPYTEXSUBIMAGE2DPROC (int target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
public delegate void PFNGLTEXSUBIMAGE1DPROC (int target, int level, int xoffset, uint width, int format, int type,  void *pixels);
public delegate void PFNGLTEXSUBIMAGE2DPROC (int target, int level, int xoffset, int yoffset, uint width, uint height, int format, int type,  void *pixels);
public delegate void PFNGLBINDTEXTUREPROC (int target, uint texture);
public delegate void PFNGLDELETETEXTURESPROC (uint n,  uint *textures);
public delegate void PFNGLGENTEXTURESPROC (uint n, uint *textures);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawArrays (int mode, int first, uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElements (int mode, uint count, int type,  void *indices);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPointerv (int pname, void **prms);
	[DllImport("glfw3.dll")]
	public static extern  void glPolygonOffset (float factor, float units);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTexImage1D (int target, int level, int internalformat, int x, int y, uint width, int border);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTexImage2D (int target, int level, int internalformat, int x, int y, uint width, uint height, int border);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTexSubImage1D (int target, int level, int xoffset, int x, int y, uint width);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTexSubImage2D (int target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glTexSubImage1D (int target, int level, int xoffset, uint width, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTexSubImage2D (int target, int level, int xoffset, int yoffset, uint width, uint height, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glBindTexture (int target, uint texture);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteTextures (uint n,  uint *textures);
	[DllImport("glfw3.dll")]
	public static extern  void glGenTextures (uint n, uint *textures);
	[DllImport("glfw3.dll")]
	public static extern  int glIsTexture (uint texture);
	public const int GL_VERSION_1_2 = 1;

	public const int GL_UNSIGNED_BYTE_3_3_2 = 0x8032;

	public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;

	public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;

	public const int GL_UNSIGNED_INT_8_8_8_8 = 0x8035;

	public const int GL_UNSIGNED_INT_10_10_10_2 = 0x8036;

	public const int GL_TEXTURE_BINDING_3D = 0x806A;

	public const int GL_PACK_SKIP_IMAGES = 0x806B;

	public const int GL_PACK_IMAGE_HEIGHT = 0x806C;

	public const int GL_UNPACK_SKIP_IMAGES = 0x806D;

	public const int GL_UNPACK_IMAGE_HEIGHT = 0x806E;

	public const int GL_TEXTURE_3D = 0x806F;

	public const int GL_PROXY_TEXTURE_3D = 0x8070;

	public const int GL_TEXTURE_DEPTH = 0x8071;

	public const int GL_TEXTURE_WRAP_R = 0x8072;

	public const int GL_MAX_3D_TEXTURE_SIZE = 0x8073;

	public const int GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;

	public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;

	public const int GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;

	public const int GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;

	public const int GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;

	public const int GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;

	public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;

	public const int GL_BGR = 0x80E0;

	public const int GL_BGRA = 0x80E1;

	public const int GL_MAX_ELEMENTS_VERTICES = 0x80E8;

	public const int GL_MAX_ELEMENTS_INDICES = 0x80E9;

	public const int GL_CLAMP_TO_EDGE = 0x812F;

	public const int GL_TEXTURE_MIN_LOD = 0x813A;

	public const int GL_TEXTURE_MAX_LOD = 0x813B;

	public const int GL_TEXTURE_BASE_LEVEL = 0x813C;

	public const int GL_TEXTURE_MAX_LEVEL = 0x813D;

	public const int GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;

	public const int GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;

	public const int GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;

	public const int GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;

	public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;

public delegate void PFNGLDRAWRANGEELEMENTSPROC (int mode, uint start, uint end, uint count, int type,  void *indices);
public delegate void PFNGLTEXIMAGE3DPROC (int target, int level, int internalformat, uint width, uint height, uint depth, int border, int format, int type,  void *pixels);
public delegate void PFNGLTEXSUBIMAGE3DPROC (int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *pixels);
public delegate void PFNGLCOPYTEXSUBIMAGE3DPROC (int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawRangeElements (int mode, uint start, uint end, uint count, int type,  void *indices);
	[DllImport("glfw3.dll")]
	public static extern  void glTexImage3D (int target, int level, int internalformat, uint width, uint height, uint depth, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTexSubImage3D (int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTexSubImage3D (int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
	public const int GL_VERSION_1_3 = 1;

	public const int GL_TEXTURE0 = 0x84C0;

	public const int GL_TEXTURE1 = 0x84C1;

	public const int GL_TEXTURE2 = 0x84C2;

	public const int GL_TEXTURE3 = 0x84C3;

	public const int GL_TEXTURE4 = 0x84C4;

	public const int GL_TEXTURE5 = 0x84C5;

	public const int GL_TEXTURE6 = 0x84C6;

	public const int GL_TEXTURE7 = 0x84C7;

	public const int GL_TEXTURE8 = 0x84C8;

	public const int GL_TEXTURE9 = 0x84C9;

	public const int GL_TEXTURE10 = 0x84CA;

	public const int GL_TEXTURE11 = 0x84CB;

	public const int GL_TEXTURE12 = 0x84CC;

	public const int GL_TEXTURE13 = 0x84CD;

	public const int GL_TEXTURE14 = 0x84CE;

	public const int GL_TEXTURE15 = 0x84CF;

	public const int GL_TEXTURE16 = 0x84D0;

	public const int GL_TEXTURE17 = 0x84D1;

	public const int GL_TEXTURE18 = 0x84D2;

	public const int GL_TEXTURE19 = 0x84D3;

	public const int GL_TEXTURE20 = 0x84D4;

	public const int GL_TEXTURE21 = 0x84D5;

	public const int GL_TEXTURE22 = 0x84D6;

	public const int GL_TEXTURE23 = 0x84D7;

	public const int GL_TEXTURE24 = 0x84D8;

	public const int GL_TEXTURE25 = 0x84D9;

	public const int GL_TEXTURE26 = 0x84DA;

	public const int GL_TEXTURE27 = 0x84DB;

	public const int GL_TEXTURE28 = 0x84DC;

	public const int GL_TEXTURE29 = 0x84DD;

	public const int GL_TEXTURE30 = 0x84DE;

	public const int GL_TEXTURE31 = 0x84DF;

	public const int GL_ACTIVE_TEXTURE = 0x84E0;

	public const int GL_MULTISAMPLE = 0x809D;

	public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;

	public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;

	public const int GL_SAMPLE_COVERAGE = 0x80A0;

	public const int GL_SAMPLE_BUFFERS = 0x80A8;

	public const int GL_SAMPLES = 0x80A9;

	public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;

	public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;

	public const int GL_TEXTURE_CUBE_MAP = 0x8513;

	public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;

	public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;

	public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;

	public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;

	public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;

	public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;

	public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;

	public const int GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;

	public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

	public const int GL_COMPRESSED_RGB = 0x84ED;

	public const int GL_COMPRESSED_RGBA = 0x84EE;

	public const int GL_TEXTURE_COMPRESSION_HINT = 0x84EF;

	public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;

	public const int GL_TEXTURE_COMPRESSED = 0x86A1;

	public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;

	public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;

	public const int GL_CLAMP_TO_BORDER = 0x812D;

public delegate void PFNGLACTIVETEXTUREPROC (int texture);
public delegate void PFNGLSAMPLECOVERAGEPROC (float value, int invert);
public delegate void PFNGLCOMPRESSEDTEXIMAGE3DPROC (int target, int level, int internalformat, uint width, uint height, uint depth, int border, uint imageSize,  void *data);
public delegate void PFNGLCOMPRESSEDTEXIMAGE2DPROC (int target, int level, int internalformat, uint width, uint height, int border, uint imageSize,  void *data);
public delegate void PFNGLCOMPRESSEDTEXIMAGE1DPROC (int target, int level, int internalformat, uint width, int border, uint imageSize,  void *data);
public delegate void PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC (int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, uint imageSize,  void *data);
public delegate void PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC (int target, int level, int xoffset, int yoffset, uint width, uint height, int format, uint imageSize,  void *data);
public delegate void PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC (int target, int level, int xoffset, uint width, int format, uint imageSize,  void *data);
public delegate void PFNGLGETCOMPRESSEDTEXIMAGEPROC (int target, int level, void *img);
	[DllImport("glfw3.dll")]
	public static extern  void glActiveTexture (int texture);
	[DllImport("glfw3.dll")]
	public static extern  void glSampleCoverage (float value, int invert);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTexImage3D (int target, int level, int internalformat, uint width, uint height, uint depth, int border, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTexImage2D (int target, int level, int internalformat, uint width, uint height, int border, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTexImage1D (int target, int level, int internalformat, uint width, int border, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTexSubImage3D (int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTexSubImage2D (int target, int level, int xoffset, int yoffset, uint width, uint height, int format, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTexSubImage1D (int target, int level, int xoffset, uint width, int format, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetCompressedTexImage (int target, int level, void *img);
	public const int GL_VERSION_1_4 = 1;

	public const int GL_BLEND_DST_RGB = 0x80C8;

	public const int GL_BLEND_SRC_RGB = 0x80C9;

	public const int GL_BLEND_DST_ALPHA = 0x80CA;

	public const int GL_BLEND_SRC_ALPHA = 0x80CB;

	public const int GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;

	public const int GL_DEPTH_COMPONENT16 = 0x81A5;

	public const int GL_DEPTH_COMPONENT24 = 0x81A6;

	public const int GL_DEPTH_COMPONENT32 = 0x81A7;

	public const int GL_MIRRORED_REPEAT = 0x8370;

	public const int GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;

	public const int GL_TEXTURE_LOD_BIAS = 0x8501;

	public const int GL_INCR_WRAP = 0x8507;

	public const int GL_DECR_WRAP = 0x8508;

	public const int GL_TEXTURE_DEPTH_SIZE = 0x884A;

	public const int GL_TEXTURE_COMPARE_MODE = 0x884C;

	public const int GL_TEXTURE_COMPARE_FUNC = 0x884D;

	public const int GL_BLEND_COLOR = 0x8005;

	public const int GL_BLEND_EQUATION = 0x8009;

	public const int GL_CONSTANT_COLOR = 0x8001;

	public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;

	public const int GL_CONSTANT_ALPHA = 0x8003;

	public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;

	public const int GL_FUNC_ADD = 0x8006;

	public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;

	public const int GL_FUNC_SUBTRACT = 0x800A;

	public const int GL_MIN = 0x8007;

	public const int GL_MAX = 0x8008;

public delegate void PFNGLBLENDFUNCSEPARATEPROC (int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
public delegate void PFNGLMULTIDRAWARRAYSPROC (int mode,  int *first,  uint *count, uint drawcount);
public delegate void PFNGLMULTIDRAWELEMENTSPROC (int mode,  uint *count, int type,  void **indices, uint drawcount);
public delegate void PFNGLPOINTPARAMETERFPROC (int pname, float param);
public delegate void PFNGLPOINTPARAMETERFVPROC (int pname,  float *prms);
public delegate void PFNGLPOINTPARAMETERIPROC (int pname, int param);
public delegate void PFNGLPOINTPARAMETERIVPROC (int pname,  int *prms);
public delegate void PFNGLBLENDCOLORPROC (float red, float green, float blue, float alpha);
public delegate void PFNGLBLENDEQUATIONPROC (int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendFuncSeparate (int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawArrays (int mode,  int *first,  uint *count, uint drawcount);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawElements (int mode,  uint *count, int type,  void **indices, uint drawcount);
	[DllImport("glfw3.dll")]
	public static extern  void glPointParameterf (int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glPointParameterfv (int pname,  float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glPointParameteri (int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glPointParameteriv (int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendColor (float red, float green, float blue, float alpha);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendEquation (int mode);
	public const int GL_VERSION_1_5 = 1;

	public const int GL_BUFFER_SIZE = 0x8764;

	public const int GL_BUFFER_USAGE = 0x8765;

	public const int GL_QUERY_COUNTER_BITS = 0x8864;

	public const int GL_CURRENT_QUERY = 0x8865;

	public const int GL_QUERY_RESULT = 0x8866;

	public const int GL_QUERY_RESULT_AVAILABLE = 0x8867;

	public const int GL_ARRAY_BUFFER = 0x8892;

	public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;

	public const int GL_ARRAY_BUFFER_BINDING = 0x8894;

	public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

	public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

	public const int GL_READ_ONLY = 0x88B8;

	public const int GL_WRITE_ONLY = 0x88B9;

	public const int GL_READ_WRITE = 0x88BA;

	public const int GL_BUFFER_ACCESS = 0x88BB;

	public const int GL_BUFFER_MAPPED = 0x88BC;

	public const int GL_BUFFER_MAP_POINTER = 0x88BD;

	public const int GL_STREAM_DRAW = 0x88E0;

	public const int GL_STREAM_READ = 0x88E1;

	public const int GL_STREAM_COPY = 0x88E2;

	public const int GL_STATIC_DRAW = 0x88E4;

	public const int GL_STATIC_READ = 0x88E5;

	public const int GL_STATIC_COPY = 0x88E6;

	public const int GL_DYNAMIC_DRAW = 0x88E8;

	public const int GL_DYNAMIC_READ = 0x88E9;

	public const int GL_DYNAMIC_COPY = 0x88EA;

	public const int GL_SAMPLES_PASSED = 0x8914;

	public const int GL_SRC1_ALPHA = 0x8589;

public delegate void PFNGLGENQUERIESPROC (uint n, uint *ids);
public delegate void PFNGLDELETEQUERIESPROC (uint n,  uint *ids);
public delegate void PFNGLBEGINQUERYPROC (int target, uint id);
public delegate void PFNGLENDQUERYPROC (int target);
public delegate void PFNGLGETQUERYIVPROC (int target, int pname, int *prms);
public delegate void PFNGLGETQUERYOBJECTIVPROC (uint id, int pname, int *prms);
public delegate void PFNGLGETQUERYOBJECTUIVPROC (uint id, int pname, uint *prms);
public delegate void PFNGLBINDBUFFERPROC (int target, uint buffer);
public delegate void PFNGLDELETEBUFFERSPROC (uint n,  uint *buffers);
public delegate void PFNGLGENBUFFERSPROC (uint n, uint *buffers);
public delegate void PFNGLBUFFERDATAPROC (int target, uint* size,  void *data, int usage);
public delegate void PFNGLBUFFERSUBDATAPROC (int target, int* offset, uint* size,  void *data);
public delegate void PFNGLGETBUFFERSUBDATAPROC (int target, int* offset, uint* size, void *data);
public delegate void PFNGLGETBUFFERPARAMETERIVPROC (int target, int pname, int *prms);
public delegate void PFNGLGETBUFFERPOINTERVPROC (int target, int pname, void **prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGenQueries (uint n, uint *ids);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteQueries (uint n,  uint *ids);
	[DllImport("glfw3.dll")]
	public static extern  int glIsQuery (uint id);
	[DllImport("glfw3.dll")]
	public static extern  void glBeginQuery (int target, uint id);
	[DllImport("glfw3.dll")]
	public static extern  void glEndQuery (int target);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryiv (int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryObjectiv (uint id, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryObjectuiv (uint id, int pname, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glBindBuffer (int target, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteBuffers (uint n,  uint *buffers);
	[DllImport("glfw3.dll")]
	public static extern  void glGenBuffers (uint n, uint *buffers);
	[DllImport("glfw3.dll")]
	public static extern  int glIsBuffer (uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glBufferData (int target, uint* size,  void *data, int usage);
	[DllImport("glfw3.dll")]
	public static extern  void glBufferSubData (int target, int* offset, uint* size,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetBufferSubData (int target, int* offset, uint* size, void *data);
	[DllImport("glfw3.dll")]
	public static extern  void  glMapBuffer (int target, int access);
	[DllImport("glfw3.dll")]
	public static extern  int glUnmapBuffer (int target);
	[DllImport("glfw3.dll")]
	public static extern  void glGetBufferParameteriv (int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetBufferPointerv (int target, int pname, void **prms);
	public const int GL_VERSION_2_0 = 1;

	public const int GL_BLEND_EQUATION_RGB = 0x8009;

	public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;

	public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;

	public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;

	public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;

	public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;

	public const int GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642;

	public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;

	public const int GL_STENCIL_BACK_FUNC = 0x8800;

	public const int GL_STENCIL_BACK_FAIL = 0x8801;

	public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;

	public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;

	public const int GL_MAX_DRAW_BUFFERS = 0x8824;

	public const int GL_DRAW_BUFFER0 = 0x8825;

	public const int GL_DRAW_BUFFER1 = 0x8826;

	public const int GL_DRAW_BUFFER2 = 0x8827;

	public const int GL_DRAW_BUFFER3 = 0x8828;

	public const int GL_DRAW_BUFFER4 = 0x8829;

	public const int GL_DRAW_BUFFER5 = 0x882A;

	public const int GL_DRAW_BUFFER6 = 0x882B;

	public const int GL_DRAW_BUFFER7 = 0x882C;

	public const int GL_DRAW_BUFFER8 = 0x882D;

	public const int GL_DRAW_BUFFER9 = 0x882E;

	public const int GL_DRAW_BUFFER10 = 0x882F;

	public const int GL_DRAW_BUFFER11 = 0x8830;

	public const int GL_DRAW_BUFFER12 = 0x8831;

	public const int GL_DRAW_BUFFER13 = 0x8832;

	public const int GL_DRAW_BUFFER14 = 0x8833;

	public const int GL_DRAW_BUFFER15 = 0x8834;

	public const int GL_BLEND_EQUATION_ALPHA = 0x883D;

	public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;

	public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;

	public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;

	public const int GL_FRAGMENT_SHADER = 0x8B30;

	public const int GL_VERTEX_SHADER = 0x8B31;

	public const int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;

	public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;

	public const int GL_MAX_VARYING_FLOATS = 0x8B4B;

	public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;

	public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;

	public const int GL_SHADER_TYPE = 0x8B4F;

	public const int GL_FLOAT_VEC2 = 0x8B50;

	public const int GL_FLOAT_VEC3 = 0x8B51;

	public const int GL_FLOAT_VEC4 = 0x8B52;

	public const int GL_INT_VEC2 = 0x8B53;

	public const int GL_INT_VEC3 = 0x8B54;

	public const int GL_INT_VEC4 = 0x8B55;

	public const int GL_BOOL = 0x8B56;

	public const int GL_BOOL_VEC2 = 0x8B57;

	public const int GL_BOOL_VEC3 = 0x8B58;

	public const int GL_BOOL_VEC4 = 0x8B59;

	public const int GL_FLOAT_MAT2 = 0x8B5A;

	public const int GL_FLOAT_MAT3 = 0x8B5B;

	public const int GL_FLOAT_MAT4 = 0x8B5C;

	public const int GL_SAMPLER_1D = 0x8B5D;

	public const int GL_SAMPLER_2D = 0x8B5E;

	public const int GL_SAMPLER_3D = 0x8B5F;

	public const int GL_SAMPLER_CUBE = 0x8B60;

	public const int GL_SAMPLER_1D_SHADOW = 0x8B61;

	public const int GL_SAMPLER_2D_SHADOW = 0x8B62;

	public const int GL_DELETE_STATUS = 0x8B80;

	public const int GL_COMPILE_STATUS = 0x8B81;

	public const int GL_LINK_STATUS = 0x8B82;

	public const int GL_VALIDATE_STATUS = 0x8B83;

	public const int GL_INFO_LOG_LENGTH = 0x8B84;

	public const int GL_ATTACHED_SHADERS = 0x8B85;

	public const int GL_ACTIVE_UNIFORMS = 0x8B86;

	public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;

	public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;

	public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;

	public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;

	public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

	public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;

	public const int GL_CURRENT_PROGRAM = 0x8B8D;

	public const int GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0;

	public const int GL_LOWER_LEFT = 0x8CA1;

	public const int GL_UPPER_LEFT = 0x8CA2;

	public const int GL_STENCIL_BACK_REF = 0x8CA3;

	public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;

	public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;

public delegate void PFNGLBLENDEQUATIONSEPARATEPROC (int modeRGB, int modeAlpha);
public delegate void PFNGLDRAWBUFFERSPROC (uint n,  int *bufs);
public delegate void PFNGLSTENCILOPSEPARATEPROC (int face, int sfail, int dpfail, int dppass);
public delegate void PFNGLSTENCILFUNCSEPARATEPROC (int face, int func, int reference, uint mask);
public delegate void PFNGLSTENCILMASKSEPARATEPROC (int face, uint mask);
public delegate void PFNGLATTACHSHADERPROC (uint program, uint shader);
public delegate void PFNGLBINDATTRIBLOCATIONPROC (uint program, uint index,  char *name);
public delegate void PFNGLCOMPILESHADERPROC (uint shader);
public delegate void PFNGLDELETEPROGRAMPROC (uint program);
public delegate void PFNGLDELETESHADERPROC (uint shader);
public delegate void PFNGLDETACHSHADERPROC (uint program, uint shader);
public delegate void PFNGLDISABLEVERTEXATTRIBARRAYPROC (uint index);
public delegate void PFNGLENABLEVERTEXATTRIBARRAYPROC (uint index);
public delegate void PFNGLGETACTIVEATTRIBPROC (uint program, uint index, uint bufSize, uint *length, int *size, int *type, char *name);
public delegate void PFNGLGETACTIVEUNIFORMPROC (uint program, uint index, uint bufSize, uint *length, int *size, int *type, char *name);
public delegate void PFNGLGETATTACHEDSHADERSPROC (uint program, uint maxCount, uint *count, uint *shaders);
public delegate void PFNGLGETPROGRAMIVPROC (uint program, int pname, int *prms);
public delegate void PFNGLGETPROGRAMINFOLOGPROC (uint program, uint bufSize, uint *length, char *infoLog);
public delegate void PFNGLGETSHADERIVPROC (uint shader, int pname, int *prms);
public delegate void PFNGLGETSHADERINFOLOGPROC (uint shader, uint bufSize, uint *length, char *infoLog);
public delegate void PFNGLGETSHADERSOURCEPROC (uint shader, uint bufSize, uint *length, char *source);
public delegate void PFNGLGETUNIFORMFVPROC (uint program, int location, float *prms);
public delegate void PFNGLGETUNIFORMIVPROC (uint program, int location, int *prms);
public delegate void PFNGLGETVERTEXATTRIBDVPROC (uint index, int pname, double *prms);
public delegate void PFNGLGETVERTEXATTRIBFVPROC (uint index, int pname, float *prms);
public delegate void PFNGLGETVERTEXATTRIBIVPROC (uint index, int pname, int *prms);
public delegate void PFNGLGETVERTEXATTRIBPOINTERVPROC (uint index, int pname, void **pointer);
public delegate void PFNGLLINKPROGRAMPROC (uint program);
public delegate void PFNGLSHADERSOURCEPROC (uint shader, uint count,  char **str,  int *length);
public delegate void PFNGLUSEPROGRAMPROC (uint program);
public delegate void PFNGLUNIFORM1FPROC (int location, float v0);
public delegate void PFNGLUNIFORM2FPROC (int location, float v0, float v1);
public delegate void PFNGLUNIFORM3FPROC (int location, float v0, float v1, float v2);
public delegate void PFNGLUNIFORM4FPROC (int location, float v0, float v1, float v2, float v3);
public delegate void PFNGLUNIFORM1IPROC (int location, int v0);
public delegate void PFNGLUNIFORM2IPROC (int location, int v0, int v1);
public delegate void PFNGLUNIFORM3IPROC (int location, int v0, int v1, int v2);
public delegate void PFNGLUNIFORM4IPROC (int location, int v0, int v1, int v2, int v3);
public delegate void PFNGLUNIFORM1FVPROC (int location, uint count,  float *value);
public delegate void PFNGLUNIFORM2FVPROC (int location, uint count,  float *value);
public delegate void PFNGLUNIFORM3FVPROC (int location, uint count,  float *value);
public delegate void PFNGLUNIFORM4FVPROC (int location, uint count,  float *value);
public delegate void PFNGLUNIFORM1IVPROC (int location, uint count,  int *value);
public delegate void PFNGLUNIFORM2IVPROC (int location, uint count,  int *value);
public delegate void PFNGLUNIFORM3IVPROC (int location, uint count,  int *value);
public delegate void PFNGLUNIFORM4IVPROC (int location, uint count,  int *value);
public delegate void PFNGLUNIFORMMATRIX2FVPROC (int location, uint count, int transpose,  float *value);
public delegate void PFNGLUNIFORMMATRIX3FVPROC (int location, uint count, int transpose,  float *value);
public delegate void PFNGLUNIFORMMATRIX4FVPROC (int location, uint count, int transpose,  float *value);
public delegate void PFNGLVALIDATEPROGRAMPROC (uint program);
public delegate void PFNGLVERTEXATTRIB1DPROC (uint index, double x);
public delegate void PFNGLVERTEXATTRIB1DVPROC (uint index,  double *v);
public delegate void PFNGLVERTEXATTRIB1FPROC (uint index, float x);
public delegate void PFNGLVERTEXATTRIB1FVPROC (uint index,  float *v);
public delegate void PFNGLVERTEXATTRIB1SPROC (uint index, GLshort x);
public delegate void PFNGLVERTEXATTRIB1SVPROC (uint index,  GLshort *v);
public delegate void PFNGLVERTEXATTRIB2DPROC (uint index, double x, double y);
public delegate void PFNGLVERTEXATTRIB2DVPROC (uint index,  double *v);
public delegate void PFNGLVERTEXATTRIB2FPROC (uint index, float x, float y);
public delegate void PFNGLVERTEXATTRIB2FVPROC (uint index,  float *v);
public delegate void PFNGLVERTEXATTRIB2SPROC (uint index, GLshort x, GLshort y);
public delegate void PFNGLVERTEXATTRIB2SVPROC (uint index,  GLshort *v);
public delegate void PFNGLVERTEXATTRIB3DPROC (uint index, double x, double y, double z);
public delegate void PFNGLVERTEXATTRIB3DVPROC (uint index,  double *v);
public delegate void PFNGLVERTEXATTRIB3FPROC (uint index, float x, float y, float z);
public delegate void PFNGLVERTEXATTRIB3FVPROC (uint index,  float *v);
public delegate void PFNGLVERTEXATTRIB3SPROC (uint index, GLshort x, GLshort y, GLshort z);
public delegate void PFNGLVERTEXATTRIB3SVPROC (uint index,  GLshort *v);
public delegate void PFNGLVERTEXATTRIB4NBVPROC (uint index,  GLbyte *v);
public delegate void PFNGLVERTEXATTRIB4NIVPROC (uint index,  int *v);
public delegate void PFNGLVERTEXATTRIB4NSVPROC (uint index,  GLshort *v);
public delegate void PFNGLVERTEXATTRIB4NUBPROC (uint index, byte x, byte y, byte z, byte w);
public delegate void PFNGLVERTEXATTRIB4NUBVPROC (uint index,  byte *v);
public delegate void PFNGLVERTEXATTRIB4NUIVPROC (uint index,  uint *v);
public delegate void PFNGLVERTEXATTRIB4NUSVPROC (uint index,  GLushort *v);
public delegate void PFNGLVERTEXATTRIB4BVPROC (uint index,  GLbyte *v);
public delegate void PFNGLVERTEXATTRIB4DPROC (uint index, double x, double y, double z, double w);
public delegate void PFNGLVERTEXATTRIB4DVPROC (uint index,  double *v);
public delegate void PFNGLVERTEXATTRIB4FPROC (uint index, float x, float y, float z, float w);
public delegate void PFNGLVERTEXATTRIB4FVPROC (uint index,  float *v);
public delegate void PFNGLVERTEXATTRIB4IVPROC (uint index,  int *v);
public delegate void PFNGLVERTEXATTRIB4SPROC (uint index, GLshort x, GLshort y, GLshort z, GLshort w);
public delegate void PFNGLVERTEXATTRIB4SVPROC (uint index,  GLshort *v);
public delegate void PFNGLVERTEXATTRIB4UBVPROC (uint index,  byte *v);
public delegate void PFNGLVERTEXATTRIB4UIVPROC (uint index,  uint *v);
public delegate void PFNGLVERTEXATTRIB4USVPROC (uint index,  GLushort *v);
public delegate void PFNGLVERTEXATTRIBPOINTERPROC (uint index, int size, int type, int normalized, uint stride,  void *pointer);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendEquationSeparate (int modeRGB, int modeAlpha);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawBuffers (uint n,  int *bufs);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilOpSeparate (int face, int sfail, int dpfail, int dppass);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilFuncSeparate (int face, int func, int reference, uint mask);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilMaskSeparate (int face, uint mask);
	[DllImport("glfw3.dll")]
	public static extern  void glAttachShader (uint program, uint shader);
	[DllImport("glfw3.dll")]
	public static extern  void glBindAttribLocation (uint program, uint index,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glCompileShader (uint shader);
	[DllImport("glfw3.dll")]
	public static extern  uint glCreateProgram ();
	[DllImport("glfw3.dll")]
	public static extern  uint glCreateShader (int type);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteProgram (uint program);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteShader (uint shader);
	[DllImport("glfw3.dll")]
	public static extern  void glDetachShader (uint program, uint shader);
	[DllImport("glfw3.dll")]
	public static extern  void glDisableVertexAttribArray (uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glEnableVertexAttribArray (uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveAttrib (uint program, uint index, uint bufSize, uint *length, int *size, int *type, char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveUniform (uint program, uint index, uint bufSize, uint *length, int *size, int *type, char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetAttachedShaders (uint program, uint maxCount, uint *count, uint *shaders);
	[DllImport("glfw3.dll")]
	public static extern  int glGetAttribLocation (uint program,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramiv (uint program, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramInfoLog (uint program, uint bufSize, uint *length, char *infoLog);
	[DllImport("glfw3.dll")]
	public static extern  void glGetShaderiv (uint shader, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetShaderInfoLog (uint shader, uint bufSize, uint *length, char *infoLog);
	[DllImport("glfw3.dll")]
	public static extern  void glGetShaderSource (uint shader, uint bufSize, uint *length, char *source);
	[DllImport("glfw3.dll")]
	public static extern  int glGetUniformLocation (uint program,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformfv (uint program, int location, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformiv (uint program, int location, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribdv (uint index, int pname, double *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribfv (uint index, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribiv (uint index, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribPointerv (uint index, int pname, void **pointer);
	[DllImport("glfw3.dll")]
	public static extern  int glIsProgram (uint program);
	[DllImport("glfw3.dll")]
	public static extern  int glIsShader (uint shader);
	[DllImport("glfw3.dll")]
	public static extern  void glLinkProgram (uint program);
	[DllImport("glfw3.dll")]
	public static extern  void glShaderSource (uint shader, uint count,  char **str,  int *length);
	[DllImport("glfw3.dll")]
	public static extern  void glUseProgram (uint program);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1f (int location, float v0);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2f (int location, float v0, float v1);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3f (int location, float v0, float v1, float v2);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4f (int location, float v0, float v1, float v2, float v3);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1i (int location, int v0);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2i (int location, int v0, int v1);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3i (int location, int v0, int v1, int v2);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4i (int location, int v0, int v1, int v2, int v3);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1fv (int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2fv (int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3fv (int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4fv (int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1iv (int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2iv (int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3iv (int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4iv (int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix2fv (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix3fv (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix4fv (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glValidateProgram (uint program);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib1d (uint index, double x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib1dv (uint index,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib1f (uint index, float x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib1fv (uint index,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib1s (uint index, GLshort x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib1sv (uint index,  GLshort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib2d (uint index, double x, double y);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib2dv (uint index,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib2f (uint index, float x, float y);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib2fv (uint index,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib2s (uint index, GLshort x, GLshort y);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib2sv (uint index,  GLshort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib3d (uint index, double x, double y, double z);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib3dv (uint index,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib3f (uint index, float x, float y, float z);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib3fv (uint index,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib3s (uint index, GLshort x, GLshort y, GLshort z);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib3sv (uint index,  GLshort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4Nbv (uint index,  GLbyte *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4Niv (uint index,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4Nsv (uint index,  GLshort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4Nub (uint index, byte x, byte y, byte z, byte w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4Nubv (uint index,  byte *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4Nuiv (uint index,  uint *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4Nusv (uint index,  GLushort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4bv (uint index,  GLbyte *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4d (uint index, double x, double y, double z, double w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4dv (uint index,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4f (uint index, float x, float y, float z, float w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4fv (uint index,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4iv (uint index,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4s (uint index, GLshort x, GLshort y, GLshort z, GLshort w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4sv (uint index,  GLshort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4ubv (uint index,  byte *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4uiv (uint index,  uint *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttrib4usv (uint index,  GLushort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribPointer (uint index, int size, int type, int normalized, uint stride,  void *pointer);
	public const int GL_VERSION_2_1 = 1;

	public const int GL_PIXEL_PACK_BUFFER = 0x88EB;

	public const int GL_PIXEL_UNPACK_BUFFER = 0x88EC;

	public const int GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;

	public const int GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;

	public const int GL_FLOAT_MAT2x3 = 0x8B65;

	public const int GL_FLOAT_MAT2x4 = 0x8B66;

	public const int GL_FLOAT_MAT3x2 = 0x8B67;

	public const int GL_FLOAT_MAT3x4 = 0x8B68;

	public const int GL_FLOAT_MAT4x2 = 0x8B69;

	public const int GL_FLOAT_MAT4x3 = 0x8B6A;

	public const int GL_SRGB = 0x8C40;

	public const int GL_SRGB8 = 0x8C41;

	public const int GL_SRGB_ALPHA = 0x8C42;

	public const int GL_SRGB8_ALPHA8 = 0x8C43;

	public const int GL_COMPRESSED_SRGB = 0x8C48;

	public const int GL_COMPRESSED_SRGB_ALPHA = 0x8C49;

public delegate void PFNGLUNIFORMMATRIX2X3FVPROC (int location, uint count, int transpose,  float *value);
public delegate void PFNGLUNIFORMMATRIX3X2FVPROC (int location, uint count, int transpose,  float *value);
public delegate void PFNGLUNIFORMMATRIX2X4FVPROC (int location, uint count, int transpose,  float *value);
public delegate void PFNGLUNIFORMMATRIX4X2FVPROC (int location, uint count, int transpose,  float *value);
public delegate void PFNGLUNIFORMMATRIX3X4FVPROC (int location, uint count, int transpose,  float *value);
public delegate void PFNGLUNIFORMMATRIX4X3FVPROC (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix2x3fv (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix3x2fv (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix2x4fv (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix4x2fv (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix3x4fv (int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix4x3fv (int location, uint count, int transpose,  float *value);
	public const int GL_VERSION_3_0 = 1;

	public const int GL_COMPARE_REF_TO_TEXTURE = 0x884E;

	public const int GL_CLIP_DISTANCE0 = 0x3000;

	public const int GL_CLIP_DISTANCE1 = 0x3001;

	public const int GL_CLIP_DISTANCE2 = 0x3002;

	public const int GL_CLIP_DISTANCE3 = 0x3003;

	public const int GL_CLIP_DISTANCE4 = 0x3004;

	public const int GL_CLIP_DISTANCE5 = 0x3005;

	public const int GL_CLIP_DISTANCE6 = 0x3006;

	public const int GL_CLIP_DISTANCE7 = 0x3007;

	public const int GL_MAX_CLIP_DISTANCES = 0x0D32;

	public const int GL_MAJOR_VERSION = 0x821B;

	public const int GL_MINOR_VERSION = 0x821C;

	public const int GL_NUM_EXTENSIONS = 0x821D;

	public const int GL_CONTEXT_FLAGS = 0x821E;

	public const int GL_COMPRESSED_RED = 0x8225;

	public const int GL_COMPRESSED_RG = 0x8226;

	public const int GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;

	public const int GL_RGBA32F = 0x8814;

	public const int GL_RGB32F = 0x8815;

	public const int GL_RGBA16F = 0x881A;

	public const int GL_RGB16F = 0x881B;

	public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;

	public const int GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;

	public const int GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;

	public const int GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;

	public const int GL_CLAMP_READ_COLOR = 0x891C;

	public const int GL_FIXED_ONLY = 0x891D;

	public const int GL_MAX_VARYING_COMPONENTS = 0x8B4B;

	public const int GL_TEXTURE_1D_ARRAY = 0x8C18;

	public const int GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19;

	public const int GL_TEXTURE_2D_ARRAY = 0x8C1A;

	public const int GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B;

	public const int GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;

	public const int GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;

	public const int GL_R11F_G11F_B10F = 0x8C3A;

	public const int GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;

	public const int GL_RGB9_E5 = 0x8C3D;

	public const int GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;

	public const int GL_TEXTURE_SHARED_SIZE = 0x8C3F;

	public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;

	public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;

	public const int GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;

	public const int GL_PRIMITIVES_GENERATED = 0x8C87;

	public const int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;

	public const int GL_RASTERIZER_DISCARD = 0x8C89;

	public const int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;

	public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;

	public const int GL_INTERLEAVED_ATTRIBS = 0x8C8C;

	public const int GL_SEPARATE_ATTRIBS = 0x8C8D;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;

	public const int GL_RGBA32UI = 0x8D70;

	public const int GL_RGB32UI = 0x8D71;

	public const int GL_RGBA16UI = 0x8D76;

	public const int GL_RGB16UI = 0x8D77;

	public const int GL_RGBA8UI = 0x8D7C;

	public const int GL_RGB8UI = 0x8D7D;

	public const int GL_RGBA32I = 0x8D82;

	public const int GL_RGB32I = 0x8D83;

	public const int GL_RGBA16I = 0x8D88;

	public const int GL_RGB16I = 0x8D89;

	public const int GL_RGBA8I = 0x8D8E;

	public const int GL_RGB8I = 0x8D8F;

	public const int GL_RED_INTEGER = 0x8D94;

	public const int GL_GREEN_INTEGER = 0x8D95;

	public const int GL_BLUE_INTEGER = 0x8D96;

	public const int GL_RGB_INTEGER = 0x8D98;

	public const int GL_RGBA_INTEGER = 0x8D99;

	public const int GL_BGR_INTEGER = 0x8D9A;

	public const int GL_BGRA_INTEGER = 0x8D9B;

	public const int GL_SAMPLER_1D_ARRAY = 0x8DC0;

	public const int GL_SAMPLER_2D_ARRAY = 0x8DC1;

	public const int GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;

	public const int GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;

	public const int GL_SAMPLER_CUBE_SHADOW = 0x8DC5;

	public const int GL_UNSIGNED_INT_VEC2 = 0x8DC6;

	public const int GL_UNSIGNED_INT_VEC3 = 0x8DC7;

	public const int GL_UNSIGNED_INT_VEC4 = 0x8DC8;

	public const int GL_INT_SAMPLER_1D = 0x8DC9;

	public const int GL_INT_SAMPLER_2D = 0x8DCA;

	public const int GL_INT_SAMPLER_3D = 0x8DCB;

	public const int GL_INT_SAMPLER_CUBE = 0x8DCC;

	public const int GL_INT_SAMPLER_1D_ARRAY = 0x8DCE;

	public const int GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;

	public const int GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1;

	public const int GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;

	public const int GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;

	public const int GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;

	public const int GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;

	public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;

	public const int GL_QUERY_WAIT = 0x8E13;

	public const int GL_QUERY_NO_WAIT = 0x8E14;

	public const int GL_QUERY_BY_REGION_WAIT = 0x8E15;

	public const int GL_QUERY_BY_REGION_NO_WAIT = 0x8E16;

	public const int GL_BUFFER_ACCESS_FLAGS = 0x911F;

	public const int GL_BUFFER_MAP_LENGTH = 0x9120;

	public const int GL_BUFFER_MAP_OFFSET = 0x9121;

	public const int GL_DEPTH_COMPONENT32F = 0x8CAC;

	public const int GL_DEPTH32F_STENCIL8 = 0x8CAD;

	public const int GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;

	public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;

	public const int GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;

	public const int GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;

	public const int GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;

	public const int GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;

	public const int GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;

	public const int GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;

	public const int GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;

	public const int GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;

	public const int GL_FRAMEBUFFER_DEFAULT = 0x8218;

	public const int GL_FRAMEBUFFER_UNDEFINED = 0x8219;

	public const int GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;

	public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;

	public const int GL_DEPTH_STENCIL = 0x84F9;

	public const int GL_UNSIGNED_INT_24_8 = 0x84FA;

	public const int GL_DEPTH24_STENCIL8 = 0x88F0;

	public const int GL_TEXTURE_STENCIL_SIZE = 0x88F1;

	public const int GL_TEXTURE_RED_TYPE = 0x8C10;

	public const int GL_TEXTURE_GREEN_TYPE = 0x8C11;

	public const int GL_TEXTURE_BLUE_TYPE = 0x8C12;

	public const int GL_TEXTURE_ALPHA_TYPE = 0x8C13;

	public const int GL_TEXTURE_DEPTH_TYPE = 0x8C16;

	public const int GL_UNSIGNED_NORMALIZED = 0x8C17;

	public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;

	public const int GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;

	public const int GL_RENDERBUFFER_BINDING = 0x8CA7;

	public const int GL_READ_FRAMEBUFFER = 0x8CA8;

	public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;

	public const int GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;

	public const int GL_RENDERBUFFER_SAMPLES = 0x8CAB;

	public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;

	public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;

	public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;

	public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;

	public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;

	public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;

	public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;

	public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;

	public const int GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;

	public const int GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;

	public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;

	public const int GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;

	public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;

	public const int GL_COLOR_ATTACHMENT1 = 0x8CE1;

	public const int GL_COLOR_ATTACHMENT2 = 0x8CE2;

	public const int GL_COLOR_ATTACHMENT3 = 0x8CE3;

	public const int GL_COLOR_ATTACHMENT4 = 0x8CE4;

	public const int GL_COLOR_ATTACHMENT5 = 0x8CE5;

	public const int GL_COLOR_ATTACHMENT6 = 0x8CE6;

	public const int GL_COLOR_ATTACHMENT7 = 0x8CE7;

	public const int GL_COLOR_ATTACHMENT8 = 0x8CE8;

	public const int GL_COLOR_ATTACHMENT9 = 0x8CE9;

	public const int GL_COLOR_ATTACHMENT10 = 0x8CEA;

	public const int GL_COLOR_ATTACHMENT11 = 0x8CEB;

	public const int GL_COLOR_ATTACHMENT12 = 0x8CEC;

	public const int GL_COLOR_ATTACHMENT13 = 0x8CED;

	public const int GL_COLOR_ATTACHMENT14 = 0x8CEE;

	public const int GL_COLOR_ATTACHMENT15 = 0x8CEF;

	public const int GL_COLOR_ATTACHMENT16 = 0x8CF0;

	public const int GL_COLOR_ATTACHMENT17 = 0x8CF1;

	public const int GL_COLOR_ATTACHMENT18 = 0x8CF2;

	public const int GL_COLOR_ATTACHMENT19 = 0x8CF3;

	public const int GL_COLOR_ATTACHMENT20 = 0x8CF4;

	public const int GL_COLOR_ATTACHMENT21 = 0x8CF5;

	public const int GL_COLOR_ATTACHMENT22 = 0x8CF6;

	public const int GL_COLOR_ATTACHMENT23 = 0x8CF7;

	public const int GL_COLOR_ATTACHMENT24 = 0x8CF8;

	public const int GL_COLOR_ATTACHMENT25 = 0x8CF9;

	public const int GL_COLOR_ATTACHMENT26 = 0x8CFA;

	public const int GL_COLOR_ATTACHMENT27 = 0x8CFB;

	public const int GL_COLOR_ATTACHMENT28 = 0x8CFC;

	public const int GL_COLOR_ATTACHMENT29 = 0x8CFD;

	public const int GL_COLOR_ATTACHMENT30 = 0x8CFE;

	public const int GL_COLOR_ATTACHMENT31 = 0x8CFF;

	public const int GL_DEPTH_ATTACHMENT = 0x8D00;

	public const int GL_STENCIL_ATTACHMENT = 0x8D20;

	public const int GL_FRAMEBUFFER = 0x8D40;

	public const int GL_RENDERBUFFER = 0x8D41;

	public const int GL_RENDERBUFFER_WIDTH = 0x8D42;

	public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;

	public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;

	public const int GL_STENCIL_INDEX1 = 0x8D46;

	public const int GL_STENCIL_INDEX4 = 0x8D47;

	public const int GL_STENCIL_INDEX8 = 0x8D48;

	public const int GL_STENCIL_INDEX16 = 0x8D49;

	public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;

	public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;

	public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;

	public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;

	public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;

	public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;

	public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;

	public const int GL_MAX_SAMPLES = 0x8D57;

	public const int GL_FRAMEBUFFER_SRGB = 0x8DB9;

	public const int GL_HALF_FLOAT = 0x140B;

	public const int GL_MAP_READ_BIT = 0x0001;

	public const int GL_MAP_WRITE_BIT = 0x0002;

	public const int GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;

	public const int GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;

	public const int GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;

	public const int GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;

	public const int GL_COMPRESSED_RED_RGTC1 = 0x8DBB;

	public const int GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;

	public const int GL_COMPRESSED_RG_RGTC2 = 0x8DBD;

	public const int GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;

	public const int GL_RG = 0x8227;

	public const int GL_RG_INTEGER = 0x8228;

	public const int GL_R8 = 0x8229;

	public const int GL_R16 = 0x822A;

	public const int GL_RG8 = 0x822B;

	public const int GL_RG16 = 0x822C;

	public const int GL_R16F = 0x822D;

	public const int GL_R32F = 0x822E;

	public const int GL_RG16F = 0x822F;

	public const int GL_RG32F = 0x8230;

	public const int GL_R8I = 0x8231;

	public const int GL_R8UI = 0x8232;

	public const int GL_R16I = 0x8233;

	public const int GL_R16UI = 0x8234;

	public const int GL_R32I = 0x8235;

	public const int GL_R32UI = 0x8236;

	public const int GL_RG8I = 0x8237;

	public const int GL_RG8UI = 0x8238;

	public const int GL_RG16I = 0x8239;

	public const int GL_RG16UI = 0x823A;

	public const int GL_RG32I = 0x823B;

	public const int GL_RG32UI = 0x823C;

	public const int GL_VERTEX_ARRAY_BINDING = 0x85B5;

public delegate void PFNGLCOLORMASKIPROC (uint index, int r, int g, int b, int a);
public delegate void PFNGLGETBOOLEANI_VPROC (int target, uint index, int *data);
public delegate void PFNGLGETINTEGERI_VPROC (int target, uint index, int *data);
public delegate void PFNGLENABLEIPROC (int target, uint index);
public delegate void PFNGLDISABLEIPROC (int target, uint index);
public delegate void PFNGLBEGINTRANSFORMFEEDBACKPROC (int primitiveMode);
public delegate void PFNGLENDTRANSFORMFEEDBACKPROC ();
public delegate void PFNGLBINDBUFFERRANGEPROC (int target, uint index, uint buffer, int* offset, uint* size);
public delegate void PFNGLBINDBUFFERBASEPROC (int target, uint index, uint buffer);
public delegate void PFNGLTRANSFORMFEEDBACKVARYINGSPROC (uint program, uint count,  char **varyings, int bufferMode);
public delegate void PFNGLGETTRANSFORMFEEDBACKVARYINGPROC (uint program, uint index, uint bufSize, uint *length, uint *size, int *type, char *name);
public delegate void PFNGLCLAMPCOLORPROC (int target, int clamp);
public delegate void PFNGLBEGINCONDITIONALRENDERPROC (uint id, int mode);
public delegate void PFNGLENDCONDITIONALRENDERPROC ();
public delegate void PFNGLVERTEXATTRIBIPOINTERPROC (uint index, int size, int type, uint stride,  void *pointer);
public delegate void PFNGLGETVERTEXATTRIBIIVPROC (uint index, int pname, int *prms);
public delegate void PFNGLGETVERTEXATTRIBIUIVPROC (uint index, int pname, uint *prms);
public delegate void PFNGLVERTEXATTRIBI1IPROC (uint index, int x);
public delegate void PFNGLVERTEXATTRIBI2IPROC (uint index, int x, int y);
public delegate void PFNGLVERTEXATTRIBI3IPROC (uint index, int x, int y, int z);
public delegate void PFNGLVERTEXATTRIBI4IPROC (uint index, int x, int y, int z, int w);
public delegate void PFNGLVERTEXATTRIBI1UIPROC (uint index, uint x);
public delegate void PFNGLVERTEXATTRIBI2UIPROC (uint index, uint x, uint y);
public delegate void PFNGLVERTEXATTRIBI3UIPROC (uint index, uint x, uint y, uint z);
public delegate void PFNGLVERTEXATTRIBI4UIPROC (uint index, uint x, uint y, uint z, uint w);
public delegate void PFNGLVERTEXATTRIBI1IVPROC (uint index,  int *v);
public delegate void PFNGLVERTEXATTRIBI2IVPROC (uint index,  int *v);
public delegate void PFNGLVERTEXATTRIBI3IVPROC (uint index,  int *v);
public delegate void PFNGLVERTEXATTRIBI4IVPROC (uint index,  int *v);
public delegate void PFNGLVERTEXATTRIBI1UIVPROC (uint index,  uint *v);
public delegate void PFNGLVERTEXATTRIBI2UIVPROC (uint index,  uint *v);
public delegate void PFNGLVERTEXATTRIBI3UIVPROC (uint index,  uint *v);
public delegate void PFNGLVERTEXATTRIBI4UIVPROC (uint index,  uint *v);
public delegate void PFNGLVERTEXATTRIBI4BVPROC (uint index,  GLbyte *v);
public delegate void PFNGLVERTEXATTRIBI4SVPROC (uint index,  GLshort *v);
public delegate void PFNGLVERTEXATTRIBI4UBVPROC (uint index,  byte *v);
public delegate void PFNGLVERTEXATTRIBI4USVPROC (uint index,  GLushort *v);
public delegate void PFNGLGETUNIFORMUIVPROC (uint program, int location, uint *prms);
public delegate void PFNGLBINDFRAGDATALOCATIONPROC (uint program, uint color,  char *name);
public delegate void PFNGLUNIFORM1UIPROC (int location, uint v0);
public delegate void PFNGLUNIFORM2UIPROC (int location, uint v0, uint v1);
public delegate void PFNGLUNIFORM3UIPROC (int location, uint v0, uint v1, uint v2);
public delegate void PFNGLUNIFORM4UIPROC (int location, uint v0, uint v1, uint v2, uint v3);
public delegate void PFNGLUNIFORM1UIVPROC (int location, uint count,  uint *value);
public delegate void PFNGLUNIFORM2UIVPROC (int location, uint count,  uint *value);
public delegate void PFNGLUNIFORM3UIVPROC (int location, uint count,  uint *value);
public delegate void PFNGLUNIFORM4UIVPROC (int location, uint count,  uint *value);
public delegate void PFNGLTEXPARAMETERIIVPROC (int target, int pname,  int *prms);
public delegate void PFNGLTEXPARAMETERIUIVPROC (int target, int pname,  uint *prms);
public delegate void PFNGLGETTEXPARAMETERIIVPROC (int target, int pname, int *prms);
public delegate void PFNGLGETTEXPARAMETERIUIVPROC (int target, int pname, uint *prms);
public delegate void PFNGLCLEARBUFFERIVPROC (int buffer, int drawbuffer,  int *value);
public delegate void PFNGLCLEARBUFFERUIVPROC (int buffer, int drawbuffer,  uint *value);
public delegate void PFNGLCLEARBUFFERFVPROC (int buffer, int drawbuffer,  float *value);
public delegate void PFNGLCLEARBUFFERFIPROC (int buffer, int drawbuffer, float depth, int stencil);
public delegate void PFNGLBINDRENDERBUFFERPROC (int target, uint renderbuffer);
public delegate void PFNGLDELETERENDERBUFFERSPROC (uint n,  uint *renderbuffers);
public delegate void PFNGLGENRENDERBUFFERSPROC (uint n, uint *renderbuffers);
public delegate void PFNGLRENDERBUFFERSTORAGEPROC (int target, int internalformat, uint width, uint height);
public delegate void PFNGLGETRENDERBUFFERPARAMETERIVPROC (int target, int pname, int *prms);
public delegate void PFNGLBINDFRAMEBUFFERPROC (int target, uint framebuffer);
public delegate void PFNGLDELETEFRAMEBUFFERSPROC (uint n,  uint *framebuffers);
public delegate void PFNGLGENFRAMEBUFFERSPROC (uint n, uint *framebuffers);
public delegate void PFNGLFRAMEBUFFERTEXTURE1DPROC (int target, int attachment, int textarget, uint texture, int level);
public delegate void PFNGLFRAMEBUFFERTEXTURE2DPROC (int target, int attachment, int textarget, uint texture, int level);
public delegate void PFNGLFRAMEBUFFERTEXTURE3DPROC (int target, int attachment, int textarget, uint texture, int level, int zoffset);
public delegate void PFNGLFRAMEBUFFERRENDERBUFFERPROC (int target, int attachment, int renderbuffertarget, uint renderbuffer);
public delegate void PFNGLGETFRAMEBUFFERATTACHMENTPARAMETERIVPROC (int target, int attachment, int pname, int *prms);
public delegate void PFNGLGENERATEMIPMAPPROC (int target);
public delegate void PFNGLBLITFRAMEBUFFERPROC (int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);
public delegate void PFNGLRENDERBUFFERSTORAGEMULTISAMPLEPROC (int target, uint samples, int internalformat, uint width, uint height);
public delegate void PFNGLFRAMEBUFFERTEXTURELAYERPROC (int target, int attachment, uint texture, int level, int layer);
public delegate void PFNGLFLUSHMAPPEDBUFFERRANGEPROC (int target, int* offset, uint* length);
public delegate void PFNGLBINDVERTEXARRAYPROC (uint array);
public delegate void PFNGLDELETEVERTEXARRAYSPROC (uint n,  uint *arrays);
public delegate void PFNGLGENVERTEXARRAYSPROC (uint n, uint *arrays);
	[DllImport("glfw3.dll")]
	public static extern  void glColorMaski (uint index, int r, int g, int b, int a);
	[DllImport("glfw3.dll")]
	public static extern  void glGetBooleani_v (int target, uint index, int *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetIntegeri_v (int target, uint index, int *data);
	[DllImport("glfw3.dll")]
	public static extern  void glEnablei (int target, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glDisablei (int target, uint index);
	[DllImport("glfw3.dll")]
	public static extern  int glIsEnabledi (int target, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glBeginTransformFeedback (int primitiveMode);
	[DllImport("glfw3.dll")]
	public static extern  void glEndTransformFeedback ();
	[DllImport("glfw3.dll")]
	public static extern  void glBindBufferRange (int target, uint index, uint buffer, int* offset, uint* size);
	[DllImport("glfw3.dll")]
	public static extern  void glBindBufferBase (int target, uint index, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glTransformFeedbackVaryings (uint program, uint count,  char **varyings, int bufferMode);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTransformFeedbackVarying (uint program, uint index, uint bufSize, uint *length, uint *size, int *type, char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glClampColor (int target, int clamp);
	[DllImport("glfw3.dll")]
	public static extern  void glBeginConditionalRender (uint id, int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glEndConditionalRender ();
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribIPointer (uint index, int size, int type, uint stride,  void *pointer);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribIiv (uint index, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribIuiv (uint index, int pname, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI1i (uint index, int x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI2i (uint index, int x, int y);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI3i (uint index, int x, int y, int z);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI4i (uint index, int x, int y, int z, int w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI1ui (uint index, uint x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI2ui (uint index, uint x, uint y);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI3ui (uint index, uint x, uint y, uint z);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI4ui (uint index, uint x, uint y, uint z, uint w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI1iv (uint index,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI2iv (uint index,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI3iv (uint index,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI4iv (uint index,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI1uiv (uint index,  uint *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI2uiv (uint index,  uint *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI3uiv (uint index,  uint *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI4uiv (uint index,  uint *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI4bv (uint index,  GLbyte *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI4sv (uint index,  GLshort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI4ubv (uint index,  byte *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribI4usv (uint index,  GLushort *v);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformuiv (uint program, int location, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glBindFragDataLocation (uint program, uint color,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  int glGetFragDataLocation (uint program,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1ui (int location, uint v0);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2ui (int location, uint v0, uint v1);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3ui (int location, uint v0, uint v1, uint v2);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4ui (int location, uint v0, uint v1, uint v2, uint v3);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1uiv (int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2uiv (int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3uiv (int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4uiv (int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glTexParameterIiv (int target, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTexParameterIuiv (int target, int pname,  uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTexParameterIiv (int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTexParameterIuiv (int target, int pname, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glClearBufferiv (int buffer, int drawbuffer,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glClearBufferuiv (int buffer, int drawbuffer,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glClearBufferfv (int buffer, int drawbuffer,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glClearBufferfi (int buffer, int drawbuffer, float depth, int stencil);
	[DllImport("glfw3.dll")]
	public static extern   byte  glGetStringi (int name, uint index);
	[DllImport("glfw3.dll")]
	public static extern  int glIsRenderbuffer (uint renderbuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glBindRenderbuffer (int target, uint renderbuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteRenderbuffers (uint n,  uint *renderbuffers);
	[DllImport("glfw3.dll")]
	public static extern  void glGenRenderbuffers (uint n, uint *renderbuffers);
	[DllImport("glfw3.dll")]
	public static extern  void glRenderbufferStorage (int target, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glGetRenderbufferParameteriv (int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  int glIsFramebuffer (uint framebuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glBindFramebuffer (int target, uint framebuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteFramebuffers (uint n,  uint *framebuffers);
	[DllImport("glfw3.dll")]
	public static extern  void glGenFramebuffers (uint n, uint *framebuffers);
	[DllImport("glfw3.dll")]
	public static extern  int glCheckFramebufferStatus (int target);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTexture1D (int target, int attachment, int textarget, uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTexture2D (int target, int attachment, int textarget, uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTexture3D (int target, int attachment, int textarget, uint texture, int level, int zoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferRenderbuffer (int target, int attachment, int renderbuffertarget, uint renderbuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glGetFramebufferAttachmentParameteriv (int target, int attachment, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGenerateMipmap (int target);
	[DllImport("glfw3.dll")]
	public static extern  void glBlitFramebuffer (int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);
	[DllImport("glfw3.dll")]
	public static extern  void glRenderbufferStorageMultisample (int target, uint samples, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTextureLayer (int target, int attachment, uint texture, int level, int layer);
	[DllImport("glfw3.dll")]
	public static extern  void  glMapBufferRange (int target, int* offset, uint* length, int access);
	[DllImport("glfw3.dll")]
	public static extern  void glFlushMappedBufferRange (int target, int* offset, uint* length);
	[DllImport("glfw3.dll")]
	public static extern  void glBindVertexArray (uint array);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteVertexArrays (uint n,  uint *arrays);
	[DllImport("glfw3.dll")]
	public static extern  void glGenVertexArrays (uint n, uint *arrays);
	[DllImport("glfw3.dll")]
	public static extern  int glIsVertexArray (uint array);
	public const int GL_VERSION_3_1 = 1;

	public const int GL_SAMPLER_2D_RECT = 0x8B63;

	public const int GL_SAMPLER_2D_RECT_SHADOW = 0x8B64;

	public const int GL_SAMPLER_BUFFER = 0x8DC2;

	public const int GL_INT_SAMPLER_2D_RECT = 0x8DCD;

	public const int GL_INT_SAMPLER_BUFFER = 0x8DD0;

	public const int GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;

	public const int GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;

	public const int GL_TEXTURE_BUFFER = 0x8C2A;

	public const int GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;

	public const int GL_TEXTURE_BINDING_BUFFER = 0x8C2C;

	public const int GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;

	public const int GL_TEXTURE_RECTANGLE = 0x84F5;

	public const int GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;

	public const int GL_PROXY_TEXTURE_RECTANGLE = 0x84F7;

	public const int GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;

	public const int GL_R8_SNORM = 0x8F94;

	public const int GL_RG8_SNORM = 0x8F95;

	public const int GL_RGB8_SNORM = 0x8F96;

	public const int GL_RGBA8_SNORM = 0x8F97;

	public const int GL_R16_SNORM = 0x8F98;

	public const int GL_RG16_SNORM = 0x8F99;

	public const int GL_RGB16_SNORM = 0x8F9A;

	public const int GL_RGBA16_SNORM = 0x8F9B;

	public const int GL_SIGNED_NORMALIZED = 0x8F9C;

	public const int GL_PRIMITIVE_RESTART = 0x8F9D;

	public const int GL_PRIMITIVE_RESTART_INDEX = 0x8F9E;

	public const int GL_COPY_READ_BUFFER = 0x8F36;

	public const int GL_COPY_WRITE_BUFFER = 0x8F37;

	public const int GL_UNIFORM_BUFFER = 0x8A11;

	public const int GL_UNIFORM_BUFFER_BINDING = 0x8A28;

	public const int GL_UNIFORM_BUFFER_START = 0x8A29;

	public const int GL_UNIFORM_BUFFER_SIZE = 0x8A2A;

	public const int GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;

	public const int GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;

	public const int GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;

	public const int GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;

	public const int GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;

	public const int GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;

	public const int GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;

	public const int GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;

	public const int GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;

	public const int GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;

	public const int GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;

	public const int GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;

	public const int GL_UNIFORM_TYPE = 0x8A37;

	public const int GL_UNIFORM_SIZE = 0x8A38;

	public const int GL_UNIFORM_NAME_LENGTH = 0x8A39;

	public const int GL_UNIFORM_BLOCK_INDEX = 0x8A3A;

	public const int GL_UNIFORM_OFFSET = 0x8A3B;

	public const int GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;

	public const int GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;

	public const int GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;

	public const int GL_UNIFORM_BLOCK_BINDING = 0x8A3F;

	public const int GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;

	public const int GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;

	public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;

	public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;

	public const int GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;

	public const int GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;

	public const int GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;

	public const int GL_INVALID_INDEX = 0xFFFFFFFFu;

public delegate void PFNGLDRAWARRAYSINSTANCEDPROC (int mode, int first, uint count, uint instancecount);
public delegate void PFNGLDRAWELEMENTSINSTANCEDPROC (int mode, uint count, int type,  void *indices, uint instancecount);
public delegate void PFNGLTEXBUFFERPROC (int target, int internalformat, uint buffer);
public delegate void PFNGLPRIMITIVERESTARTINDEXPROC (uint index);
public delegate void PFNGLCOPYBUFFERSUBDATAPROC (int readTarget, int writeTarget, int* readOffset, int* writeOffset, uint* size);
public delegate void PFNGLGETUNIFORMINDICESPROC (uint program, uint uniformCount,  char **uniformNames, uint *uniformIndices);
public delegate void PFNGLGETACTIVEUNIFORMSIVPROC (uint program, uint uniformCount,  uint *uniformIndices, int pname, int *prms);
public delegate void PFNGLGETACTIVEUNIFORMNAMEPROC (uint program, uint uniformIndex, uint bufSize, uint *length, char *uniformName);
public delegate void PFNGLGETACTIVEUNIFORMBLOCKIVPROC (uint program, uint uniformBlockIndex, int pname, int *prms);
public delegate void PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC (uint program, uint uniformBlockIndex, uint bufSize, uint *length, char *uniformBlockName);
public delegate void PFNGLUNIFORMBLOCKBINDINGPROC (uint program, uint uniformBlockIndex, uint uniformBlockBinding);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawArraysInstanced (int mode, int first, uint count, uint instancecount);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElementsInstanced (int mode, uint count, int type,  void *indices, uint instancecount);
	[DllImport("glfw3.dll")]
	public static extern  void glTexBuffer (int target, int internalformat, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glPrimitiveRestartIndex (uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyBufferSubData (int readTarget, int writeTarget, int* readOffset, int* writeOffset, uint* size);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformIndices (uint program, uint uniformCount,  char **uniformNames, uint *uniformIndices);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveUniformsiv (uint program, uint uniformCount,  uint *uniformIndices, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveUniformName (uint program, uint uniformIndex, uint bufSize, uint *length, char *uniformName);
	[DllImport("glfw3.dll")]
	public static extern  uint glGetUniformBlockIndex (uint program,  char *uniformBlockName);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveUniformBlockiv (uint program, uint uniformBlockIndex, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveUniformBlockName (uint program, uint uniformBlockIndex, uint bufSize, uint *length, char *uniformBlockName);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformBlockBinding (uint program, uint uniformBlockIndex, uint uniformBlockBinding);
	public const int GL_VERSION_3_2 = 1;

public struct __GLsync {}
	public const int GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001;

	public const int GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;

	public const int GL_LINES_ADJACENCY = 0x000A;

	public const int GL_LINE_STRIP_ADJACENCY = 0x000B;

	public const int GL_TRIANGLES_ADJACENCY = 0x000C;

	public const int GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;

	public const int GL_PROGRAM_POINT_SIZE = 0x8642;

	public const int GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;

	public const int GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;

	public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;

	public const int GL_GEOMETRY_SHADER = 0x8DD9;

	public const int GL_GEOMETRY_VERTICES_OUT = 0x8916;

	public const int GL_GEOMETRY_INPUT_TYPE = 0x8917;

	public const int GL_GEOMETRY_OUTPUT_TYPE = 0x8918;

	public const int GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;

	public const int GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;

	public const int GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;

	public const int GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;

	public const int GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;

	public const int GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;

	public const int GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;

	public const int GL_CONTEXT_PROFILE_MASK = 0x9126;

	public const int GL_DEPTH_CLAMP = 0x864F;

	public const int GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;

	public const int GL_FIRST_VERTEX_CONVENTION = 0x8E4D;

	public const int GL_LAST_VERTEX_CONVENTION = 0x8E4E;

	public const int GL_PROVOKING_VERTEX = 0x8E4F;

	public const int GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;

	public const int GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;

	public const int GL_OBJECT_TYPE = 0x9112;

	public const int GL_SYNC_CONDITION = 0x9113;

	public const int GL_SYNC_STATUS = 0x9114;

	public const int GL_SYNC_FLAGS = 0x9115;

	public const int GL_SYNC_FENCE = 0x9116;

	public const int GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;

	public const int GL_UNSIGNALED = 0x9118;

	public const int GL_SIGNALED = 0x9119;

	public const int GL_ALREADY_SIGNALED = 0x911A;

	public const int GL_TIMEOUT_EXPIRED = 0x911B;

	public const int GL_CONDITION_SATISFIED = 0x911C;

	public const int GL_WAIT_FAILED = 0x911D;

	public const int GL_TIMEOUT_IGNORED = 18446744073709551615;

	public const int GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;

	public const int GL_SAMPLE_POSITION = 0x8E50;

	public const int GL_SAMPLE_MASK = 0x8E51;

	public const int GL_SAMPLE_MASK_VALUE = 0x8E52;

	public const int GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;

	public const int GL_TEXTURE_2D_MULTISAMPLE = 0x9100;

	public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;

	public const int GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;

	public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;

	public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;

	public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;

	public const int GL_TEXTURE_SAMPLES = 0x9106;

	public const int GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;

	public const int GL_SAMPLER_2D_MULTISAMPLE = 0x9108;

	public const int GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;

	public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;

	public const int GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;

	public const int GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;

	public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;

	public const int GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;

	public const int GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;

	public const int GL_MAX_INTEGER_SAMPLES = 0x9110;

public delegate void PFNGLDRAWELEMENTSBASEVERTEXPROC (int mode, uint count, int type,  void *indices, int basevertex);
public delegate void PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC (int mode, uint start, uint end, uint count, int type,  void *indices, int basevertex);
public delegate void PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC (int mode, uint count, int type,  void *indices, uint instancecount, int basevertex);
public delegate void PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC (int mode,  uint *count, int type,  void **indices, uint drawcount,  int *basevertex);
public delegate void PFNGLPROVOKINGVERTEXPROC (int mode);
public delegate IntPtr PFNGLFENCESYNCPROC (int condition, int flags);
public delegate void PFNGLDELETESYNCPROC (IntPtr sync);
public delegate void PFNGLWAITSYNCPROC (IntPtr sync, int flags, ulong timeout);
public delegate void PFNGLGETINTEGER64VPROC (int pname, int64 *data);
public delegate void PFNGLGETSYNCIVPROC (IntPtr sync, int pname, uint count, uint *length, int *values);
public delegate void PFNGLGETINTEGER64I_VPROC (int target, uint index, int64 *data);
public delegate void PFNGLGETBUFFERPARAMETERI64VPROC (int target, int pname, int64 *prms);
public delegate void PFNGLFRAMEBUFFERTEXTUREPROC (int target, int attachment, uint texture, int level);
public delegate void PFNGLTEXIMAGE2DMULTISAMPLEPROC (int target, uint samples, int internalformat, uint width, uint height, int fixedsamplelocations);
public delegate void PFNGLTEXIMAGE3DMULTISAMPLEPROC (int target, uint samples, int internalformat, uint width, uint height, uint depth, int fixedsamplelocations);
public delegate void PFNGLGETMULTISAMPLEFVPROC (int pname, uint index, float *val);
public delegate void PFNGLSAMPLEMASKIPROC (uint maskNumber, int mask);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElementsBaseVertex (int mode, uint count, int type,  void *indices, int basevertex);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawRangeElementsBaseVertex (int mode, uint start, uint end, uint count, int type,  void *indices, int basevertex);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElementsInstancedBaseVertex (int mode, uint count, int type,  void *indices, uint instancecount, int basevertex);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawElementsBaseVertex (int mode,  uint *count, int type,  void **indices, uint drawcount,  int *basevertex);
	[DllImport("glfw3.dll")]
	public static extern  void glProvokingVertex (int mode);
	[DllImport("glfw3.dll")]
	public static extern  IntPtr glFenceSync (int condition, int flags);
	[DllImport("glfw3.dll")]
	public static extern  int glIsSync (IntPtr sync);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteSync (IntPtr sync);
	[DllImport("glfw3.dll")]
	public static extern  int glClientWaitSync (IntPtr sync, int flags, ulong timeout);
	[DllImport("glfw3.dll")]
	public static extern  void glWaitSync (IntPtr sync, int flags, ulong timeout);
	[DllImport("glfw3.dll")]
	public static extern  void glGetInteger64v (int pname, int64 *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetSynciv (IntPtr sync, int pname, uint count, uint *length, int *values);
	[DllImport("glfw3.dll")]
	public static extern  void glGetInteger64i_v (int target, uint index, int64 *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetBufferParameteri64v (int target, int pname, int64 *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTexture (int target, int attachment, uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glTexImage2DMultisample (int target, uint samples, int internalformat, uint width, uint height, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glTexImage3DMultisample (int target, uint samples, int internalformat, uint width, uint height, uint depth, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultisamplefv (int pname, uint index, float *val);
	[DllImport("glfw3.dll")]
	public static extern  void glSampleMaski (uint maskNumber, int mask);
	public const int GL_VERSION_3_3 = 1;

	public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;

	public const int GL_SRC1_COLOR = 0x88F9;

	public const int GL_ONE_MINUS_SRC1_COLOR = 0x88FA;

	public const int GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;

	public const int GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;

	public const int GL_ANY_SAMPLES_PASSED = 0x8C2F;

	public const int GL_SAMPLER_BINDING = 0x8919;

	public const int GL_RGB10_A2UI = 0x906F;

	public const int GL_TEXTURE_SWIZZLE_R = 0x8E42;

	public const int GL_TEXTURE_SWIZZLE_G = 0x8E43;

	public const int GL_TEXTURE_SWIZZLE_B = 0x8E44;

	public const int GL_TEXTURE_SWIZZLE_A = 0x8E45;

	public const int GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;

	public const int GL_TIME_ELAPSED = 0x88BF;

	public const int GL_TIMESTAMP = 0x8E28;

	public const int GL_INT_2_10_10_10_REV = 0x8D9F;

public delegate void PFNGLBINDFRAGDATALOCATIONINDEXEDPROC (uint program, uint colorNumber, uint index,  char *name);
public delegate void PFNGLGENSAMPLERSPROC (uint count, uint *samplers);
public delegate void PFNGLDELETESAMPLERSPROC (uint count,  uint *samplers);
public delegate void PFNGLBINDSAMPLERPROC (uint unit, uint sampler);
public delegate void PFNGLSAMPLERPARAMETERIPROC (uint sampler, int pname, int param);
public delegate void PFNGLSAMPLERPARAMETERIVPROC (uint sampler, int pname,  int *param);
public delegate void PFNGLSAMPLERPARAMETERFPROC (uint sampler, int pname, float param);
public delegate void PFNGLSAMPLERPARAMETERFVPROC (uint sampler, int pname,  float *param);
public delegate void PFNGLSAMPLERPARAMETERIIVPROC (uint sampler, int pname,  int *param);
public delegate void PFNGLSAMPLERPARAMETERIUIVPROC (uint sampler, int pname,  uint *param);
public delegate void PFNGLGETSAMPLERPARAMETERIVPROC (uint sampler, int pname, int *prms);
public delegate void PFNGLGETSAMPLERPARAMETERIIVPROC (uint sampler, int pname, int *prms);
public delegate void PFNGLGETSAMPLERPARAMETERFVPROC (uint sampler, int pname, float *prms);
public delegate void PFNGLGETSAMPLERPARAMETERIUIVPROC (uint sampler, int pname, uint *prms);
public delegate void PFNGLQUERYCOUNTERPROC (uint id, int target);
public delegate void PFNGLGETQUERYOBJECTI64VPROC (uint id, int pname, int64 *prms);
public delegate void PFNGLGETQUERYOBJECTUI64VPROC (uint id, int pname, ulong *prms);
public delegate void PFNGLVERTEXATTRIBDIVISORPROC (uint index, uint divisor);
public delegate void PFNGLVERTEXATTRIBP1UIPROC (uint index, int type, int normalized, uint value);
public delegate void PFNGLVERTEXATTRIBP1UIVPROC (uint index, int type, int normalized,  uint *value);
public delegate void PFNGLVERTEXATTRIBP2UIPROC (uint index, int type, int normalized, uint value);
public delegate void PFNGLVERTEXATTRIBP2UIVPROC (uint index, int type, int normalized,  uint *value);
public delegate void PFNGLVERTEXATTRIBP3UIPROC (uint index, int type, int normalized, uint value);
public delegate void PFNGLVERTEXATTRIBP3UIVPROC (uint index, int type, int normalized,  uint *value);
public delegate void PFNGLVERTEXATTRIBP4UIPROC (uint index, int type, int normalized, uint value);
public delegate void PFNGLVERTEXATTRIBP4UIVPROC (uint index, int type, int normalized,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glBindFragDataLocationIndexed (uint program, uint colorNumber, uint index,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  int glGetFragDataIndex (uint program,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGenSamplers (uint count, uint *samplers);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteSamplers (uint count,  uint *samplers);
	[DllImport("glfw3.dll")]
	public static extern  int glIsSampler (uint sampler);
	[DllImport("glfw3.dll")]
	public static extern  void glBindSampler (uint unit, uint sampler);
	[DllImport("glfw3.dll")]
	public static extern  void glSamplerParameteri (uint sampler, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glSamplerParameteriv (uint sampler, int pname,  int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glSamplerParameterf (uint sampler, int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glSamplerParameterfv (uint sampler, int pname,  float *param);
	[DllImport("glfw3.dll")]
	public static extern  void glSamplerParameterIiv (uint sampler, int pname,  int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glSamplerParameterIuiv (uint sampler, int pname,  uint *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetSamplerParameteriv (uint sampler, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetSamplerParameterIiv (uint sampler, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetSamplerParameterfv (uint sampler, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetSamplerParameterIuiv (uint sampler, int pname, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glQueryCounter (uint id, int target);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryObjecti64v (uint id, int pname, int64 *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryObjectui64v (uint id, int pname, ulong *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribDivisor (uint index, uint divisor);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribP1ui (uint index, int type, int normalized, uint value);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribP1uiv (uint index, int type, int normalized,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribP2ui (uint index, int type, int normalized, uint value);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribP2uiv (uint index, int type, int normalized,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribP3ui (uint index, int type, int normalized, uint value);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribP3uiv (uint index, int type, int normalized,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribP4ui (uint index, int type, int normalized, uint value);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribP4uiv (uint index, int type, int normalized,  uint *value);
	public const int GL_VERSION_4_0 = 1;

	public const int GL_SAMPLE_SHADING = 0x8C36;

	public const int GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;

	public const int GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;

	public const int GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;

	public const int GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;

	public const int GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;

	public const int GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;

	public const int GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;

	public const int GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;

	public const int GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;

	public const int GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;

	public const int GL_DRAW_INDIRECT_BUFFER = 0x8F3F;

	public const int GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;

	public const int GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;

	public const int GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;

	public const int GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;

	public const int GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;

	public const int GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;

	public const int GL_MAX_VERTEX_STREAMS = 0x8E71;

	public const int GL_DOUBLE_VEC2 = 0x8FFC;

	public const int GL_DOUBLE_VEC3 = 0x8FFD;

	public const int GL_DOUBLE_VEC4 = 0x8FFE;

	public const int GL_DOUBLE_MAT2 = 0x8F46;

	public const int GL_DOUBLE_MAT3 = 0x8F47;

	public const int GL_DOUBLE_MAT4 = 0x8F48;

	public const int GL_DOUBLE_MAT2x3 = 0x8F49;

	public const int GL_DOUBLE_MAT2x4 = 0x8F4A;

	public const int GL_DOUBLE_MAT3x2 = 0x8F4B;

	public const int GL_DOUBLE_MAT3x4 = 0x8F4C;

	public const int GL_DOUBLE_MAT4x2 = 0x8F4D;

	public const int GL_DOUBLE_MAT4x3 = 0x8F4E;

	public const int GL_ACTIVE_SUBROUTINES = 0x8DE5;

	public const int GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;

	public const int GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;

	public const int GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;

	public const int GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;

	public const int GL_MAX_SUBROUTINES = 0x8DE7;

	public const int GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;

	public const int GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;

	public const int GL_COMPATIBLE_SUBROUTINES = 0x8E4B;

	public const int GL_PATCHES = 0x000E;

	public const int GL_PATCH_VERTICES = 0x8E72;

	public const int GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;

	public const int GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;

	public const int GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;

	public const int GL_TESS_GEN_MODE = 0x8E76;

	public const int GL_TESS_GEN_SPACING = 0x8E77;

	public const int GL_TESS_GEN_VERTEX_ORDER = 0x8E78;

	public const int GL_TESS_GEN_POINT_MODE = 0x8E79;

	public const int GL_ISOLINES = 0x8E7A;

	public const int GL_FRACTIONAL_ODD = 0x8E7B;

	public const int GL_FRACTIONAL_EVEN = 0x8E7C;

	public const int GL_MAX_PATCH_VERTICES = 0x8E7D;

	public const int GL_MAX_TESS_GEN_LEVEL = 0x8E7E;

	public const int GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;

	public const int GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;

	public const int GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;

	public const int GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;

	public const int GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;

	public const int GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;

	public const int GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;

	public const int GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;

	public const int GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;

	public const int GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;

	public const int GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;

	public const int GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;

	public const int GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;

	public const int GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;

	public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;

	public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;

	public const int GL_TESS_EVALUATION_SHADER = 0x8E87;

	public const int GL_TESS_CONTROL_SHADER = 0x8E88;

	public const int GL_TRANSFORM_FEEDBACK = 0x8E22;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;

	public const int GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;

	public const int GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;

public delegate void PFNGLMINSAMPLESHADINGPROC (float value);
public delegate void PFNGLBLENDEQUATIONIPROC (uint buf, int mode);
public delegate void PFNGLBLENDEQUATIONSEPARATEIPROC (uint buf, int modeRGB, int modeAlpha);
public delegate void PFNGLBLENDFUNCIPROC (uint buf, int src, int dst);
public delegate void PFNGLBLENDFUNCSEPARATEIPROC (uint buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
public delegate void PFNGLDRAWARRAYSINDIRECTPROC (int mode,  void *indirect);
public delegate void PFNGLDRAWELEMENTSINDIRECTPROC (int mode, int type,  void *indirect);
public delegate void PFNGLUNIFORM1DPROC (int location, double x);
public delegate void PFNGLUNIFORM2DPROC (int location, double x, double y);
public delegate void PFNGLUNIFORM3DPROC (int location, double x, double y, double z);
public delegate void PFNGLUNIFORM4DPROC (int location, double x, double y, double z, double w);
public delegate void PFNGLUNIFORM1DVPROC (int location, uint count,  double *value);
public delegate void PFNGLUNIFORM2DVPROC (int location, uint count,  double *value);
public delegate void PFNGLUNIFORM3DVPROC (int location, uint count,  double *value);
public delegate void PFNGLUNIFORM4DVPROC (int location, uint count,  double *value);
public delegate void PFNGLUNIFORMMATRIX2DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLUNIFORMMATRIX3DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLUNIFORMMATRIX4DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLUNIFORMMATRIX2X3DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLUNIFORMMATRIX2X4DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLUNIFORMMATRIX3X2DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLUNIFORMMATRIX3X4DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLUNIFORMMATRIX4X2DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLUNIFORMMATRIX4X3DVPROC (int location, uint count, int transpose,  double *value);
public delegate void PFNGLGETUNIFORMDVPROC (uint program, int location, double *prms);
public delegate void PFNGLGETACTIVESUBROUTINEUNIFORMIVPROC (uint program, int shadertype, uint index, int pname, int *values);
public delegate void PFNGLGETACTIVESUBROUTINEUNIFORMNAMEPROC (uint program, int shadertype, uint index, uint bufSize, uint *length, char *name);
public delegate void PFNGLGETACTIVESUBROUTINENAMEPROC (uint program, int shadertype, uint index, uint bufSize, uint *length, char *name);
public delegate void PFNGLUNIFORMSUBROUTINESUIVPROC (int shadertype, uint count,  uint *indices);
public delegate void PFNGLGETUNIFORMSUBROUTINEUIVPROC (int shadertype, int location, uint *prms);
public delegate void PFNGLGETPROGRAMSTAGEIVPROC (uint program, int shadertype, int pname, int *values);
public delegate void PFNGLPATCHPARAMETERIPROC (int pname, int value);
public delegate void PFNGLPATCHPARAMETERFVPROC (int pname,  float *values);
public delegate void PFNGLBINDTRANSFORMFEEDBACKPROC (int target, uint id);
public delegate void PFNGLDELETETRANSFORMFEEDBACKSPROC (uint n,  uint *ids);
public delegate void PFNGLGENTRANSFORMFEEDBACKSPROC (uint n, uint *ids);
public delegate void PFNGLPAUSETRANSFORMFEEDBACKPROC ();
public delegate void PFNGLRESUMETRANSFORMFEEDBACKPROC ();
public delegate void PFNGLDRAWTRANSFORMFEEDBACKPROC (int mode, uint id);
public delegate void PFNGLDRAWTRANSFORMFEEDBACKSTREAMPROC (int mode, uint id, uint stream);
public delegate void PFNGLBEGINQUERYINDEXEDPROC (int target, uint index, uint id);
public delegate void PFNGLENDQUERYINDEXEDPROC (int target, uint index);
public delegate void PFNGLGETQUERYINDEXEDIVPROC (int target, uint index, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMinSampleShading (float value);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendEquationi (uint buf, int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendEquationSeparatei (uint buf, int modeRGB, int modeAlpha);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendFunci (uint buf, int src, int dst);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendFuncSeparatei (uint buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawArraysIndirect (int mode,  void *indirect);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElementsIndirect (int mode, int type,  void *indirect);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1d (int location, double x);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2d (int location, double x, double y);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3d (int location, double x, double y, double z);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4d (int location, double x, double y, double z, double w);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1dv (int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2dv (int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3dv (int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4dv (int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix2dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix3dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix4dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix2x3dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix2x4dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix3x2dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix3x4dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix4x2dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformMatrix4x3dv (int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformdv (uint program, int location, double *prms);
	[DllImport("glfw3.dll")]
	public static extern  int glGetSubroutineUniformLocation (uint program, int shadertype,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  uint glGetSubroutineIndex (uint program, int shadertype,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveSubroutineUniformiv (uint program, int shadertype, uint index, int pname, int *values);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveSubroutineUniformName (uint program, int shadertype, uint index, uint bufSize, uint *length, char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveSubroutineName (uint program, int shadertype, uint index, uint bufSize, uint *length, char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformSubroutinesuiv (int shadertype, uint count,  uint *indices);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformSubroutineuiv (int shadertype, int location, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramStageiv (uint program, int shadertype, int pname, int *values);
	[DllImport("glfw3.dll")]
	public static extern  void glPatchParameteri (int pname, int value);
	[DllImport("glfw3.dll")]
	public static extern  void glPatchParameterfv (int pname,  float *values);
	[DllImport("glfw3.dll")]
	public static extern  void glBindTransformFeedback (int target, uint id);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteTransformFeedbacks (uint n,  uint *ids);
	[DllImport("glfw3.dll")]
	public static extern  void glGenTransformFeedbacks (uint n, uint *ids);
	[DllImport("glfw3.dll")]
	public static extern  int glIsTransformFeedback (uint id);
	[DllImport("glfw3.dll")]
	public static extern  void glPauseTransformFeedback ();
	[DllImport("glfw3.dll")]
	public static extern  void glResumeTransformFeedback ();
	[DllImport("glfw3.dll")]
	public static extern  void glDrawTransformFeedback (int mode, uint id);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawTransformFeedbackStream (int mode, uint id, uint stream);
	[DllImport("glfw3.dll")]
	public static extern  void glBeginQueryIndexed (int target, uint index, uint id);
	[DllImport("glfw3.dll")]
	public static extern  void glEndQueryIndexed (int target, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryIndexediv (int target, uint index, int pname, int *prms);
	public const int GL_VERSION_4_1 = 1;

	public const int GL_FIXED = 0x140C;

	public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;

	public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

	public const int GL_LOW_FLOAT = 0x8DF0;

	public const int GL_MEDIUM_FLOAT = 0x8DF1;

	public const int GL_HIGH_FLOAT = 0x8DF2;

	public const int GL_LOW_INT = 0x8DF3;

	public const int GL_MEDIUM_INT = 0x8DF4;

	public const int GL_HIGH_INT = 0x8DF5;

	public const int GL_SHADER_COMPILER = 0x8DFA;

	public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;

	public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;

	public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;

	public const int GL_MAX_VARYING_VECTORS = 0x8DFC;

	public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;

	public const int GL_RGB565 = 0x8D62;

	public const int GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;

	public const int GL_PROGRAM_BINARY_LENGTH = 0x8741;

	public const int GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;

	public const int GL_PROGRAM_BINARY_FORMATS = 0x87FF;

	public const int GL_VERTEX_SHADER_BIT = 0x00000001;

	public const int GL_FRAGMENT_SHADER_BIT = 0x00000002;

	public const int GL_GEOMETRY_SHADER_BIT = 0x00000004;

	public const int GL_TESS_CONTROL_SHADER_BIT = 0x00000008;

	public const int GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;

	public const int GL_ALL_SHADER_BITS = 0xFFFFFFFF;

	public const int GL_PROGRAM_SEPARABLE = 0x8258;

	public const int GL_ACTIVE_PROGRAM = 0x8259;

	public const int GL_PROGRAM_PIPELINE_BINDING = 0x825A;

	public const int GL_MAX_VIEWPORTS = 0x825B;

	public const int GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;

	public const int GL_VIEWPORT_BOUNDS_RANGE = 0x825D;

	public const int GL_LAYER_PROVOKING_VERTEX = 0x825E;

	public const int GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;

	public const int GL_UNDEFINED_VERTEX = 0x8260;

public delegate void PFNGLRELEASESHADERCOMPILERPROC ();
public delegate void PFNGLSHADERBINARYPROC (uint count,  uint *shaders, int binaryFormat,  void *binary, uint length);
public delegate void PFNGLGETSHADERPRECISIONFORMATPROC (int shadertype, int precisiontype, int *range, int *precision);
public delegate void PFNGLDEPTHRANGEFPROC (float n, float f);
public delegate void PFNGLCLEARDEPTHFPROC (float d);
public delegate void PFNGLGETPROGRAMBINARYPROC (uint program, uint bufSize, uint *length, int *binaryFormat, void *binary);
public delegate void PFNGLPROGRAMBINARYPROC (uint program, int binaryFormat,  void *binary, uint length);
public delegate void PFNGLPROGRAMPARAMETERIPROC (uint program, int pname, int value);
public delegate void PFNGLUSEPROGRAMSTAGESPROC (uint pipeline, int stages, uint program);
public delegate void PFNGLACTIVESHADERPROGRAMPROC (uint pipeline, uint program);
public delegate void PFNGLBINDPROGRAMPIPELINEPROC (uint pipeline);
public delegate void PFNGLDELETEPROGRAMPIPELINESPROC (uint n,  uint *pipelines);
public delegate void PFNGLGENPROGRAMPIPELINESPROC (uint n, uint *pipelines);
public delegate void PFNGLGETPROGRAMPIPELINEIVPROC (uint pipeline, int pname, int *prms);
public delegate void PFNGLPROGRAMUNIFORM1IPROC (uint program, int location, int v0);
public delegate void PFNGLPROGRAMUNIFORM1IVPROC (uint program, int location, uint count,  int *value);
public delegate void PFNGLPROGRAMUNIFORM1FPROC (uint program, int location, float v0);
public delegate void PFNGLPROGRAMUNIFORM1FVPROC (uint program, int location, uint count,  float *value);
public delegate void PFNGLPROGRAMUNIFORM1DPROC (uint program, int location, double v0);
public delegate void PFNGLPROGRAMUNIFORM1DVPROC (uint program, int location, uint count,  double *value);
public delegate void PFNGLPROGRAMUNIFORM1UIPROC (uint program, int location, uint v0);
public delegate void PFNGLPROGRAMUNIFORM1UIVPROC (uint program, int location, uint count,  uint *value);
public delegate void PFNGLPROGRAMUNIFORM2IPROC (uint program, int location, int v0, int v1);
public delegate void PFNGLPROGRAMUNIFORM2IVPROC (uint program, int location, uint count,  int *value);
public delegate void PFNGLPROGRAMUNIFORM2FPROC (uint program, int location, float v0, float v1);
public delegate void PFNGLPROGRAMUNIFORM2FVPROC (uint program, int location, uint count,  float *value);
public delegate void PFNGLPROGRAMUNIFORM2DPROC (uint program, int location, double v0, double v1);
public delegate void PFNGLPROGRAMUNIFORM2DVPROC (uint program, int location, uint count,  double *value);
public delegate void PFNGLPROGRAMUNIFORM2UIPROC (uint program, int location, uint v0, uint v1);
public delegate void PFNGLPROGRAMUNIFORM2UIVPROC (uint program, int location, uint count,  uint *value);
public delegate void PFNGLPROGRAMUNIFORM3IPROC (uint program, int location, int v0, int v1, int v2);
public delegate void PFNGLPROGRAMUNIFORM3IVPROC (uint program, int location, uint count,  int *value);
public delegate void PFNGLPROGRAMUNIFORM3FPROC (uint program, int location, float v0, float v1, float v2);
public delegate void PFNGLPROGRAMUNIFORM3FVPROC (uint program, int location, uint count,  float *value);
public delegate void PFNGLPROGRAMUNIFORM3DPROC (uint program, int location, double v0, double v1, double v2);
public delegate void PFNGLPROGRAMUNIFORM3DVPROC (uint program, int location, uint count,  double *value);
public delegate void PFNGLPROGRAMUNIFORM3UIPROC (uint program, int location, uint v0, uint v1, uint v2);
public delegate void PFNGLPROGRAMUNIFORM3UIVPROC (uint program, int location, uint count,  uint *value);
public delegate void PFNGLPROGRAMUNIFORM4IPROC (uint program, int location, int v0, int v1, int v2, int v3);
public delegate void PFNGLPROGRAMUNIFORM4IVPROC (uint program, int location, uint count,  int *value);
public delegate void PFNGLPROGRAMUNIFORM4FPROC (uint program, int location, float v0, float v1, float v2, float v3);
public delegate void PFNGLPROGRAMUNIFORM4FVPROC (uint program, int location, uint count,  float *value);
public delegate void PFNGLPROGRAMUNIFORM4DPROC (uint program, int location, double v0, double v1, double v2, double v3);
public delegate void PFNGLPROGRAMUNIFORM4DVPROC (uint program, int location, uint count,  double *value);
public delegate void PFNGLPROGRAMUNIFORM4UIPROC (uint program, int location, uint v0, uint v1, uint v2, uint v3);
public delegate void PFNGLPROGRAMUNIFORM4UIVPROC (uint program, int location, uint count,  uint *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2X3FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3X2FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2X4FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4X2FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3X4FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4X3FVPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2X3DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3X2DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2X4DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4X2DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3X4DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4X3DVPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLVALIDATEPROGRAMPIPELINEPROC (uint pipeline);
public delegate void PFNGLGETPROGRAMPIPELINEINFOLOGPROC (uint pipeline, uint bufSize, uint *length, char *infoLog);
public delegate void PFNGLVERTEXATTRIBL1DPROC (uint index, double x);
public delegate void PFNGLVERTEXATTRIBL2DPROC (uint index, double x, double y);
public delegate void PFNGLVERTEXATTRIBL3DPROC (uint index, double x, double y, double z);
public delegate void PFNGLVERTEXATTRIBL4DPROC (uint index, double x, double y, double z, double w);
public delegate void PFNGLVERTEXATTRIBL1DVPROC (uint index,  double *v);
public delegate void PFNGLVERTEXATTRIBL2DVPROC (uint index,  double *v);
public delegate void PFNGLVERTEXATTRIBL3DVPROC (uint index,  double *v);
public delegate void PFNGLVERTEXATTRIBL4DVPROC (uint index,  double *v);
public delegate void PFNGLVERTEXATTRIBLPOINTERPROC (uint index, int size, int type, uint stride,  void *pointer);
public delegate void PFNGLGETVERTEXATTRIBLDVPROC (uint index, int pname, double *prms);
public delegate void PFNGLVIEWPORTARRAYVPROC (uint first, uint count,  float *v);
public delegate void PFNGLVIEWPORTINDEXEDFPROC (uint index, float x, float y, float w, float h);
public delegate void PFNGLVIEWPORTINDEXEDFVPROC (uint index,  float *v);
public delegate void PFNGLSCISSORARRAYVPROC (uint first, uint count,  int *v);
public delegate void PFNGLSCISSORINDEXEDPROC (uint index, int left, int bottom, uint width, uint height);
public delegate void PFNGLSCISSORINDEXEDVPROC (uint index,  int *v);
public delegate void PFNGLDEPTHRANGEARRAYVPROC (uint first, uint count,  double *v);
public delegate void PFNGLDEPTHRANGEINDEXEDPROC (uint index, double n, double f);
public delegate void PFNGLGETFLOATI_VPROC (int target, uint index, float *data);
public delegate void PFNGLGETDOUBLEI_VPROC (int target, uint index, double *data);
	[DllImport("glfw3.dll")]
	public static extern  void glReleaseShaderCompiler ();
	[DllImport("glfw3.dll")]
	public static extern  void glShaderBinary (uint count,  uint *shaders, int binaryFormat,  void *binary, uint length);
	[DllImport("glfw3.dll")]
	public static extern  void glGetShaderPrecisionFormat (int shadertype, int precisiontype, int *range, int *precision);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthRangef (float n, float f);
	[DllImport("glfw3.dll")]
	public static extern  void glClearDepthf (float d);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramBinary (uint program, uint bufSize, uint *length, int *binaryFormat, void *binary);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramBinary (uint program, int binaryFormat,  void *binary, uint length);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramParameteri (uint program, int pname, int value);
	[DllImport("glfw3.dll")]
	public static extern  void glUseProgramStages (uint pipeline, int stages, uint program);
	[DllImport("glfw3.dll")]
	public static extern  void glActiveShaderProgram (uint pipeline, uint program);
	[DllImport("glfw3.dll")]
	public static extern  uint glCreateShaderProgramv (int type, uint count,  char **strs);
	[DllImport("glfw3.dll")]
	public static extern  void glBindProgramPipeline (uint pipeline);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteProgramPipelines (uint n,  uint *pipelines);
	[DllImport("glfw3.dll")]
	public static extern  void glGenProgramPipelines (uint n, uint *pipelines);
	[DllImport("glfw3.dll")]
	public static extern  int glIsProgramPipeline (uint pipeline);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramPipelineiv (uint pipeline, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1i (uint program, int location, int v0);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1iv (uint program, int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1f (uint program, int location, float v0);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1fv (uint program, int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1d (uint program, int location, double v0);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1dv (uint program, int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1ui (uint program, int location, uint v0);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1uiv (uint program, int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2i (uint program, int location, int v0, int v1);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2iv (uint program, int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2f (uint program, int location, float v0, float v1);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2fv (uint program, int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2d (uint program, int location, double v0, double v1);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2dv (uint program, int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2ui (uint program, int location, uint v0, uint v1);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2uiv (uint program, int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3i (uint program, int location, int v0, int v1, int v2);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3iv (uint program, int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3f (uint program, int location, float v0, float v1, float v2);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3fv (uint program, int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3d (uint program, int location, double v0, double v1, double v2);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3dv (uint program, int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3ui (uint program, int location, uint v0, uint v1, uint v2);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3uiv (uint program, int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4i (uint program, int location, int v0, int v1, int v2, int v3);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4iv (uint program, int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4f (uint program, int location, float v0, float v1, float v2, float v3);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4fv (uint program, int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4d (uint program, int location, double v0, double v1, double v2, double v3);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4dv (uint program, int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4ui (uint program, int location, uint v0, uint v1, uint v2, uint v3);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4uiv (uint program, int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2x3fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3x2fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2x4fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4x2fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3x4fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4x3fv (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2x3dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3x2dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2x4dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4x2dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3x4dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4x3dv (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glValidateProgramPipeline (uint pipeline);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramPipelineInfoLog (uint pipeline, uint bufSize, uint *length, char *infoLog);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL1d (uint index, double x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL2d (uint index, double x, double y);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL3d (uint index, double x, double y, double z);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL4d (uint index, double x, double y, double z, double w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL1dv (uint index,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL2dv (uint index,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL3dv (uint index,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL4dv (uint index,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribLPointer (uint index, int size, int type, uint stride,  void *pointer);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribLdv (uint index, int pname, double *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glViewportArrayv (uint first, uint count,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glViewportIndexedf (uint index, float x, float y, float w, float h);
	[DllImport("glfw3.dll")]
	public static extern  void glViewportIndexedfv (uint index,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glScissorArrayv (uint first, uint count,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glScissorIndexed (uint index, int left, int bottom, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glScissorIndexedv (uint index,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthRangeArrayv (uint first, uint count,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthRangeIndexed (uint index, double n, double f);
	[DllImport("glfw3.dll")]
	public static extern  void glGetFloati_v (int target, uint index, float *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetDoublei_v (int target, uint index, double *data);
	public const int GL_VERSION_4_2 = 1;

	public const int GL_COPY_READ_BUFFER_BINDING = 0x8F36;

	public const int GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;

	public const int GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;

	public const int GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;

	public const int GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;

	public const int GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;

	public const int GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;

	public const int GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;

	public const int GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;

	public const int GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;

	public const int GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;

	public const int GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;

	public const int GL_NUM_SAMPLE_COUNTS = 0x9380;

	public const int GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;

	public const int GL_ATOMIC_COUNTER_BUFFER = 0x92C0;

	public const int GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;

	public const int GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;

	public const int GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;

	public const int GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;

	public const int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;

	public const int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;

	public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;

	public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;

	public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;

	public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;

	public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;

	public const int GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;

	public const int GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;

	public const int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;

	public const int GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;

	public const int GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;

	public const int GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;

	public const int GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;

	public const int GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;

	public const int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;

	public const int GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;

	public const int GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;

	public const int GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;

	public const int GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;

	public const int GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;

	public const int GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;

	public const int GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;

	public const int GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;

	public const int GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;

	public const int GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;

	public const int GL_UNIFORM_BARRIER_BIT = 0x00000004;

	public const int GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;

	public const int GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;

	public const int GL_COMMAND_BARRIER_BIT = 0x00000040;

	public const int GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;

	public const int GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;

	public const int GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;

	public const int GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;

	public const int GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;

	public const int GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;

	public const int GL_ALL_BARRIER_BITS = 0xFFFFFFFF;

	public const int GL_MAX_IMAGE_UNITS = 0x8F38;

	public const int GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;

	public const int GL_IMAGE_BINDING_NAME = 0x8F3A;

	public const int GL_IMAGE_BINDING_LEVEL = 0x8F3B;

	public const int GL_IMAGE_BINDING_LAYERED = 0x8F3C;

	public const int GL_IMAGE_BINDING_LAYER = 0x8F3D;

	public const int GL_IMAGE_BINDING_ACCESS = 0x8F3E;

	public const int GL_IMAGE_1D = 0x904C;

	public const int GL_IMAGE_2D = 0x904D;

	public const int GL_IMAGE_3D = 0x904E;

	public const int GL_IMAGE_2D_RECT = 0x904F;

	public const int GL_IMAGE_CUBE = 0x9050;

	public const int GL_IMAGE_BUFFER = 0x9051;

	public const int GL_IMAGE_1D_ARRAY = 0x9052;

	public const int GL_IMAGE_2D_ARRAY = 0x9053;

	public const int GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;

	public const int GL_IMAGE_2D_MULTISAMPLE = 0x9055;

	public const int GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;

	public const int GL_INT_IMAGE_1D = 0x9057;

	public const int GL_INT_IMAGE_2D = 0x9058;

	public const int GL_INT_IMAGE_3D = 0x9059;

	public const int GL_INT_IMAGE_2D_RECT = 0x905A;

	public const int GL_INT_IMAGE_CUBE = 0x905B;

	public const int GL_INT_IMAGE_BUFFER = 0x905C;

	public const int GL_INT_IMAGE_1D_ARRAY = 0x905D;

	public const int GL_INT_IMAGE_2D_ARRAY = 0x905E;

	public const int GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;

	public const int GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;

	public const int GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;

	public const int GL_UNSIGNED_INT_IMAGE_1D = 0x9062;

	public const int GL_UNSIGNED_INT_IMAGE_2D = 0x9063;

	public const int GL_UNSIGNED_INT_IMAGE_3D = 0x9064;

	public const int GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;

	public const int GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;

	public const int GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;

	public const int GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;

	public const int GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;

	public const int GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;

	public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;

	public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;

	public const int GL_MAX_IMAGE_SAMPLES = 0x906D;

	public const int GL_IMAGE_BINDING_FORMAT = 0x906E;

	public const int GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;

	public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;

	public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;

	public const int GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;

	public const int GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;

	public const int GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;

	public const int GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;

	public const int GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;

	public const int GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;

	public const int GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;

	public const int GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;

	public const int GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;

	public const int GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;

	public const int GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;

public delegate void PFNGLDRAWARRAYSINSTANCEDBASEINSTANCEPROC (int mode, int first, uint count, uint instancecount, uint baseinstance);
public delegate void PFNGLDRAWELEMENTSINSTANCEDBASEINSTANCEPROC (int mode, uint count, int type,  void *indices, uint instancecount, uint baseinstance);
public delegate void PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXBASEINSTANCEPROC (int mode, uint count, int type,  void *indices, uint instancecount, int basevertex, uint baseinstance);
public delegate void PFNGLGETINTERNALFORMATIVPROC (int target, int internalformat, int pname, uint count, int *prms);
public delegate void PFNGLGETACTIVEATOMICCOUNTERBUFFERIVPROC (uint program, uint bufferIndex, int pname, int *prms);
public delegate void PFNGLBINDIMAGETEXTUREPROC (uint unit, uint texture, int level, int layered, int layer, int access, int format);
public delegate void PFNGLMEMORYBARRIERPROC (int barriers);
public delegate void PFNGLTEXSTORAGE1DPROC (int target, uint levels, int internalformat, uint width);
public delegate void PFNGLTEXSTORAGE2DPROC (int target, uint levels, int internalformat, uint width, uint height);
public delegate void PFNGLTEXSTORAGE3DPROC (int target, uint levels, int internalformat, uint width, uint height, uint depth);
public delegate void PFNGLDRAWTRANSFORMFEEDBACKINSTANCEDPROC (int mode, uint id, uint instancecount);
public delegate void PFNGLDRAWTRANSFORMFEEDBACKSTREAMINSTANCEDPROC (int mode, uint id, uint stream, uint instancecount);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawArraysInstancedBaseInstance (int mode, int first, uint count, uint instancecount, uint baseinstance);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElementsInstancedBaseInstance (int mode, uint count, int type,  void *indices, uint instancecount, uint baseinstance);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElementsInstancedBaseVertexBaseInstance (int mode, uint count, int type,  void *indices, uint instancecount, int basevertex, uint baseinstance);
	[DllImport("glfw3.dll")]
	public static extern  void glGetInternalformativ (int target, int internalformat, int pname, uint count, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetActiveAtomicCounterBufferiv (uint program, uint bufferIndex, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glBindImageTexture (uint unit, uint texture, int level, int layered, int layer, int access, int format);
	[DllImport("glfw3.dll")]
	public static extern  void glMemoryBarrier (int barriers);
	[DllImport("glfw3.dll")]
	public static extern  void glTexStorage1D (int target, uint levels, int internalformat, uint width);
	[DllImport("glfw3.dll")]
	public static extern  void glTexStorage2D (int target, uint levels, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glTexStorage3D (int target, uint levels, int internalformat, uint width, uint height, uint depth);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawTransformFeedbackInstanced (int mode, uint id, uint instancecount);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawTransformFeedbackStreamInstanced (int mode, uint id, uint stream, uint instancecount);
	public const int GL_VERSION_4_3 = 1;

public delegate void  GLDEBUGPROC (int source,int type,uint id,int severity,uint length, char *message, void *userParam);
	public const int GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;

	public const int GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E;

	public const int GL_COMPRESSED_RGB8_ETC2 = 0x9274;

	public const int GL_COMPRESSED_SRGB8_ETC2 = 0x9275;

	public const int GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;

	public const int GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;

	public const int GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;

	public const int GL_COMPRESSED_R11_EAC = 0x9270;

	public const int GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;

	public const int GL_COMPRESSED_RG11_EAC = 0x9272;

	public const int GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;

	public const int GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;

	public const int GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;

	public const int GL_MAX_ELEMENT_INDEX = 0x8D6B;

	public const int GL_COMPUTE_SHADER = 0x91B9;

	public const int GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;

	public const int GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;

	public const int GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;

	public const int GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;

	public const int GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;

	public const int GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;

	public const int GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;

	public const int GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;

	public const int GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;

	public const int GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;

	public const int GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;

	public const int GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;

	public const int GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;

	public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;

	public const int GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;

	public const int GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;

	public const int GL_COMPUTE_SHADER_BIT = 0x00000020;

	public const int GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;

	public const int GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;

	public const int GL_DEBUG_CALLBACK_FUNCTION = 0x8244;

	public const int GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;

	public const int GL_DEBUG_SOURCE_API = 0x8246;

	public const int GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;

	public const int GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;

	public const int GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;

	public const int GL_DEBUG_SOURCE_APPLICATION = 0x824A;

	public const int GL_DEBUG_SOURCE_OTHER = 0x824B;

	public const int GL_DEBUG_TYPE_ERROR = 0x824C;

	public const int GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;

	public const int GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;

	public const int GL_DEBUG_TYPE_PORTABILITY = 0x824F;

	public const int GL_DEBUG_TYPE_PERFORMANCE = 0x8250;

	public const int GL_DEBUG_TYPE_OTHER = 0x8251;

	public const int GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;

	public const int GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;

	public const int GL_DEBUG_LOGGED_MESSAGES = 0x9145;

	public const int GL_DEBUG_SEVERITY_HIGH = 0x9146;

	public const int GL_DEBUG_SEVERITY_MEDIUM = 0x9147;

	public const int GL_DEBUG_SEVERITY_LOW = 0x9148;

	public const int GL_DEBUG_TYPE_MARKER = 0x8268;

	public const int GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;

	public const int GL_DEBUG_TYPE_POP_GROUP = 0x826A;

	public const int GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;

	public const int GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;

	public const int GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;

	public const int GL_BUFFER = 0x82E0;

	public const int GL_SHADER = 0x82E1;

	public const int GL_PROGRAM = 0x82E2;

	public const int GL_QUERY = 0x82E3;

	public const int GL_PROGRAM_PIPELINE = 0x82E4;

	public const int GL_SAMPLER = 0x82E6;

	public const int GL_MAX_LABEL_LENGTH = 0x82E8;

	public const int GL_DEBUG_OUTPUT = 0x92E0;

	public const int GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;

	public const int GL_MAX_UNIFORM_LOCATIONS = 0x826E;

	public const int GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;

	public const int GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;

	public const int GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;

	public const int GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;

	public const int GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;

	public const int GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;

	public const int GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;

	public const int GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;

	public const int GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;

	public const int GL_INTERNALFORMAT_SUPPORTED = 0x826F;

	public const int GL_INTERNALFORMAT_PREFERRED = 0x8270;

	public const int GL_INTERNALFORMAT_RED_SIZE = 0x8271;

	public const int GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;

	public const int GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;

	public const int GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;

	public const int GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;

	public const int GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;

	public const int GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;

	public const int GL_INTERNALFORMAT_RED_TYPE = 0x8278;

	public const int GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;

	public const int GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;

	public const int GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;

	public const int GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;

	public const int GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;

	public const int GL_MAX_WIDTH = 0x827E;

	public const int GL_MAX_HEIGHT = 0x827F;

	public const int GL_MAX_DEPTH = 0x8280;

	public const int GL_MAX_LAYERS = 0x8281;

	public const int GL_MAX_COMBINED_DIMENSIONS = 0x8282;

	public const int GL_COLOR_COMPONENTS = 0x8283;

	public const int GL_DEPTH_COMPONENTS = 0x8284;

	public const int GL_STENCIL_COMPONENTS = 0x8285;

	public const int GL_COLOR_RENDERABLE = 0x8286;

	public const int GL_DEPTH_RENDERABLE = 0x8287;

	public const int GL_STENCIL_RENDERABLE = 0x8288;

	public const int GL_FRAMEBUFFER_RENDERABLE = 0x8289;

	public const int GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;

	public const int GL_FRAMEBUFFER_BLEND = 0x828B;

	public const int GL_READ_PIXELS = 0x828C;

	public const int GL_READ_PIXELS_FORMAT = 0x828D;

	public const int GL_READ_PIXELS_TYPE = 0x828E;

	public const int GL_TEXTURE_IMAGE_FORMAT = 0x828F;

	public const int GL_TEXTURE_IMAGE_TYPE = 0x8290;

	public const int GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;

	public const int GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;

	public const int GL_MIPMAP = 0x8293;

	public const int GL_MANUAL_GENERATE_MIPMAP = 0x8294;

	public const int GL_AUTO_GENERATE_MIPMAP = 0x8295;

	public const int GL_COLOR_ENCODING = 0x8296;

	public const int GL_SRGB_READ = 0x8297;

	public const int GL_SRGB_WRITE = 0x8298;

	public const int GL_FILTER = 0x829A;

	public const int GL_VERTEX_TEXTURE = 0x829B;

	public const int GL_TESS_CONTROL_TEXTURE = 0x829C;

	public const int GL_TESS_EVALUATION_TEXTURE = 0x829D;

	public const int GL_GEOMETRY_TEXTURE = 0x829E;

	public const int GL_FRAGMENT_TEXTURE = 0x829F;

	public const int GL_COMPUTE_TEXTURE = 0x82A0;

	public const int GL_TEXTURE_SHADOW = 0x82A1;

	public const int GL_TEXTURE_GATHER = 0x82A2;

	public const int GL_TEXTURE_GATHER_SHADOW = 0x82A3;

	public const int GL_SHADER_IMAGE_LOAD = 0x82A4;

	public const int GL_SHADER_IMAGE_STORE = 0x82A5;

	public const int GL_SHADER_IMAGE_ATOMIC = 0x82A6;

	public const int GL_IMAGE_TEXEL_SIZE = 0x82A7;

	public const int GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;

	public const int GL_IMAGE_PIXEL_FORMAT = 0x82A9;

	public const int GL_IMAGE_PIXEL_TYPE = 0x82AA;

	public const int GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;

	public const int GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;

	public const int GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;

	public const int GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;

	public const int GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;

	public const int GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;

	public const int GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;

	public const int GL_CLEAR_BUFFER = 0x82B4;

	public const int GL_TEXTURE_VIEW = 0x82B5;

	public const int GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;

	public const int GL_FULL_SUPPORT = 0x82B7;

	public const int GL_CAVEAT_SUPPORT = 0x82B8;

	public const int GL_IMAGE_CLASS_4_X_32 = 0x82B9;

	public const int GL_IMAGE_CLASS_2_X_32 = 0x82BA;

	public const int GL_IMAGE_CLASS_1_X_32 = 0x82BB;

	public const int GL_IMAGE_CLASS_4_X_16 = 0x82BC;

	public const int GL_IMAGE_CLASS_2_X_16 = 0x82BD;

	public const int GL_IMAGE_CLASS_1_X_16 = 0x82BE;

	public const int GL_IMAGE_CLASS_4_X_8 = 0x82BF;

	public const int GL_IMAGE_CLASS_2_X_8 = 0x82C0;

	public const int GL_IMAGE_CLASS_1_X_8 = 0x82C1;

	public const int GL_IMAGE_CLASS_11_11_10 = 0x82C2;

	public const int GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;

	public const int GL_VIEW_CLASS_128_BITS = 0x82C4;

	public const int GL_VIEW_CLASS_96_BITS = 0x82C5;

	public const int GL_VIEW_CLASS_64_BITS = 0x82C6;

	public const int GL_VIEW_CLASS_48_BITS = 0x82C7;

	public const int GL_VIEW_CLASS_32_BITS = 0x82C8;

	public const int GL_VIEW_CLASS_24_BITS = 0x82C9;

	public const int GL_VIEW_CLASS_16_BITS = 0x82CA;

	public const int GL_VIEW_CLASS_8_BITS = 0x82CB;

	public const int GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;

	public const int GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;

	public const int GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;

	public const int GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;

	public const int GL_VIEW_CLASS_RGTC1_RED = 0x82D0;

	public const int GL_VIEW_CLASS_RGTC2_RG = 0x82D1;

	public const int GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;

	public const int GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;

	public const int GL_UNIFORM = 0x92E1;

	public const int GL_UNIFORM_BLOCK = 0x92E2;

	public const int GL_PROGRAM_INPUT = 0x92E3;

	public const int GL_PROGRAM_OUTPUT = 0x92E4;

	public const int GL_BUFFER_VARIABLE = 0x92E5;

	public const int GL_SHADER_STORAGE_BLOCK = 0x92E6;

	public const int GL_VERTEX_SUBROUTINE = 0x92E8;

	public const int GL_TESS_CONTROL_SUBROUTINE = 0x92E9;

	public const int GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;

	public const int GL_GEOMETRY_SUBROUTINE = 0x92EB;

	public const int GL_FRAGMENT_SUBROUTINE = 0x92EC;

	public const int GL_COMPUTE_SUBROUTINE = 0x92ED;

	public const int GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;

	public const int GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;

	public const int GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;

	public const int GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;

	public const int GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;

	public const int GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;

	public const int GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;

	public const int GL_ACTIVE_RESOURCES = 0x92F5;

	public const int GL_MAX_NAME_LENGTH = 0x92F6;

	public const int GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;

	public const int GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;

	public const int GL_NAME_LENGTH = 0x92F9;

	public const int GL_TYPE = 0x92FA;

	public const int GL_ARRAY_SIZE = 0x92FB;

	public const int GL_OFFSET = 0x92FC;

	public const int GL_BLOCK_INDEX = 0x92FD;

	public const int GL_ARRAY_STRIDE = 0x92FE;

	public const int GL_MATRIX_STRIDE = 0x92FF;

	public const int GL_IS_ROW_MAJOR = 0x9300;

	public const int GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;

	public const int GL_BUFFER_BINDING = 0x9302;

	public const int GL_BUFFER_DATA_SIZE = 0x9303;

	public const int GL_NUM_ACTIVE_VARIABLES = 0x9304;

	public const int GL_ACTIVE_VARIABLES = 0x9305;

	public const int GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;

	public const int GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;

	public const int GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;

	public const int GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;

	public const int GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;

	public const int GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;

	public const int GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;

	public const int GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;

	public const int GL_LOCATION = 0x930E;

	public const int GL_LOCATION_INDEX = 0x930F;

	public const int GL_IS_PER_PATCH = 0x92E7;

	public const int GL_SHADER_STORAGE_BUFFER = 0x90D2;

	public const int GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;

	public const int GL_SHADER_STORAGE_BUFFER_START = 0x90D4;

	public const int GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;

	public const int GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;

	public const int GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;

	public const int GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;

	public const int GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;

	public const int GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;

	public const int GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;

	public const int GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;

	public const int GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;

	public const int GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;

	public const int GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;

	public const int GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;

	public const int GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;

	public const int GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;

	public const int GL_TEXTURE_BUFFER_OFFSET = 0x919D;

	public const int GL_TEXTURE_BUFFER_SIZE = 0x919E;

	public const int GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;

	public const int GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;

	public const int GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;

	public const int GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;

	public const int GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;

	public const int GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;

	public const int GL_VERTEX_ATTRIB_BINDING = 0x82D4;

	public const int GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;

	public const int GL_VERTEX_BINDING_DIVISOR = 0x82D6;

	public const int GL_VERTEX_BINDING_OFFSET = 0x82D7;

	public const int GL_VERTEX_BINDING_STRIDE = 0x82D8;

	public const int GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;

	public const int GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;

	public const int GL_VERTEX_BINDING_BUFFER = 0x8F4F;

public delegate void PFNGLCLEARBUFFERDATAPROC (int target, int internalformat, int format, int type,  void *data);
public delegate void PFNGLCLEARBUFFERSUBDATAPROC (int target, int internalformat, int* offset, uint* size, int format, int type,  void *data);
public delegate void PFNGLDISPATCHCOMPUTEPROC (uint num_groups_x, uint num_groups_y, uint num_groups_z);
public delegate void PFNGLDISPATCHCOMPUTEINDIRECTPROC (int* indirect);
public delegate void PFNGLCOPYIMAGESUBDATAPROC (uint srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint srcWidth, uint srcHeight, uint srcDepth);
public delegate void PFNGLFRAMEBUFFERPARAMETERIPROC (int target, int pname, int param);
public delegate void PFNGLGETFRAMEBUFFERPARAMETERIVPROC (int target, int pname, int *prms);
public delegate void PFNGLGETINTERNALFORMATI64VPROC (int target, int internalformat, int pname, uint count, int64 *prms);
public delegate void PFNGLINVALIDATETEXSUBIMAGEPROC (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth);
public delegate void PFNGLINVALIDATETEXIMAGEPROC (uint texture, int level);
public delegate void PFNGLINVALIDATEBUFFERSUBDATAPROC (uint buffer, int* offset, uint* length);
public delegate void PFNGLINVALIDATEBUFFERDATAPROC (uint buffer);
public delegate void PFNGLINVALIDATEFRAMEBUFFERPROC (int target, uint numAttachments,  int *attachments);
public delegate void PFNGLINVALIDATESUBFRAMEBUFFERPROC (int target, uint numAttachments,  int *attachments, int x, int y, uint width, uint height);
public delegate void PFNGLMULTIDRAWARRAYSINDIRECTPROC (int mode,  void *indirect, uint drawcount, uint stride);
public delegate void PFNGLMULTIDRAWELEMENTSINDIRECTPROC (int mode, int type,  void *indirect, uint drawcount, uint stride);
public delegate void PFNGLGETPROGRAMINTERFACEIVPROC (uint program, int programInterface, int pname, int *prms);
public delegate void PFNGLGETPROGRAMRESOURCENAMEPROC (uint program, int programInterface, uint index, uint bufSize, uint *length, char *name);
public delegate void PFNGLGETPROGRAMRESOURCEIVPROC (uint program, int programInterface, uint index, uint propCount,  int *props, uint count, uint *length, int *prms);
public delegate void PFNGLSHADERSTORAGEBLOCKBINDINGPROC (uint program, uint storageBlockIndex, uint storageBlockBinding);
public delegate void PFNGLTEXBUFFERRANGEPROC (int target, int internalformat, uint buffer, int* offset, uint* size);
public delegate void PFNGLTEXSTORAGE2DMULTISAMPLEPROC (int target, uint samples, int internalformat, uint width, uint height, int fixedsamplelocations);
public delegate void PFNGLTEXSTORAGE3DMULTISAMPLEPROC (int target, uint samples, int internalformat, uint width, uint height, uint depth, int fixedsamplelocations);
public delegate void PFNGLTEXTUREVIEWPROC (uint texture, int target, uint origtexture, int internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
public delegate void PFNGLBINDVERTEXBUFFERPROC (uint bindingindex, uint buffer, int* offset, uint stride);
public delegate void PFNGLVERTEXATTRIBFORMATPROC (uint attribindex, int size, int type, int normalized, uint relativeoffset);
public delegate void PFNGLVERTEXATTRIBIFORMATPROC (uint attribindex, int size, int type, uint relativeoffset);
public delegate void PFNGLVERTEXATTRIBLFORMATPROC (uint attribindex, int size, int type, uint relativeoffset);
public delegate void PFNGLVERTEXATTRIBBINDINGPROC (uint attribindex, uint bindingindex);
public delegate void PFNGLVERTEXBINDINGDIVISORPROC (uint bindingindex, uint divisor);
public delegate void PFNGLDEBUGMESSAGECONTROLPROC (int source, int type, int severity, uint count,  uint *ids, int enabled);
public delegate void PFNGLDEBUGMESSAGEINSERTPROC (int source, int type, uint id, int severity, uint length,  char *buf);
public delegate void PFNGLDEBUGMESSAGECALLBACKPROC (GLDEBUGPROC callback,  void *userParam);
public delegate void PFNGLPUSHDEBUGGROUPPROC (int source, uint id, uint length,  char *message);
public delegate void PFNGLPOPDEBUGGROUPPROC ();
public delegate void PFNGLOBJECTLABELPROC (int identifier, uint name, uint length,  char *label);
public delegate void PFNGLGETOBJECTLABELPROC (int identifier, uint name, uint bufSize, uint *length, char *label);
public delegate void PFNGLOBJECTPTRLABELPROC ( void *ptr, uint length,  char *label);
public delegate void PFNGLGETOBJECTPTRLABELPROC ( void *ptr, uint bufSize, uint *length, char *label);
	[DllImport("glfw3.dll")]
	public static extern  void glClearBufferData (int target, int internalformat, int format, int type,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glClearBufferSubData (int target, int internalformat, int* offset, uint* size, int format, int type,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glDispatchCompute (uint num_groups_x, uint num_groups_y, uint num_groups_z);
	[DllImport("glfw3.dll")]
	public static extern  void glDispatchComputeIndirect (int* indirect);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyImageSubData (uint srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint srcWidth, uint srcHeight, uint srcDepth);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferParameteri (int target, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetFramebufferParameteriv (int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetInternalformati64v (int target, int internalformat, int pname, uint count, int64 *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glInvalidateTexSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth);
	[DllImport("glfw3.dll")]
	public static extern  void glInvalidateTexImage (uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glInvalidateBufferSubData (uint buffer, int* offset, uint* length);
	[DllImport("glfw3.dll")]
	public static extern  void glInvalidateBufferData (uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glInvalidateFramebuffer (int target, uint numAttachments,  int *attachments);
	[DllImport("glfw3.dll")]
	public static extern  void glInvalidateSubFramebuffer (int target, uint numAttachments,  int *attachments, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawArraysIndirect (int mode,  void *indirect, uint drawcount, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawElementsIndirect (int mode, int type,  void *indirect, uint drawcount, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramInterfaceiv (uint program, int programInterface, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  uint glGetProgramResourceIndex (uint program, int programInterface,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramResourceName (uint program, int programInterface, uint index, uint bufSize, uint *length, char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramResourceiv (uint program, int programInterface, uint index, uint propCount,  int *props, uint count, uint *length, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  int glGetProgramResourceLocation (uint program, int programInterface,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  int glGetProgramResourceLocationIndex (uint program, int programInterface,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glShaderStorageBlockBinding (uint program, uint storageBlockIndex, uint storageBlockBinding);
	[DllImport("glfw3.dll")]
	public static extern  void glTexBufferRange (int target, int internalformat, uint buffer, int* offset, uint* size);
	[DllImport("glfw3.dll")]
	public static extern  void glTexStorage2DMultisample (int target, uint samples, int internalformat, uint width, uint height, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glTexStorage3DMultisample (int target, uint samples, int internalformat, uint width, uint height, uint depth, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureView (uint texture, int target, uint origtexture, int internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
	[DllImport("glfw3.dll")]
	public static extern  void glBindVertexBuffer (uint bindingindex, uint buffer, int* offset, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribFormat (uint attribindex, int size, int type, int normalized, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribIFormat (uint attribindex, int size, int type, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribLFormat (uint attribindex, int size, int type, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribBinding (uint attribindex, uint bindingindex);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexBindingDivisor (uint bindingindex, uint divisor);
	[DllImport("glfw3.dll")]
	public static extern  void glDebugMessageControl (int source, int type, int severity, uint count,  uint *ids, int enabled);
	[DllImport("glfw3.dll")]
	public static extern  void glDebugMessageInsert (int source, int type, uint id, int severity, uint length,  char *buf);
	[DllImport("glfw3.dll")]
	public static extern  void glDebugMessageCallback (GLDEBUGPROC callback,  void *userParam);
	[DllImport("glfw3.dll")]
	public static extern  uint glGetDebugMessageLog (uint count, uint bufSize, int *sources, int *types, uint *ids, int *severities, uint *lengths, char *messageLog);
	[DllImport("glfw3.dll")]
	public static extern  void glPushDebugGroup (int source, uint id, uint length,  char *message);
	[DllImport("glfw3.dll")]
	public static extern  void glPopDebugGroup ();
	[DllImport("glfw3.dll")]
	public static extern  void glObjectLabel (int identifier, uint name, uint length,  char *label);
	[DllImport("glfw3.dll")]
	public static extern  void glGetObjectLabel (int identifier, uint name, uint bufSize, uint *length, char *label);
	[DllImport("glfw3.dll")]
	public static extern  void glObjectPtrLabel ( void *ptr, uint length,  char *label);
	[DllImport("glfw3.dll")]
	public static extern  void glGetObjectPtrLabel ( void *ptr, uint bufSize, uint *length, char *label);
	public const int GL_VERSION_4_4 = 1;

	public const int GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;

	public const int GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;

	public const int GL_TEXTURE_BUFFER_BINDING = 0x8C2A;

	public const int GL_MAP_PERSISTENT_BIT = 0x0040;

	public const int GL_MAP_COHERENT_BIT = 0x0080;

	public const int GL_DYNAMIC_STORAGE_BIT = 0x0100;

	public const int GL_CLIENT_STORAGE_BIT = 0x0200;

	public const int GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;

	public const int GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;

	public const int GL_BUFFER_STORAGE_FLAGS = 0x8220;

	public const int GL_CLEAR_TEXTURE = 0x9365;

	public const int GL_LOCATION_COMPONENT = 0x934A;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;

	public const int GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;

	public const int GL_QUERY_BUFFER = 0x9192;

	public const int GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;

	public const int GL_QUERY_BUFFER_BINDING = 0x9193;

	public const int GL_QUERY_RESULT_NO_WAIT = 0x9194;

	public const int GL_MIRROR_CLAMP_TO_EDGE = 0x8743;

public delegate void PFNGLBUFFERSTORAGEPROC (int target, uint* size,  void *data, int flags);
public delegate void PFNGLCLEARTEXIMAGEPROC (uint texture, int level, int format, int type,  void *data);
public delegate void PFNGLCLEARTEXSUBIMAGEPROC (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *data);
public delegate void PFNGLBINDBUFFERSBASEPROC (int target, uint first, uint count,  uint *buffers);
public delegate void PFNGLBINDBUFFERSRANGEPROC (int target, uint first, uint count,  uint *buffers,  int* *offsets,  uint* *sizes);
public delegate void PFNGLBINDTEXTURESPROC (uint first, uint count,  uint *textures);
public delegate void PFNGLBINDSAMPLERSPROC (uint first, uint count,  uint *samplers);
public delegate void PFNGLBINDIMAGETEXTURESPROC (uint first, uint count,  uint *textures);
public delegate void PFNGLBINDVERTEXBUFFERSPROC (uint first, uint count,  uint *buffers,  int* *offsets,  uint *strides);
	[DllImport("glfw3.dll")]
	public static extern  void glBufferStorage (int target, uint* size,  void *data, int flags);
	[DllImport("glfw3.dll")]
	public static extern  void glClearTexImage (uint texture, int level, int format, int type,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glClearTexSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glBindBuffersBase (int target, uint first, uint count,  uint *buffers);
	[DllImport("glfw3.dll")]
	public static extern  void glBindBuffersRange (int target, uint first, uint count,  uint *buffers,  int* *offsets,  uint* *sizes);
	[DllImport("glfw3.dll")]
	public static extern  void glBindTextures (uint first, uint count,  uint *textures);
	[DllImport("glfw3.dll")]
	public static extern  void glBindSamplers (uint first, uint count,  uint *samplers);
	[DllImport("glfw3.dll")]
	public static extern  void glBindImageTextures (uint first, uint count,  uint *textures);
	[DllImport("glfw3.dll")]
	public static extern  void glBindVertexBuffers (uint first, uint count,  uint *buffers,  int* *offsets,  uint *strides);
	public const int GL_VERSION_4_5 = 1;

	public const int GL_CONTEXT_LOST = 0x0507;

	public const int GL_NEGATIVE_ONE_TO_ONE = 0x935E;

	public const int GL_ZERO_TO_ONE = 0x935F;

	public const int GL_CLIP_ORIGIN = 0x935C;

	public const int GL_CLIP_DEPTH_MODE = 0x935D;

	public const int GL_QUERY_WAIT_INVERTED = 0x8E17;

	public const int GL_QUERY_NO_WAIT_INVERTED = 0x8E18;

	public const int GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;

	public const int GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;

	public const int GL_MAX_CULL_DISTANCES = 0x82F9;

	public const int GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;

	public const int GL_TEXTURE_TARGET = 0x1006;

	public const int GL_QUERY_TARGET = 0x82EA;

	public const int GL_GUILTY_CONTEXT_RESET = 0x8253;

	public const int GL_INNOCENT_CONTEXT_RESET = 0x8254;

	public const int GL_UNKNOWN_CONTEXT_RESET = 0x8255;

	public const int GL_RESET_NOTIFICATION_STRATEGY = 0x8256;

	public const int GL_LOSE_CONTEXT_ON_RESET = 0x8252;

	public const int GL_NO_RESET_NOTIFICATION = 0x8261;

	public const int GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;

	public const int GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;

	public const int GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;

public delegate void PFNGLCLIPCONTROLPROC (int origin, int depth);
public delegate void PFNGLCREATETRANSFORMFEEDBACKSPROC (uint n, uint *ids);
public delegate void PFNGLTRANSFORMFEEDBACKBUFFERBASEPROC (uint xfb, uint index, uint buffer);
public delegate void PFNGLTRANSFORMFEEDBACKBUFFERRANGEPROC (uint xfb, uint index, uint buffer, int* offset, uint* size);
public delegate void PFNGLGETTRANSFORMFEEDBACKIVPROC (uint xfb, int pname, int *param);
public delegate void PFNGLGETTRANSFORMFEEDBACKI_VPROC (uint xfb, int pname, uint index, int *param);
public delegate void PFNGLGETTRANSFORMFEEDBACKI64_VPROC (uint xfb, int pname, uint index, int64 *param);
public delegate void PFNGLCREATEBUFFERSPROC (uint n, uint *buffers);
public delegate void PFNGLNAMEDBUFFERSTORAGEPROC (uint buffer, uint* size,  void *data, int flags);
public delegate void PFNGLNAMEDBUFFERDATAPROC (uint buffer, uint* size,  void *data, int usage);
public delegate void PFNGLNAMEDBUFFERSUBDATAPROC (uint buffer, int* offset, uint* size,  void *data);
public delegate void PFNGLCOPYNAMEDBUFFERSUBDATAPROC (uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, uint* size);
public delegate void PFNGLCLEARNAMEDBUFFERDATAPROC (uint buffer, int internalformat, int format, int type,  void *data);
public delegate void PFNGLCLEARNAMEDBUFFERSUBDATAPROC (uint buffer, int internalformat, int* offset, uint* size, int format, int type,  void *data);
public delegate void PFNGLFLUSHMAPPEDNAMEDBUFFERRANGEPROC (uint buffer, int* offset, uint* length);
public delegate void PFNGLGETNAMEDBUFFERPARAMETERIVPROC (uint buffer, int pname, int *prms);
public delegate void PFNGLGETNAMEDBUFFERPARAMETERI64VPROC (uint buffer, int pname, int64 *prms);
public delegate void PFNGLGETNAMEDBUFFERPOINTERVPROC (uint buffer, int pname, void **prms);
public delegate void PFNGLGETNAMEDBUFFERSUBDATAPROC (uint buffer, int* offset, uint* size, void *data);
public delegate void PFNGLCREATEFRAMEBUFFERSPROC (uint n, uint *framebuffers);
public delegate void PFNGLNAMEDFRAMEBUFFERRENDERBUFFERPROC (uint framebuffer, int attachment, int renderbuffertarget, uint renderbuffer);
public delegate void PFNGLNAMEDFRAMEBUFFERPARAMETERIPROC (uint framebuffer, int pname, int param);
public delegate void PFNGLNAMEDFRAMEBUFFERTEXTUREPROC (uint framebuffer, int attachment, uint texture, int level);
public delegate void PFNGLNAMEDFRAMEBUFFERTEXTURELAYERPROC (uint framebuffer, int attachment, uint texture, int level, int layer);
public delegate void PFNGLNAMEDFRAMEBUFFERDRAWBUFFERPROC (uint framebuffer, int buf);
public delegate void PFNGLNAMEDFRAMEBUFFERDRAWBUFFERSPROC (uint framebuffer, uint n,  int *bufs);
public delegate void PFNGLNAMEDFRAMEBUFFERREADBUFFERPROC (uint framebuffer, int src);
public delegate void PFNGLINVALIDATENAMEDFRAMEBUFFERDATAPROC (uint framebuffer, uint numAttachments,  int *attachments);
public delegate void PFNGLINVALIDATENAMEDFRAMEBUFFERSUBDATAPROC (uint framebuffer, uint numAttachments,  int *attachments, int x, int y, uint width, uint height);
public delegate void PFNGLCLEARNAMEDFRAMEBUFFERIVPROC (uint framebuffer, int buffer, int drawbuffer,  int *value);
public delegate void PFNGLCLEARNAMEDFRAMEBUFFERUIVPROC (uint framebuffer, int buffer, int drawbuffer,  uint *value);
public delegate void PFNGLCLEARNAMEDFRAMEBUFFERFVPROC (uint framebuffer, int buffer, int drawbuffer,  float *value);
public delegate void PFNGLCLEARNAMEDFRAMEBUFFERFIPROC (uint framebuffer, int buffer, int drawbuffer, float depth, int stencil);
public delegate void PFNGLBLITNAMEDFRAMEBUFFERPROC (uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);
public delegate void PFNGLGETNAMEDFRAMEBUFFERPARAMETERIVPROC (uint framebuffer, int pname, int *param);
public delegate void PFNGLGETNAMEDFRAMEBUFFERATTACHMENTPARAMETERIVPROC (uint framebuffer, int attachment, int pname, int *prms);
public delegate void PFNGLCREATERENDERBUFFERSPROC (uint n, uint *renderbuffers);
public delegate void PFNGLNAMEDRENDERBUFFERSTORAGEPROC (uint renderbuffer, int internalformat, uint width, uint height);
public delegate void PFNGLNAMEDRENDERBUFFERSTORAGEMULTISAMPLEPROC (uint renderbuffer, uint samples, int internalformat, uint width, uint height);
public delegate void PFNGLGETNAMEDRENDERBUFFERPARAMETERIVPROC (uint renderbuffer, int pname, int *prms);
public delegate void PFNGLCREATETEXTURESPROC (int target, uint n, uint *textures);
public delegate void PFNGLTEXTUREBUFFERPROC (uint texture, int internalformat, uint buffer);
public delegate void PFNGLTEXTUREBUFFERRANGEPROC (uint texture, int internalformat, uint buffer, int* offset, uint* size);
public delegate void PFNGLTEXTURESTORAGE1DPROC (uint texture, uint levels, int internalformat, uint width);
public delegate void PFNGLTEXTURESTORAGE2DPROC (uint texture, uint levels, int internalformat, uint width, uint height);
public delegate void PFNGLTEXTURESTORAGE3DPROC (uint texture, uint levels, int internalformat, uint width, uint height, uint depth);
public delegate void PFNGLTEXTURESTORAGE2DMULTISAMPLEPROC (uint texture, uint samples, int internalformat, uint width, uint height, int fixedsamplelocations);
public delegate void PFNGLTEXTURESTORAGE3DMULTISAMPLEPROC (uint texture, uint samples, int internalformat, uint width, uint height, uint depth, int fixedsamplelocations);
public delegate void PFNGLTEXTURESUBIMAGE1DPROC (uint texture, int level, int xoffset, uint width, int format, int type,  void *pixels);
public delegate void PFNGLTEXTURESUBIMAGE2DPROC (uint texture, int level, int xoffset, int yoffset, uint width, uint height, int format, int type,  void *pixels);
public delegate void PFNGLTEXTURESUBIMAGE3DPROC (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *pixels);
public delegate void PFNGLCOMPRESSEDTEXTURESUBIMAGE1DPROC (uint texture, int level, int xoffset, uint width, int format, uint imageSize,  void *data);
public delegate void PFNGLCOMPRESSEDTEXTURESUBIMAGE2DPROC (uint texture, int level, int xoffset, int yoffset, uint width, uint height, int format, uint imageSize,  void *data);
public delegate void PFNGLCOMPRESSEDTEXTURESUBIMAGE3DPROC (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, uint imageSize,  void *data);
public delegate void PFNGLCOPYTEXTURESUBIMAGE1DPROC (uint texture, int level, int xoffset, int x, int y, uint width);
public delegate void PFNGLCOPYTEXTURESUBIMAGE2DPROC (uint texture, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
public delegate void PFNGLCOPYTEXTURESUBIMAGE3DPROC (uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
public delegate void PFNGLTEXTUREPARAMETERFPROC (uint texture, int pname, float param);
public delegate void PFNGLTEXTUREPARAMETERFVPROC (uint texture, int pname,  float *param);
public delegate void PFNGLTEXTUREPARAMETERIPROC (uint texture, int pname, int param);
public delegate void PFNGLTEXTUREPARAMETERIIVPROC (uint texture, int pname,  int *prms);
public delegate void PFNGLTEXTUREPARAMETERIUIVPROC (uint texture, int pname,  uint *prms);
public delegate void PFNGLTEXTUREPARAMETERIVPROC (uint texture, int pname,  int *param);
public delegate void PFNGLGENERATETEXTUREMIPMAPPROC (uint texture);
public delegate void PFNGLBINDTEXTUREUNITPROC (uint unit, uint texture);
public delegate void PFNGLGETTEXTUREIMAGEPROC (uint texture, int level, int format, int type, uint bufSize, void *pixels);
public delegate void PFNGLGETCOMPRESSEDTEXTUREIMAGEPROC (uint texture, int level, uint bufSize, void *pixels);
public delegate void PFNGLGETTEXTURELEVELPARAMETERFVPROC (uint texture, int level, int pname, float *prms);
public delegate void PFNGLGETTEXTURELEVELPARAMETERIVPROC (uint texture, int level, int pname, int *prms);
public delegate void PFNGLGETTEXTUREPARAMETERFVPROC (uint texture, int pname, float *prms);
public delegate void PFNGLGETTEXTUREPARAMETERIIVPROC (uint texture, int pname, int *prms);
public delegate void PFNGLGETTEXTUREPARAMETERIUIVPROC (uint texture, int pname, uint *prms);
public delegate void PFNGLGETTEXTUREPARAMETERIVPROC (uint texture, int pname, int *prms);
public delegate void PFNGLCREATEVERTEXARRAYSPROC (uint n, uint *arrays);
public delegate void PFNGLDISABLEVERTEXARRAYATTRIBPROC (uint vaobj, uint index);
public delegate void PFNGLENABLEVERTEXARRAYATTRIBPROC (uint vaobj, uint index);
public delegate void PFNGLVERTEXARRAYELEMENTBUFFERPROC (uint vaobj, uint buffer);
public delegate void PFNGLVERTEXARRAYVERTEXBUFFERPROC (uint vaobj, uint bindingindex, uint buffer, int* offset, uint stride);
public delegate void PFNGLVERTEXARRAYVERTEXBUFFERSPROC (uint vaobj, uint first, uint count,  uint *buffers,  int* *offsets,  uint *strides);
public delegate void PFNGLVERTEXARRAYATTRIBBINDINGPROC (uint vaobj, uint attribindex, uint bindingindex);
public delegate void PFNGLVERTEXARRAYATTRIBFORMATPROC (uint vaobj, uint attribindex, int size, int type, int normalized, uint relativeoffset);
public delegate void PFNGLVERTEXARRAYATTRIBIFORMATPROC (uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
public delegate void PFNGLVERTEXARRAYATTRIBLFORMATPROC (uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
public delegate void PFNGLVERTEXARRAYBINDINGDIVISORPROC (uint vaobj, uint bindingindex, uint divisor);
public delegate void PFNGLGETVERTEXARRAYIVPROC (uint vaobj, int pname, int *param);
public delegate void PFNGLGETVERTEXARRAYINDEXEDIVPROC (uint vaobj, uint index, int pname, int *param);
public delegate void PFNGLGETVERTEXARRAYINDEXED64IVPROC (uint vaobj, uint index, int pname, int64 *param);
public delegate void PFNGLCREATESAMPLERSPROC (uint n, uint *samplers);
public delegate void PFNGLCREATEPROGRAMPIPELINESPROC (uint n, uint *pipelines);
public delegate void PFNGLCREATEQUERIESPROC (int target, uint n, uint *ids);
public delegate void PFNGLGETQUERYBUFFEROBJECTI64VPROC (uint id, uint buffer, int pname, int* offset);
public delegate void PFNGLGETQUERYBUFFEROBJECTIVPROC (uint id, uint buffer, int pname, int* offset);
public delegate void PFNGLGETQUERYBUFFEROBJECTUI64VPROC (uint id, uint buffer, int pname, int* offset);
public delegate void PFNGLGETQUERYBUFFEROBJECTUIVPROC (uint id, uint buffer, int pname, int* offset);
public delegate void PFNGLMEMORYBARRIERBYREGIONPROC (int barriers);
public delegate void PFNGLGETTEXTURESUBIMAGEPROC (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type, uint bufSize, void *pixels);
public delegate void PFNGLGETCOMPRESSEDTEXTURESUBIMAGEPROC (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, uint bufSize, void *pixels);
public delegate void PFNGLGETNCOMPRESSEDTEXIMAGEPROC (int target, int lod, uint bufSize, void *pixels);
public delegate void PFNGLGETNTEXIMAGEPROC (int target, int level, int format, int type, uint bufSize, void *pixels);
public delegate void PFNGLGETNUNIFORMDVPROC (uint program, int location, uint bufSize, double *prms);
public delegate void PFNGLGETNUNIFORMFVPROC (uint program, int location, uint bufSize, float *prms);
public delegate void PFNGLGETNUNIFORMIVPROC (uint program, int location, uint bufSize, int *prms);
public delegate void PFNGLGETNUNIFORMUIVPROC (uint program, int location, uint bufSize, uint *prms);
public delegate void PFNGLREADNPIXELSPROC (int x, int y, uint width, uint height, int format, int type, uint bufSize, void *data);
public delegate void PFNGLTEXTUREBARRIERPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glClipControl (int origin, int depth);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateTransformFeedbacks (uint n, uint *ids);
	[DllImport("glfw3.dll")]
	public static extern  void glTransformFeedbackBufferBase (uint xfb, uint index, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glTransformFeedbackBufferRange (uint xfb, uint index, uint buffer, int* offset, uint* size);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTransformFeedbackiv (uint xfb, int pname, int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTransformFeedbacki_v (uint xfb, int pname, uint index, int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTransformFeedbacki64_v (uint xfb, int pname, uint index, int64 *param);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateBuffers (uint n, uint *buffers);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferStorage (uint buffer, uint* size,  void *data, int flags);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferData (uint buffer, uint* size,  void *data, int usage);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferSubData (uint buffer, int* offset, uint* size,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyNamedBufferSubData (uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, uint* size);
	[DllImport("glfw3.dll")]
	public static extern  void glClearNamedBufferData (uint buffer, int internalformat, int format, int type,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glClearNamedBufferSubData (uint buffer, int internalformat, int* offset, uint* size, int format, int type,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void  glMapNamedBuffer (uint buffer, int access);
	[DllImport("glfw3.dll")]
	public static extern  void  glMapNamedBufferRange (uint buffer, int* offset, uint* length, int access);
	[DllImport("glfw3.dll")]
	public static extern  int glUnmapNamedBuffer (uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glFlushMappedNamedBufferRange (uint buffer, int* offset, uint* length);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedBufferParameteriv (uint buffer, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedBufferParameteri64v (uint buffer, int pname, int64 *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedBufferPointerv (uint buffer, int pname, void **prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedBufferSubData (uint buffer, int* offset, uint* size, void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateFramebuffers (uint n, uint *framebuffers);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferRenderbuffer (uint framebuffer, int attachment, int renderbuffertarget, uint renderbuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferParameteri (uint framebuffer, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferTexture (uint framebuffer, int attachment, uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferTextureLayer (uint framebuffer, int attachment, uint texture, int level, int layer);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferDrawBuffer (uint framebuffer, int buf);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferDrawBuffers (uint framebuffer, uint n,  int *bufs);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferReadBuffer (uint framebuffer, int src);
	[DllImport("glfw3.dll")]
	public static extern  void glInvalidateNamedFramebufferData (uint framebuffer, uint numAttachments,  int *attachments);
	[DllImport("glfw3.dll")]
	public static extern  void glInvalidateNamedFramebufferSubData (uint framebuffer, uint numAttachments,  int *attachments, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glClearNamedFramebufferiv (uint framebuffer, int buffer, int drawbuffer,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glClearNamedFramebufferuiv (uint framebuffer, int buffer, int drawbuffer,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glClearNamedFramebufferfv (uint framebuffer, int buffer, int drawbuffer,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glClearNamedFramebufferfi (uint framebuffer, int buffer, int drawbuffer, float depth, int stencil);
	[DllImport("glfw3.dll")]
	public static extern  void glBlitNamedFramebuffer (uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);
	[DllImport("glfw3.dll")]
	public static extern  int glCheckNamedFramebufferStatus (uint framebuffer, int target);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedFramebufferParameteriv (uint framebuffer, int pname, int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedFramebufferAttachmentParameteriv (uint framebuffer, int attachment, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateRenderbuffers (uint n, uint *renderbuffers);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedRenderbufferStorage (uint renderbuffer, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedRenderbufferStorageMultisample (uint renderbuffer, uint samples, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedRenderbufferParameteriv (uint renderbuffer, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateTextures (int target, uint n, uint *textures);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureBuffer (uint texture, int internalformat, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureBufferRange (uint texture, int internalformat, uint buffer, int* offset, uint* size);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage1D (uint texture, uint levels, int internalformat, uint width);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage2D (uint texture, uint levels, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage3D (uint texture, uint levels, int internalformat, uint width, uint height, uint depth);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage2DMultisample (uint texture, uint samples, int internalformat, uint width, uint height, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage3DMultisample (uint texture, uint samples, int internalformat, uint width, uint height, uint depth, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureSubImage1D (uint texture, int level, int xoffset, uint width, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureSubImage2D (uint texture, int level, int xoffset, int yoffset, uint width, uint height, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureSubImage1D (uint texture, int level, int xoffset, uint width, int format, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureSubImage2D (uint texture, int level, int xoffset, int yoffset, uint width, uint height, int format, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, uint imageSize,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTextureSubImage1D (uint texture, int level, int xoffset, int x, int y, uint width);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTextureSubImage2D (uint texture, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterf (uint texture, int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterfv (uint texture, int pname,  float *param);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameteri (uint texture, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterIiv (uint texture, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterIuiv (uint texture, int pname,  uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameteriv (uint texture, int pname,  int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGenerateTextureMipmap (uint texture);
	[DllImport("glfw3.dll")]
	public static extern  void glBindTextureUnit (uint unit, uint texture);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureImage (uint texture, int level, int format, int type, uint bufSize, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetCompressedTextureImage (uint texture, int level, uint bufSize, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureLevelParameterfv (uint texture, int level, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureLevelParameteriv (uint texture, int level, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureParameterfv (uint texture, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureParameterIiv (uint texture, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureParameterIuiv (uint texture, int pname, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureParameteriv (uint texture, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateVertexArrays (uint n, uint *arrays);
	[DllImport("glfw3.dll")]
	public static extern  void glDisableVertexArrayAttrib (uint vaobj, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glEnableVertexArrayAttrib (uint vaobj, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayElementBuffer (uint vaobj, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexBuffer (uint vaobj, uint bindingindex, uint buffer, int* offset, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexBuffers (uint vaobj, uint first, uint count,  uint *buffers,  int* *offsets,  uint *strides);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayAttribBinding (uint vaobj, uint attribindex, uint bindingindex);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayAttribFormat (uint vaobj, uint attribindex, int size, int type, int normalized, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayAttribIFormat (uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayAttribLFormat (uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayBindingDivisor (uint vaobj, uint bindingindex, uint divisor);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexArrayiv (uint vaobj, int pname, int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexArrayIndexediv (uint vaobj, uint index, int pname, int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexArrayIndexed64iv (uint vaobj, uint index, int pname, int64 *param);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateSamplers (uint n, uint *samplers);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateProgramPipelines (uint n, uint *pipelines);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateQueries (int target, uint n, uint *ids);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryBufferObjecti64v (uint id, uint buffer, int pname, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryBufferObjectiv (uint id, uint buffer, int pname, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryBufferObjectui64v (uint id, uint buffer, int pname, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glGetQueryBufferObjectuiv (uint id, uint buffer, int pname, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glMemoryBarrierByRegion (int barriers);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type, uint bufSize, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetCompressedTextureSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, uint bufSize, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  int glGetGraphicsResetStatus ();
	[DllImport("glfw3.dll")]
	public static extern  void glGetnCompressedTexImage (int target, int lod, uint bufSize, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnTexImage (int target, int level, int format, int type, uint bufSize, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformdv (uint program, int location, uint bufSize, double *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformfv (uint program, int location, uint bufSize, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformiv (uint program, int location, uint bufSize, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformuiv (uint program, int location, uint bufSize, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glReadnPixels (int x, int y, uint width, uint height, int format, int type, uint bufSize, void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureBarrier ();
	public const int GL_VERSION_4_6 = 1;

	public const int GL_SHADER_BINARY_FORMAT_SPIR_V = 0x9551;

	public const int GL_SPIR_V_BINARY = 0x9552;

	public const int GL_PARAMETER_BUFFER = 0x80EE;

	public const int GL_PARAMETER_BUFFER_BINDING = 0x80EF;

	public const int GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;

	public const int GL_VERTICES_SUBMITTED = 0x82EE;

	public const int GL_PRIMITIVES_SUBMITTED = 0x82EF;

	public const int GL_VERTEX_SHADER_INVOCATIONS = 0x82F0;

	public const int GL_TESS_CONTROL_SHADER_PATCHES = 0x82F1;

	public const int GL_TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;

	public const int GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;

	public const int GL_FRAGMENT_SHADER_INVOCATIONS = 0x82F4;

	public const int GL_COMPUTE_SHADER_INVOCATIONS = 0x82F5;

	public const int GL_CLIPPING_INPUT_PRIMITIVES = 0x82F6;

	public const int GL_CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;

	public const int GL_POLYGON_OFFSET_CLAMP = 0x8E1B;

	public const int GL_SPIR_V_EXTENSIONS = 0x9553;

	public const int GL_NUM_SPIR_V_EXTENSIONS = 0x9554;

	public const int GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;

	public const int GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;

	public const int GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC;

	public const int GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;

public delegate void PFNGLSPECIALIZESHADERPROC (uint shader,  char *pEntryPoint, uint numSpecializationConstants,  uint *pConstantIndex,  uint *pConstantValue);
public delegate void PFNGLMULTIDRAWARRAYSINDIRECTCOUNTPROC (int mode,  void *indirect, int* drawcount, uint maxdrawcount, uint stride);
public delegate void PFNGLMULTIDRAWELEMENTSINDIRECTCOUNTPROC (int mode, int type,  void *indirect, int* drawcount, uint maxdrawcount, uint stride);
public delegate void PFNGLPOLYGONOFFSETCLAMPPROC (float factor, float units, float clamp);
	[DllImport("glfw3.dll")]
	public static extern  void glSpecializeShader (uint shader,  char *pEntryPoint, uint numSpecializationConstants,  uint *pConstantIndex,  uint *pConstantValue);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawArraysIndirectCount (int mode,  void *indirect, int* drawcount, uint maxdrawcount, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawElementsIndirectCount (int mode, int type,  void *indirect, int* drawcount, uint maxdrawcount, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glPolygonOffsetClamp (float factor, float units, float clamp);
	public const int GL_ARB_ES2_compatibility = 1;

	public const int GL_ARB_ES3_1_compatibility = 1;

	public const int GL_ARB_ES3_2_compatibility = 1;

	public const int GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;

	public const int GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;

	public const int GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;

public delegate void PFNGLPRIMITIVEBOUNDINGBOXARBPROC (float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
	[DllImport("glfw3.dll")]
	public static extern  void glPrimitiveBoundingBoxARB (float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
	public const int GL_ARB_ES3_compatibility = 1;

	public const int GL_ARB_arrays_of_arrays = 1;

	public const int GL_ARB_base_instance = 1;

	public const int GL_ARB_bindless_texture = 1;

	public const int GL_UNSIGNED_INT64_ARB = 0x140F;

public delegate void PFNGLMAKETEXTUREHANDLERESIDENTARBPROC (ulong handle);
public delegate void PFNGLMAKETEXTUREHANDLENONRESIDENTARBPROC (ulong handle);
public delegate void PFNGLMAKEIMAGEHANDLERESIDENTARBPROC (ulong handle, int access);
public delegate void PFNGLMAKEIMAGEHANDLENONRESIDENTARBPROC (ulong handle);
public delegate void PFNGLUNIFORMHANDLEUI64ARBPROC (int location, ulong value);
public delegate void PFNGLUNIFORMHANDLEUI64VARBPROC (int location, uint count,  ulong *value);
public delegate void PFNGLPROGRAMUNIFORMHANDLEUI64ARBPROC (uint program, int location, ulong value);
public delegate void PFNGLPROGRAMUNIFORMHANDLEUI64VARBPROC (uint program, int location, uint count,  ulong *values);
public delegate void PFNGLVERTEXATTRIBL1UI64ARBPROC (uint index, ulong x);
public delegate void PFNGLVERTEXATTRIBL1UI64VARBPROC (uint index,  ulong *v);
public delegate void PFNGLGETVERTEXATTRIBLUI64VARBPROC (uint index, int pname, ulong *prms);
	[DllImport("glfw3.dll")]
	public static extern  ulong glGetTextureHandleARB (uint texture);
	[DllImport("glfw3.dll")]
	public static extern  ulong glGetTextureSamplerHandleARB (uint texture, uint sampler);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeTextureHandleResidentARB (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeTextureHandleNonResidentARB (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  ulong glGetImageHandleARB (uint texture, int level, int layered, int layer, int format);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeImageHandleResidentARB (ulong handle, int access);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeImageHandleNonResidentARB (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformHandleui64ARB (int location, ulong value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformHandleui64vARB (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformHandleui64ARB (uint program, int location, ulong value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformHandleui64vARB (uint program, int location, uint count,  ulong *values);
	[DllImport("glfw3.dll")]
	public static extern  int glIsTextureHandleResidentARB (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  int glIsImageHandleResidentARB (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL1ui64ARB (uint index, ulong x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL1ui64vARB (uint index,  ulong *v);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribLui64vARB (uint index, int pname, ulong *prms);
	public const int GL_ARB_blend_func_extended = 1;

	public const int GL_ARB_buffer_storage = 1;

	public const int GL_ARB_cl_event = 1;

struct _cl_context;{}
struct _cl_event;{}
	public const int GL_SYNC_CL_EVENT_ARB = 0x8240;

	public const int GL_SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;

public delegate IntPtr PFNGLCREATESYNCFROMCLEVENTARBPROC ( _cl_context *context,  _cl_event *event, int flags);
	[DllImport("glfw3.dll")]
	public static extern  IntPtr glCreateSyncFromCLeventARB ( _cl_context *context,  _cl_event *event, int flags);
	public const int GL_ARB_clear_buffer_object = 1;

	public const int GL_ARB_clear_texture = 1;

	public const int GL_ARB_clip_control = 1;

	public const int GL_ARB_compressed_texture_pixel_storage = 1;

	public const int GL_ARB_compute_shader = 1;

	public const int GL_ARB_compute_variable_group_size = 1;

	public const int GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;

	public const int GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB;

	public const int GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;

	public const int GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF;

public delegate void PFNGLDISPATCHCOMPUTEGROUPSIZEARBPROC (uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);
	[DllImport("glfw3.dll")]
	public static extern  void glDispatchComputeGroupSizeARB (uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);
	public const int GL_ARB_conditional_render_inverted = 1;

	public const int GL_ARB_conservative_depth = 1;

	public const int GL_ARB_copy_buffer = 1;

	public const int GL_ARB_copy_image = 1;

	public const int GL_ARB_cull_distance = 1;

	public const int GL_ARB_debug_output = 1;

public delegate void  GLDEBUGPROCARB (int source,int type,uint id,int severity,uint length, char *message, void *userParam);
	public const int GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242;

	public const int GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243;

	public const int GL_DEBUG_CALLBACK_FUNCTION_ARB = 0x8244;

	public const int GL_DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245;

	public const int GL_DEBUG_SOURCE_API_ARB = 0x8246;

	public const int GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247;

	public const int GL_DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248;

	public const int GL_DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249;

	public const int GL_DEBUG_SOURCE_APPLICATION_ARB = 0x824A;

	public const int GL_DEBUG_SOURCE_OTHER_ARB = 0x824B;

	public const int GL_DEBUG_TYPE_ERROR_ARB = 0x824C;

	public const int GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D;

	public const int GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E;

	public const int GL_DEBUG_TYPE_PORTABILITY_ARB = 0x824F;

	public const int GL_DEBUG_TYPE_PERFORMANCE_ARB = 0x8250;

	public const int GL_DEBUG_TYPE_OTHER_ARB = 0x8251;

	public const int GL_MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143;

	public const int GL_MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144;

	public const int GL_DEBUG_LOGGED_MESSAGES_ARB = 0x9145;

	public const int GL_DEBUG_SEVERITY_HIGH_ARB = 0x9146;

	public const int GL_DEBUG_SEVERITY_MEDIUM_ARB = 0x9147;

	public const int GL_DEBUG_SEVERITY_LOW_ARB = 0x9148;

public delegate void PFNGLDEBUGMESSAGECONTROLARBPROC (int source, int type, int severity, uint count,  uint *ids, int enabled);
public delegate void PFNGLDEBUGMESSAGEINSERTARBPROC (int source, int type, uint id, int severity, uint length,  char *buf);
public delegate void PFNGLDEBUGMESSAGECALLBACKARBPROC (GLDEBUGPROCARB callback,  void *userParam);
	[DllImport("glfw3.dll")]
	public static extern  void glDebugMessageControlARB (int source, int type, int severity, uint count,  uint *ids, int enabled);
	[DllImport("glfw3.dll")]
	public static extern  void glDebugMessageInsertARB (int source, int type, uint id, int severity, uint length,  char *buf);
	[DllImport("glfw3.dll")]
	public static extern  void glDebugMessageCallbackARB (GLDEBUGPROCARB callback,  void *userParam);
	[DllImport("glfw3.dll")]
	public static extern  uint glGetDebugMessageLogARB (uint count, uint bufSize, int *sources, int *types, uint *ids, int *severities, uint *lengths, char *messageLog);
	public const int GL_ARB_depth_buffer_float = 1;

	public const int GL_ARB_depth_clamp = 1;

	public const int GL_ARB_derivative_control = 1;

	public const int GL_ARB_direct_state_access = 1;

	public const int GL_ARB_draw_buffers_blend = 1;

public delegate void PFNGLBLENDEQUATIONIARBPROC (uint buf, int mode);
public delegate void PFNGLBLENDEQUATIONSEPARATEIARBPROC (uint buf, int modeRGB, int modeAlpha);
public delegate void PFNGLBLENDFUNCIARBPROC (uint buf, int src, int dst);
public delegate void PFNGLBLENDFUNCSEPARATEIARBPROC (uint buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendEquationiARB (uint buf, int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendEquationSeparateiARB (uint buf, int modeRGB, int modeAlpha);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendFunciARB (uint buf, int src, int dst);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendFuncSeparateiARB (uint buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
	public const int GL_ARB_draw_elements_base_vertex = 1;

	public const int GL_ARB_draw_indirect = 1;

	public const int GL_ARB_draw_instanced = 1;

public delegate void PFNGLDRAWARRAYSINSTANCEDARBPROC (int mode, int first, uint count, uint primcount);
public delegate void PFNGLDRAWELEMENTSINSTANCEDARBPROC (int mode, uint count, int type,  void *indices, uint primcount);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawArraysInstancedARB (int mode, int first, uint count, uint primcount);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElementsInstancedARB (int mode, uint count, int type,  void *indices, uint primcount);
	public const int GL_ARB_enhanced_layouts = 1;

	public const int GL_ARB_explicit_attrib_location = 1;

	public const int GL_ARB_explicit_uniform_location = 1;

	public const int GL_ARB_fragment_coord_conventions = 1;

	public const int GL_ARB_fragment_layer_viewport = 1;

	public const int GL_ARB_fragment_shader_interlock = 1;

	public const int GL_ARB_framebuffer_no_attachments = 1;

	public const int GL_ARB_framebuffer_object = 1;

	public const int GL_ARB_framebuffer_sRGB = 1;

	public const int GL_ARB_geometry_shader4 = 1;

	public const int GL_LINES_ADJACENCY_ARB = 0x000A;

	public const int GL_LINE_STRIP_ADJACENCY_ARB = 0x000B;

	public const int GL_TRIANGLES_ADJACENCY_ARB = 0x000C;

	public const int GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D;

	public const int GL_PROGRAM_POINT_SIZE_ARB = 0x8642;

	public const int GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;

	public const int GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7;

	public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;

	public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;

	public const int GL_GEOMETRY_SHADER_ARB = 0x8DD9;

	public const int GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;

	public const int GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;

	public const int GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;

	public const int GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;

	public const int GL_MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;

	public const int GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;

	public const int GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;

	public const int GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;

public delegate void PFNGLPROGRAMPARAMETERIARBPROC (uint program, int pname, int value);
public delegate void PFNGLFRAMEBUFFERTEXTUREARBPROC (int target, int attachment, uint texture, int level);
public delegate void PFNGLFRAMEBUFFERTEXTURELAYERARBPROC (int target, int attachment, uint texture, int level, int layer);
public delegate void PFNGLFRAMEBUFFERTEXTUREFACEARBPROC (int target, int attachment, uint texture, int level, int face);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramParameteriARB (uint program, int pname, int value);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTextureARB (int target, int attachment, uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTextureLayerARB (int target, int attachment, uint texture, int level, int layer);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTextureFaceARB (int target, int attachment, uint texture, int level, int face);
	public const int GL_ARB_get_program_binary = 1;

	public const int GL_ARB_get_texture_sub_image = 1;

	public const int GL_ARB_gl_spirv = 1;

	public const int GL_SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551;

	public const int GL_SPIR_V_BINARY_ARB = 0x9552;

public delegate void PFNGLSPECIALIZESHADERARBPROC (uint shader,  char *pEntryPoint, uint numSpecializationConstants,  uint *pConstantIndex,  uint *pConstantValue);
	[DllImport("glfw3.dll")]
	public static extern  void glSpecializeShaderARB (uint shader,  char *pEntryPoint, uint numSpecializationConstants,  uint *pConstantIndex,  uint *pConstantValue);
	public const int GL_ARB_gpu_shader5 = 1;

	public const int GL_ARB_gpu_shader_fp64 = 1;

	public const int GL_ARB_gpu_shader_int64 = 1;

	public const int GL_INT64_ARB = 0x140E;

	public const int GL_INT64_VEC2_ARB = 0x8FE9;

	public const int GL_INT64_VEC3_ARB = 0x8FEA;

	public const int GL_INT64_VEC4_ARB = 0x8FEB;

	public const int GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5;

	public const int GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6;

	public const int GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7;

public delegate void PFNGLUNIFORM1I64ARBPROC (int location, int64 x);
public delegate void PFNGLUNIFORM2I64ARBPROC (int location, int64 x, int64 y);
public delegate void PFNGLUNIFORM3I64ARBPROC (int location, int64 x, int64 y, int64 z);
public delegate void PFNGLUNIFORM4I64ARBPROC (int location, int64 x, int64 y, int64 z, int64 w);
public delegate void PFNGLUNIFORM1I64VARBPROC (int location, uint count,  int64 *value);
public delegate void PFNGLUNIFORM2I64VARBPROC (int location, uint count,  int64 *value);
public delegate void PFNGLUNIFORM3I64VARBPROC (int location, uint count,  int64 *value);
public delegate void PFNGLUNIFORM4I64VARBPROC (int location, uint count,  int64 *value);
public delegate void PFNGLUNIFORM1UI64ARBPROC (int location, ulong x);
public delegate void PFNGLUNIFORM2UI64ARBPROC (int location, ulong x, ulong y);
public delegate void PFNGLUNIFORM3UI64ARBPROC (int location, ulong x, ulong y, ulong z);
public delegate void PFNGLUNIFORM4UI64ARBPROC (int location, ulong x, ulong y, ulong z, ulong w);
public delegate void PFNGLUNIFORM1UI64VARBPROC (int location, uint count,  ulong *value);
public delegate void PFNGLUNIFORM2UI64VARBPROC (int location, uint count,  ulong *value);
public delegate void PFNGLUNIFORM3UI64VARBPROC (int location, uint count,  ulong *value);
public delegate void PFNGLUNIFORM4UI64VARBPROC (int location, uint count,  ulong *value);
public delegate void PFNGLGETUNIFORMI64VARBPROC (uint program, int location, int64 *prms);
public delegate void PFNGLGETUNIFORMUI64VARBPROC (uint program, int location, ulong *prms);
public delegate void PFNGLGETNUNIFORMI64VARBPROC (uint program, int location, uint bufSize, int64 *prms);
public delegate void PFNGLGETNUNIFORMUI64VARBPROC (uint program, int location, uint bufSize, ulong *prms);
public delegate void PFNGLPROGRAMUNIFORM1I64ARBPROC (uint program, int location, int64 x);
public delegate void PFNGLPROGRAMUNIFORM2I64ARBPROC (uint program, int location, int64 x, int64 y);
public delegate void PFNGLPROGRAMUNIFORM3I64ARBPROC (uint program, int location, int64 x, int64 y, int64 z);
public delegate void PFNGLPROGRAMUNIFORM4I64ARBPROC (uint program, int location, int64 x, int64 y, int64 z, int64 w);
public delegate void PFNGLPROGRAMUNIFORM1I64VARBPROC (uint program, int location, uint count,  int64 *value);
public delegate void PFNGLPROGRAMUNIFORM2I64VARBPROC (uint program, int location, uint count,  int64 *value);
public delegate void PFNGLPROGRAMUNIFORM3I64VARBPROC (uint program, int location, uint count,  int64 *value);
public delegate void PFNGLPROGRAMUNIFORM4I64VARBPROC (uint program, int location, uint count,  int64 *value);
public delegate void PFNGLPROGRAMUNIFORM1UI64ARBPROC (uint program, int location, ulong x);
public delegate void PFNGLPROGRAMUNIFORM2UI64ARBPROC (uint program, int location, ulong x, ulong y);
public delegate void PFNGLPROGRAMUNIFORM3UI64ARBPROC (uint program, int location, ulong x, ulong y, ulong z);
public delegate void PFNGLPROGRAMUNIFORM4UI64ARBPROC (uint program, int location, ulong x, ulong y, ulong z, ulong w);
public delegate void PFNGLPROGRAMUNIFORM1UI64VARBPROC (uint program, int location, uint count,  ulong *value);
public delegate void PFNGLPROGRAMUNIFORM2UI64VARBPROC (uint program, int location, uint count,  ulong *value);
public delegate void PFNGLPROGRAMUNIFORM3UI64VARBPROC (uint program, int location, uint count,  ulong *value);
public delegate void PFNGLPROGRAMUNIFORM4UI64VARBPROC (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1i64ARB (int location, int64 x);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2i64ARB (int location, int64 x, int64 y);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3i64ARB (int location, int64 x, int64 y, int64 z);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4i64ARB (int location, int64 x, int64 y, int64 z, int64 w);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1i64vARB (int location, uint count,  int64 *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2i64vARB (int location, uint count,  int64 *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3i64vARB (int location, uint count,  int64 *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4i64vARB (int location, uint count,  int64 *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1ui64ARB (int location, ulong x);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2ui64ARB (int location, ulong x, ulong y);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3ui64ARB (int location, ulong x, ulong y, ulong z);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4ui64ARB (int location, ulong x, ulong y, ulong z, ulong w);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1ui64vARB (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2ui64vARB (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3ui64vARB (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4ui64vARB (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformi64vARB (uint program, int location, int64 *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformui64vARB (uint program, int location, ulong *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformi64vARB (uint program, int location, uint bufSize, int64 *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformui64vARB (uint program, int location, uint bufSize, ulong *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1i64ARB (uint program, int location, int64 x);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2i64ARB (uint program, int location, int64 x, int64 y);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3i64ARB (uint program, int location, int64 x, int64 y, int64 z);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4i64ARB (uint program, int location, int64 x, int64 y, int64 z, int64 w);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1i64vARB (uint program, int location, uint count,  int64 *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2i64vARB (uint program, int location, uint count,  int64 *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3i64vARB (uint program, int location, uint count,  int64 *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4i64vARB (uint program, int location, uint count,  int64 *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1ui64ARB (uint program, int location, ulong x);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2ui64ARB (uint program, int location, ulong x, ulong y);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3ui64ARB (uint program, int location, ulong x, ulong y, ulong z);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4ui64ARB (uint program, int location, ulong x, ulong y, ulong z, ulong w);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1ui64vARB (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2ui64vARB (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3ui64vARB (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4ui64vARB (uint program, int location, uint count,  ulong *value);
	public const int GL_ARB_half_float_vertex = 1;

	public const int GL_ARB_imaging = 1;

	public const int GL_ARB_indirect_parameters = 1;

	public const int GL_PARAMETER_BUFFER_ARB = 0x80EE;

	public const int GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF;

public delegate void PFNGLMULTIDRAWARRAYSINDIRECTCOUNTARBPROC (int mode,  void *indirect, int* drawcount, uint maxdrawcount, uint stride);
public delegate void PFNGLMULTIDRAWELEMENTSINDIRECTCOUNTARBPROC (int mode, int type,  void *indirect, int* drawcount, uint maxdrawcount, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawArraysIndirectCountARB (int mode,  void *indirect, int* drawcount, uint maxdrawcount, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawElementsIndirectCountARB (int mode, int type,  void *indirect, int* drawcount, uint maxdrawcount, uint stride);
	public const int GL_ARB_instanced_arrays = 1;

	public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;

public delegate void PFNGLVERTEXATTRIBDIVISORARBPROC (uint index, uint divisor);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribDivisorARB (uint index, uint divisor);
	public const int GL_ARB_internalformat_query = 1;

	public const int GL_ARB_internalformat_query2 = 1;

	public const int GL_SRGB_DECODE_ARB = 0x8299;

	public const int GL_VIEW_CLASS_EAC_R11 = 0x9383;

	public const int GL_VIEW_CLASS_EAC_RG11 = 0x9384;

	public const int GL_VIEW_CLASS_ETC2_RGB = 0x9385;

	public const int GL_VIEW_CLASS_ETC2_RGBA = 0x9386;

	public const int GL_VIEW_CLASS_ETC2_EAC_RGBA = 0x9387;

	public const int GL_VIEW_CLASS_ASTC_4x4_RGBA = 0x9388;

	public const int GL_VIEW_CLASS_ASTC_5x4_RGBA = 0x9389;

	public const int GL_VIEW_CLASS_ASTC_5x5_RGBA = 0x938A;

	public const int GL_VIEW_CLASS_ASTC_6x5_RGBA = 0x938B;

	public const int GL_VIEW_CLASS_ASTC_6x6_RGBA = 0x938C;

	public const int GL_VIEW_CLASS_ASTC_8x5_RGBA = 0x938D;

	public const int GL_VIEW_CLASS_ASTC_8x6_RGBA = 0x938E;

	public const int GL_VIEW_CLASS_ASTC_8x8_RGBA = 0x938F;

	public const int GL_VIEW_CLASS_ASTC_10x5_RGBA = 0x9390;

	public const int GL_VIEW_CLASS_ASTC_10x6_RGBA = 0x9391;

	public const int GL_VIEW_CLASS_ASTC_10x8_RGBA = 0x9392;

	public const int GL_VIEW_CLASS_ASTC_10x10_RGBA = 0x9393;

	public const int GL_VIEW_CLASS_ASTC_12x10_RGBA = 0x9394;

	public const int GL_VIEW_CLASS_ASTC_12x12_RGBA = 0x9395;

	public const int GL_ARB_invalidate_subdata = 1;

	public const int GL_ARB_map_buffer_alignment = 1;

	public const int GL_ARB_map_buffer_range = 1;

	public const int GL_ARB_multi_bind = 1;

	public const int GL_ARB_multi_draw_indirect = 1;

	public const int GL_ARB_occlusion_query2 = 1;

	public const int GL_ARB_parallel_shader_compile = 1;

	public const int GL_MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;

	public const int GL_COMPLETION_STATUS_ARB = 0x91B1;

public delegate void PFNGLMAXSHADERCOMPILERTHREADSARBPROC (uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glMaxShaderCompilerThreadsARB (uint count);
	public const int GL_ARB_pipeline_statistics_query = 1;

	public const int GL_VERTICES_SUBMITTED_ARB = 0x82EE;

	public const int GL_PRIMITIVES_SUBMITTED_ARB = 0x82EF;

	public const int GL_VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0;

	public const int GL_TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1;

	public const int GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2;

	public const int GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3;

	public const int GL_FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4;

	public const int GL_COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5;

	public const int GL_CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6;

	public const int GL_CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7;

	public const int GL_ARB_pixel_buffer_object = 1;

	public const int GL_PIXEL_PACK_BUFFER_ARB = 0x88EB;

	public const int GL_PIXEL_UNPACK_BUFFER_ARB = 0x88EC;

	public const int GL_PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;

	public const int GL_PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;

	public const int GL_ARB_polygon_offset_clamp = 1;

	public const int GL_ARB_post_depth_coverage = 1;

	public const int GL_ARB_program_interface_query = 1;

	public const int GL_ARB_provoking_vertex = 1;

	public const int GL_ARB_query_buffer_object = 1;

	public const int GL_ARB_robust_buffer_access_behavior = 1;

	public const int GL_ARB_robustness = 1;

	public const int GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004;

	public const int GL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252;

	public const int GL_GUILTY_CONTEXT_RESET_ARB = 0x8253;

	public const int GL_INNOCENT_CONTEXT_RESET_ARB = 0x8254;

	public const int GL_UNKNOWN_CONTEXT_RESET_ARB = 0x8255;

	public const int GL_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;

	public const int GL_NO_RESET_NOTIFICATION_ARB = 0x8261;

public delegate void PFNGLGETNTEXIMAGEARBPROC (int target, int level, int format, int type, uint bufSize, void *img);
public delegate void PFNGLREADNPIXELSARBPROC (int x, int y, uint width, uint height, int format, int type, uint bufSize, void *data);
public delegate void PFNGLGETNCOMPRESSEDTEXIMAGEARBPROC (int target, int lod, uint bufSize, void *img);
public delegate void PFNGLGETNUNIFORMFVARBPROC (uint program, int location, uint bufSize, float *prms);
public delegate void PFNGLGETNUNIFORMIVARBPROC (uint program, int location, uint bufSize, int *prms);
public delegate void PFNGLGETNUNIFORMUIVARBPROC (uint program, int location, uint bufSize, uint *prms);
public delegate void PFNGLGETNUNIFORMDVARBPROC (uint program, int location, uint bufSize, double *prms);
	[DllImport("glfw3.dll")]
	public static extern  int glGetGraphicsResetStatusARB ();
	[DllImport("glfw3.dll")]
	public static extern  void glGetnTexImageARB (int target, int level, int format, int type, uint bufSize, void *img);
	[DllImport("glfw3.dll")]
	public static extern  void glReadnPixelsARB (int x, int y, uint width, uint height, int format, int type, uint bufSize, void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnCompressedTexImageARB (int target, int lod, uint bufSize, void *img);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformfvARB (uint program, int location, uint bufSize, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformivARB (uint program, int location, uint bufSize, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformuivARB (uint program, int location, uint bufSize, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetnUniformdvARB (uint program, int location, uint bufSize, double *prms);
	public const int GL_ARB_robustness_isolation = 1;

	public const int GL_ARB_sample_locations = 1;

	public const int GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;

	public const int GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;

	public const int GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;

	public const int GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;

	public const int GL_SAMPLE_LOCATION_ARB = 0x8E50;

	public const int GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;

	public const int GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;

	public const int GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;

public delegate void PFNGLFRAMEBUFFERSAMPLELOCATIONSFVARBPROC (int target, uint start, uint count,  float *v);
public delegate void PFNGLNAMEDFRAMEBUFFERSAMPLELOCATIONSFVARBPROC (uint framebuffer, uint start, uint count,  float *v);
public delegate void PFNGLEVALUATEDEPTHVALUESARBPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferSampleLocationsfvARB (int target, uint start, uint count,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferSampleLocationsfvARB (uint framebuffer, uint start, uint count,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glEvaluateDepthValuesARB ();
	public const int GL_ARB_sample_shading = 1;

	public const int GL_SAMPLE_SHADING_ARB = 0x8C36;

	public const int GL_MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;

public delegate void PFNGLMINSAMPLESHADINGARBPROC (float value);
	[DllImport("glfw3.dll")]
	public static extern  void glMinSampleShadingARB (float value);
	public const int GL_ARB_sampler_objects = 1;

	public const int GL_ARB_seamless_cube_map = 1;

	public const int GL_ARB_seamless_cubemap_per_texture = 1;

	public const int GL_ARB_separate_shader_objects = 1;

	public const int GL_ARB_shader_atomic_counter_ops = 1;

	public const int GL_ARB_shader_atomic_counters = 1;

	public const int GL_ARB_shader_ballot = 1;

	public const int GL_ARB_shader_bit_encoding = 1;

	public const int GL_ARB_shader_clock = 1;

	public const int GL_ARB_shader_draw_parameters = 1;

	public const int GL_ARB_shader_group_vote = 1;

	public const int GL_ARB_shader_image_load_store = 1;

	public const int GL_ARB_shader_image_size = 1;

	public const int GL_ARB_shader_precision = 1;

	public const int GL_ARB_shader_stencil_export = 1;

	public const int GL_ARB_shader_storage_buffer_object = 1;

	public const int GL_ARB_shader_subroutine = 1;

	public const int GL_ARB_shader_texture_image_samples = 1;

	public const int GL_ARB_shader_viewport_layer_array = 1;

	public const int GL_ARB_shading_language_420pack = 1;

	public const int GL_ARB_shading_language_include = 1;

	public const int GL_SHADER_INCLUDE_ARB = 0x8DAE;

	public const int GL_NAMED_STRING_LENGTH_ARB = 0x8DE9;

	public const int GL_NAMED_STRING_TYPE_ARB = 0x8DEA;

public delegate void PFNGLNAMEDSTRINGARBPROC (int type, int namelen,  char *name, int strlen,  char *str);
public delegate void PFNGLDELETENAMEDSTRINGARBPROC (int namelen,  char *name);
public delegate void PFNGLCOMPILESHADERINCLUDEARBPROC (uint shader, uint count,  char **path,  int *length);
public delegate void PFNGLGETNAMEDSTRINGARBPROC (int namelen,  char *name, uint bufSize, int *strlen, char *str);
public delegate void PFNGLGETNAMEDSTRINGIVARBPROC (int namelen,  char *name, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedStringARB (int type, int namelen,  char *name, int strlen,  char *str);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteNamedStringARB (int namelen,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glCompileShaderIncludeARB (uint shader, uint count,  char **path,  int *length);
	[DllImport("glfw3.dll")]
	public static extern  int glIsNamedStringARB (int namelen,  char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedStringARB (int namelen,  char *name, uint bufSize, int *strlen, char *str);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedStringivARB (int namelen,  char *name, int pname, int *prms);
	public const int GL_ARB_shading_language_packing = 1;

	public const int GL_ARB_sparse_buffer = 1;

	public const int GL_SPARSE_STORAGE_BIT_ARB = 0x0400;

	public const int GL_SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;

public delegate void PFNGLBUFFERPAGECOMMITMENTARBPROC (int target, int* offset, uint* size, int commit);
public delegate void PFNGLNAMEDBUFFERPAGECOMMITMENTEXTPROC (uint buffer, int* offset, uint* size, int commit);
public delegate void PFNGLNAMEDBUFFERPAGECOMMITMENTARBPROC (uint buffer, int* offset, uint* size, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glBufferPageCommitmentARB (int target, int* offset, uint* size, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferPageCommitmentEXT (uint buffer, int* offset, uint* size, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferPageCommitmentARB (uint buffer, int* offset, uint* size, int commit);
	public const int GL_ARB_sparse_texture = 1;

	public const int GL_TEXTURE_SPARSE_ARB = 0x91A6;

	public const int GL_VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7;

	public const int GL_NUM_SPARSE_LEVELS_ARB = 0x91AA;

	public const int GL_NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8;

	public const int GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195;

	public const int GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196;

	public const int GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197;

	public const int GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198;

	public const int GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199;

	public const int GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A;

	public const int GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;

public delegate void PFNGLTEXPAGECOMMITMENTARBPROC (int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glTexPageCommitmentARB (int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int commit);
	public const int GL_ARB_sparse_texture2 = 1;

	public const int GL_ARB_sparse_texture_clamp = 1;

	public const int GL_ARB_spirv_extensions = 1;

	public const int GL_ARB_stencil_texturing = 1;

	public const int GL_ARB_sync = 1;

	public const int GL_ARB_tessellation_shader = 1;

	public const int GL_ARB_texture_barrier = 1;

	public const int GL_ARB_texture_border_clamp = 1;

	public const int GL_CLAMP_TO_BORDER_ARB = 0x812D;

	public const int GL_ARB_texture_buffer_object = 1;

	public const int GL_TEXTURE_BUFFER_ARB = 0x8C2A;

	public const int GL_MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;

	public const int GL_TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;

	public const int GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;

	public const int GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;

public delegate void PFNGLTEXBUFFERARBPROC (int target, int internalformat, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glTexBufferARB (int target, int internalformat, uint buffer);
	public const int GL_ARB_texture_buffer_object_rgb32 = 1;

	public const int GL_ARB_texture_buffer_range = 1;

	public const int GL_ARB_texture_compression_bptc = 1;

	public const int GL_COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C;

	public const int GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D;

	public const int GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E;

	public const int GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F;

	public const int GL_ARB_texture_compression_rgtc = 1;

	public const int GL_ARB_texture_cube_map_array = 1;

	public const int GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009;

	public const int GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A;

	public const int GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B;

	public const int GL_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C;

	public const int GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D;

	public const int GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E;

	public const int GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F;

	public const int GL_ARB_texture_filter_anisotropic = 1;

	public const int GL_ARB_texture_filter_minmax = 1;

	public const int GL_TEXTURE_REDUCTION_MODE_ARB = 0x9366;

	public const int GL_WEIGHTED_AVERAGE_ARB = 0x9367;

	public const int GL_ARB_texture_gather = 1;

	public const int GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5E;

	public const int GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5F;

	public const int GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB = 0x8F9F;

	public const int GL_ARB_texture_mirror_clamp_to_edge = 1;

	public const int GL_ARB_texture_mirrored_repeat = 1;

	public const int GL_MIRRORED_REPEAT_ARB = 0x8370;

	public const int GL_ARB_texture_multisample = 1;

	public const int GL_ARB_texture_non_power_of_two = 1;

	public const int GL_ARB_texture_query_levels = 1;

	public const int GL_ARB_texture_query_lod = 1;

	public const int GL_ARB_texture_rg = 1;

	public const int GL_ARB_texture_rgb10_a2ui = 1;

	public const int GL_ARB_texture_stencil8 = 1;

	public const int GL_ARB_texture_storage = 1;

	public const int GL_ARB_texture_storage_multisample = 1;

	public const int GL_ARB_texture_swizzle = 1;

	public const int GL_ARB_texture_view = 1;

	public const int GL_ARB_timer_query = 1;

	public const int GL_ARB_transform_feedback2 = 1;

	public const int GL_ARB_transform_feedback3 = 1;

	public const int GL_ARB_transform_feedback_instanced = 1;

	public const int GL_ARB_transform_feedback_overflow_query = 1;

	public const int GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB = 0x82EC;

	public const int GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB = 0x82ED;

	public const int GL_ARB_uniform_buffer_object = 1;

	public const int GL_ARB_vertex_array_bgra = 1;

	public const int GL_ARB_vertex_array_object = 1;

	public const int GL_ARB_vertex_attrib_64bit = 1;

	public const int GL_ARB_vertex_attrib_binding = 1;

	public const int GL_ARB_vertex_type_10f_11f_11f_rev = 1;

	public const int GL_ARB_vertex_type_2_10_10_10_rev = 1;

	public const int GL_ARB_viewport_array = 1;

public delegate void PFNGLDEPTHRANGEARRAYDVNVPROC (uint first, uint count,  double *v);
public delegate void PFNGLDEPTHRANGEINDEXEDDNVPROC (uint index, double n, double f);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthRangeArraydvNV (uint first, uint count,  double *v);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthRangeIndexeddNV (uint index, double n, double f);
	public const int GL_KHR_blend_equation_advanced = 1;

	public const int GL_MULTIPLY_KHR = 0x9294;

	public const int GL_SCREEN_KHR = 0x9295;

	public const int GL_OVERLAY_KHR = 0x9296;

	public const int GL_DARKEN_KHR = 0x9297;

	public const int GL_LIGHTEN_KHR = 0x9298;

	public const int GL_COLORDODGE_KHR = 0x9299;

	public const int GL_COLORBURN_KHR = 0x929A;

	public const int GL_HARDLIGHT_KHR = 0x929B;

	public const int GL_SOFTLIGHT_KHR = 0x929C;

	public const int GL_DIFFERENCE_KHR = 0x929E;

	public const int GL_EXCLUSION_KHR = 0x92A0;

	public const int GL_HSL_HUE_KHR = 0x92AD;

	public const int GL_HSL_SATURATION_KHR = 0x92AE;

	public const int GL_HSL_COLOR_KHR = 0x92AF;

	public const int GL_HSL_LUMINOSITY_KHR = 0x92B0;

public delegate void PFNGLBLENDBARRIERKHRPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glBlendBarrierKHR ();
	public const int GL_KHR_blend_equation_advanced_coherent = 1;

	public const int GL_BLEND_ADVANCED_COHERENT_KHR = 0x9285;

	public const int GL_KHR_context_flush_control = 1;

	public const int GL_KHR_debug = 1;

	public const int GL_KHR_no_error = 1;

	public const int GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008;

	public const int GL_KHR_parallel_shader_compile = 1;

	public const int GL_MAX_SHADER_COMPILER_THREADS_KHR = 0x91B0;

	public const int GL_COMPLETION_STATUS_KHR = 0x91B1;

public delegate void PFNGLMAXSHADERCOMPILERTHREADSKHRPROC (uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glMaxShaderCompilerThreadsKHR (uint count);
	public const int GL_KHR_robust_buffer_access_behavior = 1;

	public const int GL_KHR_robustness = 1;

	public const int GL_CONTEXT_ROBUST_ACCESS = 0x90F3;

	public const int GL_KHR_shader_subgroup = 1;

	public const int GL_SUBGROUP_SIZE_KHR = 0x9532;

	public const int GL_SUBGROUP_SUPPORTED_STAGES_KHR = 0x9533;

	public const int GL_SUBGROUP_SUPPORTED_FEATURES_KHR = 0x9534;

	public const int GL_SUBGROUP_QUAD_ALL_STAGES_KHR = 0x9535;

	public const int GL_SUBGROUP_FEATURE_BASIC_BIT_KHR = 0x00000001;

	public const int GL_SUBGROUP_FEATURE_VOTE_BIT_KHR = 0x00000002;

	public const int GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR = 0x00000004;

	public const int GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR = 0x00000008;

	public const int GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR = 0x00000010;

	public const int GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR = 0x00000020;

	public const int GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR = 0x00000040;

	public const int GL_SUBGROUP_FEATURE_QUAD_BIT_KHR = 0x00000080;

	public const int GL_KHR_texture_compression_astc_hdr = 1;

	public const int GL_COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0;

	public const int GL_COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1;

	public const int GL_COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2;

	public const int GL_COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3;

	public const int GL_COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4;

	public const int GL_COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5;

	public const int GL_COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6;

	public const int GL_COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7;

	public const int GL_COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8;

	public const int GL_COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9;

	public const int GL_COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA;

	public const int GL_COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB;

	public const int GL_COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC;

	public const int GL_COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC;

	public const int GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD;

	public const int GL_KHR_texture_compression_astc_ldr = 1;

	public const int GL_KHR_texture_compression_astc_sliced_3d = 1;

	public const int GL_AMD_framebuffer_multisample_advanced = 1;

	public const int GL_RENDERBUFFER_STORAGE_SAMPLES_AMD = 0x91B2;

	public const int GL_MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD = 0x91B3;

	public const int GL_MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD = 0x91B4;

	public const int GL_MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD = 0x91B5;

	public const int GL_NUM_SUPPORTED_MULTISAMPLE_MODES_AMD = 0x91B6;

	public const int GL_SUPPORTED_MULTISAMPLE_MODES_AMD = 0x91B7;

public delegate void PFNGLRENDERBUFFERSTORAGEMULTISAMPLEADVANCEDAMDPROC (int target, uint samples, uint storageSamples, int internalformat, uint width, uint height);
public delegate void PFNGLNAMEDRENDERBUFFERSTORAGEMULTISAMPLEADVANCEDAMDPROC (uint renderbuffer, uint samples, uint storageSamples, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glRenderbufferStorageMultisampleAdvancedAMD (int target, uint samples, uint storageSamples, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedRenderbufferStorageMultisampleAdvancedAMD (uint renderbuffer, uint samples, uint storageSamples, int internalformat, uint width, uint height);
	public const int GL_AMD_performance_monitor = 1;

	public const int GL_COUNTER_TYPE_AMD = 0x8BC0;

	public const int GL_COUNTER_RANGE_AMD = 0x8BC1;

	public const int GL_UNSIGNED_INT64_AMD = 0x8BC2;

	public const int GL_PERCENTAGE_AMD = 0x8BC3;

	public const int GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;

	public const int GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5;

	public const int GL_PERFMON_RESULT_AMD = 0x8BC6;

public delegate void PFNGLGETPERFMONITORGROUPSAMDPROC (int *numGroups, uint groupsSize, uint *groups);
public delegate void PFNGLGETPERFMONITORCOUNTERSAMDPROC (uint group, int *numCounters, int *maxActiveCounters, uint counterSize, uint *counters);
public delegate void PFNGLGETPERFMONITORGROUPSTRINGAMDPROC (uint group, uint bufSize, uint *length, char *groupString);
public delegate void PFNGLGETPERFMONITORCOUNTERSTRINGAMDPROC (uint group, uint counter, uint bufSize, uint *length, char *counterString);
public delegate void PFNGLGETPERFMONITORCOUNTERINFOAMDPROC (uint group, uint counter, int pname, void *data);
public delegate void PFNGLGENPERFMONITORSAMDPROC (uint n, uint *monitors);
public delegate void PFNGLDELETEPERFMONITORSAMDPROC (uint n, uint *monitors);
public delegate void PFNGLSELECTPERFMONITORCOUNTERSAMDPROC (uint monitor, int enable, uint group, int numCounters, uint *counterList);
public delegate void PFNGLBEGINPERFMONITORAMDPROC (uint monitor);
public delegate void PFNGLENDPERFMONITORAMDPROC (uint monitor);
public delegate void PFNGLGETPERFMONITORCOUNTERDATAAMDPROC (uint monitor, int pname, uint dataSize, uint *data, int *bytesWritten);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfMonitorGroupsAMD (int *numGroups, uint groupsSize, uint *groups);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfMonitorCountersAMD (uint group, int *numCounters, int *maxActiveCounters, uint counterSize, uint *counters);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfMonitorGroupStringAMD (uint group, uint bufSize, uint *length, char *groupString);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfMonitorCounterStringAMD (uint group, uint counter, uint bufSize, uint *length, char *counterString);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfMonitorCounterInfoAMD (uint group, uint counter, int pname, void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGenPerfMonitorsAMD (uint n, uint *monitors);
	[DllImport("glfw3.dll")]
	public static extern  void glDeletePerfMonitorsAMD (uint n, uint *monitors);
	[DllImport("glfw3.dll")]
	public static extern  void glSelectPerfMonitorCountersAMD (uint monitor, int enable, uint group, int numCounters, uint *counterList);
	[DllImport("glfw3.dll")]
	public static extern  void glBeginPerfMonitorAMD (uint monitor);
	[DllImport("glfw3.dll")]
	public static extern  void glEndPerfMonitorAMD (uint monitor);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfMonitorCounterDataAMD (uint monitor, int pname, uint dataSize, uint *data, int *bytesWritten);
	public const int GL_APPLE_rgb_422 = 1;

	public const int GL_RGB_422_APPLE = 0x8A1F;

	public const int GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA;

	public const int GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;

	public const int GL_RGB_RAW_422_APPLE = 0x8A51;

	public const int GL_EXT_EGL_image_storage = 1;

public delegate void PFNGLEGLIMAGETARGETTEXSTORAGEEXTPROC (int target, GLeglImageOES image,  int* attrib_list);
public delegate void PFNGLEGLIMAGETARGETTEXTURESTORAGEEXTPROC (uint texture, GLeglImageOES image,  int* attrib_list);
	[DllImport("glfw3.dll")]
	public static extern  void glEGLImageTargetTexStorageEXT (int target, GLeglImageOES image,  int* attrib_list);
	[DllImport("glfw3.dll")]
	public static extern  void glEGLImageTargetTextureStorageEXT (uint texture, GLeglImageOES image,  int* attrib_list);
	public const int GL_EXT_EGL_sync = 1;

	public const int GL_EXT_debug_label = 1;

	public const int GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;

	public const int GL_PROGRAM_OBJECT_EXT = 0x8B40;

	public const int GL_SHADER_OBJECT_EXT = 0x8B48;

	public const int GL_BUFFER_OBJECT_EXT = 0x9151;

	public const int GL_QUERY_OBJECT_EXT = 0x9153;

	public const int GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154;

public delegate void PFNGLLABELOBJECTEXTPROC (int type, uint obj, uint length,  char *label);
public delegate void PFNGLGETOBJECTLABELEXTPROC (int type, uint obj, uint bufSize, uint *length, char *label);
	[DllImport("glfw3.dll")]
	public static extern  void glLabelObjectEXT (int type, uint obj, uint length,  char *label);
	[DllImport("glfw3.dll")]
	public static extern  void glGetObjectLabelEXT (int type, uint obj, uint bufSize, uint *length, char *label);
	public const int GL_EXT_debug_marker = 1;

public delegate void PFNGLINSERTEVENTMARKEREXTPROC (uint length,  char *marker);
public delegate void PFNGLPUSHGROUPMARKEREXTPROC (uint length,  char *marker);
public delegate void PFNGLPOPGROUPMARKEREXTPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glInsertEventMarkerEXT (uint length,  char *marker);
	[DllImport("glfw3.dll")]
	public static extern  void glPushGroupMarkerEXT (uint length,  char *marker);
	[DllImport("glfw3.dll")]
	public static extern  void glPopGroupMarkerEXT ();
	public const int GL_EXT_direct_state_access = 1;

	public const int GL_PROGRAM_MATRIX_EXT = 0x8E2D;

	public const int GL_TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;

	public const int GL_PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;

public delegate void PFNGLMATRIXLOADFEXTPROC (int mode,  float *m);
public delegate void PFNGLMATRIXLOADDEXTPROC (int mode,  double *m);
public delegate void PFNGLMATRIXMULTFEXTPROC (int mode,  float *m);
public delegate void PFNGLMATRIXMULTDEXTPROC (int mode,  double *m);
public delegate void PFNGLMATRIXLOADIDENTITYEXTPROC (int mode);
public delegate void PFNGLMATRIXROTATEFEXTPROC (int mode, float angle, float x, float y, float z);
public delegate void PFNGLMATRIXROTATEDEXTPROC (int mode, double angle, double x, double y, double z);
public delegate void PFNGLMATRIXSCALEFEXTPROC (int mode, float x, float y, float z);
public delegate void PFNGLMATRIXSCALEDEXTPROC (int mode, double x, double y, double z);
public delegate void PFNGLMATRIXTRANSLATEFEXTPROC (int mode, float x, float y, float z);
public delegate void PFNGLMATRIXTRANSLATEDEXTPROC (int mode, double x, double y, double z);
public delegate void PFNGLMATRIXFRUSTUMEXTPROC (int mode, double left, double right, double bottom, double top, double zNear, double zFar);
public delegate void PFNGLMATRIXORTHOEXTPROC (int mode, double left, double right, double bottom, double top, double zNear, double zFar);
public delegate void PFNGLMATRIXPOPEXTPROC (int mode);
public delegate void PFNGLMATRIXPUSHEXTPROC (int mode);
public delegate void PFNGLCLIENTATTRIBDEFAULTEXTPROC (int mask);
public delegate void PFNGLPUSHCLIENTATTRIBDEFAULTEXTPROC (int mask);
public delegate void PFNGLTEXTUREPARAMETERFEXTPROC (uint texture, int target, int pname, float param);
public delegate void PFNGLTEXTUREPARAMETERFVEXTPROC (uint texture, int target, int pname,  float *prms);
public delegate void PFNGLTEXTUREPARAMETERIEXTPROC (uint texture, int target, int pname, int param);
public delegate void PFNGLTEXTUREPARAMETERIVEXTPROC (uint texture, int target, int pname,  int *prms);
public delegate void PFNGLTEXTUREIMAGE1DEXTPROC (uint texture, int target, int level, int internalformat, uint width, int border, int format, int type,  void *pixels);
public delegate void PFNGLTEXTUREIMAGE2DEXTPROC (uint texture, int target, int level, int internalformat, uint width, uint height, int border, int format, int type,  void *pixels);
public delegate void PFNGLTEXTURESUBIMAGE1DEXTPROC (uint texture, int target, int level, int xoffset, uint width, int format, int type,  void *pixels);
public delegate void PFNGLTEXTURESUBIMAGE2DEXTPROC (uint texture, int target, int level, int xoffset, int yoffset, uint width, uint height, int format, int type,  void *pixels);
public delegate void PFNGLCOPYTEXTUREIMAGE1DEXTPROC (uint texture, int target, int level, int internalformat, int x, int y, uint width, int border);
public delegate void PFNGLCOPYTEXTUREIMAGE2DEXTPROC (uint texture, int target, int level, int internalformat, int x, int y, uint width, uint height, int border);
public delegate void PFNGLCOPYTEXTURESUBIMAGE1DEXTPROC (uint texture, int target, int level, int xoffset, int x, int y, uint width);
public delegate void PFNGLCOPYTEXTURESUBIMAGE2DEXTPROC (uint texture, int target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
public delegate void PFNGLGETTEXTUREIMAGEEXTPROC (uint texture, int target, int level, int format, int type, void *pixels);
public delegate void PFNGLGETTEXTUREPARAMETERFVEXTPROC (uint texture, int target, int pname, float *prms);
public delegate void PFNGLGETTEXTUREPARAMETERIVEXTPROC (uint texture, int target, int pname, int *prms);
public delegate void PFNGLGETTEXTURELEVELPARAMETERFVEXTPROC (uint texture, int target, int level, int pname, float *prms);
public delegate void PFNGLGETTEXTURELEVELPARAMETERIVEXTPROC (uint texture, int target, int level, int pname, int *prms);
public delegate void PFNGLTEXTUREIMAGE3DEXTPROC (uint texture, int target, int level, int internalformat, uint width, uint height, uint depth, int border, int format, int type,  void *pixels);
public delegate void PFNGLTEXTURESUBIMAGE3DEXTPROC (uint texture, int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *pixels);
public delegate void PFNGLCOPYTEXTURESUBIMAGE3DEXTPROC (uint texture, int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
public delegate void PFNGLBINDMULTITEXTUREEXTPROC (int texunit, int target, uint texture);
public delegate void PFNGLMULTITEXCOORDPOINTEREXTPROC (int texunit, int size, int type, uint stride,  void *pointer);
public delegate void PFNGLMULTITEXENVFEXTPROC (int texunit, int target, int pname, float param);
public delegate void PFNGLMULTITEXENVFVEXTPROC (int texunit, int target, int pname,  float *prms);
public delegate void PFNGLMULTITEXENVIEXTPROC (int texunit, int target, int pname, int param);
public delegate void PFNGLMULTITEXENVIVEXTPROC (int texunit, int target, int pname,  int *prms);
public delegate void PFNGLMULTITEXGENDEXTPROC (int texunit, int coord, int pname, double param);
public delegate void PFNGLMULTITEXGENDVEXTPROC (int texunit, int coord, int pname,  double *prms);
public delegate void PFNGLMULTITEXGENFEXTPROC (int texunit, int coord, int pname, float param);
public delegate void PFNGLMULTITEXGENFVEXTPROC (int texunit, int coord, int pname,  float *prms);
public delegate void PFNGLMULTITEXGENIEXTPROC (int texunit, int coord, int pname, int param);
public delegate void PFNGLMULTITEXGENIVEXTPROC (int texunit, int coord, int pname,  int *prms);
public delegate void PFNGLGETMULTITEXENVFVEXTPROC (int texunit, int target, int pname, float *prms);
public delegate void PFNGLGETMULTITEXENVIVEXTPROC (int texunit, int target, int pname, int *prms);
public delegate void PFNGLGETMULTITEXGENDVEXTPROC (int texunit, int coord, int pname, double *prms);
public delegate void PFNGLGETMULTITEXGENFVEXTPROC (int texunit, int coord, int pname, float *prms);
public delegate void PFNGLGETMULTITEXGENIVEXTPROC (int texunit, int coord, int pname, int *prms);
public delegate void PFNGLMULTITEXPARAMETERIEXTPROC (int texunit, int target, int pname, int param);
public delegate void PFNGLMULTITEXPARAMETERIVEXTPROC (int texunit, int target, int pname,  int *prms);
public delegate void PFNGLMULTITEXPARAMETERFEXTPROC (int texunit, int target, int pname, float param);
public delegate void PFNGLMULTITEXPARAMETERFVEXTPROC (int texunit, int target, int pname,  float *prms);
public delegate void PFNGLMULTITEXIMAGE1DEXTPROC (int texunit, int target, int level, int internalformat, uint width, int border, int format, int type,  void *pixels);
public delegate void PFNGLMULTITEXIMAGE2DEXTPROC (int texunit, int target, int level, int internalformat, uint width, uint height, int border, int format, int type,  void *pixels);
public delegate void PFNGLMULTITEXSUBIMAGE1DEXTPROC (int texunit, int target, int level, int xoffset, uint width, int format, int type,  void *pixels);
public delegate void PFNGLMULTITEXSUBIMAGE2DEXTPROC (int texunit, int target, int level, int xoffset, int yoffset, uint width, uint height, int format, int type,  void *pixels);
public delegate void PFNGLCOPYMULTITEXIMAGE1DEXTPROC (int texunit, int target, int level, int internalformat, int x, int y, uint width, int border);
public delegate void PFNGLCOPYMULTITEXIMAGE2DEXTPROC (int texunit, int target, int level, int internalformat, int x, int y, uint width, uint height, int border);
public delegate void PFNGLCOPYMULTITEXSUBIMAGE1DEXTPROC (int texunit, int target, int level, int xoffset, int x, int y, uint width);
public delegate void PFNGLCOPYMULTITEXSUBIMAGE2DEXTPROC (int texunit, int target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
public delegate void PFNGLGETMULTITEXIMAGEEXTPROC (int texunit, int target, int level, int format, int type, void *pixels);
public delegate void PFNGLGETMULTITEXPARAMETERFVEXTPROC (int texunit, int target, int pname, float *prms);
public delegate void PFNGLGETMULTITEXPARAMETERIVEXTPROC (int texunit, int target, int pname, int *prms);
public delegate void PFNGLGETMULTITEXLEVELPARAMETERFVEXTPROC (int texunit, int target, int level, int pname, float *prms);
public delegate void PFNGLGETMULTITEXLEVELPARAMETERIVEXTPROC (int texunit, int target, int level, int pname, int *prms);
public delegate void PFNGLMULTITEXIMAGE3DEXTPROC (int texunit, int target, int level, int internalformat, uint width, uint height, uint depth, int border, int format, int type,  void *pixels);
public delegate void PFNGLMULTITEXSUBIMAGE3DEXTPROC (int texunit, int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *pixels);
public delegate void PFNGLCOPYMULTITEXSUBIMAGE3DEXTPROC (int texunit, int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
public delegate void PFNGLENABLECLIENTSTATEINDEXEDEXTPROC (int array, uint index);
public delegate void PFNGLDISABLECLIENTSTATEINDEXEDEXTPROC (int array, uint index);
public delegate void PFNGLGETFLOATINDEXEDVEXTPROC (int target, uint index, float *data);
public delegate void PFNGLGETDOUBLEINDEXEDVEXTPROC (int target, uint index, double *data);
public delegate void PFNGLGETPOINTERINDEXEDVEXTPROC (int target, uint index, void **data);
public delegate void PFNGLENABLEINDEXEDEXTPROC (int target, uint index);
public delegate void PFNGLDISABLEINDEXEDEXTPROC (int target, uint index);
public delegate void PFNGLGETINTEGERINDEXEDVEXTPROC (int target, uint index, int *data);
public delegate void PFNGLGETBOOLEANINDEXEDVEXTPROC (int target, uint index, int *data);
public delegate void PFNGLCOMPRESSEDTEXTUREIMAGE3DEXTPROC (uint texture, int target, int level, int internalformat, uint width, uint height, uint depth, int border, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDTEXTUREIMAGE2DEXTPROC (uint texture, int target, int level, int internalformat, uint width, uint height, int border, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDTEXTUREIMAGE1DEXTPROC (uint texture, int target, int level, int internalformat, uint width, int border, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDTEXTURESUBIMAGE3DEXTPROC (uint texture, int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDTEXTURESUBIMAGE2DEXTPROC (uint texture, int target, int level, int xoffset, int yoffset, uint width, uint height, int format, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDTEXTURESUBIMAGE1DEXTPROC (uint texture, int target, int level, int xoffset, uint width, int format, uint imageSize,  void *bits);
public delegate void PFNGLGETCOMPRESSEDTEXTUREIMAGEEXTPROC (uint texture, int target, int lod, void *img);
public delegate void PFNGLCOMPRESSEDMULTITEXIMAGE3DEXTPROC (int texunit, int target, int level, int internalformat, uint width, uint height, uint depth, int border, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDMULTITEXIMAGE2DEXTPROC (int texunit, int target, int level, int internalformat, uint width, uint height, int border, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDMULTITEXIMAGE1DEXTPROC (int texunit, int target, int level, int internalformat, uint width, int border, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDMULTITEXSUBIMAGE3DEXTPROC (int texunit, int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDMULTITEXSUBIMAGE2DEXTPROC (int texunit, int target, int level, int xoffset, int yoffset, uint width, uint height, int format, uint imageSize,  void *bits);
public delegate void PFNGLCOMPRESSEDMULTITEXSUBIMAGE1DEXTPROC (int texunit, int target, int level, int xoffset, uint width, int format, uint imageSize,  void *bits);
public delegate void PFNGLGETCOMPRESSEDMULTITEXIMAGEEXTPROC (int texunit, int target, int lod, void *img);
public delegate void PFNGLMATRIXLOADTRANSPOSEFEXTPROC (int mode,  float *m);
public delegate void PFNGLMATRIXLOADTRANSPOSEDEXTPROC (int mode,  double *m);
public delegate void PFNGLMATRIXMULTTRANSPOSEFEXTPROC (int mode,  float *m);
public delegate void PFNGLMATRIXMULTTRANSPOSEDEXTPROC (int mode,  double *m);
public delegate void PFNGLNAMEDBUFFERDATAEXTPROC (uint buffer, uint* size,  void *data, int usage);
public delegate void PFNGLNAMEDBUFFERSUBDATAEXTPROC (uint buffer, int* offset, uint* size,  void *data);
public delegate void PFNGLGETNAMEDBUFFERPARAMETERIVEXTPROC (uint buffer, int pname, int *prms);
public delegate void PFNGLGETNAMEDBUFFERPOINTERVEXTPROC (uint buffer, int pname, void **prms);
public delegate void PFNGLGETNAMEDBUFFERSUBDATAEXTPROC (uint buffer, int* offset, uint* size, void *data);
public delegate void PFNGLPROGRAMUNIFORM1FEXTPROC (uint program, int location, float v0);
public delegate void PFNGLPROGRAMUNIFORM2FEXTPROC (uint program, int location, float v0, float v1);
public delegate void PFNGLPROGRAMUNIFORM3FEXTPROC (uint program, int location, float v0, float v1, float v2);
public delegate void PFNGLPROGRAMUNIFORM4FEXTPROC (uint program, int location, float v0, float v1, float v2, float v3);
public delegate void PFNGLPROGRAMUNIFORM1IEXTPROC (uint program, int location, int v0);
public delegate void PFNGLPROGRAMUNIFORM2IEXTPROC (uint program, int location, int v0, int v1);
public delegate void PFNGLPROGRAMUNIFORM3IEXTPROC (uint program, int location, int v0, int v1, int v2);
public delegate void PFNGLPROGRAMUNIFORM4IEXTPROC (uint program, int location, int v0, int v1, int v2, int v3);
public delegate void PFNGLPROGRAMUNIFORM1FVEXTPROC (uint program, int location, uint count,  float *value);
public delegate void PFNGLPROGRAMUNIFORM2FVEXTPROC (uint program, int location, uint count,  float *value);
public delegate void PFNGLPROGRAMUNIFORM3FVEXTPROC (uint program, int location, uint count,  float *value);
public delegate void PFNGLPROGRAMUNIFORM4FVEXTPROC (uint program, int location, uint count,  float *value);
public delegate void PFNGLPROGRAMUNIFORM1IVEXTPROC (uint program, int location, uint count,  int *value);
public delegate void PFNGLPROGRAMUNIFORM2IVEXTPROC (uint program, int location, uint count,  int *value);
public delegate void PFNGLPROGRAMUNIFORM3IVEXTPROC (uint program, int location, uint count,  int *value);
public delegate void PFNGLPROGRAMUNIFORM4IVEXTPROC (uint program, int location, uint count,  int *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2X3FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3X2FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2X4FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4X2FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3X4FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4X3FVEXTPROC (uint program, int location, uint count, int transpose,  float *value);
public delegate void PFNGLTEXTUREBUFFEREXTPROC (uint texture, int target, int internalformat, uint buffer);
public delegate void PFNGLMULTITEXBUFFEREXTPROC (int texunit, int target, int internalformat, uint buffer);
public delegate void PFNGLTEXTUREPARAMETERIIVEXTPROC (uint texture, int target, int pname,  int *prms);
public delegate void PFNGLTEXTUREPARAMETERIUIVEXTPROC (uint texture, int target, int pname,  uint *prms);
public delegate void PFNGLGETTEXTUREPARAMETERIIVEXTPROC (uint texture, int target, int pname, int *prms);
public delegate void PFNGLGETTEXTUREPARAMETERIUIVEXTPROC (uint texture, int target, int pname, uint *prms);
public delegate void PFNGLMULTITEXPARAMETERIIVEXTPROC (int texunit, int target, int pname,  int *prms);
public delegate void PFNGLMULTITEXPARAMETERIUIVEXTPROC (int texunit, int target, int pname,  uint *prms);
public delegate void PFNGLGETMULTITEXPARAMETERIIVEXTPROC (int texunit, int target, int pname, int *prms);
public delegate void PFNGLGETMULTITEXPARAMETERIUIVEXTPROC (int texunit, int target, int pname, uint *prms);
public delegate void PFNGLPROGRAMUNIFORM1UIEXTPROC (uint program, int location, uint v0);
public delegate void PFNGLPROGRAMUNIFORM2UIEXTPROC (uint program, int location, uint v0, uint v1);
public delegate void PFNGLPROGRAMUNIFORM3UIEXTPROC (uint program, int location, uint v0, uint v1, uint v2);
public delegate void PFNGLPROGRAMUNIFORM4UIEXTPROC (uint program, int location, uint v0, uint v1, uint v2, uint v3);
public delegate void PFNGLPROGRAMUNIFORM1UIVEXTPROC (uint program, int location, uint count,  uint *value);
public delegate void PFNGLPROGRAMUNIFORM2UIVEXTPROC (uint program, int location, uint count,  uint *value);
public delegate void PFNGLPROGRAMUNIFORM3UIVEXTPROC (uint program, int location, uint count,  uint *value);
public delegate void PFNGLPROGRAMUNIFORM4UIVEXTPROC (uint program, int location, uint count,  uint *value);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETERS4FVEXTPROC (uint program, int target, uint index, uint count,  float *prms);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETERI4IEXTPROC (uint program, int target, uint index, int x, int y, int z, int w);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETERI4IVEXTPROC (uint program, int target, uint index,  int *prms);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETERSI4IVEXTPROC (uint program, int target, uint index, uint count,  int *prms);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETERI4UIEXTPROC (uint program, int target, uint index, uint x, uint y, uint z, uint w);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETERI4UIVEXTPROC (uint program, int target, uint index,  uint *prms);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETERSI4UIVEXTPROC (uint program, int target, uint index, uint count,  uint *prms);
public delegate void PFNGLGETNAMEDPROGRAMLOCALPARAMETERIIVEXTPROC (uint program, int target, uint index, int *prms);
public delegate void PFNGLGETNAMEDPROGRAMLOCALPARAMETERIUIVEXTPROC (uint program, int target, uint index, uint *prms);
public delegate void PFNGLENABLECLIENTSTATEIEXTPROC (int array, uint index);
public delegate void PFNGLDISABLECLIENTSTATEIEXTPROC (int array, uint index);
public delegate void PFNGLGETFLOATI_VEXTPROC (int pname, uint index, float *prms);
public delegate void PFNGLGETDOUBLEI_VEXTPROC (int pname, uint index, double *prms);
public delegate void PFNGLGETPOINTERI_VEXTPROC (int pname, uint index, void **prms);
public delegate void PFNGLNAMEDPROGRAMSTRINGEXTPROC (uint program, int target, int format, uint len,  void *str);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETER4DEXTPROC (uint program, int target, uint index, double x, double y, double z, double w);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETER4DVEXTPROC (uint program, int target, uint index,  double *prms);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETER4FEXTPROC (uint program, int target, uint index, float x, float y, float z, float w);
public delegate void PFNGLNAMEDPROGRAMLOCALPARAMETER4FVEXTPROC (uint program, int target, uint index,  float *prms);
public delegate void PFNGLGETNAMEDPROGRAMLOCALPARAMETERDVEXTPROC (uint program, int target, uint index, double *prms);
public delegate void PFNGLGETNAMEDPROGRAMLOCALPARAMETERFVEXTPROC (uint program, int target, uint index, float *prms);
public delegate void PFNGLGETNAMEDPROGRAMIVEXTPROC (uint program, int target, int pname, int *prms);
public delegate void PFNGLGETNAMEDPROGRAMSTRINGEXTPROC (uint program, int target, int pname, void *str);
public delegate void PFNGLNAMEDRENDERBUFFERSTORAGEEXTPROC (uint renderbuffer, int internalformat, uint width, uint height);
public delegate void PFNGLGETNAMEDRENDERBUFFERPARAMETERIVEXTPROC (uint renderbuffer, int pname, int *prms);
public delegate void PFNGLNAMEDRENDERBUFFERSTORAGEMULTISAMPLEEXTPROC (uint renderbuffer, uint samples, int internalformat, uint width, uint height);
public delegate void PFNGLNAMEDRENDERBUFFERSTORAGEMULTISAMPLECOVERAGEEXTPROC (uint renderbuffer, uint coverageSamples, uint colorSamples, int internalformat, uint width, uint height);
public delegate void PFNGLNAMEDFRAMEBUFFERTEXTURE1DEXTPROC (uint framebuffer, int attachment, int textarget, uint texture, int level);
public delegate void PFNGLNAMEDFRAMEBUFFERTEXTURE2DEXTPROC (uint framebuffer, int attachment, int textarget, uint texture, int level);
public delegate void PFNGLNAMEDFRAMEBUFFERTEXTURE3DEXTPROC (uint framebuffer, int attachment, int textarget, uint texture, int level, int zoffset);
public delegate void PFNGLNAMEDFRAMEBUFFERRENDERBUFFEREXTPROC (uint framebuffer, int attachment, int renderbuffertarget, uint renderbuffer);
public delegate void PFNGLGETNAMEDFRAMEBUFFERATTACHMENTPARAMETERIVEXTPROC (uint framebuffer, int attachment, int pname, int *prms);
public delegate void PFNGLGENERATETEXTUREMIPMAPEXTPROC (uint texture, int target);
public delegate void PFNGLGENERATEMULTITEXMIPMAPEXTPROC (int texunit, int target);
public delegate void PFNGLFRAMEBUFFERDRAWBUFFEREXTPROC (uint framebuffer, int mode);
public delegate void PFNGLFRAMEBUFFERDRAWBUFFERSEXTPROC (uint framebuffer, uint n,  int *bufs);
public delegate void PFNGLFRAMEBUFFERREADBUFFEREXTPROC (uint framebuffer, int mode);
public delegate void PFNGLGETFRAMEBUFFERPARAMETERIVEXTPROC (uint framebuffer, int pname, int *prms);
public delegate void PFNGLNAMEDCOPYBUFFERSUBDATAEXTPROC (uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, uint* size);
public delegate void PFNGLNAMEDFRAMEBUFFERTEXTUREEXTPROC (uint framebuffer, int attachment, uint texture, int level);
public delegate void PFNGLNAMEDFRAMEBUFFERTEXTURELAYEREXTPROC (uint framebuffer, int attachment, uint texture, int level, int layer);
public delegate void PFNGLNAMEDFRAMEBUFFERTEXTUREFACEEXTPROC (uint framebuffer, int attachment, uint texture, int level, int face);
public delegate void PFNGLTEXTURERENDERBUFFEREXTPROC (uint texture, int target, uint renderbuffer);
public delegate void PFNGLMULTITEXRENDERBUFFEREXTPROC (int texunit, int target, uint renderbuffer);
public delegate void PFNGLVERTEXARRAYVERTEXOFFSETEXTPROC (uint vaobj, uint buffer, int size, int type, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYCOLOROFFSETEXTPROC (uint vaobj, uint buffer, int size, int type, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYEDGEFLAGOFFSETEXTPROC (uint vaobj, uint buffer, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYINDEXOFFSETEXTPROC (uint vaobj, uint buffer, int type, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYNORMALOFFSETEXTPROC (uint vaobj, uint buffer, int type, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYTEXCOORDOFFSETEXTPROC (uint vaobj, uint buffer, int size, int type, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYMULTITEXCOORDOFFSETEXTPROC (uint vaobj, uint buffer, int texunit, int size, int type, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYFOGCOORDOFFSETEXTPROC (uint vaobj, uint buffer, int type, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYSECONDARYCOLOROFFSETEXTPROC (uint vaobj, uint buffer, int size, int type, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYVERTEXATTRIBOFFSETEXTPROC (uint vaobj, uint buffer, uint index, int size, int type, int normalized, uint stride, int* offset);
public delegate void PFNGLVERTEXARRAYVERTEXATTRIBIOFFSETEXTPROC (uint vaobj, uint buffer, uint index, int size, int type, uint stride, int* offset);
public delegate void PFNGLENABLEVERTEXARRAYEXTPROC (uint vaobj, int array);
public delegate void PFNGLDISABLEVERTEXARRAYEXTPROC (uint vaobj, int array);
public delegate void PFNGLENABLEVERTEXARRAYATTRIBEXTPROC (uint vaobj, uint index);
public delegate void PFNGLDISABLEVERTEXARRAYATTRIBEXTPROC (uint vaobj, uint index);
public delegate void PFNGLGETVERTEXARRAYINTEGERVEXTPROC (uint vaobj, int pname, int *param);
public delegate void PFNGLGETVERTEXARRAYPOINTERVEXTPROC (uint vaobj, int pname, void **param);
public delegate void PFNGLGETVERTEXARRAYINTEGERI_VEXTPROC (uint vaobj, uint index, int pname, int *param);
public delegate void PFNGLGETVERTEXARRAYPOINTERI_VEXTPROC (uint vaobj, uint index, int pname, void **param);
public delegate void PFNGLFLUSHMAPPEDNAMEDBUFFERRANGEEXTPROC (uint buffer, int* offset, uint* length);
public delegate void PFNGLNAMEDBUFFERSTORAGEEXTPROC (uint buffer, uint* size,  void *data, int flags);
public delegate void PFNGLCLEARNAMEDBUFFERDATAEXTPROC (uint buffer, int internalformat, int format, int type,  void *data);
public delegate void PFNGLCLEARNAMEDBUFFERSUBDATAEXTPROC (uint buffer, int internalformat, uint* offset, uint* size, int format, int type,  void *data);
public delegate void PFNGLNAMEDFRAMEBUFFERPARAMETERIEXTPROC (uint framebuffer, int pname, int param);
public delegate void PFNGLGETNAMEDFRAMEBUFFERPARAMETERIVEXTPROC (uint framebuffer, int pname, int *prms);
public delegate void PFNGLPROGRAMUNIFORM1DEXTPROC (uint program, int location, double x);
public delegate void PFNGLPROGRAMUNIFORM2DEXTPROC (uint program, int location, double x, double y);
public delegate void PFNGLPROGRAMUNIFORM3DEXTPROC (uint program, int location, double x, double y, double z);
public delegate void PFNGLPROGRAMUNIFORM4DEXTPROC (uint program, int location, double x, double y, double z, double w);
public delegate void PFNGLPROGRAMUNIFORM1DVEXTPROC (uint program, int location, uint count,  double *value);
public delegate void PFNGLPROGRAMUNIFORM2DVEXTPROC (uint program, int location, uint count,  double *value);
public delegate void PFNGLPROGRAMUNIFORM3DVEXTPROC (uint program, int location, uint count,  double *value);
public delegate void PFNGLPROGRAMUNIFORM4DVEXTPROC (uint program, int location, uint count,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2X3DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX2X4DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3X2DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX3X4DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4X2DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLPROGRAMUNIFORMMATRIX4X3DVEXTPROC (uint program, int location, uint count, int transpose,  double *value);
public delegate void PFNGLTEXTUREBUFFERRANGEEXTPROC (uint texture, int target, int internalformat, uint buffer, int* offset, uint* size);
public delegate void PFNGLTEXTURESTORAGE1DEXTPROC (uint texture, int target, uint levels, int internalformat, uint width);
public delegate void PFNGLTEXTURESTORAGE2DEXTPROC (uint texture, int target, uint levels, int internalformat, uint width, uint height);
public delegate void PFNGLTEXTURESTORAGE3DEXTPROC (uint texture, int target, uint levels, int internalformat, uint width, uint height, uint depth);
public delegate void PFNGLTEXTURESTORAGE2DMULTISAMPLEEXTPROC (uint texture, int target, uint samples, int internalformat, uint width, uint height, int fixedsamplelocations);
public delegate void PFNGLTEXTURESTORAGE3DMULTISAMPLEEXTPROC (uint texture, int target, uint samples, int internalformat, uint width, uint height, uint depth, int fixedsamplelocations);
public delegate void PFNGLVERTEXARRAYBINDVERTEXBUFFEREXTPROC (uint vaobj, uint bindingindex, uint buffer, int* offset, uint stride);
public delegate void PFNGLVERTEXARRAYVERTEXATTRIBFORMATEXTPROC (uint vaobj, uint attribindex, int size, int type, int normalized, uint relativeoffset);
public delegate void PFNGLVERTEXARRAYVERTEXATTRIBIFORMATEXTPROC (uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
public delegate void PFNGLVERTEXARRAYVERTEXATTRIBLFORMATEXTPROC (uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
public delegate void PFNGLVERTEXARRAYVERTEXATTRIBBINDINGEXTPROC (uint vaobj, uint attribindex, uint bindingindex);
public delegate void PFNGLVERTEXARRAYVERTEXBINDINGDIVISOREXTPROC (uint vaobj, uint bindingindex, uint divisor);
public delegate void PFNGLVERTEXARRAYVERTEXATTRIBLOFFSETEXTPROC (uint vaobj, uint buffer, uint index, int size, int type, uint stride, int* offset);
public delegate void PFNGLTEXTUREPAGECOMMITMENTEXTPROC (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int commit);
public delegate void PFNGLVERTEXARRAYVERTEXATTRIBDIVISOREXTPROC (uint vaobj, uint index, uint divisor);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixLoadfEXT (int mode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixLoaddEXT (int mode,  double *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixMultfEXT (int mode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixMultdEXT (int mode,  double *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixLoadIdentityEXT (int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixRotatefEXT (int mode, float angle, float x, float y, float z);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixRotatedEXT (int mode, double angle, double x, double y, double z);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixScalefEXT (int mode, float x, float y, float z);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixScaledEXT (int mode, double x, double y, double z);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixTranslatefEXT (int mode, float x, float y, float z);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixTranslatedEXT (int mode, double x, double y, double z);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixFrustumEXT (int mode, double left, double right, double bottom, double top, double zNear, double zFar);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixOrthoEXT (int mode, double left, double right, double bottom, double top, double zNear, double zFar);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixPopEXT (int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixPushEXT (int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glClientAttribDefaultEXT (int mask);
	[DllImport("glfw3.dll")]
	public static extern  void glPushClientAttribDefaultEXT (int mask);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterfEXT (uint texture, int target, int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterfvEXT (uint texture, int target, int pname,  float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameteriEXT (uint texture, int target, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterivEXT (uint texture, int target, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureImage1DEXT (uint texture, int target, int level, int internalformat, uint width, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureImage2DEXT (uint texture, int target, int level, int internalformat, uint width, uint height, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureSubImage1DEXT (uint texture, int target, int level, int xoffset, uint width, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureSubImage2DEXT (uint texture, int target, int level, int xoffset, int yoffset, uint width, uint height, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTextureImage1DEXT (uint texture, int target, int level, int internalformat, int x, int y, uint width, int border);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTextureImage2DEXT (uint texture, int target, int level, int internalformat, int x, int y, uint width, uint height, int border);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTextureSubImage1DEXT (uint texture, int target, int level, int xoffset, int x, int y, uint width);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTextureSubImage2DEXT (uint texture, int target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureImageEXT (uint texture, int target, int level, int format, int type, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureParameterfvEXT (uint texture, int target, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureParameterivEXT (uint texture, int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureLevelParameterfvEXT (uint texture, int target, int level, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureLevelParameterivEXT (uint texture, int target, int level, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureImage3DEXT (uint texture, int target, int level, int internalformat, uint width, uint height, uint depth, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureSubImage3DEXT (uint texture, int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyTextureSubImage3DEXT (uint texture, int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glBindMultiTextureEXT (int texunit, int target, uint texture);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexCoordPointerEXT (int texunit, int size, int type, uint stride,  void *pointer);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexEnvfEXT (int texunit, int target, int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexEnvfvEXT (int texunit, int target, int pname,  float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexEnviEXT (int texunit, int target, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexEnvivEXT (int texunit, int target, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexGendEXT (int texunit, int coord, int pname, double param);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexGendvEXT (int texunit, int coord, int pname,  double *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexGenfEXT (int texunit, int coord, int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexGenfvEXT (int texunit, int coord, int pname,  float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexGeniEXT (int texunit, int coord, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexGenivEXT (int texunit, int coord, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexEnvfvEXT (int texunit, int target, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexEnvivEXT (int texunit, int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexGendvEXT (int texunit, int coord, int pname, double *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexGenfvEXT (int texunit, int coord, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexGenivEXT (int texunit, int coord, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexParameteriEXT (int texunit, int target, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexParameterivEXT (int texunit, int target, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexParameterfEXT (int texunit, int target, int pname, float param);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexParameterfvEXT (int texunit, int target, int pname,  float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexImage1DEXT (int texunit, int target, int level, int internalformat, uint width, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexImage2DEXT (int texunit, int target, int level, int internalformat, uint width, uint height, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexSubImage1DEXT (int texunit, int target, int level, int xoffset, uint width, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexSubImage2DEXT (int texunit, int target, int level, int xoffset, int yoffset, uint width, uint height, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyMultiTexImage1DEXT (int texunit, int target, int level, int internalformat, int x, int y, uint width, int border);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyMultiTexImage2DEXT (int texunit, int target, int level, int internalformat, int x, int y, uint width, uint height, int border);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyMultiTexSubImage1DEXT (int texunit, int target, int level, int xoffset, int x, int y, uint width);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyMultiTexSubImage2DEXT (int texunit, int target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexImageEXT (int texunit, int target, int level, int format, int type, void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexParameterfvEXT (int texunit, int target, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexParameterivEXT (int texunit, int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexLevelParameterfvEXT (int texunit, int target, int level, int pname, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexLevelParameterivEXT (int texunit, int target, int level, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexImage3DEXT (int texunit, int target, int level, int internalformat, uint width, uint height, uint depth, int border, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexSubImage3DEXT (int texunit, int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, int type,  void *pixels);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyMultiTexSubImage3DEXT (int texunit, int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glEnableClientStateIndexedEXT (int array, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glDisableClientStateIndexedEXT (int array, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glGetFloatIndexedvEXT (int target, uint index, float *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetDoubleIndexedvEXT (int target, uint index, double *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPointerIndexedvEXT (int target, uint index, void **data);
	[DllImport("glfw3.dll")]
	public static extern  void glEnableIndexedEXT (int target, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glDisableIndexedEXT (int target, uint index);
	[DllImport("glfw3.dll")]
	public static extern  int glIsEnabledIndexedEXT (int target, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glGetIntegerIndexedvEXT (int target, uint index, int *data);
	[DllImport("glfw3.dll")]
	public static extern  void glGetBooleanIndexedvEXT (int target, uint index, int *data);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureImage3DEXT (uint texture, int target, int level, int internalformat, uint width, uint height, uint depth, int border, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureImage2DEXT (uint texture, int target, int level, int internalformat, uint width, uint height, int border, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureImage1DEXT (uint texture, int target, int level, int internalformat, uint width, int border, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureSubImage3DEXT (uint texture, int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureSubImage2DEXT (uint texture, int target, int level, int xoffset, int yoffset, uint width, uint height, int format, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedTextureSubImage1DEXT (uint texture, int target, int level, int xoffset, uint width, int format, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glGetCompressedTextureImageEXT (uint texture, int target, int lod, void *img);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedMultiTexImage3DEXT (int texunit, int target, int level, int internalformat, uint width, uint height, uint depth, int border, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedMultiTexImage2DEXT (int texunit, int target, int level, int internalformat, uint width, uint height, int border, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedMultiTexImage1DEXT (int texunit, int target, int level, int internalformat, uint width, int border, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedMultiTexSubImage3DEXT (int texunit, int target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int format, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedMultiTexSubImage2DEXT (int texunit, int target, int level, int xoffset, int yoffset, uint width, uint height, int format, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glCompressedMultiTexSubImage1DEXT (int texunit, int target, int level, int xoffset, uint width, int format, uint imageSize,  void *bits);
	[DllImport("glfw3.dll")]
	public static extern  void glGetCompressedMultiTexImageEXT (int texunit, int target, int lod, void *img);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixLoadTransposefEXT (int mode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixLoadTransposedEXT (int mode,  double *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixMultTransposefEXT (int mode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixMultTransposedEXT (int mode,  double *m);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferDataEXT (uint buffer, uint* size,  void *data, int usage);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferSubDataEXT (uint buffer, int* offset, uint* size,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void  glMapNamedBufferEXT (uint buffer, int access);
	[DllImport("glfw3.dll")]
	public static extern  int glUnmapNamedBufferEXT (uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedBufferParameterivEXT (uint buffer, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedBufferPointervEXT (uint buffer, int pname, void **prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedBufferSubDataEXT (uint buffer, int* offset, uint* size, void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1fEXT (uint program, int location, float v0);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2fEXT (uint program, int location, float v0, float v1);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3fEXT (uint program, int location, float v0, float v1, float v2);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4fEXT (uint program, int location, float v0, float v1, float v2, float v3);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1iEXT (uint program, int location, int v0);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2iEXT (uint program, int location, int v0, int v1);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3iEXT (uint program, int location, int v0, int v1, int v2);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4iEXT (uint program, int location, int v0, int v1, int v2, int v3);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1fvEXT (uint program, int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2fvEXT (uint program, int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3fvEXT (uint program, int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4fvEXT (uint program, int location, uint count,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1ivEXT (uint program, int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2ivEXT (uint program, int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3ivEXT (uint program, int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4ivEXT (uint program, int location, uint count,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2x3fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3x2fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2x4fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4x2fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3x4fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4x3fvEXT (uint program, int location, uint count, int transpose,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureBufferEXT (uint texture, int target, int internalformat, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexBufferEXT (int texunit, int target, int internalformat, uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterIivEXT (uint texture, int target, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureParameterIuivEXT (uint texture, int target, int pname,  uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureParameterIivEXT (uint texture, int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetTextureParameterIuivEXT (uint texture, int target, int pname, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexParameterIivEXT (int texunit, int target, int pname,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexParameterIuivEXT (int texunit, int target, int pname,  uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexParameterIivEXT (int texunit, int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMultiTexParameterIuivEXT (int texunit, int target, int pname, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1uiEXT (uint program, int location, uint v0);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2uiEXT (uint program, int location, uint v0, uint v1);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3uiEXT (uint program, int location, uint v0, uint v1, uint v2);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4uiEXT (uint program, int location, uint v0, uint v1, uint v2, uint v3);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1uivEXT (uint program, int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2uivEXT (uint program, int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3uivEXT (uint program, int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4uivEXT (uint program, int location, uint count,  uint *value);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameters4fvEXT (uint program, int target, uint index, uint count,  float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameterI4iEXT (uint program, int target, uint index, int x, int y, int z, int w);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameterI4ivEXT (uint program, int target, uint index,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParametersI4ivEXT (uint program, int target, uint index, uint count,  int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameterI4uiEXT (uint program, int target, uint index, uint x, uint y, uint z, uint w);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameterI4uivEXT (uint program, int target, uint index,  uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParametersI4uivEXT (uint program, int target, uint index, uint count,  uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedProgramLocalParameterIivEXT (uint program, int target, uint index, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedProgramLocalParameterIuivEXT (uint program, int target, uint index, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glEnableClientStateiEXT (int array, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glDisableClientStateiEXT (int array, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glGetFloati_vEXT (int pname, uint index, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetDoublei_vEXT (int pname, uint index, double *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPointeri_vEXT (int pname, uint index, void **prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramStringEXT (uint program, int target, int format, uint len,  void *str);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameter4dEXT (uint program, int target, uint index, double x, double y, double z, double w);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameter4dvEXT (uint program, int target, uint index,  double *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameter4fEXT (uint program, int target, uint index, float x, float y, float z, float w);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedProgramLocalParameter4fvEXT (uint program, int target, uint index,  float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedProgramLocalParameterdvEXT (uint program, int target, uint index, double *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedProgramLocalParameterfvEXT (uint program, int target, uint index, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedProgramivEXT (uint program, int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedProgramStringEXT (uint program, int target, int pname, void *str);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedRenderbufferStorageEXT (uint renderbuffer, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedRenderbufferParameterivEXT (uint renderbuffer, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedRenderbufferStorageMultisampleEXT (uint renderbuffer, uint samples, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedRenderbufferStorageMultisampleCoverageEXT (uint renderbuffer, uint coverageSamples, uint colorSamples, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  int glCheckNamedFramebufferStatusEXT (uint framebuffer, int target);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferTexture1DEXT (uint framebuffer, int attachment, int textarget, uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferTexture2DEXT (uint framebuffer, int attachment, int textarget, uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferTexture3DEXT (uint framebuffer, int attachment, int textarget, uint texture, int level, int zoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferRenderbufferEXT (uint framebuffer, int attachment, int renderbuffertarget, uint renderbuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedFramebufferAttachmentParameterivEXT (uint framebuffer, int attachment, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGenerateTextureMipmapEXT (uint texture, int target);
	[DllImport("glfw3.dll")]
	public static extern  void glGenerateMultiTexMipmapEXT (int texunit, int target);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferDrawBufferEXT (uint framebuffer, int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferDrawBuffersEXT (uint framebuffer, uint n,  int *bufs);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferReadBufferEXT (uint framebuffer, int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glGetFramebufferParameterivEXT (uint framebuffer, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedCopyBufferSubDataEXT (uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, uint* size);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferTextureEXT (uint framebuffer, int attachment, uint texture, int level);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferTextureLayerEXT (uint framebuffer, int attachment, uint texture, int level, int layer);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferTextureFaceEXT (uint framebuffer, int attachment, uint texture, int level, int face);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureRenderbufferEXT (uint texture, int target, uint renderbuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiTexRenderbufferEXT (int texunit, int target, uint renderbuffer);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexOffsetEXT (uint vaobj, uint buffer, int size, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayColorOffsetEXT (uint vaobj, uint buffer, int size, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayEdgeFlagOffsetEXT (uint vaobj, uint buffer, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayIndexOffsetEXT (uint vaobj, uint buffer, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayNormalOffsetEXT (uint vaobj, uint buffer, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayTexCoordOffsetEXT (uint vaobj, uint buffer, int size, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayMultiTexCoordOffsetEXT (uint vaobj, uint buffer, int texunit, int size, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayFogCoordOffsetEXT (uint vaobj, uint buffer, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArraySecondaryColorOffsetEXT (uint vaobj, uint buffer, int size, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexAttribOffsetEXT (uint vaobj, uint buffer, uint index, int size, int type, int normalized, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexAttribIOffsetEXT (uint vaobj, uint buffer, uint index, int size, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glEnableVertexArrayEXT (uint vaobj, int array);
	[DllImport("glfw3.dll")]
	public static extern  void glDisableVertexArrayEXT (uint vaobj, int array);
	[DllImport("glfw3.dll")]
	public static extern  void glEnableVertexArrayAttribEXT (uint vaobj, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glDisableVertexArrayAttribEXT (uint vaobj, uint index);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexArrayIntegervEXT (uint vaobj, int pname, int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexArrayPointervEXT (uint vaobj, int pname, void **param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexArrayIntegeri_vEXT (uint vaobj, uint index, int pname, int *param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexArrayPointeri_vEXT (uint vaobj, uint index, int pname, void **param);
	[DllImport("glfw3.dll")]
	public static extern  void  glMapNamedBufferRangeEXT (uint buffer, int* offset, uint* length, int access);
	[DllImport("glfw3.dll")]
	public static extern  void glFlushMappedNamedBufferRangeEXT (uint buffer, int* offset, uint* length);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferStorageEXT (uint buffer, uint* size,  void *data, int flags);
	[DllImport("glfw3.dll")]
	public static extern  void glClearNamedBufferDataEXT (uint buffer, int internalformat, int format, int type,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glClearNamedBufferSubDataEXT (uint buffer, int internalformat, uint* offset, uint* size, int format, int type,  void *data);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferParameteriEXT (uint framebuffer, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedFramebufferParameterivEXT (uint framebuffer, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1dEXT (uint program, int location, double x);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2dEXT (uint program, int location, double x, double y);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3dEXT (uint program, int location, double x, double y, double z);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4dEXT (uint program, int location, double x, double y, double z, double w);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1dvEXT (uint program, int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2dvEXT (uint program, int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3dvEXT (uint program, int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4dvEXT (uint program, int location, uint count,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2x3dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix2x4dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3x2dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix3x4dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4x2dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformMatrix4x3dvEXT (uint program, int location, uint count, int transpose,  double *value);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureBufferRangeEXT (uint texture, int target, int internalformat, uint buffer, int* offset, uint* size);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage1DEXT (uint texture, int target, uint levels, int internalformat, uint width);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage2DEXT (uint texture, int target, uint levels, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage3DEXT (uint texture, int target, uint levels, int internalformat, uint width, uint height, uint depth);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage2DMultisampleEXT (uint texture, int target, uint samples, int internalformat, uint width, uint height, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureStorage3DMultisampleEXT (uint texture, int target, uint samples, int internalformat, uint width, uint height, uint depth, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayBindVertexBufferEXT (uint vaobj, uint bindingindex, uint buffer, int* offset, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexAttribFormatEXT (uint vaobj, uint attribindex, int size, int type, int normalized, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexAttribIFormatEXT (uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexAttribLFormatEXT (uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexAttribBindingEXT (uint vaobj, uint attribindex, uint bindingindex);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexBindingDivisorEXT (uint vaobj, uint bindingindex, uint divisor);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexAttribLOffsetEXT (uint vaobj, uint buffer, uint index, int size, int type, uint stride, int* offset);
	[DllImport("glfw3.dll")]
	public static extern  void glTexturePageCommitmentEXT (uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexArrayVertexAttribDivisorEXT (uint vaobj, uint index, uint divisor);
	public const int GL_EXT_draw_instanced = 1;

public delegate void PFNGLDRAWARRAYSINSTANCEDEXTPROC (int mode, int start, uint count, uint primcount);
public delegate void PFNGLDRAWELEMENTSINSTANCEDEXTPROC (int mode, uint count, int type,  void *indices, uint primcount);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawArraysInstancedEXT (int mode, int start, uint count, uint primcount);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawElementsInstancedEXT (int mode, uint count, int type,  void *indices, uint primcount);
	public const int GL_EXT_multiview_tessellation_geometry_shader = 1;

	public const int GL_EXT_multiview_texture_multisample = 1;

	public const int GL_EXT_multiview_timer_query = 1;

	public const int GL_EXT_polygon_offset_clamp = 1;

	public const int GL_POLYGON_OFFSET_CLAMP_EXT = 0x8E1B;

public delegate void PFNGLPOLYGONOFFSETCLAMPEXTPROC (float factor, float units, float clamp);
	[DllImport("glfw3.dll")]
	public static extern  void glPolygonOffsetClampEXT (float factor, float units, float clamp);
	public const int GL_EXT_post_depth_coverage = 1;

	public const int GL_EXT_raster_multisample = 1;

	public const int GL_RASTER_MULTISAMPLE_EXT = 0x9327;

	public const int GL_RASTER_SAMPLES_EXT = 0x9328;

	public const int GL_MAX_RASTER_SAMPLES_EXT = 0x9329;

	public const int GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;

	public const int GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;

	public const int GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;

public delegate void PFNGLRASTERSAMPLESEXTPROC (uint samples, int fixedsamplelocations);
	[DllImport("glfw3.dll")]
	public static extern  void glRasterSamplesEXT (uint samples, int fixedsamplelocations);
	public const int GL_EXT_separate_shader_objects = 1;

	public const int GL_ACTIVE_PROGRAM_EXT = 0x8B8D;

public delegate void PFNGLUSESHADERPROGRAMEXTPROC (int type, uint program);
public delegate void PFNGLACTIVEPROGRAMEXTPROC (uint program);
	[DllImport("glfw3.dll")]
	public static extern  void glUseShaderProgramEXT (int type, uint program);
	[DllImport("glfw3.dll")]
	public static extern  void glActiveProgramEXT (uint program);
	[DllImport("glfw3.dll")]
	public static extern  uint glCreateShaderProgramEXT (int type,  char *str);
	public const int GL_EXT_shader_framebuffer_fetch = 1;

	public const int GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT = 0x8A52;

	public const int GL_EXT_shader_framebuffer_fetch_non_coherent = 1;

public delegate void PFNGLFRAMEBUFFERFETCHBARRIEREXTPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferFetchBarrierEXT ();
	public const int GL_EXT_shader_integer_mix = 1;

	public const int GL_EXT_texture_compression_s3tc = 1;

	public const int GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;

	public const int GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;

	public const int GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2;

	public const int GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3;

	public const int GL_EXT_texture_filter_minmax = 1;

	public const int GL_TEXTURE_REDUCTION_MODE_EXT = 0x9366;

	public const int GL_WEIGHTED_AVERAGE_EXT = 0x9367;

	public const int GL_EXT_texture_sRGB_R8 = 1;

	public const int GL_SR8_EXT = 0x8FBD;

	public const int GL_EXT_texture_sRGB_RG8 = 1;

	public const int GL_SRG8_EXT = 0x8FBE;

	public const int GL_EXT_texture_sRGB_decode = 1;

	public const int GL_TEXTURE_SRGB_DECODE_EXT = 0x8A48;

	public const int GL_DECODE_EXT = 0x8A49;

	public const int GL_SKIP_DECODE_EXT = 0x8A4A;

	public const int GL_EXT_texture_shadow_lod = 1;

	public const int GL_EXT_texture_storage = 1;

	public const int GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F;

	public const int GL_ALPHA8_EXT = 0x803C;

	public const int GL_LUMINANCE8_EXT = 0x8040;

	public const int GL_LUMINANCE8_ALPHA8_EXT = 0x8045;

	public const int GL_RGBA32F_EXT = 0x8814;

	public const int GL_RGB32F_EXT = 0x8815;

	public const int GL_ALPHA32F_EXT = 0x8816;

	public const int GL_LUMINANCE32F_EXT = 0x8818;

	public const int GL_LUMINANCE_ALPHA32F_EXT = 0x8819;

	public const int GL_RGBA16F_EXT = 0x881A;

	public const int GL_RGB16F_EXT = 0x881B;

	public const int GL_ALPHA16F_EXT = 0x881C;

	public const int GL_LUMINANCE16F_EXT = 0x881E;

	public const int GL_LUMINANCE_ALPHA16F_EXT = 0x881F;

	public const int GL_RGB10_A2_EXT = 0x8059;

	public const int GL_RGB10_EXT = 0x8052;

	public const int GL_BGRA8_EXT = 0x93A1;

	public const int GL_R8_EXT = 0x8229;

	public const int GL_RG8_EXT = 0x822B;

	public const int GL_R32F_EXT = 0x822E;

	public const int GL_RG32F_EXT = 0x8230;

	public const int GL_R16F_EXT = 0x822D;

	public const int GL_RG16F_EXT = 0x822F;

public delegate void PFNGLTEXSTORAGE1DEXTPROC (int target, uint levels, int internalformat, uint width);
public delegate void PFNGLTEXSTORAGE2DEXTPROC (int target, uint levels, int internalformat, uint width, uint height);
public delegate void PFNGLTEXSTORAGE3DEXTPROC (int target, uint levels, int internalformat, uint width, uint height, uint depth);
	[DllImport("glfw3.dll")]
	public static extern  void glTexStorage1DEXT (int target, uint levels, int internalformat, uint width);
	[DllImport("glfw3.dll")]
	public static extern  void glTexStorage2DEXT (int target, uint levels, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glTexStorage3DEXT (int target, uint levels, int internalformat, uint width, uint height, uint depth);
	public const int GL_EXT_window_rectangles = 1;

	public const int GL_INCLUSIVE_EXT = 0x8F10;

	public const int GL_EXCLUSIVE_EXT = 0x8F11;

	public const int GL_WINDOW_RECTANGLE_EXT = 0x8F12;

	public const int GL_WINDOW_RECTANGLE_MODE_EXT = 0x8F13;

	public const int GL_MAX_WINDOW_RECTANGLES_EXT = 0x8F14;

	public const int GL_NUM_WINDOW_RECTANGLES_EXT = 0x8F15;

public delegate void PFNGLWINDOWRECTANGLESEXTPROC (int mode, uint count,  int *box);
	[DllImport("glfw3.dll")]
	public static extern  void glWindowRectanglesEXT (int mode, uint count,  int *box);
	public const int GL_INTEL_blackhole_render = 1;

	public const int GL_BLACKHOLE_RENDER_INTEL = 0x83FC;

	public const int GL_INTEL_conservative_rasterization = 1;

	public const int GL_CONSERVATIVE_RASTERIZATION_INTEL = 0x83FE;

	public const int GL_INTEL_framebuffer_CMAA = 1;

public delegate void PFNGLAPPLYFRAMEBUFFERATTACHMENTCMAAINTELPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glApplyFramebufferAttachmentCMAAINTEL ();
	public const int GL_INTEL_performance_query = 1;

	public const int GL_PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000;

	public const int GL_PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001;

	public const int GL_PERFQUERY_WAIT_INTEL = 0x83FB;

	public const int GL_PERFQUERY_FLUSH_INTEL = 0x83FA;

	public const int GL_PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9;

	public const int GL_PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0;

	public const int GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1;

	public const int GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2;

	public const int GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3;

	public const int GL_PERFQUERY_COUNTER_RAW_INTEL = 0x94F4;

	public const int GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5;

	public const int GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8;

	public const int GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9;

	public const int GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA;

	public const int GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB;

	public const int GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC;

	public const int GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD;

	public const int GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE;

	public const int GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF;

	public const int GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500;

public delegate void PFNGLBEGINPERFQUERYINTELPROC (uint queryHandle);
public delegate void PFNGLCREATEPERFQUERYINTELPROC (uint queryId, uint *queryHandle);
public delegate void PFNGLDELETEPERFQUERYINTELPROC (uint queryHandle);
public delegate void PFNGLENDPERFQUERYINTELPROC (uint queryHandle);
public delegate void PFNGLGETFIRSTPERFQUERYIDINTELPROC (uint *queryId);
public delegate void PFNGLGETNEXTPERFQUERYIDINTELPROC (uint queryId, uint *nextQueryId);
public delegate void PFNGLGETPERFCOUNTERINFOINTELPROC (uint queryId, uint counterId, uint counterNameLength, char *counterName, uint counterDescLength, char *counterDesc, uint *counterOffset, uint *counterDataSize, uint *counterTypeEnum, uint *counterDataTypeEnum, ulong *rawCounterMaxValue);
public delegate void PFNGLGETPERFQUERYDATAINTELPROC (uint queryHandle, uint flags, uint dataSize, void *data, uint *bytesWritten);
public delegate void PFNGLGETPERFQUERYIDBYNAMEINTELPROC (char *queryName, uint *queryId);
public delegate void PFNGLGETPERFQUERYINFOINTELPROC (uint queryId, uint queryNameLength, char *queryName, uint *dataSize, uint *noCounters, uint *noInstances, uint *capsMask);
	[DllImport("glfw3.dll")]
	public static extern  void glBeginPerfQueryINTEL (uint queryHandle);
	[DllImport("glfw3.dll")]
	public static extern  void glCreatePerfQueryINTEL (uint queryId, uint *queryHandle);
	[DllImport("glfw3.dll")]
	public static extern  void glDeletePerfQueryINTEL (uint queryHandle);
	[DllImport("glfw3.dll")]
	public static extern  void glEndPerfQueryINTEL (uint queryHandle);
	[DllImport("glfw3.dll")]
	public static extern  void glGetFirstPerfQueryIdINTEL (uint *queryId);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNextPerfQueryIdINTEL (uint queryId, uint *nextQueryId);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfCounterInfoINTEL (uint queryId, uint counterId, uint counterNameLength, char *counterName, uint counterDescLength, char *counterDesc, uint *counterOffset, uint *counterDataSize, uint *counterTypeEnum, uint *counterDataTypeEnum, ulong *rawCounterMaxValue);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfQueryDataINTEL (uint queryHandle, uint flags, uint dataSize, void *data, uint *bytesWritten);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfQueryIdByNameINTEL (char *queryName, uint *queryId);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPerfQueryInfoINTEL (uint queryId, uint queryNameLength, char *queryName, uint *dataSize, uint *noCounters, uint *noInstances, uint *capsMask);
	public const int GL_MESA_framebuffer_flip_x = 1;

	public const int GL_FRAMEBUFFER_FLIP_X_MESA = 0x8BBC;

	public const int GL_MESA_framebuffer_flip_y = 1;

	public const int GL_FRAMEBUFFER_FLIP_Y_MESA = 0x8BBB;

public delegate void PFNGLFRAMEBUFFERPARAMETERIMESAPROC (int target, int pname, int param);
public delegate void PFNGLGETFRAMEBUFFERPARAMETERIVMESAPROC (int target, int pname, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferParameteriMESA (int target, int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glGetFramebufferParameterivMESA (int target, int pname, int *prms);
	public const int GL_MESA_framebuffer_swap_xy = 1;

	public const int GL_FRAMEBUFFER_SWAP_XY_MESA = 0x8BBD;

	public const int GL_NV_bindless_multi_draw_indirect = 1;

public delegate void PFNGLMULTIDRAWARRAYSINDIRECTBINDLESSNVPROC (int mode,  void *indirect, uint drawCount, uint stride, int vertexBufferCount);
public delegate void PFNGLMULTIDRAWELEMENTSINDIRECTBINDLESSNVPROC (int mode, int type,  void *indirect, uint drawCount, uint stride, int vertexBufferCount);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawArraysIndirectBindlessNV (int mode,  void *indirect, uint drawCount, uint stride, int vertexBufferCount);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawElementsIndirectBindlessNV (int mode, int type,  void *indirect, uint drawCount, uint stride, int vertexBufferCount);
	public const int GL_NV_bindless_multi_draw_indirect_count = 1;

public delegate void PFNGLMULTIDRAWARRAYSINDIRECTBINDLESSCOUNTNVPROC (int mode,  void *indirect, uint drawCount, uint maxDrawCount, uint stride, int vertexBufferCount);
public delegate void PFNGLMULTIDRAWELEMENTSINDIRECTBINDLESSCOUNTNVPROC (int mode, int type,  void *indirect, uint drawCount, uint maxDrawCount, uint stride, int vertexBufferCount);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawArraysIndirectBindlessCountNV (int mode,  void *indirect, uint drawCount, uint maxDrawCount, uint stride, int vertexBufferCount);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawElementsIndirectBindlessCountNV (int mode, int type,  void *indirect, uint drawCount, uint maxDrawCount, uint stride, int vertexBufferCount);
	public const int GL_NV_bindless_texture = 1;

public delegate void PFNGLMAKETEXTUREHANDLERESIDENTNVPROC (ulong handle);
public delegate void PFNGLMAKETEXTUREHANDLENONRESIDENTNVPROC (ulong handle);
public delegate void PFNGLMAKEIMAGEHANDLERESIDENTNVPROC (ulong handle, int access);
public delegate void PFNGLMAKEIMAGEHANDLENONRESIDENTNVPROC (ulong handle);
public delegate void PFNGLUNIFORMHANDLEUI64NVPROC (int location, ulong value);
public delegate void PFNGLUNIFORMHANDLEUI64VNVPROC (int location, uint count,  ulong *value);
public delegate void PFNGLPROGRAMUNIFORMHANDLEUI64NVPROC (uint program, int location, ulong value);
public delegate void PFNGLPROGRAMUNIFORMHANDLEUI64VNVPROC (uint program, int location, uint count,  ulong *values);
	[DllImport("glfw3.dll")]
	public static extern  ulong glGetTextureHandleNV (uint texture);
	[DllImport("glfw3.dll")]
	public static extern  ulong glGetTextureSamplerHandleNV (uint texture, uint sampler);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeTextureHandleResidentNV (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeTextureHandleNonResidentNV (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  ulong glGetImageHandleNV (uint texture, int level, int layered, int layer, int format);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeImageHandleResidentNV (ulong handle, int access);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeImageHandleNonResidentNV (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformHandleui64NV (int location, ulong value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformHandleui64vNV (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformHandleui64NV (uint program, int location, ulong value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformHandleui64vNV (uint program, int location, uint count,  ulong *values);
	[DllImport("glfw3.dll")]
	public static extern  int glIsTextureHandleResidentNV (ulong handle);
	[DllImport("glfw3.dll")]
	public static extern  int glIsImageHandleResidentNV (ulong handle);
	public const int GL_NV_blend_equation_advanced = 1;

	public const int GL_BLEND_OVERLAP_NV = 0x9281;

	public const int GL_BLEND_PREMULTIPLIED_SRC_NV = 0x9280;

	public const int GL_BLUE_NV = 0x1905;

	public const int GL_COLORBURN_NV = 0x929A;

	public const int GL_COLORDODGE_NV = 0x9299;

	public const int GL_CONJOINT_NV = 0x9284;

	public const int GL_CONTRAST_NV = 0x92A1;

	public const int GL_DARKEN_NV = 0x9297;

	public const int GL_DIFFERENCE_NV = 0x929E;

	public const int GL_DISJOINT_NV = 0x9283;

	public const int GL_DST_ATOP_NV = 0x928F;

	public const int GL_DST_IN_NV = 0x928B;

	public const int GL_DST_NV = 0x9287;

	public const int GL_DST_OUT_NV = 0x928D;

	public const int GL_DST_OVER_NV = 0x9289;

	public const int GL_EXCLUSION_NV = 0x92A0;

	public const int GL_GREEN_NV = 0x1904;

	public const int GL_HARDLIGHT_NV = 0x929B;

	public const int GL_HARDMIX_NV = 0x92A9;

	public const int GL_HSL_COLOR_NV = 0x92AF;

	public const int GL_HSL_HUE_NV = 0x92AD;

	public const int GL_HSL_LUMINOSITY_NV = 0x92B0;

	public const int GL_HSL_SATURATION_NV = 0x92AE;

	public const int GL_INVERT_OVG_NV = 0x92B4;

	public const int GL_INVERT_RGB_NV = 0x92A3;

	public const int GL_LIGHTEN_NV = 0x9298;

	public const int GL_LINEARBURN_NV = 0x92A5;

	public const int GL_LINEARDODGE_NV = 0x92A4;

	public const int GL_LINEARLIGHT_NV = 0x92A7;

	public const int GL_MINUS_CLAMPED_NV = 0x92B3;

	public const int GL_MINUS_NV = 0x929F;

	public const int GL_MULTIPLY_NV = 0x9294;

	public const int GL_OVERLAY_NV = 0x9296;

	public const int GL_PINLIGHT_NV = 0x92A8;

	public const int GL_PLUS_CLAMPED_ALPHA_NV = 0x92B2;

	public const int GL_PLUS_CLAMPED_NV = 0x92B1;

	public const int GL_PLUS_DARKER_NV = 0x9292;

	public const int GL_PLUS_NV = 0x9291;

	public const int GL_RED_NV = 0x1903;

	public const int GL_SCREEN_NV = 0x9295;

	public const int GL_SOFTLIGHT_NV = 0x929C;

	public const int GL_SRC_ATOP_NV = 0x928E;

	public const int GL_SRC_IN_NV = 0x928A;

	public const int GL_SRC_NV = 0x9286;

	public const int GL_SRC_OUT_NV = 0x928C;

	public const int GL_SRC_OVER_NV = 0x9288;

	public const int GL_UNCORRELATED_NV = 0x9282;

	public const int GL_VIVIDLIGHT_NV = 0x92A6;

	public const int GL_XOR_NV = 0x1506;

public delegate void PFNGLBLENDPARAMETERINVPROC (int pname, int value);
public delegate void PFNGLBLENDBARRIERNVPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glBlendParameteriNV (int pname, int value);
	[DllImport("glfw3.dll")]
	public static extern  void glBlendBarrierNV ();
	public const int GL_NV_blend_equation_advanced_coherent = 1;

	public const int GL_BLEND_ADVANCED_COHERENT_NV = 0x9285;

	public const int GL_NV_blend_minmax_factor = 1;

	public const int GL_FACTOR_MIN_AMD = 0x901C;

	public const int GL_FACTOR_MAX_AMD = 0x901D;

	public const int GL_NV_clip_space_w_scaling = 1;

	public const int GL_VIEWPORT_POSITION_W_SCALE_NV = 0x937C;

	public const int GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV = 0x937D;

	public const int GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV = 0x937E;

public delegate void PFNGLVIEWPORTPOSITIONWSCALENVPROC (uint index, float xcoeff, float ycoeff);
	[DllImport("glfw3.dll")]
	public static extern  void glViewportPositionWScaleNV (uint index, float xcoeff, float ycoeff);
	public const int GL_NV_command_list = 1;

	public const int GL_TERMINATE_SEQUENCE_COMMAND_NV = 0x0000;

	public const int GL_NOP_COMMAND_NV = 0x0001;

	public const int GL_DRAW_ELEMENTS_COMMAND_NV = 0x0002;

	public const int GL_DRAW_ARRAYS_COMMAND_NV = 0x0003;

	public const int GL_DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004;

	public const int GL_DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005;

	public const int GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006;

	public const int GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007;

	public const int GL_ELEMENT_ADDRESS_COMMAND_NV = 0x0008;

	public const int GL_ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009;

	public const int GL_UNIFORM_ADDRESS_COMMAND_NV = 0x000A;

	public const int GL_BLEND_COLOR_COMMAND_NV = 0x000B;

	public const int GL_STENCIL_REF_COMMAND_NV = 0x000C;

	public const int GL_LINE_WIDTH_COMMAND_NV = 0x000D;

	public const int GL_POLYGON_OFFSET_COMMAND_NV = 0x000E;

	public const int GL_ALPHA_REF_COMMAND_NV = 0x000F;

	public const int GL_VIEWPORT_COMMAND_NV = 0x0010;

	public const int GL_SCISSOR_COMMAND_NV = 0x0011;

	public const int GL_FRONT_FACE_COMMAND_NV = 0x0012;

public delegate void PFNGLCREATESTATESNVPROC (uint n, uint *states);
public delegate void PFNGLDELETESTATESNVPROC (uint n,  uint *states);
public delegate void PFNGLSTATECAPTURENVPROC (uint state, int mode);
public delegate void PFNGLDRAWCOMMANDSNVPROC (int primitiveMode, uint buffer,  int* *indirects,  uint *sizes, uint count);
public delegate void PFNGLDRAWCOMMANDSADDRESSNVPROC (int primitiveMode,  ulong *indirects,  uint *sizes, uint count);
public delegate void PFNGLDRAWCOMMANDSSTATESNVPROC (uint buffer,  int* *indirects,  uint *sizes,  uint *states,  uint *fbos, uint count);
public delegate void PFNGLDRAWCOMMANDSSTATESADDRESSNVPROC ( ulong *indirects,  uint *sizes,  uint *states,  uint *fbos, uint count);
public delegate void PFNGLCREATECOMMANDLISTSNVPROC (uint n, uint *lists);
public delegate void PFNGLDELETECOMMANDLISTSNVPROC (uint n,  uint *lists);
public delegate void PFNGLLISTDRAWCOMMANDSSTATESCLIENTNVPROC (uint list, uint segment,  void **indirects,  uint *sizes,  uint *states,  uint *fbos, uint count);
public delegate void PFNGLCOMMANDLISTSEGMENTSNVPROC (uint list, uint segments);
public delegate void PFNGLCOMPILECOMMANDLISTNVPROC (uint list);
public delegate void PFNGLCALLCOMMANDLISTNVPROC (uint list);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateStatesNV (uint n, uint *states);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteStatesNV (uint n,  uint *states);
	[DllImport("glfw3.dll")]
	public static extern  int glIsStateNV (uint state);
	[DllImport("glfw3.dll")]
	public static extern  void glStateCaptureNV (uint state, int mode);
	[DllImport("glfw3.dll")]
	public static extern  uint glGetCommandHeaderNV (int tokenID, uint size);
	[DllImport("glfw3.dll")]
	public static extern  GLushort glGetStageIndexNV (int shadertype);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawCommandsNV (int primitiveMode, uint buffer,  int* *indirects,  uint *sizes, uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawCommandsAddressNV (int primitiveMode,  ulong *indirects,  uint *sizes, uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawCommandsStatesNV (uint buffer,  int* *indirects,  uint *sizes,  uint *states,  uint *fbos, uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawCommandsStatesAddressNV ( ulong *indirects,  uint *sizes,  uint *states,  uint *fbos, uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glCreateCommandListsNV (uint n, uint *lists);
	[DllImport("glfw3.dll")]
	public static extern  void glDeleteCommandListsNV (uint n,  uint *lists);
	[DllImport("glfw3.dll")]
	public static extern  int glIsCommandListNV (uint list);
	[DllImport("glfw3.dll")]
	public static extern  void glListDrawCommandsStatesClientNV (uint list, uint segment,  void **indirects,  uint *sizes,  uint *states,  uint *fbos, uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glCommandListSegmentsNV (uint list, uint segments);
	[DllImport("glfw3.dll")]
	public static extern  void glCompileCommandListNV (uint list);
	[DllImport("glfw3.dll")]
	public static extern  void glCallCommandListNV (uint list);
	public const int GL_NV_compute_shader_derivatives = 1;

	public const int GL_NV_conditional_render = 1;

	public const int GL_QUERY_WAIT_NV = 0x8E13;

	public const int GL_QUERY_NO_WAIT_NV = 0x8E14;

	public const int GL_QUERY_BY_REGION_WAIT_NV = 0x8E15;

	public const int GL_QUERY_BY_REGION_NO_WAIT_NV = 0x8E16;

public delegate void PFNGLBEGINCONDITIONALRENDERNVPROC (uint id, int mode);
public delegate void PFNGLENDCONDITIONALRENDERNVPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glBeginConditionalRenderNV (uint id, int mode);
	[DllImport("glfw3.dll")]
	public static extern  void glEndConditionalRenderNV ();
	public const int GL_NV_conservative_raster = 1;

	public const int GL_CONSERVATIVE_RASTERIZATION_NV = 0x9346;

	public const int GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347;

	public const int GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348;

	public const int GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349;

public delegate void PFNGLSUBPIXELPRECISIONBIASNVPROC (uint xbits, uint ybits);
	[DllImport("glfw3.dll")]
	public static extern  void glSubpixelPrecisionBiasNV (uint xbits, uint ybits);
	public const int GL_NV_conservative_raster_dilate = 1;

	public const int GL_CONSERVATIVE_RASTER_DILATE_NV = 0x9379;

	public const int GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A;

	public const int GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B;

public delegate void PFNGLCONSERVATIVERASTERPARAMETERFNVPROC (int pname, float value);
	[DllImport("glfw3.dll")]
	public static extern  void glConservativeRasterParameterfNV (int pname, float value);
	public const int GL_NV_conservative_raster_pre_snap = 1;

	public const int GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV = 0x9550;

	public const int GL_NV_conservative_raster_pre_snap_triangles = 1;

	public const int GL_CONSERVATIVE_RASTER_MODE_NV = 0x954D;

	public const int GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV = 0x954E;

	public const int GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV = 0x954F;

public delegate void PFNGLCONSERVATIVERASTERPARAMETERINVPROC (int pname, int param);
	[DllImport("glfw3.dll")]
	public static extern  void glConservativeRasterParameteriNV (int pname, int param);
	public const int GL_NV_conservative_raster_underestimation = 1;

	public const int GL_NV_depth_buffer_float = 1;

	public const int GL_DEPTH_COMPONENT32F_NV = 0x8DAB;

	public const int GL_DEPTH32F_STENCIL8_NV = 0x8DAC;

	public const int GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD;

	public const int GL_DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF;

public delegate void PFNGLDEPTHRANGEDNVPROC (double zNear, double zFar);
public delegate void PFNGLCLEARDEPTHDNVPROC (double depth);
public delegate void PFNGLDEPTHBOUNDSDNVPROC (double zmin, double zmax);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthRangedNV (double zNear, double zFar);
	[DllImport("glfw3.dll")]
	public static extern  void glClearDepthdNV (double depth);
	[DllImport("glfw3.dll")]
	public static extern  void glDepthBoundsdNV (double zmin, double zmax);
	public const int GL_NV_draw_vulkan_image = 1;

public delegate void  GLVULKANPROCNV ();
public delegate void PFNGLDRAWVKIMAGENVPROC (ulong vkImage, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
public delegate void PFNGLWAITVKSEMAPHORENVPROC (ulong vkSemaphore);
public delegate void PFNGLSIGNALVKSEMAPHORENVPROC (ulong vkSemaphore);
public delegate void PFNGLSIGNALVKFENCENVPROC (ulong vkFence);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawVkImageNV (ulong vkImage, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
	[DllImport("glfw3.dll")]
	public static extern  GLVULKANPROCNV glGetVkProcAddrNV ( char *name);
	[DllImport("glfw3.dll")]
	public static extern  void glWaitVkSemaphoreNV (ulong vkSemaphore);
	[DllImport("glfw3.dll")]
	public static extern  void glSignalVkSemaphoreNV (ulong vkSemaphore);
	[DllImport("glfw3.dll")]
	public static extern  void glSignalVkFenceNV (ulong vkFence);
	public const int GL_NV_fill_rectangle = 1;

	public const int GL_FILL_RECTANGLE_NV = 0x933C;

	public const int GL_NV_fragment_coverage_to_color = 1;

	public const int GL_FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD;

	public const int GL_FRAGMENT_COVERAGE_COLOR_NV = 0x92DE;

public delegate void PFNGLFRAGMENTCOVERAGECOLORNVPROC (uint color);
	[DllImport("glfw3.dll")]
	public static extern  void glFragmentCoverageColorNV (uint color);
	public const int GL_NV_fragment_shader_barycentric = 1;

	public const int GL_NV_fragment_shader_interlock = 1;

	public const int GL_NV_framebuffer_mixed_samples = 1;

	public const int GL_COVERAGE_MODULATION_TABLE_NV = 0x9331;

	public const int GL_COLOR_SAMPLES_NV = 0x8E20;

	public const int GL_DEPTH_SAMPLES_NV = 0x932D;

	public const int GL_STENCIL_SAMPLES_NV = 0x932E;

	public const int GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F;

	public const int GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330;

	public const int GL_COVERAGE_MODULATION_NV = 0x9332;

	public const int GL_COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333;

public delegate void PFNGLCOVERAGEMODULATIONTABLENVPROC (uint n,  float *v);
public delegate void PFNGLGETCOVERAGEMODULATIONTABLENVPROC (uint bufSize, float *v);
public delegate void PFNGLCOVERAGEMODULATIONNVPROC (int components);
	[DllImport("glfw3.dll")]
	public static extern  void glCoverageModulationTableNV (uint n,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glGetCoverageModulationTableNV (uint bufSize, float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glCoverageModulationNV (int components);
	public const int GL_NV_framebuffer_multisample_coverage = 1;

	public const int GL_RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;

	public const int GL_RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10;

	public const int GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;

	public const int GL_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12;

public delegate void PFNGLRENDERBUFFERSTORAGEMULTISAMPLECOVERAGENVPROC (int target, uint coverageSamples, uint colorSamples, int internalformat, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glRenderbufferStorageMultisampleCoverageNV (int target, uint coverageSamples, uint colorSamples, int internalformat, uint width, uint height);
	public const int GL_NV_geometry_shader_passthrough = 1;

	public const int GL_NV_gpu_shader5 = 1;

	public const int GL_INT64_NV = 0x140E;

	public const int GL_UNSIGNED_INT64_NV = 0x140F;

	public const int GL_INT8_NV = 0x8FE0;

	public const int GL_INT8_VEC2_NV = 0x8FE1;

	public const int GL_INT8_VEC3_NV = 0x8FE2;

	public const int GL_INT8_VEC4_NV = 0x8FE3;

	public const int GL_INT16_NV = 0x8FE4;

	public const int GL_INT16_VEC2_NV = 0x8FE5;

	public const int GL_INT16_VEC3_NV = 0x8FE6;

	public const int GL_INT16_VEC4_NV = 0x8FE7;

	public const int GL_INT64_VEC2_NV = 0x8FE9;

	public const int GL_INT64_VEC3_NV = 0x8FEA;

	public const int GL_INT64_VEC4_NV = 0x8FEB;

	public const int GL_UNSIGNED_INT8_NV = 0x8FEC;

	public const int GL_UNSIGNED_INT8_VEC2_NV = 0x8FED;

	public const int GL_UNSIGNED_INT8_VEC3_NV = 0x8FEE;

	public const int GL_UNSIGNED_INT8_VEC4_NV = 0x8FEF;

	public const int GL_UNSIGNED_INT16_NV = 0x8FF0;

	public const int GL_UNSIGNED_INT16_VEC2_NV = 0x8FF1;

	public const int GL_UNSIGNED_INT16_VEC3_NV = 0x8FF2;

	public const int GL_UNSIGNED_INT16_VEC4_NV = 0x8FF3;

	public const int GL_UNSIGNED_INT64_VEC2_NV = 0x8FF5;

	public const int GL_UNSIGNED_INT64_VEC3_NV = 0x8FF6;

	public const int GL_UNSIGNED_INT64_VEC4_NV = 0x8FF7;

	public const int GL_FLOAT16_NV = 0x8FF8;

	public const int GL_FLOAT16_VEC2_NV = 0x8FF9;

	public const int GL_FLOAT16_VEC3_NV = 0x8FFA;

	public const int GL_FLOAT16_VEC4_NV = 0x8FFB;

public delegate void PFNGLUNIFORM1I64NVPROC (int location, long x);
public delegate void PFNGLUNIFORM2I64NVPROC (int location, long x, long y);
public delegate void PFNGLUNIFORM3I64NVPROC (int location, long x, long y, long z);
public delegate void PFNGLUNIFORM4I64NVPROC (int location, long x, long y, long z, long w);
public delegate void PFNGLUNIFORM1I64VNVPROC (int location, uint count,  long *value);
public delegate void PFNGLUNIFORM2I64VNVPROC (int location, uint count,  long *value);
public delegate void PFNGLUNIFORM3I64VNVPROC (int location, uint count,  long *value);
public delegate void PFNGLUNIFORM4I64VNVPROC (int location, uint count,  long *value);
public delegate void PFNGLUNIFORM1UI64NVPROC (int location, ulong x);
public delegate void PFNGLUNIFORM2UI64NVPROC (int location, ulong x, ulong y);
public delegate void PFNGLUNIFORM3UI64NVPROC (int location, ulong x, ulong y, ulong z);
public delegate void PFNGLUNIFORM4UI64NVPROC (int location, ulong x, ulong y, ulong z, ulong w);
public delegate void PFNGLUNIFORM1UI64VNVPROC (int location, uint count,  ulong *value);
public delegate void PFNGLUNIFORM2UI64VNVPROC (int location, uint count,  ulong *value);
public delegate void PFNGLUNIFORM3UI64VNVPROC (int location, uint count,  ulong *value);
public delegate void PFNGLUNIFORM4UI64VNVPROC (int location, uint count,  ulong *value);
public delegate void PFNGLGETUNIFORMI64VNVPROC (uint program, int location, long *prms);
public delegate void PFNGLPROGRAMUNIFORM1I64NVPROC (uint program, int location, long x);
public delegate void PFNGLPROGRAMUNIFORM2I64NVPROC (uint program, int location, long x, long y);
public delegate void PFNGLPROGRAMUNIFORM3I64NVPROC (uint program, int location, long x, long y, long z);
public delegate void PFNGLPROGRAMUNIFORM4I64NVPROC (uint program, int location, long x, long y, long z, long w);
public delegate void PFNGLPROGRAMUNIFORM1I64VNVPROC (uint program, int location, uint count,  long *value);
public delegate void PFNGLPROGRAMUNIFORM2I64VNVPROC (uint program, int location, uint count,  long *value);
public delegate void PFNGLPROGRAMUNIFORM3I64VNVPROC (uint program, int location, uint count,  long *value);
public delegate void PFNGLPROGRAMUNIFORM4I64VNVPROC (uint program, int location, uint count,  long *value);
public delegate void PFNGLPROGRAMUNIFORM1UI64NVPROC (uint program, int location, ulong x);
public delegate void PFNGLPROGRAMUNIFORM2UI64NVPROC (uint program, int location, ulong x, ulong y);
public delegate void PFNGLPROGRAMUNIFORM3UI64NVPROC (uint program, int location, ulong x, ulong y, ulong z);
public delegate void PFNGLPROGRAMUNIFORM4UI64NVPROC (uint program, int location, ulong x, ulong y, ulong z, ulong w);
public delegate void PFNGLPROGRAMUNIFORM1UI64VNVPROC (uint program, int location, uint count,  ulong *value);
public delegate void PFNGLPROGRAMUNIFORM2UI64VNVPROC (uint program, int location, uint count,  ulong *value);
public delegate void PFNGLPROGRAMUNIFORM3UI64VNVPROC (uint program, int location, uint count,  ulong *value);
public delegate void PFNGLPROGRAMUNIFORM4UI64VNVPROC (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1i64NV (int location, long x);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2i64NV (int location, long x, long y);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3i64NV (int location, long x, long y, long z);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4i64NV (int location, long x, long y, long z, long w);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1i64vNV (int location, uint count,  long *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2i64vNV (int location, uint count,  long *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3i64vNV (int location, uint count,  long *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4i64vNV (int location, uint count,  long *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1ui64NV (int location, ulong x);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2ui64NV (int location, ulong x, ulong y);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3ui64NV (int location, ulong x, ulong y, ulong z);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4ui64NV (int location, ulong x, ulong y, ulong z, ulong w);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform1ui64vNV (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform2ui64vNV (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform3ui64vNV (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniform4ui64vNV (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformi64vNV (uint program, int location, long *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1i64NV (uint program, int location, long x);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2i64NV (uint program, int location, long x, long y);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3i64NV (uint program, int location, long x, long y, long z);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4i64NV (uint program, int location, long x, long y, long z, long w);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1i64vNV (uint program, int location, uint count,  long *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2i64vNV (uint program, int location, uint count,  long *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3i64vNV (uint program, int location, uint count,  long *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4i64vNV (uint program, int location, uint count,  long *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1ui64NV (uint program, int location, ulong x);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2ui64NV (uint program, int location, ulong x, ulong y);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3ui64NV (uint program, int location, ulong x, ulong y, ulong z);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4ui64NV (uint program, int location, ulong x, ulong y, ulong z, ulong w);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform1ui64vNV (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform2ui64vNV (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform3ui64vNV (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniform4ui64vNV (uint program, int location, uint count,  ulong *value);
	public const int GL_NV_internalformat_sample_query = 1;

	public const int GL_MULTISAMPLES_NV = 0x9371;

	public const int GL_SUPERSAMPLE_SCALE_X_NV = 0x9372;

	public const int GL_SUPERSAMPLE_SCALE_Y_NV = 0x9373;

	public const int GL_CONFORMANT_NV = 0x9374;

public delegate void PFNGLGETINTERNALFORMATSAMPLEIVNVPROC (int target, int internalformat, uint samples, int pname, uint count, int *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetInternalformatSampleivNV (int target, int internalformat, uint samples, int pname, uint count, int *prms);
	public const int GL_NV_memory_attachment = 1;

	public const int GL_ATTACHED_MEMORY_OBJECT_NV = 0x95A4;

	public const int GL_ATTACHED_MEMORY_OFFSET_NV = 0x95A5;

	public const int GL_MEMORY_ATTACHABLE_ALIGNMENT_NV = 0x95A6;

	public const int GL_MEMORY_ATTACHABLE_SIZE_NV = 0x95A7;

	public const int GL_MEMORY_ATTACHABLE_NV = 0x95A8;

	public const int GL_DETACHED_MEMORY_INCARNATION_NV = 0x95A9;

	public const int GL_DETACHED_TEXTURES_NV = 0x95AA;

	public const int GL_DETACHED_BUFFERS_NV = 0x95AB;

	public const int GL_MAX_DETACHED_TEXTURES_NV = 0x95AC;

	public const int GL_MAX_DETACHED_BUFFERS_NV = 0x95AD;

public delegate void PFNGLGETMEMORYOBJECTDETACHEDRESOURCESUIVNVPROC (uint memory, int pname, int first, uint count, uint *prms);
public delegate void PFNGLRESETMEMORYOBJECTPARAMETERNVPROC (uint memory, int pname);
public delegate void PFNGLTEXATTACHMEMORYNVPROC (int target, uint memory, ulong offset);
public delegate void PFNGLBUFFERATTACHMEMORYNVPROC (int target, uint memory, ulong offset);
public delegate void PFNGLTEXTUREATTACHMEMORYNVPROC (uint texture, uint memory, ulong offset);
public delegate void PFNGLNAMEDBUFFERATTACHMEMORYNVPROC (uint buffer, uint memory, ulong offset);
	[DllImport("glfw3.dll")]
	public static extern  void glGetMemoryObjectDetachedResourcesuivNV (uint memory, int pname, int first, uint count, uint *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glResetMemoryObjectParameterNV (uint memory, int pname);
	[DllImport("glfw3.dll")]
	public static extern  void glTexAttachMemoryNV (int target, uint memory, ulong offset);
	[DllImport("glfw3.dll")]
	public static extern  void glBufferAttachMemoryNV (int target, uint memory, ulong offset);
	[DllImport("glfw3.dll")]
	public static extern  void glTextureAttachMemoryNV (uint texture, uint memory, ulong offset);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferAttachMemoryNV (uint buffer, uint memory, ulong offset);
	public const int GL_NV_memory_object_sparse = 1;

public delegate void PFNGLBUFFERPAGECOMMITMENTMEMNVPROC (int target, int* offset, uint* size, uint memory, ulong memOffset, int commit);
public delegate void PFNGLTEXPAGECOMMITMENTMEMNVPROC (int target, int layer, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, uint memory, ulong offset, int commit);
public delegate void PFNGLNAMEDBUFFERPAGECOMMITMENTMEMNVPROC (uint buffer, int* offset, uint* size, uint memory, ulong memOffset, int commit);
public delegate void PFNGLTEXTUREPAGECOMMITMENTMEMNVPROC (uint texture, int layer, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, uint memory, ulong offset, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glBufferPageCommitmentMemNV (int target, int* offset, uint* size, uint memory, ulong memOffset, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glTexPageCommitmentMemNV (int target, int layer, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, uint memory, ulong offset, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedBufferPageCommitmentMemNV (uint buffer, int* offset, uint* size, uint memory, ulong memOffset, int commit);
	[DllImport("glfw3.dll")]
	public static extern  void glTexturePageCommitmentMemNV (uint texture, int layer, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, uint memory, ulong offset, int commit);
	public const int GL_NV_mesh_shader = 1;

	public const int GL_MESH_SHADER_NV = 0x9559;

	public const int GL_TASK_SHADER_NV = 0x955A;

	public const int GL_MAX_MESH_UNIFORM_BLOCKS_NV = 0x8E60;

	public const int GL_MAX_MESH_TEXTURE_IMAGE_UNITS_NV = 0x8E61;

	public const int GL_MAX_MESH_IMAGE_UNIFORMS_NV = 0x8E62;

	public const int GL_MAX_MESH_UNIFORM_COMPONENTS_NV = 0x8E63;

	public const int GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV = 0x8E64;

	public const int GL_MAX_MESH_ATOMIC_COUNTERS_NV = 0x8E65;

	public const int GL_MAX_MESH_SHADER_STORAGE_BLOCKS_NV = 0x8E66;

	public const int GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV = 0x8E67;

	public const int GL_MAX_TASK_UNIFORM_BLOCKS_NV = 0x8E68;

	public const int GL_MAX_TASK_TEXTURE_IMAGE_UNITS_NV = 0x8E69;

	public const int GL_MAX_TASK_IMAGE_UNIFORMS_NV = 0x8E6A;

	public const int GL_MAX_TASK_UNIFORM_COMPONENTS_NV = 0x8E6B;

	public const int GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV = 0x8E6C;

	public const int GL_MAX_TASK_ATOMIC_COUNTERS_NV = 0x8E6D;

	public const int GL_MAX_TASK_SHADER_STORAGE_BLOCKS_NV = 0x8E6E;

	public const int GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV = 0x8E6F;

	public const int GL_MAX_MESH_WORK_GROUP_INVOCATIONS_NV = 0x95A2;

	public const int GL_MAX_TASK_WORK_GROUP_INVOCATIONS_NV = 0x95A3;

	public const int GL_MAX_MESH_TOTAL_MEMORY_SIZE_NV = 0x9536;

	public const int GL_MAX_TASK_TOTAL_MEMORY_SIZE_NV = 0x9537;

	public const int GL_MAX_MESH_OUTPUT_VERTICES_NV = 0x9538;

	public const int GL_MAX_MESH_OUTPUT_PRIMITIVES_NV = 0x9539;

	public const int GL_MAX_TASK_OUTPUT_COUNT_NV = 0x953A;

	public const int GL_MAX_DRAW_MESH_TASKS_COUNT_NV = 0x953D;

	public const int GL_MAX_MESH_VIEWS_NV = 0x9557;

	public const int GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV = 0x92DF;

	public const int GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV = 0x9543;

	public const int GL_MAX_MESH_WORK_GROUP_SIZE_NV = 0x953B;

	public const int GL_MAX_TASK_WORK_GROUP_SIZE_NV = 0x953C;

	public const int GL_MESH_WORK_GROUP_SIZE_NV = 0x953E;

	public const int GL_TASK_WORK_GROUP_SIZE_NV = 0x953F;

	public const int GL_MESH_VERTICES_OUT_NV = 0x9579;

	public const int GL_MESH_PRIMITIVES_OUT_NV = 0x957A;

	public const int GL_MESH_OUTPUT_TYPE_NV = 0x957B;

	public const int GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV = 0x959C;

	public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV = 0x959D;

	public const int GL_REFERENCED_BY_MESH_SHADER_NV = 0x95A0;

	public const int GL_REFERENCED_BY_TASK_SHADER_NV = 0x95A1;

	public const int GL_MESH_SHADER_BIT_NV = 0x00000040;

	public const int GL_TASK_SHADER_BIT_NV = 0x00000080;

	public const int GL_MESH_SUBROUTINE_NV = 0x957C;

	public const int GL_TASK_SUBROUTINE_NV = 0x957D;

	public const int GL_MESH_SUBROUTINE_UNIFORM_NV = 0x957E;

	public const int GL_TASK_SUBROUTINE_UNIFORM_NV = 0x957F;

	public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV = 0x959E;

	public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV = 0x959F;

public delegate void PFNGLDRAWMESHTASKSNVPROC (uint first, uint count);
public delegate void PFNGLDRAWMESHTASKSINDIRECTNVPROC (int* indirect);
public delegate void PFNGLMULTIDRAWMESHTASKSINDIRECTNVPROC (int* indirect, uint drawcount, uint stride);
public delegate void PFNGLMULTIDRAWMESHTASKSINDIRECTCOUNTNVPROC (int* indirect, int* drawcount, uint maxdrawcount, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawMeshTasksNV (uint first, uint count);
	[DllImport("glfw3.dll")]
	public static extern  void glDrawMeshTasksIndirectNV (int* indirect);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawMeshTasksIndirectNV (int* indirect, uint drawcount, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glMultiDrawMeshTasksIndirectCountNV (int* indirect, int* drawcount, uint maxdrawcount, uint stride);
	public const int GL_NV_path_rendering = 1;

	public const int GL_PATH_FORMAT_SVG_NV = 0x9070;

	public const int GL_PATH_FORMAT_PS_NV = 0x9071;

	public const int GL_STANDARD_FONT_NAME_NV = 0x9072;

	public const int GL_SYSTEM_FONT_NAME_NV = 0x9073;

	public const int GL_FILE_NAME_NV = 0x9074;

	public const int GL_PATH_STROKE_WIDTH_NV = 0x9075;

	public const int GL_PATH_END_CAPS_NV = 0x9076;

	public const int GL_PATH_INITIAL_END_CAP_NV = 0x9077;

	public const int GL_PATH_TERMINAL_END_CAP_NV = 0x9078;

	public const int GL_PATH_JOIN_STYLE_NV = 0x9079;

	public const int GL_PATH_MITER_LIMIT_NV = 0x907A;

	public const int GL_PATH_DASH_CAPS_NV = 0x907B;

	public const int GL_PATH_INITIAL_DASH_CAP_NV = 0x907C;

	public const int GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D;

	public const int GL_PATH_DASH_OFFSET_NV = 0x907E;

	public const int GL_PATH_CLIENT_LENGTH_NV = 0x907F;

	public const int GL_PATH_FILL_MODE_NV = 0x9080;

	public const int GL_PATH_FILL_MASK_NV = 0x9081;

	public const int GL_PATH_FILL_COVER_MODE_NV = 0x9082;

	public const int GL_PATH_STROKE_COVER_MODE_NV = 0x9083;

	public const int GL_PATH_STROKE_MASK_NV = 0x9084;

	public const int GL_COUNT_UP_NV = 0x9088;

	public const int GL_COUNT_DOWN_NV = 0x9089;

	public const int GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A;

	public const int GL_CONVEX_HULL_NV = 0x908B;

	public const int GL_BOUNDING_BOX_NV = 0x908D;

	public const int GL_TRANSLATE_X_NV = 0x908E;

	public const int GL_TRANSLATE_Y_NV = 0x908F;

	public const int GL_TRANSLATE_2D_NV = 0x9090;

	public const int GL_TRANSLATE_3D_NV = 0x9091;

	public const int GL_AFFINE_2D_NV = 0x9092;

	public const int GL_AFFINE_3D_NV = 0x9094;

	public const int GL_TRANSPOSE_AFFINE_2D_NV = 0x9096;

	public const int GL_TRANSPOSE_AFFINE_3D_NV = 0x9098;

	public const int GL_UTF8_NV = 0x909A;

	public const int GL_UTF16_NV = 0x909B;

	public const int GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C;

	public const int GL_PATH_COMMAND_COUNT_NV = 0x909D;

	public const int GL_PATH_COORD_COUNT_NV = 0x909E;

	public const int GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F;

	public const int GL_PATH_COMPUTED_LENGTH_NV = 0x90A0;

	public const int GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1;

	public const int GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2;

	public const int GL_SQUARE_NV = 0x90A3;

	public const int GL_ROUND_NV = 0x90A4;

	public const int GL_TRIANGULAR_NV = 0x90A5;

	public const int GL_BEVEL_NV = 0x90A6;

	public const int GL_MITER_REVERT_NV = 0x90A7;

	public const int GL_MITER_TRUNCATE_NV = 0x90A8;

	public const int GL_SKIP_MISSING_GLYPH_NV = 0x90A9;

	public const int GL_USE_MISSING_GLYPH_NV = 0x90AA;

	public const int GL_PATH_ERROR_POSITION_NV = 0x90AB;

	public const int GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD;

	public const int GL_ADJACENT_PAIRS_NV = 0x90AE;

	public const int GL_FIRST_TO_REST_NV = 0x90AF;

	public const int GL_PATH_GEN_MODE_NV = 0x90B0;

	public const int GL_PATH_GEN_COEFF_NV = 0x90B1;

	public const int GL_PATH_GEN_COMPONENTS_NV = 0x90B3;

	public const int GL_PATH_STENCIL_FUNC_NV = 0x90B7;

	public const int GL_PATH_STENCIL_REF_NV = 0x90B8;

	public const int GL_PATH_STENCIL_VALUE_MASK_NV = 0x90B9;

	public const int GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;

	public const int GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;

	public const int GL_PATH_COVER_DEPTH_FUNC_NV = 0x90BF;

	public const int GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4;

	public const int GL_MOVE_TO_RESETS_NV = 0x90B5;

	public const int GL_MOVE_TO_CONTINUES_NV = 0x90B6;

	public const int GL_CLOSE_PATH_NV = 0x00;

	public const int GL_MOVE_TO_NV = 0x02;

	public const int GL_RELATIVE_MOVE_TO_NV = 0x03;

	public const int GL_LINE_TO_NV = 0x04;

	public const int GL_RELATIVE_LINE_TO_NV = 0x05;

	public const int GL_HORIZONTAL_LINE_TO_NV = 0x06;

	public const int GL_RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07;

	public const int GL_VERTICAL_LINE_TO_NV = 0x08;

	public const int GL_RELATIVE_VERTICAL_LINE_TO_NV = 0x09;

	public const int GL_QUADRATIC_CURVE_TO_NV = 0x0A;

	public const int GL_RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B;

	public const int GL_CUBIC_CURVE_TO_NV = 0x0C;

	public const int GL_RELATIVE_CUBIC_CURVE_TO_NV = 0x0D;

	public const int GL_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E;

	public const int GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F;

	public const int GL_SMOOTH_CUBIC_CURVE_TO_NV = 0x10;

	public const int GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11;

	public const int GL_SMALL_CCW_ARC_TO_NV = 0x12;

	public const int GL_RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13;

	public const int GL_SMALL_CW_ARC_TO_NV = 0x14;

	public const int GL_RELATIVE_SMALL_CW_ARC_TO_NV = 0x15;

	public const int GL_LARGE_CCW_ARC_TO_NV = 0x16;

	public const int GL_RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17;

	public const int GL_LARGE_CW_ARC_TO_NV = 0x18;

	public const int GL_RELATIVE_LARGE_CW_ARC_TO_NV = 0x19;

	public const int GL_RESTART_PATH_NV = 0xF0;

	public const int GL_DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2;

	public const int GL_DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4;

	public const int GL_RECT_NV = 0xF6;

	public const int GL_CIRCULAR_CCW_ARC_TO_NV = 0xF8;

	public const int GL_CIRCULAR_CW_ARC_TO_NV = 0xFA;

	public const int GL_CIRCULAR_TANGENT_ARC_TO_NV = 0xFC;

	public const int GL_ARC_TO_NV = 0xFE;

	public const int GL_RELATIVE_ARC_TO_NV = 0xFF;

	public const int GL_BOLD_BIT_NV = 0x01;

	public const int GL_ITALIC_BIT_NV = 0x02;

	public const int GL_GLYPH_WIDTH_BIT_NV = 0x01;

	public const int GL_GLYPH_HEIGHT_BIT_NV = 0x02;

	public const int GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04;

	public const int GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08;

	public const int GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10;

	public const int GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20;

	public const int GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40;

	public const int GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80;

	public const int GL_GLYPH_HAS_KERNING_BIT_NV = 0x100;

	public const int GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000;

	public const int GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000;

	public const int GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000;

	public const int GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000;

	public const int GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000;

	public const int GL_FONT_ASCENDER_BIT_NV = 0x00200000;

	public const int GL_FONT_DESCENDER_BIT_NV = 0x00400000;

	public const int GL_FONT_HEIGHT_BIT_NV = 0x00800000;

	public const int GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000;

	public const int GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000;

	public const int GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000;

	public const int GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000;

	public const int GL_FONT_HAS_KERNING_BIT_NV = 0x10000000;

	public const int GL_ROUNDED_RECT_NV = 0xE8;

	public const int GL_RELATIVE_ROUNDED_RECT_NV = 0xE9;

	public const int GL_ROUNDED_RECT2_NV = 0xEA;

	public const int GL_RELATIVE_ROUNDED_RECT2_NV = 0xEB;

	public const int GL_ROUNDED_RECT4_NV = 0xEC;

	public const int GL_RELATIVE_ROUNDED_RECT4_NV = 0xED;

	public const int GL_ROUNDED_RECT8_NV = 0xEE;

	public const int GL_RELATIVE_ROUNDED_RECT8_NV = 0xEF;

	public const int GL_RELATIVE_RECT_NV = 0xF7;

	public const int GL_FONT_GLYPHS_AVAILABLE_NV = 0x9368;

	public const int GL_FONT_TARGET_UNAVAILABLE_NV = 0x9369;

	public const int GL_FONT_UNAVAILABLE_NV = 0x936A;

	public const int GL_FONT_UNINTELLIGIBLE_NV = 0x936B;

	public const int GL_CONIC_CURVE_TO_NV = 0x1A;

	public const int GL_RELATIVE_CONIC_CURVE_TO_NV = 0x1B;

	public const int GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000;

	public const int GL_STANDARD_FONT_FORMAT_NV = 0x936C;

	public const int GL_PATH_PROJECTION_NV = 0x1701;

	public const int GL_PATH_MODELVIEW_NV = 0x1700;

	public const int GL_PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3;

	public const int GL_PATH_MODELVIEW_MATRIX_NV = 0x0BA6;

	public const int GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36;

	public const int GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3;

	public const int GL_PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4;

	public const int GL_PATH_PROJECTION_MATRIX_NV = 0x0BA7;

	public const int GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38;

	public const int GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4;

	public const int GL_FRAGMENT_INPUT_NV = 0x936D;

public delegate void PFNGLDELETEPATHSNVPROC (uint path, uint range);
public delegate void PFNGLPATHCOMMANDSNVPROC (uint path, uint numCommands,  byte *commands, uint numCoords, int coordType,  void *coords);
public delegate void PFNGLPATHCOORDSNVPROC (uint path, uint numCoords, int coordType,  void *coords);
public delegate void PFNGLPATHSUBCOMMANDSNVPROC (uint path, uint commandStart, uint commandsToDelete, uint numCommands,  byte *commands, uint numCoords, int coordType,  void *coords);
public delegate void PFNGLPATHSUBCOORDSNVPROC (uint path, uint coordStart, uint numCoords, int coordType,  void *coords);
public delegate void PFNGLPATHSTRINGNVPROC (uint path, int format, uint length,  void *pathString);
public delegate void PFNGLPATHGLYPHSNVPROC (uint firstPathName, int fontTarget,  void *fontName, int fontStyle, uint numGlyphs, int type,  void *charcodes, int handleMissingGlyphs, uint pathParameterTemplate, float emScale);
public delegate void PFNGLPATHGLYPHRANGENVPROC (uint firstPathName, int fontTarget,  void *fontName, int fontStyle, uint firstGlyph, uint numGlyphs, int handleMissingGlyphs, uint pathParameterTemplate, float emScale);
public delegate void PFNGLWEIGHTPATHSNVPROC (uint resultPath, uint numPaths,  uint *paths,  float *weights);
public delegate void PFNGLCOPYPATHNVPROC (uint resultPath, uint srcPath);
public delegate void PFNGLINTERPOLATEPATHSNVPROC (uint resultPath, uint pathA, uint pathB, float weight);
public delegate void PFNGLTRANSFORMPATHNVPROC (uint resultPath, uint srcPath, int transformType,  float *transformValues);
public delegate void PFNGLPATHPARAMETERIVNVPROC (uint path, int pname,  int *value);
public delegate void PFNGLPATHPARAMETERINVPROC (uint path, int pname, int value);
public delegate void PFNGLPATHPARAMETERFVNVPROC (uint path, int pname,  float *value);
public delegate void PFNGLPATHPARAMETERFNVPROC (uint path, int pname, float value);
public delegate void PFNGLPATHDASHARRAYNVPROC (uint path, uint dashCount,  float *dashArray);
public delegate void PFNGLPATHSTENCILFUNCNVPROC (int func, int reference, uint mask);
public delegate void PFNGLPATHSTENCILDEPTHOFFSETNVPROC (float factor, float units);
public delegate void PFNGLSTENCILFILLPATHNVPROC (uint path, int fillMode, uint mask);
public delegate void PFNGLSTENCILSTROKEPATHNVPROC (uint path, int referenceerence, uint mask);
public delegate void PFNGLSTENCILFILLPATHINSTANCEDNVPROC (uint numPaths, int pathNameType,  void *paths, uint pathBase, int fillMode, uint mask, int transformType,  float *transformValues);
public delegate void PFNGLSTENCILSTROKEPATHINSTANCEDNVPROC (uint numPaths, int pathNameType,  void *paths, uint pathBase, int referenceerence, uint mask, int transformType,  float *transformValues);
public delegate void PFNGLPATHCOVERDEPTHFUNCNVPROC (int func);
public delegate void PFNGLCOVERFILLPATHNVPROC (uint path, int coverMode);
public delegate void PFNGLCOVERSTROKEPATHNVPROC (uint path, int coverMode);
public delegate void PFNGLCOVERFILLPATHINSTANCEDNVPROC (uint numPaths, int pathNameType,  void *paths, uint pathBase, int coverMode, int transformType,  float *transformValues);
public delegate void PFNGLCOVERSTROKEPATHINSTANCEDNVPROC (uint numPaths, int pathNameType,  void *paths, uint pathBase, int coverMode, int transformType,  float *transformValues);
public delegate void PFNGLGETPATHPARAMETERIVNVPROC (uint path, int pname, int *value);
public delegate void PFNGLGETPATHPARAMETERFVNVPROC (uint path, int pname, float *value);
public delegate void PFNGLGETPATHCOMMANDSNVPROC (uint path, byte *commands);
public delegate void PFNGLGETPATHCOORDSNVPROC (uint path, float *coords);
public delegate void PFNGLGETPATHDASHARRAYNVPROC (uint path, float *dashArray);
public delegate void PFNGLGETPATHMETRICSNVPROC (int metricQueryMask, uint numPaths, int pathNameType,  void *paths, uint pathBase, uint stride, float *metrics);
public delegate void PFNGLGETPATHMETRICRANGENVPROC (int metricQueryMask, uint firstPathName, uint numPaths, uint stride, float *metrics);
public delegate void PFNGLGETPATHSPACINGNVPROC (int pathListMode, uint numPaths, int pathNameType,  void *paths, uint pathBase, float advanceScale, float kerningScale, int transformType, float *returnedSpacing);
public delegate void PFNGLMATRIXLOAD3X2FNVPROC (int matrixMode,  float *m);
public delegate void PFNGLMATRIXLOAD3X3FNVPROC (int matrixMode,  float *m);
public delegate void PFNGLMATRIXLOADTRANSPOSE3X3FNVPROC (int matrixMode,  float *m);
public delegate void PFNGLMATRIXMULT3X2FNVPROC (int matrixMode,  float *m);
public delegate void PFNGLMATRIXMULT3X3FNVPROC (int matrixMode,  float *m);
public delegate void PFNGLMATRIXMULTTRANSPOSE3X3FNVPROC (int matrixMode,  float *m);
public delegate void PFNGLSTENCILTHENCOVERFILLPATHNVPROC (uint path, int fillMode, uint mask, int coverMode);
public delegate void PFNGLSTENCILTHENCOVERSTROKEPATHNVPROC (uint path, int referenceerence, uint mask, int coverMode);
public delegate void PFNGLSTENCILTHENCOVERFILLPATHINSTANCEDNVPROC (uint numPaths, int pathNameType,  void *paths, uint pathBase, int fillMode, uint mask, int coverMode, int transformType,  float *transformValues);
public delegate void PFNGLSTENCILTHENCOVERSTROKEPATHINSTANCEDNVPROC (uint numPaths, int pathNameType,  void *paths, uint pathBase, int referenceerence, uint mask, int coverMode, int transformType,  float *transformValues);
public delegate void PFNGLPROGRAMPATHFRAGMENTINPUTGENNVPROC (uint program, int location, int genMode, int components,  float *coeffs);
public delegate void PFNGLGETPROGRAMRESOURCEFVNVPROC (uint program, int programInterface, uint index, uint propCount,  int *props, uint count, uint *length, float *prms);
	[DllImport("glfw3.dll")]
	public static extern  uint glGenPathsNV (uint range);
	[DllImport("glfw3.dll")]
	public static extern  void glDeletePathsNV (uint path, uint range);
	[DllImport("glfw3.dll")]
	public static extern  int glIsPathNV (uint path);
	[DllImport("glfw3.dll")]
	public static extern  void glPathCommandsNV (uint path, uint numCommands,  byte *commands, uint numCoords, int coordType,  void *coords);
	[DllImport("glfw3.dll")]
	public static extern  void glPathCoordsNV (uint path, uint numCoords, int coordType,  void *coords);
	[DllImport("glfw3.dll")]
	public static extern  void glPathSubCommandsNV (uint path, uint commandStart, uint commandsToDelete, uint numCommands,  byte *commands, uint numCoords, int coordType,  void *coords);
	[DllImport("glfw3.dll")]
	public static extern  void glPathSubCoordsNV (uint path, uint coordStart, uint numCoords, int coordType,  void *coords);
	[DllImport("glfw3.dll")]
	public static extern  void glPathStringNV (uint path, int format, uint length,  void *pathString);
	[DllImport("glfw3.dll")]
	public static extern  void glPathGlyphsNV (uint firstPathName, int fontTarget,  void *fontName, int fontStyle, uint numGlyphs, int type,  void *charcodes, int handleMissingGlyphs, uint pathParameterTemplate, float emScale);
	[DllImport("glfw3.dll")]
	public static extern  void glPathGlyphRangeNV (uint firstPathName, int fontTarget,  void *fontName, int fontStyle, uint firstGlyph, uint numGlyphs, int handleMissingGlyphs, uint pathParameterTemplate, float emScale);
	[DllImport("glfw3.dll")]
	public static extern  void glWeightPathsNV (uint resultPath, uint numPaths,  uint *paths,  float *weights);
	[DllImport("glfw3.dll")]
	public static extern  void glCopyPathNV (uint resultPath, uint srcPath);
	[DllImport("glfw3.dll")]
	public static extern  void glInterpolatePathsNV (uint resultPath, uint pathA, uint pathB, float weight);
	[DllImport("glfw3.dll")]
	public static extern  void glTransformPathNV (uint resultPath, uint srcPath, int transformType,  float *transformValues);
	[DllImport("glfw3.dll")]
	public static extern  void glPathParameterivNV (uint path, int pname,  int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glPathParameteriNV (uint path, int pname, int value);
	[DllImport("glfw3.dll")]
	public static extern  void glPathParameterfvNV (uint path, int pname,  float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glPathParameterfNV (uint path, int pname, float value);
	[DllImport("glfw3.dll")]
	public static extern  void glPathDashArrayNV (uint path, uint dashCount,  float *dashArray);
	[DllImport("glfw3.dll")]
	public static extern  void glPathStencilFuncNV (int func, int reference, uint mask);
	[DllImport("glfw3.dll")]
	public static extern  void glPathStencilDepthOffsetNV (float factor, float units);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilFillPathNV (uint path, int fillMode, uint mask);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilStrokePathNV (uint path, int referenceerence, uint mask);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilFillPathInstancedNV (uint numPaths, int pathNameType,  void *paths, uint pathBase, int fillMode, uint mask, int transformType,  float *transformValues);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilStrokePathInstancedNV (uint numPaths, int pathNameType,  void *paths, uint pathBase, int referenceerence, uint mask, int transformType,  float *transformValues);
	[DllImport("glfw3.dll")]
	public static extern  void glPathCoverDepthFuncNV (int func);
	[DllImport("glfw3.dll")]
	public static extern  void glCoverFillPathNV (uint path, int coverMode);
	[DllImport("glfw3.dll")]
	public static extern  void glCoverStrokePathNV (uint path, int coverMode);
	[DllImport("glfw3.dll")]
	public static extern  void glCoverFillPathInstancedNV (uint numPaths, int pathNameType,  void *paths, uint pathBase, int coverMode, int transformType,  float *transformValues);
	[DllImport("glfw3.dll")]
	public static extern  void glCoverStrokePathInstancedNV (uint numPaths, int pathNameType,  void *paths, uint pathBase, int coverMode, int transformType,  float *transformValues);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPathParameterivNV (uint path, int pname, int *value);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPathParameterfvNV (uint path, int pname, float *value);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPathCommandsNV (uint path, byte *commands);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPathCoordsNV (uint path, float *coords);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPathDashArrayNV (uint path, float *dashArray);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPathMetricsNV (int metricQueryMask, uint numPaths, int pathNameType,  void *paths, uint pathBase, uint stride, float *metrics);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPathMetricRangeNV (int metricQueryMask, uint firstPathName, uint numPaths, uint stride, float *metrics);
	[DllImport("glfw3.dll")]
	public static extern  void glGetPathSpacingNV (int pathListMode, uint numPaths, int pathNameType,  void *paths, uint pathBase, float advanceScale, float kerningScale, int transformType, float *returnedSpacing);
	[DllImport("glfw3.dll")]
	public static extern  int glIsPointInFillPathNV (uint path, uint mask, float x, float y);
	[DllImport("glfw3.dll")]
	public static extern  int glIsPointInStrokePathNV (uint path, float x, float y);
	[DllImport("glfw3.dll")]
	public static extern  float glGetPathLengthNV (uint path, uint startSegment, uint numSegments);
	[DllImport("glfw3.dll")]
	public static extern  int glPointAlongPathNV (uint path, uint startSegment, uint numSegments, float distance, float *x, float *y, float *tangentX, float *tangentY);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixLoad3x2fNV (int matrixMode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixLoad3x3fNV (int matrixMode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixLoadTranspose3x3fNV (int matrixMode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixMult3x2fNV (int matrixMode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixMult3x3fNV (int matrixMode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glMatrixMultTranspose3x3fNV (int matrixMode,  float *m);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilThenCoverFillPathNV (uint path, int fillMode, uint mask, int coverMode);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilThenCoverStrokePathNV (uint path, int referenceerence, uint mask, int coverMode);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilThenCoverFillPathInstancedNV (uint numPaths, int pathNameType,  void *paths, uint pathBase, int fillMode, uint mask, int coverMode, int transformType,  float *transformValues);
	[DllImport("glfw3.dll")]
	public static extern  void glStencilThenCoverStrokePathInstancedNV (uint numPaths, int pathNameType,  void *paths, uint pathBase, int referenceerence, uint mask, int coverMode, int transformType,  float *transformValues);
	[DllImport("glfw3.dll")]
	public static extern  int glPathGlyphIndexRangeNV (int fontTarget,  void *fontName, int fontStyle, uint pathParameterTemplate, float emScale, uint *baseAndCount);
	[DllImport("glfw3.dll")]
	public static extern  int glPathGlyphIndexArrayNV (uint firstPathName, int fontTarget,  void *fontName, int fontStyle, uint firstGlyphIndex, uint numGlyphs, uint pathParameterTemplate, float emScale);
	[DllImport("glfw3.dll")]
	public static extern  int glPathMemoryGlyphIndexArrayNV (uint firstPathName, int fontTarget, uint* fontSize,  void *fontData, uint faceIndex, uint firstGlyphIndex, uint numGlyphs, uint pathParameterTemplate, float emScale);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramPathFragmentInputGenNV (uint program, int location, int genMode, int components,  float *coeffs);
	[DllImport("glfw3.dll")]
	public static extern  void glGetProgramResourcefvNV (uint program, int programInterface, uint index, uint propCount,  int *props, uint count, uint *length, float *prms);
	public const int GL_NV_path_rendering_shared_edge = 1;

	public const int GL_SHARED_EDGE_NV = 0xC0;

	public const int GL_NV_primitive_shading_rate = 1;

	public const int GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV = 0x95B1;

	public const int GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV = 0x95B2;

	public const int GL_NV_representative_fragment_test = 1;

	public const int GL_REPRESENTATIVE_FRAGMENT_TEST_NV = 0x937F;

	public const int GL_NV_sample_locations = 1;

	public const int GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D;

	public const int GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E;

	public const int GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F;

	public const int GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340;

	public const int GL_SAMPLE_LOCATION_NV = 0x8E50;

	public const int GL_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341;

	public const int GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342;

	public const int GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343;

public delegate void PFNGLFRAMEBUFFERSAMPLELOCATIONSFVNVPROC (int target, uint start, uint count,  float *v);
public delegate void PFNGLNAMEDFRAMEBUFFERSAMPLELOCATIONSFVNVPROC (uint framebuffer, uint start, uint count,  float *v);
public delegate void PFNGLRESOLVEDEPTHVALUESNVPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferSampleLocationsfvNV (int target, uint start, uint count,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glNamedFramebufferSampleLocationsfvNV (uint framebuffer, uint start, uint count,  float *v);
	[DllImport("glfw3.dll")]
	public static extern  void glResolveDepthValuesNV ();
	public const int GL_NV_sample_mask_override_coverage = 1;

	public const int GL_NV_scissor_exclusive = 1;

	public const int GL_SCISSOR_TEST_EXCLUSIVE_NV = 0x9555;

	public const int GL_SCISSOR_BOX_EXCLUSIVE_NV = 0x9556;

public delegate void PFNGLSCISSOREXCLUSIVENVPROC (int x, int y, uint width, uint height);
public delegate void PFNGLSCISSOREXCLUSIVEARRAYVNVPROC (uint first, uint count,  int *v);
	[DllImport("glfw3.dll")]
	public static extern  void glScissorExclusiveNV (int x, int y, uint width, uint height);
	[DllImport("glfw3.dll")]
	public static extern  void glScissorExclusiveArrayvNV (uint first, uint count,  int *v);
	public const int GL_NV_shader_atomic_counters = 1;

	public const int GL_NV_shader_atomic_float = 1;

	public const int GL_NV_shader_atomic_float64 = 1;

	public const int GL_NV_shader_atomic_fp16_vector = 1;

	public const int GL_NV_shader_atomic_int64 = 1;

	public const int GL_NV_shader_buffer_load = 1;

	public const int GL_BUFFER_GPU_ADDRESS_NV = 0x8F1D;

	public const int GL_GPU_ADDRESS_NV = 0x8F34;

	public const int GL_MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;

public delegate void PFNGLMAKEBUFFERRESIDENTNVPROC (int target, int access);
public delegate void PFNGLMAKEBUFFERNONRESIDENTNVPROC (int target);
public delegate void PFNGLMAKENAMEDBUFFERRESIDENTNVPROC (uint buffer, int access);
public delegate void PFNGLMAKENAMEDBUFFERNONRESIDENTNVPROC (uint buffer);
public delegate void PFNGLGETBUFFERPARAMETERUI64VNVPROC (int target, int pname, ulong *prms);
public delegate void PFNGLGETNAMEDBUFFERPARAMETERUI64VNVPROC (uint buffer, int pname, ulong *prms);
public delegate void PFNGLGETINTEGERUI64VNVPROC (int value, ulong *result);
public delegate void PFNGLUNIFORMUI64NVPROC (int location, ulong value);
public delegate void PFNGLUNIFORMUI64VNVPROC (int location, uint count,  ulong *value);
public delegate void PFNGLGETUNIFORMUI64VNVPROC (uint program, int location, ulong *prms);
public delegate void PFNGLPROGRAMUNIFORMUI64NVPROC (uint program, int location, ulong value);
public delegate void PFNGLPROGRAMUNIFORMUI64VNVPROC (uint program, int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeBufferResidentNV (int target, int access);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeBufferNonResidentNV (int target);
	[DllImport("glfw3.dll")]
	public static extern  int glIsBufferResidentNV (int target);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeNamedBufferResidentNV (uint buffer, int access);
	[DllImport("glfw3.dll")]
	public static extern  void glMakeNamedBufferNonResidentNV (uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  int glIsNamedBufferResidentNV (uint buffer);
	[DllImport("glfw3.dll")]
	public static extern  void glGetBufferParameterui64vNV (int target, int pname, ulong *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetNamedBufferParameterui64vNV (uint buffer, int pname, ulong *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetIntegerui64vNV (int value, ulong *result);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformui64NV (int location, ulong value);
	[DllImport("glfw3.dll")]
	public static extern  void glUniformui64vNV (int location, uint count,  ulong *value);
	[DllImport("glfw3.dll")]
	public static extern  void glGetUniformui64vNV (uint program, int location, ulong *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformui64NV (uint program, int location, ulong value);
	[DllImport("glfw3.dll")]
	public static extern  void glProgramUniformui64vNV (uint program, int location, uint count,  ulong *value);
	public const int GL_NV_shader_buffer_store = 1;

	public const int GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010;

	public const int GL_NV_shader_subgroup_partitioned = 1;

	public const int GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 0x00000100;

	public const int GL_NV_shader_texture_footprint = 1;

	public const int GL_NV_shader_thread_group = 1;

	public const int GL_WARP_SIZE_NV = 0x9339;

	public const int GL_WARPS_PER_SM_NV = 0x933A;

	public const int GL_SM_COUNT_NV = 0x933B;

	public const int GL_NV_shader_thread_shuffle = 1;

	public const int GL_NV_shading_rate_image = 1;

	public const int GL_SHADING_RATE_IMAGE_NV = 0x9563;

	public const int GL_SHADING_RATE_NO_INVOCATIONS_NV = 0x9564;

	public const int GL_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = 0x9565;

	public const int GL_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = 0x9566;

	public const int GL_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = 0x9567;

	public const int GL_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = 0x9568;

	public const int GL_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = 0x9569;

	public const int GL_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = 0x956A;

	public const int GL_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = 0x956B;

	public const int GL_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = 0x956C;

	public const int GL_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = 0x956D;

	public const int GL_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = 0x956E;

	public const int GL_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = 0x956F;

	public const int GL_SHADING_RATE_IMAGE_BINDING_NV = 0x955B;

	public const int GL_SHADING_RATE_IMAGE_TEXEL_WIDTH_NV = 0x955C;

	public const int GL_SHADING_RATE_IMAGE_TEXEL_HEIGHT_NV = 0x955D;

	public const int GL_SHADING_RATE_IMAGE_PALETTE_SIZE_NV = 0x955E;

	public const int GL_MAX_COARSE_FRAGMENT_SAMPLES_NV = 0x955F;

	public const int GL_SHADING_RATE_SAMPLE_ORDER_DEFAULT_NV = 0x95AE;

	public const int GL_SHADING_RATE_SAMPLE_ORDER_PIXEL_MAJOR_NV = 0x95AF;

	public const int GL_SHADING_RATE_SAMPLE_ORDER_SAMPLE_MAJOR_NV = 0x95B0;

public delegate void PFNGLBINDSHADINGRATEIMAGENVPROC (uint texture);
public delegate void PFNGLGETSHADINGRATEIMAGEPALETTENVPROC (uint viewport, uint entry, int *rate);
public delegate void PFNGLGETSHADINGRATESAMPLELOCATIONIVNVPROC (int rate, uint samples, uint index, int *location);
public delegate void PFNGLSHADINGRATEIMAGEBARRIERNVPROC (int synchronize);
public delegate void PFNGLSHADINGRATEIMAGEPALETTENVPROC (uint viewport, uint first, uint count,  int *rates);
public delegate void PFNGLSHADINGRATESAMPLEORDERNVPROC (int order);
public delegate void PFNGLSHADINGRATESAMPLEORDERCUSTOMNVPROC (int rate, uint samples,  int *locations);
	[DllImport("glfw3.dll")]
	public static extern  void glBindShadingRateImageNV (uint texture);
	[DllImport("glfw3.dll")]
	public static extern  void glGetShadingRateImagePaletteNV (uint viewport, uint entry, int *rate);
	[DllImport("glfw3.dll")]
	public static extern  void glGetShadingRateSampleLocationivNV (int rate, uint samples, uint index, int *location);
	[DllImport("glfw3.dll")]
	public static extern  void glShadingRateImageBarrierNV (int synchronize);
	[DllImport("glfw3.dll")]
	public static extern  void glShadingRateImagePaletteNV (uint viewport, uint first, uint count,  int *rates);
	[DllImport("glfw3.dll")]
	public static extern  void glShadingRateSampleOrderNV (int order);
	[DllImport("glfw3.dll")]
	public static extern  void glShadingRateSampleOrderCustomNV (int rate, uint samples,  int *locations);
	public const int GL_NV_stereo_view_rendering = 1;

	public const int GL_NV_texture_barrier = 1;

public delegate void PFNGLTEXTUREBARRIERNVPROC ();
	[DllImport("glfw3.dll")]
	public static extern  void glTextureBarrierNV ();
	public const int GL_NV_texture_rectangle_compressed = 1;

	public const int GL_NV_uniform_buffer_unified_memory = 1;

	public const int GL_UNIFORM_BUFFER_UNIFIED_NV = 0x936E;

	public const int GL_UNIFORM_BUFFER_ADDRESS_NV = 0x936F;

	public const int GL_UNIFORM_BUFFER_LENGTH_NV = 0x9370;

	public const int GL_NV_vertex_attrib_integer_64bit = 1;

public delegate void PFNGLVERTEXATTRIBL1I64NVPROC (uint index, long x);
public delegate void PFNGLVERTEXATTRIBL2I64NVPROC (uint index, long x, long y);
public delegate void PFNGLVERTEXATTRIBL3I64NVPROC (uint index, long x, long y, long z);
public delegate void PFNGLVERTEXATTRIBL4I64NVPROC (uint index, long x, long y, long z, long w);
public delegate void PFNGLVERTEXATTRIBL1I64VNVPROC (uint index,  long *v);
public delegate void PFNGLVERTEXATTRIBL2I64VNVPROC (uint index,  long *v);
public delegate void PFNGLVERTEXATTRIBL3I64VNVPROC (uint index,  long *v);
public delegate void PFNGLVERTEXATTRIBL4I64VNVPROC (uint index,  long *v);
public delegate void PFNGLVERTEXATTRIBL1UI64NVPROC (uint index, ulong x);
public delegate void PFNGLVERTEXATTRIBL2UI64NVPROC (uint index, ulong x, ulong y);
public delegate void PFNGLVERTEXATTRIBL3UI64NVPROC (uint index, ulong x, ulong y, ulong z);
public delegate void PFNGLVERTEXATTRIBL4UI64NVPROC (uint index, ulong x, ulong y, ulong z, ulong w);
public delegate void PFNGLVERTEXATTRIBL1UI64VNVPROC (uint index,  ulong *v);
public delegate void PFNGLVERTEXATTRIBL2UI64VNVPROC (uint index,  ulong *v);
public delegate void PFNGLVERTEXATTRIBL3UI64VNVPROC (uint index,  ulong *v);
public delegate void PFNGLVERTEXATTRIBL4UI64VNVPROC (uint index,  ulong *v);
public delegate void PFNGLGETVERTEXATTRIBLI64VNVPROC (uint index, int pname, long *prms);
public delegate void PFNGLGETVERTEXATTRIBLUI64VNVPROC (uint index, int pname, ulong *prms);
public delegate void PFNGLVERTEXATTRIBLFORMATNVPROC (uint index, int size, int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL1i64NV (uint index, long x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL2i64NV (uint index, long x, long y);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL3i64NV (uint index, long x, long y, long z);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL4i64NV (uint index, long x, long y, long z, long w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL1i64vNV (uint index,  long *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL2i64vNV (uint index,  long *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL3i64vNV (uint index,  long *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL4i64vNV (uint index,  long *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL1ui64NV (uint index, ulong x);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL2ui64NV (uint index, ulong x, ulong y);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL3ui64NV (uint index, ulong x, ulong y, ulong z);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL4ui64NV (uint index, ulong x, ulong y, ulong z, ulong w);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL1ui64vNV (uint index,  ulong *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL2ui64vNV (uint index,  ulong *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL3ui64vNV (uint index,  ulong *v);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribL4ui64vNV (uint index,  ulong *v);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribLi64vNV (uint index, int pname, long *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glGetVertexAttribLui64vNV (uint index, int pname, ulong *prms);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribLFormatNV (uint index, int size, int type, uint stride);
	public const int GL_NV_vertex_buffer_unified_memory = 1;

	public const int GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E;

	public const int GL_ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F;

	public const int GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20;

	public const int GL_VERTEX_ARRAY_ADDRESS_NV = 0x8F21;

	public const int GL_NORMAL_ARRAY_ADDRESS_NV = 0x8F22;

	public const int GL_COLOR_ARRAY_ADDRESS_NV = 0x8F23;

	public const int GL_INDEX_ARRAY_ADDRESS_NV = 0x8F24;

	public const int GL_TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25;

	public const int GL_EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26;

	public const int GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27;

	public const int GL_FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28;

	public const int GL_ELEMENT_ARRAY_ADDRESS_NV = 0x8F29;

	public const int GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A;

	public const int GL_VERTEX_ARRAY_LENGTH_NV = 0x8F2B;

	public const int GL_NORMAL_ARRAY_LENGTH_NV = 0x8F2C;

	public const int GL_COLOR_ARRAY_LENGTH_NV = 0x8F2D;

	public const int GL_INDEX_ARRAY_LENGTH_NV = 0x8F2E;

	public const int GL_TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F;

	public const int GL_EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30;

	public const int GL_SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31;

	public const int GL_FOG_COORD_ARRAY_LENGTH_NV = 0x8F32;

	public const int GL_ELEMENT_ARRAY_LENGTH_NV = 0x8F33;

	public const int GL_DRAW_INDIRECT_UNIFIED_NV = 0x8F40;

	public const int GL_DRAW_INDIRECT_ADDRESS_NV = 0x8F41;

	public const int GL_DRAW_INDIRECT_LENGTH_NV = 0x8F42;

public delegate void PFNGLBUFFERADDRESSRANGENVPROC (int pname, uint index, ulong address, uint* length);
public delegate void PFNGLVERTEXFORMATNVPROC (int size, int type, uint stride);
public delegate void PFNGLNORMALFORMATNVPROC (int type, uint stride);
public delegate void PFNGLCOLORFORMATNVPROC (int size, int type, uint stride);
public delegate void PFNGLINDEXFORMATNVPROC (int type, uint stride);
public delegate void PFNGLTEXCOORDFORMATNVPROC (int size, int type, uint stride);
public delegate void PFNGLEDGEFLAGFORMATNVPROC (uint stride);
public delegate void PFNGLSECONDARYCOLORFORMATNVPROC (int size, int type, uint stride);
public delegate void PFNGLFOGCOORDFORMATNVPROC (int type, uint stride);
public delegate void PFNGLVERTEXATTRIBFORMATNVPROC (uint index, int size, int type, int normalized, uint stride);
public delegate void PFNGLVERTEXATTRIBIFORMATNVPROC (uint index, int size, int type, uint stride);
public delegate void PFNGLGETINTEGERUI64I_VNVPROC (int value, uint index, ulong *result);
	[DllImport("glfw3.dll")]
	public static extern  void glBufferAddressRangeNV (int pname, uint index, ulong address, uint* length);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexFormatNV (int size, int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glNormalFormatNV (int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glColorFormatNV (int size, int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glIndexFormatNV (int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glTexCoordFormatNV (int size, int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glEdgeFlagFormatNV (uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glSecondaryColorFormatNV (int size, int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glFogCoordFormatNV (int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribFormatNV (uint index, int size, int type, int normalized, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glVertexAttribIFormatNV (uint index, int size, int type, uint stride);
	[DllImport("glfw3.dll")]
	public static extern  void glGetIntegerui64i_vNV (int value, uint index, ulong *result);
	public const int GL_NV_viewport_array2 = 1;

	public const int GL_NV_viewport_swizzle = 1;

	public const int GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350;

	public const int GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351;

	public const int GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352;

	public const int GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353;

	public const int GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354;

	public const int GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355;

	public const int GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356;

	public const int GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357;

	public const int GL_VIEWPORT_SWIZZLE_X_NV = 0x9358;

	public const int GL_VIEWPORT_SWIZZLE_Y_NV = 0x9359;

	public const int GL_VIEWPORT_SWIZZLE_Z_NV = 0x935A;

	public const int GL_VIEWPORT_SWIZZLE_W_NV = 0x935B;

public delegate void PFNGLVIEWPORTSWIZZLENVPROC (uint index, int swizzlex, int swizzley, int swizzlez, int swizzlew);
	[DllImport("glfw3.dll")]
	public static extern  void glViewportSwizzleNV (uint index, int swizzlex, int swizzley, int swizzlez, int swizzlew);
	public const int GL_OVR_multiview = 1;

	public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630;

	public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632;

	public const int GL_MAX_VIEWS_OVR = 0x9631;

	public const int GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR = 0x9633;

public delegate void PFNGLFRAMEBUFFERTEXTUREMULTIVIEWOVRPROC (int target, int attachment, uint texture, int level, int baseViewIndex, uint numViews);
	[DllImport("glfw3.dll")]
	public static extern  void glFramebufferTextureMultiviewOVR (int target, int attachment, uint texture, int level, int baseViewIndex, uint numViews);
	public const int GL_OVR_multiview2 = 1;

}
