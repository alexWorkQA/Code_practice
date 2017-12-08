using System.Collections.Generic;

namespace CodePractice.Models
{
    public class DataModelTask26 
    {
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string AddressUser { get; set; }

        public override bool Equals(object obj)
        {
            return PhoneNumber == ((DataModelTask26) obj).PhoneNumber&&FirstName==((DataModelTask26)obj).FirstName&&AddressUser==((DataModelTask26)obj).AddressUser;
        }

        public override int GetHashCode()
        {
            return PhoneNumber.GetHashCode()^AddressUser.GetHashCode()^FirstName.GetHashCode();
        }
    }
}
