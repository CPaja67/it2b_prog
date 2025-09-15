#include <stdio.h>

int main(void) {
    int dny = 0;
    int hodina, minuty;
    int rychlost, vzdalenost;

    printf("napis cas odletu (hodina, mezera, minuta): ");
    if (scanf("%d %d", &hodina, &minuty) != 2) return 1;
    printf("napis rychlost letadla v km/h: ");
    if (scanf("%d", &rychlost) != 1) return 1;
    printf("napis vzdalenost od cile v km: ");
    if (scanf("%d", &vzdalenost) != 1) return 1;

    /* Celkový let v minutách (zaokrouhleno) */
    double totalMinutesD = (double)vzdalenost / (double)rychlost * 60.0;
    int totalMinutes = (int)(totalMinutesD + 0.5); /* zaokrouhlení na nejbližší minutu */

    /* Přičteme k času odletu */
    int arrivalMinutesTotal = hodina * 60 + minuty + totalMinutes;

    dny = arrivalMinutesTotal / (24 * 60);
    int arrivalMinutesOfDay = arrivalMinutesTotal % (24 * 60);
    int arrivalHour = arrivalMinutesOfDay / 60;
    int arrivalMinute = arrivalMinutesOfDay % 60;

    printf("priletite za %d dny v %02d:%02d\n", dny, arrivalHour, arrivalMinute);
    return 0;
}
