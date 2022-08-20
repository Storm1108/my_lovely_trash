int[] A = new int[3];
int[] B = new int[3];
int dist = 0;
int i =0;
while (i < 3){
    Console.Write("Введите " +  (i+1) + " координату точки A: ");
    A[i]=Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите " +  (i+1) + " координату точки B: ");
    B[i]=Convert.ToInt32(Console.ReadLine());
    dist += ((A[i]-B[i]) * (A[i]-B[i]));
    i++;
}
    System.Console.WriteLine($"A[{String.Join("; ", A)}]");
    System.Console.WriteLine($"A[{String.Join("; ", B)}]");
    System.Console.WriteLine("Расстояние м/у этими точками равно " + dist);