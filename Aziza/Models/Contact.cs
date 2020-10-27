using System.Collections.Generic;

namespace Aziza.Models
{
    public class Contact
    {
        public string Name { get; set; } // E.g. W/a, Telegram, Fixed...
        public string PhoneNumber { get; set; }
    }

    public class Contacter // Контактное лицо
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
