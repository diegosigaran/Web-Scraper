public class HttpClientWrapper {

  HttpClient _client;

  public HttpClientWrapper() {
	_client = new();
  }

  public HttpClient GetHttpClient() {
        return _client;
  } 

}
