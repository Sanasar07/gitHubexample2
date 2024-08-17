using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitHubexample2
{
    internal class Program
    {
        static Random random = new Random();

        static string GeneratePassword(int length, string alph)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(alph[random.Next(alph.Length)]);
            }
            return sb.ToString();
        }

        static void RunPasswordGenrationCLI()
        {
            try
            {
                Console.Write("Введите длину пароля: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите алфавит: ");
                string alph = Console.ReadLine();
                string password = GeneratePassword(length, alph);
                Console.WriteLine($"Сгенерированный пароль: {password}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            RunPasswordGenrationCLI();
        }