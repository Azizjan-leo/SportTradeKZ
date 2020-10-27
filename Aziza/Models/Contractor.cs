using System.Collections.Generic;

namespace Aziza.Models
{
    public class BaseContractor
    {
        public uint Code { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string INN { get; set; }
        public string Comment { get; set; }
        public Contacter Contacter { get; set; }
        public List<Contact> Contacts { get; set; }
        public string RealAddress { get; set; }
        public string LegalAddress { get; set; }
    }

    public class LEContr : BaseContractor // Юр лицо
    {
        public string KBe { get; set; }
        public VAT VAT { get; set; }
    }

    public class IndContr : BaseContractor // Физ лицо
    {
        public string Document { get; set; }
    }
}
