using System;

namespace ArraySample
{
    class MainApp
    {
        static void MainArraySample(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 84;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            int average = sum / scores.Length;

            int[] scores2 = new int[5];
            scores2[0] = 80;
            scores2[1] = 74;
            scores2[2] = 81;
            scores2[^2] = 90;
            scores2[^1] = 34;


        }
    }

}