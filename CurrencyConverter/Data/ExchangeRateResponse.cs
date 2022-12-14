namespace CurrencyConverter.Data;
public class Info
{
	public double rate { get; set; }
}

public class Motd
{
	public string msg { get; set; }
	public string url { get; set; }
}

public class Query
{
	public string from { get; set; }
	public string to { get; set; }
	public int amount { get; set; }
}

public class ExchangeRateResponse
{
	public Motd motd { get; set; }
	public bool success { get; set; }
	public Query query { get; set; }
	public Info info { get; set; }
	public bool historical { get; set; }
	public string date { get; set; }
	public double result { get; set; }
}