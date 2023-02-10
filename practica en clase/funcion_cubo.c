#include<stdio.h>
#include<stdlib.h>

void cubo(int, int *);
int main()
{
    int result = 0;
    int i;

    for(i=1; i<100; i++)
    {
        cubo(i, &result);
        printf("\n el cubo de %i es %i",i,result);
    }
    
    return 0;
}
void cubo (int a, int *b)
{
    *b= a*a*a;
}