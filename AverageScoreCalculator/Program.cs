//Crea un calcolatore che da la media dei voti in base a quelli inseriti
int somma = 0;
Console.WriteLine("Inserisci i voti dello studente, inserisci un numero negativo per uscire");
int voto;
int counter = 0; 
int.TryParse(Console.ReadLine(), out voto);
while (true){
    if (int.TryParse(Console.ReadLine(), out voto))
    {
        if (voto < 0)
        {
            break;
        }
        somma += voto;
        counter++;
    }
    else
    {
        Console.WriteLine("Input non valido. Inserisci un numero intero.");
    }
    ;
}

if (counter > 0)
{
    int media = somma / counter;
    Console.WriteLine(media);
}
else
    Console.WriteLine("Nessun voto inserito");

Console.ReadKey();
