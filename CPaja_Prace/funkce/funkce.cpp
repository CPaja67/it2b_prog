#include <stdio.h>
#include <math.h>

int max(int a, int b){
    if (a>b){
        return a;
    }
    else{
        return b;
    }
    return 1;
}

int main(){
    int a, b;
    printf("zadej polomer valce: ");
    scanf(" %d", &a);
    printf("zadej vysku valce: ");
    scanf(" %d", &b);
    printf("cislo %d je nejvetsi", max(a, b));
}