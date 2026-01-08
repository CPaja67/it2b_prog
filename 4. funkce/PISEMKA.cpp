#include <stdio.h>



int jePoleKladne(int pole[], int delka){
    for (int i = 0; i < delka; i++){
        if(pole[i] <= 0) return 0;
    }
    return 1;
}


void histogram(int pole[], int delka){
    printf("Histogram: \n");

    if(jePoleKladne(pole, delka) == 0) {
        printf("CHYBA");
        return;
    }

    for (int i = 0; i < delka; i++) {
        printf("|");
        for (int x = 0; x < pole[i]; x++){
            printf("*");
        }
        printf("\n");
    }
    
}



int main(){
    int pole[19] = {1, 2, 3, 5, 8, 12, 18, 25, 30, 32, 30, 25, 18, 12, 8, 5, 3, 2, 1}, delka = 19;
    printf("je pole kladne?: %d", jePoleKladne(pole, delka));
    printf("\n");
    histogram(pole, delka);
    return 0;
}
