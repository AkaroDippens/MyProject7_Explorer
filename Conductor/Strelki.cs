namespace Conductor
{
    internal class Strelki
    {
        int min, max;
        ConsoleKey key;
        int pos;
        public Strelki(int max, int min = 0)
        {
           this.min = min;
           this.max = max - 1;         
        }
        public int Arrow(int startPos = 0, int count = 3, string arrow = "->")
        {    
            string empty = new string(' ', arrow.Length);
            int i = startPos;
            Console.SetCursorPosition(0, startPos);
            Console.Write(arrow);
            ConsoleKeyInfo key;
            for (; ; )
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (i == count + startPos - 1)
                            continue;
                        Console.SetCursorPosition(0, i);
                        Console.Write(empty);
                        Console.SetCursorPosition(0, ++i);
                        Console.Write(arrow);
                        break;
                    case ConsoleKey.UpArrow:
                        if (i == startPos)
                            continue;
                        Console.SetCursorPosition(0, i);
                        Console.Write(empty);
                        Console.SetCursorPosition(0, --i);
                        Console.Write(arrow);
                        break;
                    case ConsoleKey.Enter:
                        return i + 1 - startPos;
                }
            }
        }
    }   
}



