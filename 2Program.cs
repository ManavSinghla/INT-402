// using System;

// class Program2
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: ");
//         string str = Console.ReadLine();

//         int vowels = 0;
//         int consonants = 0;
//         int digits = 0;
//         int spaces = 0;

//         foreach (char ch in str)
//         {
//             if (char.IsLetter(ch))
//             {
//                 char c = char.ToLower(ch);

//                 if (c == 'a' || c == 'e' || c == 'i' ||
//                     c == 'o' || c == 'u')
//                 {
//                     vowels++;
//                 }
//                 else
//                 {
//                     consonants++;
//                 }
//             }
//             else if (char.IsDigit(ch))
//             {
//                 digits++;
//             }
//             else if (ch == ' ')
//             {
//                 spaces++;
//             }
//         }

//         Console.WriteLine("Vowels : " + vowels);
//         Console.WriteLine("Consonants : " + consonants);
//         Console.WriteLine("Digits : " + digits);
//         Console.WriteLine("Spaces : " + spaces);
//     }
// }