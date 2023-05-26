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
            new ContactModel { Name = "Joacks Filho", Email = "joackslemos@hotmail.com"},
            new ContactModel { Name = "Heitor Vinícius", Email = "Heitor@hotmail.com"},
            new ContactModel { Name = "Thais Pereira", Email = "Thaislemos@hotmail.com"},
            new ContactModel { Name = "Lara Santello", Email = "Laralemos@hotmail.com"},
        };

        public static List<ContactModel> GetContacts() => _contacts;

        public static ContactModel GetContactById(int contactId)
        {
            return _contacts.FirstOrDefault(c => c.ContactId == contactId);
        }
    }
}
