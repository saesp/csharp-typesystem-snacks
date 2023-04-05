//Istruzioni condizionali

//1. L’utente inserisce due numeri in successione.
//Il software stampa il maggiore.

//Console.WriteLine("Inserisci un numero:");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserisci un altro numero:");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//    Console.WriteLine($"Il numero maggiore è: {num1}");
//else
//    Console.WriteLine($"Il numero maggiore è: {num2}");



//2. L’utente inserisce due parole in successione.
//	Il software stampa prima la parola più corta, poi la parola più lunga.

//Console.WriteLine("Inserisci una parola:");
//string word1 = Console.ReadLine();

//Console.WriteLine("Inserisci un'altra parola:");
//string word2 = Console.ReadLine();

//if (word1.Length > word2.Length)
//{
//    Console.WriteLine($"Parola più corta: {word2}");
//    Console.WriteLine($"Parola più lunga: {word1}");
//}
//else
//{
//    Console.WriteLine($"Parola più corta: {word1}");
//    Console.WriteLine($"Parola più lunga: {word2}");
//}




//Ciclo for

//    3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
//       Il programma stampa la somma di tutti i numeri inseriti.

int[] array = new int[10];
int sum = 0; 

for (var i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero:");
    int num = Convert.ToInt32(Console.ReadLine());

    array[i] = num;

    sum += num;
}
    Console.WriteLine($"Somma: {sum}");





//    4. Calcola la somma e la media dei numeri da 2 a 10.
//byte sum = 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;
//Console.WriteLine($"Somma: {sum}");

//int average = sum / 9;
//Console.WriteLine($"Media: {average}");



//Operatore modulo
//    5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

//Console.WriteLine("Inserisci un numero:");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 2 == 0)
//    Console.WriteLine($"{num} è pari");
//else
//    Console.WriteLine($"{num} è dispari");



//Array

//    6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

//string[] guestList = { "Davide", "Thomas", "Claudia", "Emily", "Salvatore" };

//Console.WriteLine("Inserisci il tuo nome");
//string nameUser = Console.ReadLine();

//if (guestList.Contains(nameUser))
//    Console.WriteLine("Sei invitato! Ci vediamo alla festa :)");
//else
//    Console.WriteLine("Sorry, non sei invitato.");



//7.Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

//int[] numbersArray = new int[6];
//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine("Inserisci un numero:");
//    int num = Convert.ToInt32(Console.ReadLine());

//    if (num % 2 == 0)
//        numbersArray[i] = num;
//}

//Console.WriteLine("Even array: ");
//for (int i = numbersArray[0]; i<6; i++)
//    Console.WriteLine(numbersArray[i]);




//    8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
int[] numbersArray = { 2, 5, 3, 4, 1 };









//Ciclo while
//    9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.


//Random
//    10. Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.



//Funzioni
//    11. Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.
//    12. Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari. (modificato) 
