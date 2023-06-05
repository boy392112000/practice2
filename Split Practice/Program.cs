using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("請輸入一個以逗號分隔的字串：");
        string input = Console.ReadLine();

        // 去除首尾空格
        input = input.Trim();

        string[] substrings = input.Split(',');

        string[] uniqueSubstrings = new string[substrings.Length];
        int[] counts = new int[substrings.Length];
        int uniqueCount = 0;

        foreach (string substring in substrings)
        {
            // 去除空字符串
            string trimmedSubstring = substring.Trim();

            if (!string.IsNullOrEmpty(trimmedSubstring))
            {
                bool found = false;

                // 檢查當前子字串是否已經存在於 uniqueSubstrings 陣列中
                for (int i = 0; i < uniqueCount; i++)
                {
                    if (uniqueSubstrings[i] == trimmedSubstring)
                    {
                        counts[i]++;
                        found = true;
                        break;
                    }
                }

                // 如果當前子字串不存在於 uniqueSubstrings 陣列中，則添加到陣列中
                if (!found)
                {
                    uniqueSubstrings[uniqueCount] = trimmedSubstring;
                    counts[uniqueCount] = 1;
                    uniqueCount++;
                }
            }
        }

        Console.WriteLine("每種字串出現的次數：");
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.WriteLine("{0} 出現次數：{1}", uniqueSubstrings[i], counts[i]);
        }
    }
}
