public class Program {

  public static async Task Main(string[] args) {

	string baseUrl = "https://developer.chrome.com/";

	await GetRobotsData(baseUrl);

  }

  public static async Task GetRobotsData(string baseUrl) {

	string robotsFileUrl = baseUrl + "robots.txt";

	HttpClient client = new HttpClient();
	HttpResponseMessage response = await client.GetAsync(robotsFileUrl);
	response.EnsureSuccessStatusCode();
	string responseBody = await response.Content.ReadAsStringAsync();

  }

}

public class HttpClientWrapper {

  HttpClient _client;

  public HttpClientWrapper () {
	_client = new();
  }

  public async Task<string> GetRobotsData(string baseUrl) {

    string robotsFileUrl = baseUrl + "robots.txt";

    HttpResponseMessage response = await _client.GetAsync(robotsFileUrl);

    response.EnsureSuccessStatusCode();

    string responseBody = await response.Content.ReadAsStringAsync();

    return responseBody;

  }

}
