using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Gọi hàm để nhập số thực 4 byte từ bàn phím
        float x = ReadFloatFromConsole();
        // In ra giá trị của x
        Console.WriteLine($"Giá trị được nhập: {x}");
    }

    // Hàm để đọc từ bàn phím và yêu cầu nhập số thực 4 byte, nhập sai thì nhập lại
    static float ReadFloatFromConsole()
    {
        float result;
        bool isValidInput = false;

        do
        {
            Console.Write("Nhập số thực 4 byte: ");
            string input = Console.ReadLine();
            // Kiểm tra xem đầu vào có phải là số thực không
            if (float.TryParse(input, out result))
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
