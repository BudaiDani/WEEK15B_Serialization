using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    [Serializable]
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private int phone;

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private DateTime dateOfRec;

        public DateTime DateofRec
        {
            get { return dateOfRec; }
            set { dateOfRec = value; }
        }

        private int serial;

        public int Serial
        {
            get { return serial; }
            set { serial = value; }
        }
    }
}
