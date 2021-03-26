using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Contact
{
    public class ContactPage : RootPage
    {
        public ContactPage()
        {
            Add<Modules.MainMenu>();

            OnStart(x => x.Go<ContactsPage>().RunServerSide());
        }
    }
}
