int points = 0;

Console.WriteLine("Välkommen till min frågesport, Difficulty ok");


Console.WriteLine("Vad är en kyckling?");
Console.WriteLine(" a) En fågel  b) En annan fågel c) Ok jag håller med");
string val_1 = Console.ReadLine();

if (val_1 == "c")
{

points++;
Console.WriteLine("JA DU FICK RÄTT!!");

}
else {

    Console.WriteLine("Jag tror du fick fel är inte säker dock");
}

Console.WriteLine("Okej nästa fråga");
Console.WriteLine("Varför finns solen?");
Console.WriteLine(" a) För att skapa liv på jorden  b) För att jag Richard sa till solen att det var kallt en dag och att jag ville ha värme  c) För den är cooool");
string val_2 = Console.ReadLine();

if (val_2 == "c")
{

points++;
Console.WriteLine("Bazinga du fick rätt");


}
else {

    Console.WriteLine("Bombaclatt du måste studera mer");
}

Console.WriteLine("Okej nästa");
Console.WriteLine("Vad gör en doktor?");
Console.WriteLine(" a) Hjälper människor....  b) Kanske äter choklad på helgen  c) Professionell mario cart spelare");
string val_3 = Console.ReadLine();

if(val_3 == "a")
{
points++;
Console.WriteLine("Wowzers du hade faktiskt rätt");

}
else {

Console.WriteLine("Varför skulle det vara det här svaret???");

}
Console.ReadLine();
