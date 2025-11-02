// NOTES: Consider if I may ever need to take in input as a stream (from the http client)

public class HtmlString {

  private string BackingString { get; init; } = null!;
  private int index { get; set; } = 0;

  public HtmlString(string htmlBackingString) {

    BackingString = htmlBackingString; 

  }

  public HtmlNode GetNextElement() {

     HtmlNode node;

     bool openingCarrotFound = false;

     while(index < BackingString.Length) { // It might be possible to short circuit this

        char character = BackingString[index];  

        if(character == '<' && !openingCarrotFound) {

        } else {
	  // Do I need to throw an error? if the opening character have been found, and then it runs into another one?
	} 

     } 	

  }

}

public class Parser {

  Stack<string> nodeStack { get; init; } = null!;
  HtmlTree htmlTree { get; init; }

  string HtmlString { get; init; }


  public Parser(string htmlString) {
   
    HtmlString = htmlString;
    htmlTree = new();  
       
  }

  

  public void AttributeParser(string openingTag) {

  }

  public string GetOpeningTag() {
	return "";
  } 
    
  public string GetClosingTag() {
       return "";
  }

}
