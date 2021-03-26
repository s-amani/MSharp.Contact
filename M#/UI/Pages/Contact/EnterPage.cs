using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Contact
{
    public class EnterPage : SubPage<ContactPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ContactForm>();
        }
    }
}
