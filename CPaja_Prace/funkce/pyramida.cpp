#include <stdio.h>
#include <math.h>



void pyramida(int velikost){
    for(int i = 0; i < velikost + 1; i++){
        for(int z = 0; z < ((velikost - i)); z++){
            printf(" ");
            }
        for(int y = 0; y < i; y++){
            printf("x ");
        }
        printf("\n");
    }
}

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
	int a;
    printf("zadej velikost piramidy: ");
    scanf(" %d", &a);
    pyramida(a );
}
