namespace WellShell
{
    class Config
    {
        public static string Version = "1.0";
        public static string ShellName = "Well-Shell";
        public static string InputChar = $"{Colors.Bright(Colors.Blue)}{Config.Version}{Colors.Yellow}{Config.ShellName}{Colors.Reset}> ";
    }
    
    class Colors
    {
        public static string Black = "\u001b[30m";
        public static string Red = "\u001b[31m";
        public static string Green = "\u001b[32m";
        public static string Yellow = "\u001b[33m";
        public static string Blue = "\u001b[34m";
        public static string Magenta = "\u001b[35m";
        public static string Cyan = "\u001b[36m";
        public static string White = "\u001b[37m";
        public static string Reset = "\u001b[0m";
        public static string Bright(string color) => color + ";1m";
    }
}