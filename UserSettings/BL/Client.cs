using System;
using System.Collections.Generic;
using System.Text;

namespace UserSettings.BL
{
    public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_IdNumber;
        private int m_PhoneNumber;
        private int m_ZipCode;
        private string m_Email;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int IdNumber { get => m_IdNumber; set => m_IdNumber = value; }
        public int PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public int ZipCode { get => m_ZipCode; set => m_ZipCode = value; }
        public string Email { get => m_Email; set => m_Email = value; }
    }
}
