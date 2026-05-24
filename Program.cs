

class Compiler
{   
    public static int Main(string[] input)
    {
        if (input.Length == 0) {Console.WriteLine("No input provided."); return 1; }
        if (input.Length > 1) {Console.WriteLine("Too many inputs provided."); return 1; }

        string path = Path.GetFullPath(input[0]);
        if (!File.Exists(path))
        {
            Console.WriteLine($"File not found: {path}");
            return 2;
        }

        string code = File.ReadAllText(path);
        if (String.IsNullOrWhiteSpace(code))
        {
            Console.WriteLine($"File is empty or has only whitespace: {path}");
            return 3;
        }

        foreach (string line in code.Split("\r\n", StringSplitOptions.RemoveEmptyEntries))
        {
            string[] seperatedLine = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
        }

        return 0;
    }
}