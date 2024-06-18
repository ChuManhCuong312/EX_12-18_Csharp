using System;

class Program
{
    static void Main()
    {
        // Thiết lập console để hiển thị tiếng Việt
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Gọi hàm để nhập số nguyên 1 byte không dấu trong khoảng từ 2 đến 10
        byte n = ReadByteInRange(3, 9);
        // In ra giá trị của n
        Console.WriteLine($"Giá trị được nhập: {n}");
    }

    // Hàm để nhập số nguyên 1 byte không dấu trong khoảng từ min đến max
    static byte ReadByteInRange(byte min, byte max)
    {
        byte result;
        bool isValidInput = false;
        do
        {
            Console.Write($"Nhập số nguyên 1 byte không dấu (khoảng từ 2-10): ");
            string input = Console.ReadLine();

            // Kiểm tra xem đầu vào có phải là số nguyên không dấu và nằm trong khoảng cho trước
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
}
