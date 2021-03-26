using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Domain
{
    public class Category : EntityType
    {
        public Category()
        {
            String("Name").Mandatory();
            String("Description", 512).Mandatory();
        }
    }
}
