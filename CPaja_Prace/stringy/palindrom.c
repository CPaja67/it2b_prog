#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
  char string[30];
  int x = 0;
  printf("zadej mozny palindrom: ");
  scanf(" %29s", string);

  for (int i = 0;i < strlen(string);i++) {
    if(string[i] == string[strlen(string) - i - 1]){
      x++;
    }
    else{
      printf("neni palindrom");
      return 0;
    } 
  }

  printf("je to palindorm");
    return 0;
}
