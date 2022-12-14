using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    internal class Program
    {

        static void Exo1()
        {
            Console.WriteLine("Exo1: ");
            Console.WriteLine("Enter a word");
            string word = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The word entered word is: " + word);

            string res = word[word.Length - 1]+"";
            for(int i=1;i<word.Length-1;i++)
            {
                res += word[i];
            }
            res += word[0];
            Console.WriteLine(res);

            /*string mot = "chocolat";
            string Mot= mot.Substring(1,mot.Length);
            Console.WriteLine(Mot);*/
        }

        static void Exo2()
        {
            Console.WriteLine("Exo2: ");
            int[]tab = {7,6,2,3,4,5,0,9,9};
            int[] tab2 = { 5, 3, 4, 8, 9 };
            int[] seq = {4,8,9};

            bool res = SequenceAppears(tab,seq);
            bool res2 = SequenceAppears(tab2, seq);
            Console.WriteLine(res);
            Console.WriteLine(res2);
        }

        static bool SequenceAppears(int[]tab, int[]seq)
        {
            bool res=false;
            for(int i = 0; i < tab.Length-seq.Length+1 && res==false; i++)
            {
                bool test = true;
                for (int j = 0; j < seq.Length&&test==true; j++)
                {
                    if (tab[i + j] != seq[j])
                    {
                        test = false;
                    }
                }

                if (test == true)
                {
                    res = true;
                }
            }
            return res;
        }

        static void Exo3()
        {
            Console.WriteLine("Exo3");
            Console.WriteLine("Tape 1 for 3a and 2 for 3b");
            int exercice = EnterNumber();
            switch (exercice)
            {
                case 1:
                    Console.WriteLine("Write a character");
                    char n = Convert.ToChar(Console.ReadLine());
                    int a = Convert.ToInt32(n);
                    Console.WriteLine(" ASCII value of the character " + n + ": " + a);
                    break;

                case 2:
                    Console.WriteLine("Write a word");
                    string word = Convert.ToString(Console.ReadLine());
                    DescendingOrder(word);
                    break;
                default:
                    break;

            }
        }


        static void DescendingOrder(string mot)
        {
            char[]res =new char[mot.Length];
            for (int i = 0; i < mot.Length; i++)
            {
                res[i] = mot[mot.Length - 1 - i];
                Console.Write(res[i]);
            }

        }


        static void Exo4()
        {
            Console.WriteLine("Exo4");
            Console.WriteLine("Write a word");
            string word = Convert.ToString(Console.ReadLine());
            Console.WriteLine(CompressString(word));
        }


        static string CompressString(string word)
        {
            char temp = word[0];
            int k = 1;
            string res =word[0]+"";

            for (int i=0;i<word.Length-1; i++)
            {
               if (temp == word[i+1])
                {
                    k++;
                }
                else
                {
                    res +=Convert.ToString(k) + word[i+1];
                    temp = word[i+1];
                    k = 1;
                }
            }
            res += Convert.ToString(k);

            return res;
        }

        static void Exo5()
        {
            Console.WriteLine("Exo4");
            ArmstrongNumber();
        }

        static void ArmstrongNumber()
        {
            Console.WriteLine("Armstrong Number:");
            int reste10;

            int div10;
            int div100;
            int reste100;
            for (int i = 0; i < 1000; i++)
            {
                if (i < 10)
                {
                    if (Math.Pow(i, 3) == i)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (i>=10 && i < 100)
                {
                    reste10 = i % 10;
                    div10 = i / 10;
                    if(Math.Pow(reste10,3)+Math.Pow(div10,3) == i)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    reste10 = i % 10; 
                    reste100 = i % 100;
                    div10 = (reste100 - reste10)/10;
                    div100 = (i-reste100)/ 100;

                    if (Math.Pow(reste10, 3) + Math.Pow(div10, 3)+Math.Pow(div100,3) == i)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
        }

        static void Exo6()
        {
            Console.WriteLine("Exo 6");
            int[] array = { 5, 7, 5, 2, 2, 4, 5 };
            CounterArray(array);
        }

        static void CounterArray(int[]array)
        {
            int k;
            int []temp=new int[array.Length];  
            
            for (int i=0; i<array.Length; i++)
            {
                temp[i] = -1;
            }
            int n = array.Length;
            for(int i=0; i<n; i++)
            {       
                k = 1;
                for(int j=i+1; j<n; j++)
                {
                    if(array[i]==array[j])
                    {
                        k++;
                        temp[j] = 0;
                    }
                }

                if(temp[i]!=0)
                {
                    temp[i] = k;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (temp[i] != 0)
                {
                    Console.WriteLine(array[i] +" is " + temp[i] +" times ");
                }
            }

        }

        static void Exo7()
        {
            Console.WriteLine("Exo7");
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of " + n + " is " + Factorial(n));
        }

        static int Factorial(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        static void Exo8()
        {
            Console.WriteLine("Exo8");
            Console.WriteLine("Write a sentence");
            string sentence = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The number of white spaces in a string is: "+CountSpace(sentence));
        }

        static int CountSpace(string sentence)
        {
            int space = 0;
            for(int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]==' ')
                {
                    space++;
                }
            }
            return space;
        }

        static void Exo9()
        {
            Console.WriteLine("Exo9");
            Console.WriteLine("Think 3 names");
            Person[] arrayName = new Person[3];
           
            for(int i = 0; i < arrayName.Length; i++)
            {
                Console.WriteLine("Write the " + (i+1) + " name"); 
                arrayName[i] = new Person(Convert.ToString(Console.ReadLine())); ;
            }

            for(int i=0; i<arrayName.Length; i++)
            {
                Console.WriteLine("The " + (i + 1) + " name is " + arrayName[i].ToString());
            }
        }
        static int EnterNumber()
        {
            Console.WriteLine("Enter the exercise number: ");
            int n;
            do
            {
                n=Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        static void Main(string[] args)
        {
            Console.Clear(); // réinitialise la console
            ConsoleKeyInfo keyInfo; //déclare une variable de type ConsoleKeyInfo
            keyInfo = Console.ReadKey(); // cki contient entre autres le code de latouche sur laquelle l’utilisateur a appuyé

            if (keyInfo.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Main, choose the number of exercise:\n");

                Console.WriteLine("Cliquez Escape pour terminer");

                int exercice = EnterNumber();
                switch (exercice)
                {
                    case 1:
                        Exo1();
                        break;

                    case 2:
                        Exo2();
                        break;

                    case 3:
                        Exo3();
                        break;

                    case 4:
                        Exo4();
                        break;

                    case 5:
                        Exo5();
                        break;

                    case 6:
                        Exo6();
                        break;

                    case 7:
                        Exo7();
                        break;

                    case 8:
                        Exo8();
                        break;

                    case 9:
                        Exo9();
                        break;

                    default:
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}
