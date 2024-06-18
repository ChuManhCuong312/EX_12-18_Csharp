using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Gọi hàm để đọc vào số x
        double x = ReadDouble8Byte();
        double sqrtX = Math.Sqrt(x);
        //Hiển thị giá trị căn bậc 2 của x
        Console.WriteLine($"Căn bậc 2 của {x} là: {sqrtX}");
    }

    // Hàm để đọc số thực 8 byte từ bàn phím và kiểm tra tính hợp lệ
    static double ReadDouble8Byte()
    {
        double result;
        Console.Write("Nhập số thực 8 byte x: ");

        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Nhập sai, vui lòng nhập lại số thực 8 byte: ");
        }

        return result;
    }
}
