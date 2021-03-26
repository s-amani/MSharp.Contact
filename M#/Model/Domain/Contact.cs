using MSharp;

namespace Domain
{
    public class Contact : EntityType
    {
        public Contact()
        {
            String("First name", 32).Mandatory();
            String("Last name", 32).Mandatory();
            String("Tel").Mandatory();
            String("Email").Mandatory().Accepts(TextPattern.EmailAddress);

            Associate<Category>("Category").Mandatory();
        }
    }
}
