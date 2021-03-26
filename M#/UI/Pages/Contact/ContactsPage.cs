using System;
using System.Collections.Generic;
using System.Text;
using Contact;
using MSharp;

namespace Contact
{
    public class ContactsPage : SubPage<ContactPage>
    {
        public ContactsPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ContactsList>();
        }
    }
}
