public class HtmlTree {

  public HtmlNode _root { get; init; } 

  public HtmlTree() {

      _root = new HtmlNode("html"); 
	
  }

  // Search operations

  public HtmlNode GetNodeByAttribute(string attributeName, string? attributeValue = null) {
    return null;
  }   

  public HtmlNode GetNodeByAttributeAll(string attributeName, string? attributeValue = null) {
    return null;
  }

    
 
}
