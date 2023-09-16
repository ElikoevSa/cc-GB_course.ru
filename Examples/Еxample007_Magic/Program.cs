// See https://aka.ms/new-console-template for more information
Console.Clear();

int xa = 1; 
int ya = 1;
int xb = 1; 
int yb = 30;
int xc = 40; 
int yc = 30;
int count = 0;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = ya;

while( count < 1000)
{
    int rint = new Random().Next(0,3);
    if (rint == 0){
        x = (x +xa)/2;
        y = (y+ya)/2;
    }
    if (rint==1){
        x = (x+xb) /2;
        y = (y+yb)/2;
        }
    if(rint == 2){
        x = (x+xc)/2;
        y= (y+yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}
