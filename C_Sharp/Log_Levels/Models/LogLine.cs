namespace Log_Levels.Models
{
    public static class LogLine
    {
        public static string Message(string logLine)
        {
            string result;
            var index = logLine.IndexOf(":");
            result = logLine.Substring(index + 1).Trim();

            return result;
        }

        public static string LogLevel(string logLine)
        {
            var index1 = logLine.IndexOf("[");
            var index2 = logLine.IndexOf("]");

            var result = logLine.Substring(index1 + 1, index2 - 1).Trim().ToLower();
            return result;
        }

        public static string Reformat(string logLine)
            => $"{Message(logLine)} ({LogLevel(logLine)})";

    }
}