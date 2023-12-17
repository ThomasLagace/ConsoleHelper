namespace ConsoleHelper
{
    public class ConsoleHelper
    {
        private const char OpenTag = 'o';
        private const char ForegroundColorTag = 'f';
        private const char BackgroundColorTag = 'b';

        public static void WriteWithColors(string prompt)
        {
            string[] stringsParts = prompt.Split(new[] { $"<{OpenTag}", $"</{OpenTag}>" }, StringSplitOptions.RemoveEmptyEntries);
            
        }
    }
}
