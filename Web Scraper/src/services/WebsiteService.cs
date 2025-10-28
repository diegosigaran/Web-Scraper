public class WebsiteService {

  private Uri _uri { set; get; }
  private HttpClient _client;

  public WebsiteService(HttpClient client, string uriString) {
    _client = client;
    _uri = new Uri(uriString); 
  }

  public WebsiteService(HttpClient client, Uri uri) {
    _client = client;
    _uri = uri;
  }

  public async Task<string> GetRobotsTxtFile() {

    HttpResponseMessage reponse = await _client.GetAsync(_uri.OriginalString + "/robots.txt");    
    reponse.EnsureSuccessStatusCode();
    return await reponse.Content.ReadAsStringAsync();

  }

}
