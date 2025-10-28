public class Program {

  public static async Task Main(string[] args) {

	string baseUrl = "https://developer.chrome.com/";

	HttpClientWrapper clientWrapper = new();

        WebsiteService chromeDeveloperWebsite = new(clientWrapper.GetHttpClient(), baseUrl);
        
        string robotsData = await chromeDeveloperWebsite.GetRobotsTxtFile();

        Console.WriteLine($"robotsData: {robotsData}");

  }

}
