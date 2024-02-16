using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ExchangeRateService service = new ExchangeRateService();

// REST API to get exchange rates based on input currencies
app.MapPost("/", service.GetExchangeRates);

app.Run();

public struct CnbRatesResponse
{
    [JsonPropertyName("rates")] public List<Rate> Rates { get; set; }
}

public struct Rate
{
    [JsonPropertyName("currencyCode")] public string CurrencyCode { get; set; }
    [JsonPropertyName("rate")] public float RateValue { get; set; }
}

internal class ExchangeRateService
{
    private const string MainCurrenciesUrl = "https://api.cnb.cz/cnbapi/exrates/daily";

    public IEnumerable<Rate> GetExchangeRates(List<string> currencies)
    {
        HttpClient client = new HttpClient();
			
        var data = client.GetStringAsync(MainCurrenciesUrl).Result;
        var response = JsonSerializer.Deserialize<CnbRatesResponse>(data);

        return response.Rates.Select(rate => rate).Where(rate => currencies.Contains(rate.CurrencyCode));
    }
}
