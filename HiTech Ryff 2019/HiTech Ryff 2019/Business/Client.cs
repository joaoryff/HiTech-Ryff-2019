using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTech_Ryff_2019.Business
{
    class Client
    {
        private int cId;
        private string cName;
        private string street;
        private string city;
        private string postalCode;
        private string phone;
        private string faxNumber;
        private float credit;
        private string cemail;

        public int CId { get => cId; set => cId = value; }
        public string CName { get => cName; set => cName = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string Phone { get => phone; set => phone = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public float Credit { get => credit; set => credit = value; }
        public string Cemail { get => cemail; set => cemail = value; }
    }
}
