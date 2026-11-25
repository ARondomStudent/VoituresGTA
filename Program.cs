namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    
    static void Main(string[] args)
    {
        string[] cars = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };
        
        Console.WriteLine("Vehicules du garage :");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine("- " + cars[i]);
        }
        
        Console.WriteLine("Choisis le numero du vehicule a remplacer (1 a 5) :");
        int carChoice = int.Parse(Console.ReadLine());
        int carIndex = carChoice - 1;
        
        Console.WriteLine("Entre le nom du nouveau vehicule :");
        string newCar = Console.ReadLine();
        cars[carIndex] = newCar;
        
        Console.WriteLine("Garage actualise :");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine((i + 1) + " - " + cars[i]);
        }
    }
}