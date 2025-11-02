public class WebsiteService {

  private Uri _uri { set; get; }
  private HttpClient _client;

  public WebsiteService(HttpClient client, string uriString) {
    _client = client;
    _uri = new Uri(uriString); 
  }

  public WebsiteService(HttpClient client, Uri uri) {
    _client = client;

    // Ask yourself, why would you need these changes to the header?
    //_client.DefaultRequestHeaders.Clear();
    //_client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
    //_client.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
    //_client.DefaultRequestHeaders.AcceptLanguage.ParseAdd("en-US,en;q=0.5");

    _uri = uri;
  }

  public async Task<string> GetRawHtml() {

    HttpResponseMessage response = await _client.GetAsync(_uri.OriginalString);
    response.EnsureSuccessStatusCode();

    string responseStr = await response.Content.ReadAsStringAsync();

    #if DEBUG

	//Console.WriteLine($"print debug");

    #endif
  
    return responseStr; 

  }

  public async Task<string> GetRobotsTxtFile() {

    HttpResponseMessage reponse = await _client.GetAsync(_uri.OriginalString + "/robots.txt");    
    reponse.EnsureSuccessStatusCode();
    return await reponse.Content.ReadAsStringAsync();

  }

}
