using System;
using System.IO;

string file = "input.txt";
int res = 0;

int pos = 50;
foreach (string line in File.ReadLines(file))
{ 
    int.TryParse(line.Substring(1), out int dist);
    if (line[0] == 'L')
    {
        
    }
    else
    {
       
    }
    //Console.WriteLine(pos);
    if(pos == 0)
    {
        res+=1;
    }
}
Console.WriteLine(res);