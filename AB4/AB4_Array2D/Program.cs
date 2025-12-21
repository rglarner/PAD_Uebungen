namespace AB4_Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int width = 40;
            const int height = 15;

            char[,] field = new char[height, width];
            Clear(field, '.');

            // Demo: mehrere Figuren
            Console.WriteLine("DrawRectangle(2,2, 10x4, '#') -> " +
                DrawRectangle(field, 2, 2, 10, 4, '#'));

            Console.WriteLine("DrawSquare(20,3, size 6, '@') -> " +
                DrawSquare(field, 20, 3, 6, '@'));

            // Überlappung (überschreibt)
            Console.WriteLine("DrawRectangle(6,4, 14x3, '*') -> " +
                DrawRectangle(field, 6, 4, 14, 3, '*'));

            // Teilweise ausserhalb (muss false liefern, aber innerhalb zeichnen)
            Console.WriteLine("DrawRectangle(35,12, 10x5, '+') -> " +
                DrawRectangle(field, 35, 12, 10, 5, '+'));

            Console.WriteLine();
            Print(field);
        }
        public static void Clear(char[,] field, char fill)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    field[y, x] = fill;
                }
            }
        }

        public static void Print(char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Console.Write(field[y, x]);
                }
                Console.WriteLine();
            }
        }

        public static bool DrawRectangle(char[,] field, int startX, int startY, int width, int height, char symbol)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            // Vollständig innerhalb?
            bool fullyInside =
                startX >= 0 &&
                startY >= 0 &&
                width > 0 &&
                height > 0 &&
                startX + width <= cols &&
                startY + height <= rows;

            // Zeichnen: alles innerhalb der Fläche, Rest ignorieren
            for (int y = startY; y < startY + height; y++)
            {
                for (int x = startX; x < startX + width; x++)
                {
                    if (y >= 0 && y < rows && x >= 0 && x < cols)
                    {
                        field[y, x] = symbol; // immer überschreiben
                    }
                }
            }

            return fullyInside;
        }

        public static bool DrawSquare(char[,] field, int startX, int startY, int size, char symbol)
        {
            return DrawRectangle(field, startX, startY, size, size, symbol);
        }
    }
}
