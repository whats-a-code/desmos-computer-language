using System.Reflection.Emit;

class Compiler
{
    static void Main(string[] args)
    {
        string assemblyName;
        string outputPath;
        string inputFile;

        foreach (string arg in args)
        {
            switch (arg)
            {
                case "--name":
                    assemblyName = args[Array.IndexOf(args, arg) + 1];
                    break;

                case "--path":
                    outputPath = args[Array.IndexOf(args, arg) + 1];
                    break;

                case "--input":
                    inputFile = args[Array.IndexOf(args, arg) + 1];
                    break;
            }
        }   
    }
}