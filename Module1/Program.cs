/*
        * Варіант 3:
    Створіть клас Matrix, який представляє цілочисельну матрицю. В цьому класі створіть:
    Зубчастий двовимірний масив цілих чисел.
    Індексатор для доступу до елементів матриці за допомогою індексів row та column.
        
    Напишіть метод FillMatrixRandom(int rows, int columns, int min, int max),
    який заповнює матрицю випадковими числами в діапазоні від min до max.
    Створіть об'єкт класу Matrix, заповніть його випадковими значеннями та виведіть матрицю на консоль.
    Потім, за допомогою індексатора, знайдіть та виведіть значення певного елемента матриці.
*/

class Matrix
{
    public static int row;
    public static int column;
    public int[,] arr;

    public int this[int row, int column]
    {
        get { return arr[row,column]; }
        set { arr[row,column] = value; }
    }

    public void FillMatrixRandom(int rows, int columns, int min, int max)
    {
        Random r = new Random();
        for(int i = 0; i < rows; i++)
        { 
            for(int j = 0; j < columns; j++)
            {
                arr[i,j] = r.Next(min, max);
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Matrix matrix = new Matrix();
        Console.WriteLine("\nEnter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter number of cols: ");
        int columns = int.Parse(Console.ReadLine());

        matrix.arr = new int[rows,columns];

        Console.WriteLine("\nEnter min number: ");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter min number: ");
        int max = int.Parse(Console.ReadLine());
        matrix.FillMatrixRandom(rows, columns, min, max);
        Console.WriteLine("\nGenerated matrix: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix.arr[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nWrite row: ");
        int rowToFind = int.Parse(Console.ReadLine());
        Console.WriteLine("\nWrite column: ");
        int columnToFind = int.Parse(Console.ReadLine());
        int el = matrix.arr[rowToFind,columnToFind];
        Console.WriteLine($"\nTake element from matrix at [{rowToFind}][{columnToFind}] : {el}");
    }
}


