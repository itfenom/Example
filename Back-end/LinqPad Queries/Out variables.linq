<Query Kind="Program" />

//C# 7
public void Main()
{
	PrintStars("14");//Output: 14
	PrintStars("14s");//Output: Cloudy - no stars tonight!
}

public void PrintStars(string s)
{
    if (int.TryParse(s, out var i)) { Console.WriteLine(i); }
    else { Console.WriteLine("Cloudy - no stars tonight!"); }
}