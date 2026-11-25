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
    static void DisplayCars(string[] cars)
    {
        Console.WriteLine("Véhicules du garage : ");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine((i+1).ToString() + ". " + cars[i]);
        }
    }
    
    static void Main(string[] args)
    {
        string[] cars = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };

        DisplayCars(cars);
        Console.Write("\n> Veuillez saisir le numéro du véhicule que vous souhaitez remplacer : ");
        int carToReplace = Convert.ToInt32(Console.ReadLine()); // Attention ! Commence à 1 et non 0
        
        Console.Write("\n\n> Veuillez saisir le nom du nouveau véhicule : ");
        string newCar = Console.ReadLine();

        cars[(carToReplace - 1)] = newCar; // Vu que la variable carToReplace est décalée de 1, on le retire 
        DisplayCars(cars);
    }
}