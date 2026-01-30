#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int num = 0;
int ugh = 0;
int masiv[] = {0, 1, 2, 3, 4, 5};

int count(){
    ugh = ugh + masiv[num];
    num++;
    printf("%d+", masiv[num]);
    if (num < 6){
        count();
    }
}

int main(){
    count();
    printf("\n%d", ugh);
    return 0;
}


    