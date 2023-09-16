// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter You name: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша"){
    Console.WriteLine("Это же МАША!!!");

}
else {
    Console.WriteLine("HI You name is: " + username);
}