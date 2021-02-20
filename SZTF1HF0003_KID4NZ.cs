using System;

namespace _3.sztf_hazi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sor1 = Console.ReadLine();
            string sor2 = Console.ReadLine();
            string sor3 = Console.ReadLine();
            DigitReader D = new DigitReader(sor1, sor2, sor3);
            string kimenet = D.Atalakito();
            Console.WriteLine(kimenet);
            Console.ReadLine();
        }
    }
    class DigitReader
    {
        public string sor1;
        public string sor2;
        public string sor3;

        public DigitReader(string sord1, string sord2, string sord3)
        {
            this.sor1 = sord1;
            this.sor2 = sord2;
            this.sor3 = sord3;
        }

        public string Atalakito()
        {

            int hossz = sor1.Length;
            string kimenet = "";
            for (int i = 0; i < hossz; i += 3)
            {
                if (sor1[i] == ' ' && sor1[i + 1] == '_' && sor1[i + 2] == ' ' &&
                    sor2[i] == '|' && sor2[i + 1] == ' ' && sor2[i + 2] == '|' &&
                    sor3[i] == '|' && sor3[i + 1] == '_' && sor3[i + 2] == '|')

                {
                    kimenet += '0';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == ' ' && sor1[i + 2] == ' ' &&
                       sor2[i] == ' ' && sor2[i + 1] == ' ' && sor2[i + 2] == '|' &&
                       sor3[i] == ' ' && sor3[i + 1] == ' ' && sor3[i + 2] == '|')
                {
                    kimenet += '1';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == '_' && sor1[i + 2] == ' ' &&
                    sor2[i] == ' ' && sor2[i + 1] == '_' && sor2[i + 2] == '|' &&
                    sor3[i] == '|' && sor3[i + 1] == '_' && sor3[i + 2] == ' ')

                {
                    kimenet += '2';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == '_' && sor1[i + 2] == ' ' &&
                    sor2[i] == ' ' && sor2[i + 1] == '_' && sor2[i + 2] == '|' &&
                    sor3[i] == ' ' && sor3[i + 1] == '_' && sor3[i + 2] == '|')

                {
                    kimenet += '3';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == ' ' && sor1[i + 2] == ' ' &&
                    sor2[i] == '|' && sor2[i + 1] == '_' && sor2[i + 2] == '|' &&
                    sor3[i] == ' ' && sor3[i + 1] == ' ' && sor3[i + 2] == '|')

                {
                    kimenet += '4';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == '_' && sor1[i + 2] == ' ' &&
                    sor2[i] == '|' && sor2[i + 1] == '_' && sor2[i + 2] == ' ' &&
                    sor3[i] == ' ' && sor3[i + 1] == '_' && sor3[i + 2] == '|')

                {
                    kimenet += '5';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == '_' && sor1[i + 2] == ' ' &&
                   sor2[i] == '|' && sor2[i + 1] == '_' && sor2[i + 2] == ' ' &&
                   sor3[i] == '|' && sor3[i + 1] == '_' && sor3[i + 2] == '|')

                {
                    kimenet += '6';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == '_' && sor1[i + 2] == ' ' &&
                   sor2[i] == ' ' && sor2[i + 1] == ' ' && sor2[i + 2] == '|' &&
                   sor3[i] == ' ' && sor3[i + 1] == ' ' && sor3[i + 2] == '|')

                {
                    kimenet += '7';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == '_' && sor1[i + 2] == ' ' &&
                   sor2[i] == '|' && sor2[i + 1] == '_' && sor2[i + 2] == '|' &&
                   sor3[i] == '|' && sor3[i + 1] == '_' && sor3[i + 2] == '|')

                {
                    kimenet += '8';
                }
                else if (sor1[i] == ' ' && sor1[i + 1] == '_' && sor1[i + 2] == ' ' &&
                            sor2[i] == '|' && sor2[i + 1] == '_' && sor2[i + 2] == '|' &&
                            sor3[i] == ' ' && sor3[i + 1] == '_' && sor3[i + 2] == '|')

                {
                    kimenet += '9';
                }

            }
            return kimenet;
        }







    }


}
