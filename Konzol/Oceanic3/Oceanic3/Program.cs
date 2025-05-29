// See https://aka.ms/new-console-template for more information
using Oceanic3;
using System.Globalization;

Console.WriteLine("Hello, World!");
List<Berles> berlesLista = new List<Berles>();

var szoveg = File.ReadAllLines("yacht_berlesek_2024.csv");

for (int i = 1; i < szoveg.Length; i++)
{


    var sor = szoveg[i].Split(';');

    berlesLista.Add(
        new Berles
        {
            Uid =int.Parse(sor[0]),
            YachtId =int.Parse(sor[1]),
            StartDate = DateTime.ParseExact(sor[2], "yyyy-MM-dd", CultureInfo.InvariantCulture),
            EndDate = DateTime.ParseExact(sor[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
            DailyPrice = decimal.Parse(sor[4]),
            Name =sor[5]

        });
}

Console.Write("Adjon meg egy hónapot(1-12):");
int honap = int.Parse(Console.ReadLine());

var evesBevetel = berlesLista
    .Sum(berles => berles.TotalPrice);

Console.WriteLine($"A teljes 2024-es éves bevétel: {evesBevetel:N0} euró.");



var legnagyobbBevetel = berlesLista
    .OrderByDescending(b => b.TotalPrice).First();
Console.WriteLine($"A legdrágább bérlés az {legnagyobbBevetel.Name} volt, teljes ár: {legnagyobbBevetel.TotalPrice:N0} euró");

var yachtokSzama = berlesLista
    .GroupBy(b => b.YachtId)
    .Distinct()
    .Count();

Console.WriteLine($"Összeesen {yachtokSzama} különböző yachtot bérltek ki.");

var leggyakrabbanBereltYacht = berlesLista
    .GroupBy(b => b.Name)
    .Select(b => new
    {
        nev = b.Key,
        db = b.Count()
    })
    .OrderByDescending(b => b.db)
    .First();
    
Console.WriteLine($"A legtöbbször bérelt yacht: {leggyakrabbanBereltYacht.nev} ({leggyakrabbanBereltYacht.db} bérlés)");

var yachtBerlesekIdeje = berlesLista
    .Average(b => (b.EndDate - b.StartDate).Days + 1);
Console.WriteLine($"Átlagos bérlési időtartam: {yachtBerlesekIdeje:N2}nap");
Console.ReadLine();
