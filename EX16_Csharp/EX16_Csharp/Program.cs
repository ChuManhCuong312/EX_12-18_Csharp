using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Đọc số nguyên m, n từ bàn phím (trong khoảng từ 2 đến 10)
        byte m = ReadByteInRange(3, 9);
        byte n = ReadByteInRange(3, 9);
        Console.WriteLine($"Số nguyên m được nhập: {m}");
        Console.WriteLine($"Số nguyên n được nhập: {n}");

        // Khai báo và cấp phát mảng 2 chiều số nguyên 4 byte a
        int[,] a = new int[m, n];

        // Nhập giá trị các phần tử của mảng a từ bàn phím
        ReadIntArray2DFromConsole(a);

        // In ra màn hình giá trị của mảng a
        Console.WriteLine("Các giá trị số nguyên 4 byte trong mảng a:");
        PrintIntArray2D(a);

        // Tính tổng các phần tử của mảng a chia hết cho 2024
        int sumDivisibleBy2024 = SumDivisibleBy2024(a);
        Console.WriteLine($"Tổng các phần tử của mảng a chia hết cho 2024: {sumDivisibleBy2024}");
    }

    // Hàm để đọc số nguyên 1 byte không dấu trong khoảng từ min đến max, nhập sai thì nhập lại
    static byte ReadByteInRange(byte min, byte max)
    {
        byte result;
        bool isValidInput = false;

        do
        {
            Console.Write($"Nhập số nguyên 1 byte không dấu lần lượt cho m và n (trong khoảng từ 2-10): ");
            string input = Console.ReadLine();

            if (byte.TryParse(input, out result) && result >= min && result <= max)
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại.");
            }
        } while (!isValidInput);

        return result;
    }

    // Hàm để đọc số nguyên 4 byte từ bàn phím, nhập sai thì nhập lại
    static int ReadIntFromConsole()
    {
        int result;
        bool isValidInput = false;

        do
        {
            Console.Write("Nhập số nguyên 4 byte ứng với các mảng: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out result))
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại.");
            }
        } while (!isValidInput);

        return result;
    }

    // Hàm để nhập vào mảng 2 chiều số nguyên 4 byte từ bàn phím
    static void ReadIntArray2DFromConsole(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = ReadIntFromConsole();
            }
        }
    }

    // Hàm để in ra mảng 2 chiều số nguyên 4 byte
    static void PrintIntArray2D(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"a[{i},{j}] = {array[i, j]}");
            }
        }
    }

    // Hàm để tính tổng các phần tử của mảng chia hết cho 2024
    static int SumDivisibleBy2024(int[,] array)
    {
        int sum = 0;
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] % 2024 == 0)
                {
                    sum += array[i, j];
                }
            }
        }

        return sum;
    }
}
