// See https://aka.ms/new-console-template for more information
using SportClub.API.Entities;
using SportClub.API.Extensions;

Console.WriteLine("Hello, World!");

DateTime dt = DateTime.Now;
string formatedDT = dt.ToString("HH:mm");

Console.WriteLine($"Now is: {formatedDT}");

//10.Times(s => Console.WriteLine(s));

decimal? price1 = null;
decimal? price2 = 0M;
decimal? price3 = 1M;

Console.WriteLine( $"price1 is null or zero? {price1 is null or 0M}" );
Console.WriteLine( $"price2 is null or zero? {price2 is null or 0M}" );
Console.WriteLine( $"price3 is null or zero? {price3 is null or 0M}" );

