using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if(string.IsNullOrEmpty(firstName))
                AddNotification("Name.FirstName","Nome invalido");
            
            if(string.IsNullOrEmpty(LastName))
                AddNotification("Name.FirstName","Nome invalido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}