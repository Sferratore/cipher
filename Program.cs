using System;
using System.IO;

namespace CipherProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("************\nCipherProject 1.1\n************\n\n");
            

            while(true) 
            {
                Console.WriteLine("\n\nSelect an option.\n1.Cipher a file\n2.Decipher a file\n0.Exit");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice) 
                    {
                        case 0: return; break;
                        case 1: CipherFile(); break;
                        case 2: DeCipherFile(); break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"\nERROR: {e.ToString()}\n");
                    continue;
                }
            }
        }

        static string Cipher(string message)
        {
            string msgCopy = "";

            for (int i = 0; i < message.Length; i++)
            {
                msgCopy += Convert.ToChar(message[i] + 3);
            }
            return msgCopy;
        }

        static string DeCipher(string message)
        {
            string msgCopy = "";

            for (int i = 0; i < message.Length; i++)
            {
                msgCopy += Convert.ToChar(message[i] - 3);
            }
            return msgCopy;
        }

        static void CipherFile()
        {
            string path;
            string text;

            Console.Write("\nIndicate the path of the file: ");
            path = Console.ReadLine();
            text = System.IO.File.ReadAllText(path);
            text = Cipher(text);

            System.IO.File.WriteAllText("C:\\Users\\F.P.S\\Desktop\\erfile.txt", text);
            Console.WriteLine("Operation concluded successfully.");
            return;
        }

        static void DeCipherFile()
        {
            string path;
            string text;

            Console.Write("\nIndicate the path of the file: ");
            path = Console.ReadLine();
            text = System.IO.File.ReadAllText(path);
            text = DeCipher(text);

            System.IO.File.WriteAllText("C:\\Users\\F.P.S\\Desktop\\erfile.txt", text);
            Console.WriteLine("Operation concluded successfully.");
            return;
        }

    }



}
