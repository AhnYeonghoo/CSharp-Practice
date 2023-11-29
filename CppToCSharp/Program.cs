using System;

namespace Program
{
    class Program
    {
        static void MainProgram()
        {
            Console.WriteLine("Hello World!");
            int i, sum = 0;
            for (i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine($"합은: {sum}");

            int lucky_number = 3;
            Console.WriteLine("내 비밀 수를 맞추어 보세요~");
            int user_input;
            while (true)
            {
                Console.Write("입력: ");
                user_input = Convert.ToInt32(Console.ReadLine());
                if (lucky_number == user_input)
                {
                    Console.WriteLine("맞추셨습니다.");
                    break; 
                }
                else
                {
                    Console.WriteLine("다시 생각해보세요.");
                }
            }

            Console.WriteLine("저의 정보를 표시해줍니다.");
            Console.WriteLine("1. 이름");
            Console.WriteLine("2. 나이");
            Console.WriteLine("3. 성별");
            user_input = Convert.ToInt32(Console.ReadLine());

            switch (user_input)
            {
                case 1:
                    Console.WriteLine("Psi! ");
                    break;
                case 2:
                    Console.WriteLine("99살");
                    break;
                case 3:
                    Console.WriteLine("남자");
                    break;
                default:
                    Console.WriteLine("궁금한게 없군요");
                    break;
            }
            return;
        }
    }
}

