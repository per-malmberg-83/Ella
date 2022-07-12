using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingsGenerator
{
    internal class GLGenerator
    {
        public void Generate()
        {
            var lines = File.ReadAllLines(@"C:\src\Ella\External\opengl-api\openglcore.h");
            var sb = new StringBuilder();
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("public unsafe static class Gl {");
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];

                if (line.StartsWith("struct"))
                {
                    var splat = line.Split(" ");
                    sb.AppendLine($"struct {splat[1]}{{}}");
                }
                if (line.StartsWith("#define"))
                {
                    var def = ParseDefine(line);
                    if(def != null)
                    {
                        sb.AppendLine(def);
                    }
                }
                else if (line.StartsWith("GLAPI"))
                {
                    line = line.Replace("APIENTRY ", string.Empty);
                    var split = line.Split(" ").Where(x => x != String.Empty).ToArray();
                    if (split.Length < 3)
                    {
                        continue;
                    }
                    sb.AppendLine($"\t[DllImport(\"glfw3.dll\")]");
                    var p = ParseParameters(line.Substring(line.IndexOf("(") + 1, line.IndexOf(")") - line.IndexOf("(") - 1));
                    var last = split.Single(x => x.Contains("("));

                    var start = "GLAPI".Length;
                    var returnType = line.Substring(start, line.Length - start);
                    var end = returnType.IndexOf("gl") - 1;
                    returnType = returnType.Substring(0, end);
                    returnType = TypeConverter(returnType);

                    var name = split.Single(x => x.StartsWith("gl") || x.StartsWith("*gl")).Replace("*", string.Empty);
                    sb.AppendLine($"\tpublic static extern {returnType} {name} ({(p == null ? string.Empty : p)});");
                }
                else if (line.StartsWith("typedef void (") || line.StartsWith("typedef GLsync ("))
                {
                    sb.AppendLine(ParseFunctionPointer(line));
                }
                else if (line.StartsWith("typedef struct"))
                {
                    sb.Append(ParseStruct(line, lines, i));
                }
            }
            sb.AppendLine("}");
            File.WriteAllText(@"C:\src\Ella\CsGame\Bindings\Gl.cs", sb.ToString());
        }

        private string ParseDefine(string line)
        {
            if(line == "#define APIENTRYP APIENTRY *" || line == "#define GLAPI extern")
            {
                return null;
            }

            var split = line.Split(" ").Where(x => x != String.Empty).ToArray();
            if (split.Length < 3)
            {
                return null;
            }
            var sb = new StringBuilder();
            var val = HexConverter(split[2]);           
            if (line.Contains("|"))
            {
                sb.Append($"\tpublic const int {split[1]} = {val}");
                for (var j = 3; j < split.Length; j++)
                {
                    sb.Append(split[j]);
                }
                sb.Append(";\n");
            }
            else
            {
                sb.AppendLine($"\tpublic const int {split[1]} = {val};");
            }
            return sb.ToString();
        }

        private string HexConverter(string hex)
        {
            if(hex == "0xFFFFFFFFFFFFFFFFull")
            {
                return ulong.MaxValue.ToString();
            }
            return hex;
        }

        private string ParseStruct(string line, string[] lines, int index)
        {
            //typedef struct GLFWmonitor GLFWmonitor;
            var split = line.Split(" ");
            var name = split[2];
            if (line.EndsWith(";"))
            {
                return $"public struct {name} {{}}\n";
            }
            var sb = new StringBuilder();
            sb.AppendLine($"public struct {name}");
            while (!line.Contains("}"))
            {
                line = lines[++index].Trim();
                if (line.Contains("}"))
                {
                    line = "}";
                }
                line = TypeConverter(line);
                if (!line.StartsWith("/*") && line.Contains("[") && line.Contains("]"))
                {
                    line = $"fixed {line}";
                }
                sb.AppendLine(line);
            }
            return sb.ToString();
        }

        private string ParseFunctionPointer(string line)
        {            
            line = line.Replace("APIENTRYP", string.Empty);
            line = line.Replace("APIENTRY", string.Empty);
            //typedef void (* GLFWglproc) (void);
            var returnType = TypeConverter(line.Split(" ")[1]);
            var firstp = line.IndexOf("(");
            var substr = line.Substring(firstp, line.Length - firstp);
            var nextp = substr.IndexOf(")") + firstp;
            var name = line.Substring(firstp + 2, nextp - firstp - 2).Replace("*", string.Empty);

            var firstP = line.LastIndexOf("(");
            nextp = line.LastIndexOf(")");
            var p = ParseParameters(line.Substring(firstP + 1, nextp - firstP - 1));

            return $"public delegate {returnType} {name} ({(p == null ? "" : p)});";
        }

        private string ParseParameters(string line)
        {
            if (line == "void")
            {
                return null;
            }
            line = line.Replace("struct", string.Empty);
            return TypeConverter(line);
        }

        private string TypeConverter(string type)
        {
            type = type.Replace("string", "str");
            type = type.Replace("const", string.Empty);
            type = type.Replace("unsigned char*", "byte*");
            type = type.Replace("unsigned short*", "ushort*");
            type = type.Replace("unsigned int*", "uint*");
            type = type.Replace("unsigned int", "uint");
            type = type.Replace("unsigned char", "byte");
            type = type.Replace("const char**", "string[]");
            type = type.Replace("const char*", "string");
            type = type.Replace("const float", "float");
            type = type.Replace("const int", "int");
            type = type.Replace("uint64_t", "ulong");
            type = type.Replace("uint32_t", "uint");
            type = type.Replace("VkInstance", "IntPtr");
            type = type.Replace("VkResult", "IntPtr");
            type = type.Replace("VkPhysicalDevice", "IntPtr");
            type = type.Replace("VkAllocationCallbacks*", "IntPtr");
            type = type.Replace("VkSurfaceKHR*", "IntPtr");
            type = type.Replace("char* paths[]", "char*[] paths");
            type = type.Replace("char**", "ref string");
            type = type.Replace("char*", "string");
            type = type.Replace("params", "prms");
            type = type.Replace("GLenum", "int");
            type = type.Replace("GLfloat", "float");
            type = type.Replace("GLint", "int");
            type = type.Replace("GLboolean", "int");
            type = type.Replace("GLdouble", "double");
            type = type.Replace("GLsizei", "uint");
            type = type.Replace("GLbitfield", "int");
            type = type.Replace("GLchar", "char");
            type = type.Replace("GLuint", "uint");
            type = type.Replace("GLubyte", "byte");
            type = type.Replace("ref", "reference");
            type = type.Replace("uint64EXT", "ulong");
            type = type.Replace("int64EXT", "long");
            type = type.Replace("GLintptr", "int*");
            type = type.Replace("GLuintptr", "uint*");
            type = type.Replace("object", "obj");
            type = type.Replace("GLsync", "IntPtr");
            type = type.Replace("intptr", "int*");
            type = type.Replace("uint64", "ulong");

            type = type.Replace(" event", " evt");

            return type;
        }
    }
}
