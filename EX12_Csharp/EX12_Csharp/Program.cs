using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Khai báo số nguyên n 2 byte không dấu và gọi hàm để nhập giá trị của n
        ushort n = ReadUShort();
        // In ra giá trị của n
        Console.WriteLine($"Giá trị được nhập: {n}");
        // Tính tổng bình phương các số từ 1 đến n và in ra giá trị tính được
        Console.WriteLine($"Tổng bình phương từ 1 đến {n}: {SumOfSquares(n)}");
    }

    // Hàm static để nhập số nguyên 2 byte không dấu, nếu nhập sai thì nhập lại
    static ushort ReadUShort()
    {
        ushort result;
        Console.Write("Nhập số nguyên 2 byte không dấu: ");
        while (!ushort.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Nhập sai, vui lòng nhập lại: ");
        }
        return result;
    }

    // Hàm tính tổng bình phương các số từ 1 đến n
    static ulong SumOfSquares(ushort n)
    {
        ulong sum = 0;
        for (ushort i = 1; i <= n; i++)
        {
            sum += (ulong)i * i;
        }
        return sum;
    }
}
