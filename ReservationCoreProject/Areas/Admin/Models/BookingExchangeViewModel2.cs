namespace ReservationCoreProject.Areas.Admin.Models
{
    public class BookingExchangeViewModel2
    {

        public string BaseCurrency { get; set; }
        public string BaseCurrencyDate { get; set; }
        public ExchangeRates[] ExchangeRate { get; set; }


        public class ExchangeRates

        {
            public string ExchangeRateBuy { get; set; }
            public string Currency { get; set; }
        }
    }
}
