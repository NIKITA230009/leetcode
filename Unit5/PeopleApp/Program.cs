using Packt.Shared;
using System;
using static System.Console;
using System.Collections.Generic;

class Program
{

    public static void Main(string[] args)
    {
        var bob = new Person();
        bob.Name = "Bob Smith";
        bob.DateOfBirth = new DateTime(2002, 5, 29);

        WriteLine(
            format: "{0} was born on {1:dddd, d MMMM yyyy}",
            arg0: bob.Name,
            arg1: bob.DateOfBirth
        );

        var Maria = new Person
        {
            Name = "Maria Fernanda",
            DateOfBirth = new DateTime(2007, 3, 12)
        };

        WriteLine(
            format: "{0} was born on {1: dd MMM yy}",
            arg0: Maria.Name,
            arg1: Maria.DateOfBirth
        );
        bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
        WriteLine(format:
        "{0}'s favorite wonder is {1}. It's integer is {2}.",
        arg0: bob.Name,
        arg1: bob.FavoriteAncientWonder,
        arg2: (int)bob.FavoriteAncientWonder);

        bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
        // bob.BucketList = (WondersOfTheAncientWorld)18;
        WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

        bob.Children.Add(new Person { Name = "Alfred" });
        bob.Children.Add(new Person { Name = "Zoe" });

        WriteLine(
            $"{bob.Name} has {bob.Children.Count} children:"
        );
        // for (int child = 0; child < bob.Childre.Count; child++)
        // {
        //     Writeline($"{bob.Children[child].Name}");
        // }
        foreach (Person child in bob.Children)
        {
            WriteLine(child.Name);
        }

        BankAccount.InterestRate = 0.012M; // хранение общего значения

        var jonesAccount = new BankAccount();
        jonesAccount.AccountName = "Mrs. Jones";
        jonesAccount.Balance = 24000;

        WriteLine(format: "{0} earned {1:C} interest.",
        arg0: jonesAccount.AccountName,
        arg1: jonesAccount.Balance * BankAccount.InterestRate);

        var gerrierAccount = new BankAccount();
        gerrierAccount.AccountName = "Ms. Gerrier";
        gerrierAccount.Balance = 98;

        WriteLine(format: "{0} earned {1:C} interest.",
        arg0: gerrierAccount.AccountName,
        arg1: gerrierAccount.Balance * BankAccount.InterestRate);

        WriteLine($"{bob.Name} is a {Person.Species}");
        WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

        var blankPerson = new Person();

        WriteLine(format:
"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: blankPerson.Name, arg1: blankPerson.HomePlanet,
arg2: blankPerson.Instantiated);

        var gunny = new Person("Gunny", "Mars");

        WriteLine(format:
"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: gunny.Name,
arg1: gunny.HomePlanet,
arg2: gunny.Instantiated);

        bob.WriteToConsole();

        WriteLine(bob.GetOrigin());

        var fruit = bob.GetFruit();
        WriteLine($"{fruit.Name}, {fruit.Numbers} there are");

        (string fruitName, int fruitNumber) = bob.GetFruit();
        WriteLine($"DEconstructed: {fruitName}, {fruitNumber}");

        WriteLine(bob.SayHello());
        WriteLine(bob.SayHello("Mary"));
        WriteLine(bob.OptionalParametrs("Jump", 98.5));

        int a = 10;
        int b = 20;
        int c = 30;

        WriteLine($"Before: a = {a}, b = {b}, c = {c}");

        bob.PassingParametrs(a, ref b, out c);

        WriteLine($"After: a = {a}, b = {b}, c = {c}");

        var sam = new Person
        {
            Name = "Sam",
            DateOfBirth = new DateTime(1972, 1, 27)
        };

        WriteLine(sam.Origin);
        WriteLine(sam.Greeting);
        WriteLine(sam.Age);

        sam.FavouriteIceCream = "Chocolate Fudge";

        WriteLine($"Sam's favorite ice-cream flavor is {sam.FavouriteIceCream}");

        sam.FavoritePrimaryColor = "Red";

        WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");

        sam.Children.Add(new Person { Name = "Charlie" });
        sam.Children.Add(new Person { Name = "Ella" });
        WriteLine($"Sam's first child is {sam.Children[0].Name}");
        WriteLine($"Sam's second child is {sam.Children[1].Name}");
        WriteLine($"Sam's first child is {sam[0].Name}");
        WriteLine($"Sam's second child is {sam[1].Name}");

        var Nikita = new FirstClassPassenger();
        Nikita.AirMiles = 5;

        WriteLine($"{Nikita.AirMiles}");

        object[] passengers = {
            new FirstClassPassenger { AirMiles = 1_419 },
            new FirstClassPassenger { AirMiles = 16_562 },
            new BusinessClassPassenger(),
new CoachClassPassenger { CarryOnKG = 25.7 },
new CoachClassPassenger { CarryOnKG = 0 },
};
        foreach (object passenger in passengers)
        {
            decimal flightCost = passenger switch
            {
                FirstClassPassenger p => p.AirMiles switch
                {
                    > 35000 => 1500M,
                    > 15000 => 1750M,
                    _ => 2000M
                },
                BusinessClassPassenger => 1000M,
                CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                CoachClassPassenger => 650M,
                _ => 800M
            };
            WriteLine($"Flight costs {flightCost:C} for {passenger}");
        }

        // var jeff = new ImmutablePerson
        // {
        //     FirstName = "Jeff"
        //     // LastName = "Winger"
        // };

        // jeff.FirstName = "Geoff";

        var car = new ImmutableVehicle
        {
            Brand = "Mazda MX-5 RF",
            Color = "Soul Red Crystal Metallic",
            Wheels = 4
        };

        var repaintedCar = car with { Color = "Polymetal Grey Metallic" };

        WriteLine("Original color was {0}, new color is {1}.",
arg0: car.Color, arg1: repaintedCar.Color);

        var oscar = new ImmutableAnimal("Oscar", "Labrador");
        var (who, what) = oscar; // вызов деструктора
        WriteLine($"{who} is a {what}.");
    }

}
