namespace RefAndValueTypesLesson
{
    internal class Program
    {
        //Task 1
        static string ReverseText(string text)
        {
            string outText = "";
            foreach (char c in text.Reverse())
            {
                outText += c;
            }

            return outText;
        }

        //Task 2
        static int ReverseNum(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            return result;
        }

        //Task 3
        static void CountChar(string text)
        {
            text = text.Replace(" ", "");
            char[] arr = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        count++;
                    }
                }
                
                Console.WriteLine($"Count of '{text[i]}' = {count}");
            }
        }


        //Task 4

        static bool IsPalindrome(string text)
        {
            var revText = text.Reverse().ToArray();
            bool res = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != revText[i])
                {
                    res = false;
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            //    Task 1

            //Console.WriteLine(ReverseText("Ali Sadat Nicat Mirqubad"));


            //    Task 2

            //input:
            //    bool check = int.TryParse(Console.ReadLine(), out int num);
            //    if (!check)
            //    {
            //        Console.WriteLine("Not number");
            //        goto input;
            //    }

            //    Console.WriteLine(ReverseNum(num));


            //Task 3

            //string text = Console.ReadLine();

            //CountChar(text);


            //Task 4

            //string text = Console.ReadLine();

            //Console.WriteLine(IsPalindrome(text));
        }
    }
}
