// See https://aka.ms/new-console-template for more information
using Task01.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Task 1
//Write a program to create an interface Searchable with a method Search(string word) that searches for a given keyword in a text document.
//Create two classes Document and WebPage that implement the Searchable interface and provide their own implementations of the Search() method.


WebPage page = new WebPage("<html>Welcome</html>");
Console.WriteLine(page.Search("welcome"));  

Document doc = new Document("This is a test document.");
Console.WriteLine(doc.Search("test")); 
