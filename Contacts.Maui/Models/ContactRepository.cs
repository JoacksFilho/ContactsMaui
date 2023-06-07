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
            var contact = _contacts.FirstOrDefault(c => c.ContactId == contactId);
            if (contact != null)
            {
                return new ContactModel
                {
                    ContactId = contactId,
                    Address = contact.Address,
                    Email = contact.Email,
                    Name = contact.Name,
                    Phone = contact.Phone
                };
            }
            return null;
        }

        public static void UpdateContact(int contactId, ContactModel contact)
        {
            if (contactId != contact.ContactId) return;

            var contactUpdate = _contacts.FirstOrDefault(c => c.ContactId == contactId);
            if (contactUpdate != null)
            {
                //AutoMapper
                contactUpdate.ContactId = contactId;
                contactUpdate.Email =contact.Email;
                contactUpdate.Name = contact.Name;
                contactUpdate.Address = contact.Address;
                contactUpdate.Phone = contact.Phone;
            }
            
        }
    }
}
