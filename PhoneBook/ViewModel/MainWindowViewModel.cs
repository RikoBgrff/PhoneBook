using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.ViewModel
{
   public class MainWindowViewModel
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public MainWindowViewModel()
        {

        }
        public List<Contact> ReturnContacts()
        {
            return Contacts;
        }
    }
}
