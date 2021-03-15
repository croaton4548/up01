using System;
using System.Collections.Generic;
using System.Text;

namespace UP_01
{
    class Class1
    {
        private string name;
        private string cipher;
        private int count;

        public string GetName
        {
            get
            {
                return name;
            }
            set
            {
                this.name = GetName;
            }
        }

        public string GetCipher
        {
            get
            {
                return cipher;
            }
            set
            {
                this.cipher = GetCipher;
            }
        }

        public int GetCount
        {
            get
            {
                return count;
            }
            set
            {
                this.count = GetCount;
            }
        }

        public Class1(string name, string cipher, int count)
        {
            this.name = name;
            this.cipher = cipher;
            this.count = count;
        }

        public Class1()
        {
            name = "";
            cipher = "";
            count = 0;
        }

        public void SetInfo()
        {
            Console.Write("Название: ");
            this.name = Console.ReadLine();
            Console.Write("Шифр: ");
            this.cipher = Console.ReadLine();
            Console.Write("Количество: ");
            this.count = Convert.ToInt32(Console.ReadLine());
        }

        public void GetInfo()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Шифр: " + cipher);
            Console.WriteLine("Количество: " + count);
        }
    }
}
