namespace layout
{
    class formatacao
    {
        public static void DarkRed(string RealizarAdicao, ConsoleColor DarkRed)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed
        Console.Write(RealizarAdicao);
            Console.ResetColor();
        }
    }
}