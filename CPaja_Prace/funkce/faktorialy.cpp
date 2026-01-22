#include <stdio.h>



int faktorial(int n){
    if(n == 0){
        return 1;
    }
    return n * faktorial(n-1);
}


int main(){
    int a;
    printf("zadej co chces vyfaktoriovat: ");
    scanf(" %d", &a);
    printf("vysledek pro %d! je %d", a, faktorial(a));
    return 0;
}