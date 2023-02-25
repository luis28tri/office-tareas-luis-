#include <stdio.h>

int main(){
int a[4][4];
int c, f, b, j;
int suma= 0;
for (c=1; c <= 4; c++)
{
    for (f=1; f <= 4; f++){
        suma+= f;
        b+= c;
  printf("|%d|", c);
   
     };
    
       printf("\n\t |%d|", suma);
        suma=0;
}
    return 0;
}