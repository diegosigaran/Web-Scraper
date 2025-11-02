//using HtmlParser;

public class Program {

  public static async Task Main(string[] args) {

	//string baseUrl = "https://developer.chrome.com/";
	//string baseUrl = "https://arm-creative.com/";
        string baseUrl = "https://static.app";

	HttpClientWrapper clientWrapper = new();

        WebsiteService chromeDeveloperWebsite = new(clientWrapper.GetHttpClient(), baseUrl);

        string rawHtml = await chromeDeveloperWebsite.GetRawHtml();
        Console.WriteLine($"{rawHtml}");

	Parser htmlParser = new(rawHtml); 

  }

}
