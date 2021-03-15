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
    }
}
