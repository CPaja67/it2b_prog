#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
  char heslo[100] = "";
  printf("zadej tvoje pocity: \n");
  scanf(" %100s", heslo);
  
  
  for (int i = 0; heslo[i] != '\0'; i++) {
    if(i % 2 == 0){
      printf("%c", heslo[i]);
    }
    else {
      printf("#");
    }
  }

  return 0;
}
