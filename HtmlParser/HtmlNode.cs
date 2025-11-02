public class HtmlNode {

  public HtmlNode FirstChild { get; set; } = null!;
  public HtmlNode LastChild { get; set; } = null!;

  public HtmlNode PreviousSiblingNode { get; set; } = null!;
  public HtmlNode NextSiblingNode { get; set; } = null!;

  public string ElementType { get; init; } = null!;

  public bool IsClosed { set; get; } = false;

  public HtmlNode(string elementType) {

     ElementType = elementType;

  }

}
