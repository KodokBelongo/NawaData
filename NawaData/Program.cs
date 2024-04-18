using System;
using System.Collections.Generic;
using System.Linq;

public class nawaData
{
    
     static void Main(string[] args)
    {
        // no1 
        /*Console.Write("Input one line of words (S): ");
        string input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("Input is null. Please enter valid input.");
            return;
        }

        input = input.ToLower();

        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        List<char> consonants = new List<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

        string vowelChars = GetSortedChars(input, vowels);
        string consonantChars = GetSortedChars(input, consonants);

        Console.WriteLine("Vowel Characters:");
        Console.WriteLine(vowelChars);
        Console.WriteLine("Consonant Characters:");
        Console.WriteLine(consonantChars);*/
        


        // no 2 
        Console.WriteLine("Input the number of families: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Input the number of members in the family (separated by a space): ");
        string[] membersStr = Console.ReadLine().Split();

        int totalMembers = 0;
        foreach (var memberStr in membersStr)
        {
            totalMembers += int.Parse(memberStr);
        }

        if (n != membersStr.Length)
        {
            Console.WriteLine("Input must be equal with count of family");
        }
        else
        {
            int totalBuses = (totalMembers + 3) / 4;
            Console.WriteLine($"Minimum bus required is: {totalBuses}");
        }
    }

    public static string GetSortedChars(string input, List<char> characters)
    {
        List<char> result = new List<char>();
        foreach (char c in input)
        {
            if (characters.Contains(c))
            {
                result.Add(c);
            }
        }
        result.Sort();
        return new string(result.ToArray());
    }





}



