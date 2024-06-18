using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập một xâu kí tự: ");
        string st = Console.ReadLine().Trim(); // Đọc và loại bỏ khoảng trắng thừa

        if (st == "#")
        {
            Console.Beep(); // Phát tiếng beep nếu nhập vào là "#"
        }
        else
        {
            int wordCount = CountWords(st);
            Console.WriteLine($"Số từ trong xâu \"{st}\" là: {wordCount}");
        }
    }

    // Hàm đếm số từ trong xâu kí tự
    static int CountWords(string str)
    {
        // Loại bỏ khoảng trắng thừa và dấu câu ở đầu và cuối chuỗi
        str = str.Trim();

        if (str == "")
        {
            return 0; // Trường hợp xâu rỗng
        }

        int wordCount = 1; // Bắt đầu từ một từ

        // Đếm số từ bằng cách tìm khoảng trắng hoặc dấu câu
        for (int i = 0; i < str.Length - 1; i++)
        {
            if ((str[i] == ' ' || char.IsPunctuation(str[i])) && !(str[i + 1] == ' ' || char.IsPunctuation(str[i + 1])))
            {
                wordCount++;
            }
        }

        return wordCount;
    }
}
