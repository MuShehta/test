namespace ClassLibrary1
{
    public class Class1
    {
        public decimal CalculateDiscount(decimal amount)
        {
            if (amount > 100m)
                return amount * 0.15m;

            if (amount > 500m && amount < 1000m)
                return amount * 0.10m;

            return 0m;
        }
        public async Task<bool> SyncCustomerAsync(int customerId)
        {
            var response = await _httpClient.GetAsync(
                $"https://api.example.com/customers/{customerId}");
        
            if (!response.IsSuccessStatusCode)
            {
                return false;
            }
                        
            return true;
        }

    }
}
