// This is a comment to my code

//Rakendus küsib kasutajal sisestada tema nime 
//rakendus tervitab kasutajat nimepidi


Console.WriteLine("Enter your name:"); //Output
//String - sõne
String userName; 

 userName=Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!"); //Output

//String interpolation
Console.WriteLine($"Hello, {userName}!"); //Output
