using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditcardPayment : Payment
    {
        public CreditcardPayment(
            string cardHoldNumber, 
            string cardNumber, 
            string lastTransactionNumber, 
            DateTime paiDate, 
            DateTime expireDate, 
            decimal total, 
            decimal totalPaid, 
            string payer, 
            Document document, 
            Address address, 
            Email email) : base( 
                paiDate,  
                expireDate,  
                total,  
                totalPaid,  
                payer,  
                document,  
                address,  
                email)
        {
            CardHoldNumber = cardHoldNumber;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHoldNumber { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }
}