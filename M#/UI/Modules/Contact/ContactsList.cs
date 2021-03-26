using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Modules
{
    public class ContactsList : ListModule<Domain.Contact>
    {
        public ContactsList()
        {
            Column(x => x.Category);
            Column(x => x.FirstName);
            Column(x => x.LastName);
            Column(x => x.Tel).LabelText("Telephone");
            Column(x => x.Email);

            ButtonColumn("Edit").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Edit)
                .OnClick(x => x.Go<Contact.EnterPage>()
                    .Send("item", "item.ID").SendReturnUrl(false));

            ButtonColumn("Delete").HeaderText("Actions")
                .GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Contact?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("Add Contact")
                .Icon(FA.Plus)
                .OnClick(x => x.Go<Contact.EnterPage>().SendReturnUrl(false));

        }
    }
}
