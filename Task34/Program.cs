Random rnd = new Random();
int count  = rnd.Next(1, 11);
var counter = 0;

int[] array = new int[count];

for (int i = 0; i<count; i++) {
    int num = rnd.Next(100, 1000);
    array[i] = num;
}

for (int i = 0; i<array.Length; i++) {
    int num = array[i];
    if (num % 2 == 0) {
        counter ++;
    }
}

Console.WriteLine("массив:");
for (int i = 0; i<array.Length; i++) {
    Console.Write("{0}, ", array[i]);
}

Console.WriteLine(" имеет {0} четных чисел в массиве", counter);