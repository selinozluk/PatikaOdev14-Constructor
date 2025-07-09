using Constructor;


// 1. Default constructor

Bebek baby1 = new Bebek ();
baby1.Name = "Selin";
baby1.Surname = "Özlük";

Console.WriteLine($"Bebeğin İsmi: {baby1.Name}");
Console.WriteLine($"Bebeğin Soyismi: {baby1.Surname}");
Console.WriteLine($"Bebeğin Doğum Tarihi: {baby1.Birthdate}");

Console.WriteLine("-------------------------------------");

// 2. Parametreli constructor

Bebek baby2 = new Bebek ("Billie", "Eilish");

Console.WriteLine($"Bebeğin İsmi: {baby2.Name}");
Console.WriteLine($"Bebeğin Soyismi: {baby2.Surname}");
Console.WriteLine($"Bebeğin Doğum Tarihi: {baby2.Birthdate}");

