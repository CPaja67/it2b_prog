#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(){
  char str1[20], str2[20];

  printf("zadej prvni string: ");
  scanf(" %19s", str1);
  printf("zadej druhy string: ");
  scanf(" %19s", str2);

  if(strcmp(str1, str2) == 0){
    printf("stringy se rovnaji");
  }
  else{
    printf("stringy se nerovnaji");
  }
}
