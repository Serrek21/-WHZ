using System;
using System.Collections.Generic;

// Завдання 1
class Film : IDisposable
{
    public string Title { get; set; } // Назва
    public string Studio { get; set; } // Назва студії
    public string Genre { get; set; } // Жанр
    public int Duration { get; set; } // Тривалість
    public int Year { get; set; } //Рік випуску

    // Конструктор класу
    public Film(string title, string studio, string genre, int duration, int year)
    {
        Title = title;
        Studio = studio;
        Genre = genre;
        Duration = duration;
        Year = year;
    }

    // Деструктор
    ~Film()
    {
        Console.WriteLine($"Фільм {Title} був видалений через деструктор");
        Dispose();
    }

    // Метод для інтерфейсу
    public void Dispose()
    {
        Console.WriteLine($"Фільм {Title} був видалений через Dispose метод");



    }
}


class Show : IDisposable
{
    public string Title { get; set; } // Назва
    public string Theater { get; set; } // Назва Театру
    public string Genre { get; set; } // Жанр
    public int Duration { get; set; } // Тривалість
    public List<string> Actors { get; set; } // Актори

    public Show(string title, string theater, string genre, int duration, List<string> actors)
    {
        Title = title;
        Theater = theater;
        Genre = genre;
        Duration = duration;
        Actors = actors;
    }

    ~Show()
    {
        Console.WriteLine($"Вистава {Title} була видалена через деструктор");
    }

    public void Dispose()
    {
        Console.WriteLine($"Вистава {Title} була видалена через Dispose метод");
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (Film film = new Film("Shrek", "Dreamworks.", "Fantasy", 94, 2001))
        {
            Console.WriteLine($"Film: {film.Title}, Year: {film.Year}");
        }
        List<string> actors = new List<string>() { "Johnny Depp", "Penelope Cruz", "Geoffrey Rush" };
        Show show = new Show("Pirates of the Caribbean", "Royal Theatre", "Adventure", 150, actors);
        Console.WriteLine($"Performance: {show.Title}, Theater: {show.Theater}");
    }
}