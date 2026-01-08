#include <stdio.h>





int chlast(int pocetLidi){
    int CelkemChlastu;
    for (int i = 0; i < pocetLidi; i++)
    {
        for (int x = 0; x < pocetLidi - i; x++)
        {
            CelkemChlastu +=1;
        }
        
    }
    



    return CelkemChlastu;
}



int main(){
    int n;
    printf("zadej pocet lidi na vecirku: ");
    scanf(" %d", &n);
    printf(" celkem chalst %d", chlast(n));
    return 0;
}