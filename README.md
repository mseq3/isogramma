# Descrizione

#### Il linguaggio utilizzato in questo codice è il C#

> Per risolvere questo esercizio bisogna superare 13 test.

#### **Scrivere un programma che determina se una parola o una frase è un isogramma: un isogramma è una parola o una frase che non ha lettere ripetute.**
Esempi di isogrammi:

- lumberjacks
- background
- downstream
- six-year-old

Gli isogrammi possono essere utili come chiavi di cifratura dato che la corrispondenza fra lettere è univoca. 

Isogrammi di 10 lettere, per esempio PATHFINDER, DUMBWAITER o BLACKHORSE, possono essere utilizzate da venditori di beni il cui prezzo può essere negoziato, come macchine usate, gioielli e antichità.

Per esempio le cifre decimali possono essere mappate secondo questo schema:

P	A	T	H	F	I	N	D	E	R

1	2	3	4	5	6	7	8	9	0

Ammettiamo che il prezzo indicato fosse 1200 € ma nel cartellino ci fossero anche le lettere FRR, il venditore saprebbe che il prezzo originale era 500 € in modo da non scendere sotto quella soglia.

Un isogramma di 12 lettere si può usare per mappare i mesi dell'anno.

[Wikipedia sugli Isogrammi](https://it.wikipedia.org/wiki/Isogramma)

# Descrizione della soluzione
``` c#
 word = word.ToLower();
        for(int i = 0; i < word.Length; i++)
        for(int j = 0; j < word.Length; j++)
        if((word[i] == word[j]) && (i != j) && (word[i] !=' ') && (word[i]!= '-'))
        return false;
       
        return true;

``` 
> Viene convertita la stringa in minuscolo usando il metodo ToLower(). Viene utilizzato un doppio ciclo for per confrontare ogni coppia di caratteri nella stringa. Se due caratteri uguali vengono trovati ad eccezione degli spazi e dei trattini, la funzione restituisce immediatamente false, poiché la stringa non può essere un'isogramma. Se la funzione esce dal ciclo for senza trovare alcuna coppia di caratteri ripetuti, restituisce true poiché la stringa è un'isogramma.

