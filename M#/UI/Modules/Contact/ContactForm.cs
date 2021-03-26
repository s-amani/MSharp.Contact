using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Modules
{
    public class ContactForm : FormModule<Domain.Contact>
    {
        public ContactForm()
        {
            HeaderText("Contact Details");

            Field(x => x.Category).Control(ControlType.DropdownList);

            Field(x => x.FirstName).Control(ControlType.Textbox).Mandatory();

            Field(x => x.LastName).Control(ControlType.Textbox);

            Field(x => x.Email).Control(ControlType.Textbox);

            Field(x => x.Tel).Control(ControlType.Textbox).Label("Telephone");

            Button("Cancel").CausesValidation(false)
                .OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.ReturnToPreviousPage();
                });
        }
    }
}
