using SelectionSort;

int[] integerValues = {-11, 12, -42, 0, 1, 90, 6, -9};

Console.Writeline("Vetor Original")

Console.Writeline(stringJoin("|", integerValues));

SelectionSort.SelectionSort.Sort(integerValues);

Console.Writeline("Vetor ordenado");

Console.Writeline(string.Join("|", integerValues));







string[] stringValues = {"Xernobil","Eudes", "Mayckon", "Fernandes", "Serjão", "Gorgulho","Matheus", "Christian"};

Console.Writeline("Vetor Original")

Console.Writeline(stringJoin("|", stringValuesr));

SelectionSort.SelectionSort.Sort(stringValues);

Console.Writeline("Vetor ordenado");

Console.Writeline(string.Join("|", stringValues));

