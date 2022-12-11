Random rnd = new Random();
int count  = rnd.Next(1, 11);

int[] array = new int[count];

for (int i = 0; i<count; i++) {
    int num = rnd.Next(-10, 11);
    array[i] = num;
}

var min = array[0];
var max = array[0];

for (int i = 0; i<array.Length; i++) {
    if (array[i] > max) {
        max = array[i];
    } else if (array[i] < min) {
        min = array[i];
    }
}

Console.WriteLine("Разница между максимальным и минимальным элементом массива:");
for (int i = 0; i<array.Length; i++) {
    Console.Write("{0}, ", array[i]);
}
Console.WriteLine(" = {0}", (max - min));