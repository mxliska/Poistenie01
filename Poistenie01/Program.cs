using Poistenie01;


List<Poisteny> seznamPoistencov =  new List<Poisteny>();
Poistenie poistenie = new Poistenie();
while (true)
{
    Console.WriteLine("Vitejte v evidenci poistenych");
    Console.WriteLine("1. Pridat poisteneho");
    Console.WriteLine("2. Zobrazit seznam vsech pojistenych");
    Console.WriteLine("3. vyhledat poisteneho");
    Console.WriteLine("4. konec") ;

    string volba = Console.ReadLine();

    switch (volba)
    {
        case "1":       //metoda na pridanie noveho poistenca
            poistenie.PridatPoisteneho(seznamPoistencov);
            break;

        case "2":       //metoda na zobrazenie poistencov
            poistenie.ZobrazitPojistenych(seznamPoistencov);
            break;

        case "3":       // Volani metody pro vyhledani pojisteneho
            poistenie.VyhledatPoisteneho(seznamPoistencov); 
            break;
        case "4":       // Ukonceni aplikace
            break;
            Environment.Exit(0); //prerobit na cyklus nech da false
        default:
            Console.WriteLine("Neplatná volba. Zkuste to znovu.");
            break;

    }


}