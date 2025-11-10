#include <stdio.h>
#include <string.h>


int main(){
 
  int i = 0;
  char string[67] = "ahoj jak se mas ja dobre dikec";

  printf("zadej nejaky string: ");
  scanf(" %100s ", string);
  printf("\ndelka je: %d", strlen(string));

  
  return 0;
}
