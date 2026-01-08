#include <stdio.h>
#include <string.h>
#include <windows.h>

int Odpocet_Sekund(int h, int m, int s){
    int celkemSekundy = 0;
    if (h > 0) {
        celkemSekundy += h * 3600;
    }
    if (m > 0) {
        celkemSekundy += m * 60;
    }
    celkemSekundy += s;
    return 86400 - celkemSekundy;
}



void Odpocet(int sekund){
    while (sekund > 0)
    {
        printf("zbyva %d sekund do pulnoci", sekund);
        printf("\n");
        sekund -= 1;
        Sleep(1000);
    }
    printf("gratujuleme je pulnoc");
}



int main(){
    int hodin, minut, sekund;
    printf("napis kolik je hodin: ");
    scanf(" %d", &hodin);
    printf("napis kolik je minut: ");
    scanf(" %d", &minut);
    printf("napis kolik je sekund: ");
    scanf(" %d", &sekund);
    Odpocet(Odpocet_Sekund(hodin, minut, sekund));
}
