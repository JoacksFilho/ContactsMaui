﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Maui.Models
{
    public class ContactModel
    {
        public int ContactId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

    }
}
