#include <stdio.h>



int mujstrcmp(char string1[], char string2[]){
    for(int i = 0; i < strlen(string1), i++){
        if (string1[i] != string2[i]){
            return 0;
        }
    }
    return 1;
}

int main(){
    mujstrcmp("chr");
}