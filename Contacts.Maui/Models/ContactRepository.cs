using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        public static List<ContactModel> _contacts = new List<ContactModel>()
        {
            new ContactModel {ContactId = 1, Name = "Joacks Filho", Email = "joackslemos@hotmail.com"},
            new ContactModel {ContactId = 2, Name = "Heitor Vinícius", Email = "Heitor@hotmail.com"},
            new ContactModel {ContactId = 3, Name = "Thais Pereira", Email = "Thaislemos@hotmail.com"},
            new ContactModel {ContactId = 4, Name = "Lara Santello", Email = "Laralemos@hotmail.com"},
        };

        public static List<ContactModel> GetContacts() => _contacts;

        public static ContactModel GetContactById(int contactId)
        {
            return _contacts.FirstOrDefault(c => c.ContactId == contactId);
        }
    }
}
