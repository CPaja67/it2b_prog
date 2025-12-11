#include <stdio.h>
#include <math.h>



void pyramida(int velikost, int offset){
    for(int i = 0; i < velikost + 1; i++){
        for(int z = 0; z < ((velikost - i) + offset); z++){
            printf(" ");
            }
        for(int y = 0; y < i; y++){
            printf("x ");
        }
		printf("\n");
		
    }
}



void trojstroj(int vyska,int offset, int offsetDole){
	for(int i = 0; i < vyska; i++){
		for(int x = 0; x < offset -1; x++){
			printf(" ");
		}
		printf("x");
		printf("\n");
	}
	for (int d = 0; d < offsetDole; d++){
		printf(" ");
	}
	for (int z = 0; z < vyska; z++){
		printf("x ");
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

int strom(int a){
    pyramida(a, 4);
    pyramida(a + 2, 2);
    pyramida(a + 4, 0);
    trojstroj(a, a + 4, 4);
    return 0;
}


int main(){
	int a;
    printf("zadej velikost piramidy: ");
    scanf(" %d", &a);
    return strom(a);
}
