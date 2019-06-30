## Beginning ASP.NET in C# 4 2010

### Chapter 4: Visual Studio  
Webforms - ASP.net web pages are fueled with C# code.
Webpages(webbforms) are .aspx files with HTML content and they have corresponding .aspx.cs code files. The is called the 'code-behind' approach.  
Some times you can have you code and HTML in same webpage which is not recommended.   
There must be atleast one form element inside the body element and al you pade content in the form element.  
The page directive gives ASP.NET basic information about how to compile the page.   

**Run WebForm App using xsp4 server at a specific port**  
Run this command inside the app directory:  
`$ xsp4 --port 5000`  
The app will run at localhost:5000  

### Chapter 5: Web Form Fundamentals
There are two sets of server-side controls:  
1. HTML server controls: Server based equivalents for standrad HTML elements.     
2. Web controls: Similar to HTML server controls but with richer object model with properties for formating, event and more.  

All the HTML server controls are defined in the System.Web.UI.HtmlControls namespace.  
Each kind of control has a separate class.  See pg 135

To add HTML server control simply add the runat="server" attribute to the HTML element.

The form (HtmlForm object) is the only control you do not need to access in your code behind class.

The web page object doesn't use the attribute system, it doesn't have a control tag. Instead, ASP.NET connects the web page events based on method names.  
In other words, if you have a method named Page_Load() in your page class, ASP.NET connects this event handler to the Page.Load event automatically. This feature is called _automatic event wireup_.

**Using code to connect event**
In this snippet, the OnServerClick event which is an attribute on the ConvertButton control (`<input type="submit" id="ConvertButton" value="Ok">`) is connected to the Convert_ServerClick event handler.  
```
public partial class ConvertPage
{
  protected void Page_Load()
  {
    ConvertButton.ServerClick += this.Convert_ServerClick
  }

  protected void Convert_ServerClick()
  {
    //do somethong
  }

}
```
This is useful for dynamic control creation.  

**Application Event**  
You can't handle application events in the code behind for a web form. Instead, you need the help of the _global.asax_ file.   
The global.asax file allows you to write code that responds to global application events.  

### Chapter 6: Web Controls
HTML server controls, are less important for web forms development.
You’ll only use them if you’re migrating an existing HTML page to the ASP.NET world,
or if you need to have fine-grained control over the HTML code that will be generated and sent to
the client.  

### Chapter 13: Website Navigation
