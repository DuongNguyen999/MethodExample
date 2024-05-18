internal class Program
{
    private static void Main(string[] args)
    {
        // Bước 1: Khai báo một chuỗi và gán giá trị cho nó
        string str = "Hello, world! This is a test string.";
      

        // Bước 2: Khai báo một biến ký tự và nhập từ bàn phím
        Console.WriteLine("Enter a character to count:");
        char character = Console.ReadLine()[0];

        // Bước 3 và 4: Đếm số lần xuất hiện của ký tự trong chuỗi
        int count = CountCharacterOccurrences(str, character);

        // Bước 5: In ra giá trị biến đếm
        Console.WriteLine($"The character '{character}' appears {count} times in the string.");
    }

    // Phương thức đếm số lần xuất hiện của một ký tự trong chuỗi
    static int CountCharacterOccurrences(string str, char character)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == character)
            {
                count++;
            }
        }
        return count;
    }
}