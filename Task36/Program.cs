Random rnd = new Random();
int count  = rnd.Next(1, 11);
var sum = 0;

int[] array = new int[count];

for (int i = 0; i<count; i++) {
    int num = rnd.Next(-10, 11);
    array[i] = num;
}

for (int i = 0; i<array.Length; i++) {
    int num = array[i];
    if ((i + 1) % 2 == 0) {
        sum = sum + num;
    }
}

Console.WriteLine("Сумма элементов массива:");
for (int i = 0; i<array.Length; i++) {
    Console.Write("{0}, ", array[i]);
}
Console.WriteLine("стоящих на нечётных позициях = {0}", sum);