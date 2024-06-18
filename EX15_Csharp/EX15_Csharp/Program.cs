using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Đọc số nguyên 1 byte không dấu từ bàn phím (trong khoảng từ 2 đến 10)
        byte n = ReadByteInRange(3, 9);
        Console.WriteLine($"Số nguyên 1 byte được nhập: {n}");
        // Khai báo mảng số thực 4 byte và nhập giá trị các phần tử của mảng từ bàn phím
        float[] a = new float[n];
        ReadFloatArrayFromConsole(a);

        // In ra màn hình giá trị của mảng a
        Console.WriteLine("Các giá trị số thực 4 byte trong mảng a:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}");
        }
    }

    // Hàm để đọc số nguyên 1 byte không dấu trong khoảng từ min đến max, nhập sai thì nhập lại
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

    // Hàm để đọc số thực 4 byte từ bàn phím, nhập sai thì nhập lại
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

    // Hàm để nhập vào một mảng số thực 4 byte từ bàn phím
    static void ReadFloatArrayFromConsole(float[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ReadFloatFromConsole();
        }
    }
}
