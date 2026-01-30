// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int i, t, j, s, n;
n = 10;
int[] a = [1,1,1,1,1,1,1,1,1,1,1]; 

int x = 0;


t = 0;
for (i = 1;i != n+1;i++){
    s = 0;
    for (j = 1;j !=i+1;j++){
        s = s + a[j];
        x++;
    }
    t = t + (s*s);
    x++;
}

Console.WriteLine(x);