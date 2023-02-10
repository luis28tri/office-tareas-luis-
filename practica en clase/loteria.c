#include <stdio.h>
#include <stdlib.h>
#include<time.h>

int main(){

    int menu= 0;
    time_t seed= 0;
    srand(time(&seed));
    unsigned int numero =0;
    unsigned int primera =0;
    unsigned int segunda=0;
    unsigned int tercera =0;

    printf("loteria calse programacion\n");
    do
    {
        printf("\n0 -salir");
        printf("\nl - jugar");
        printf("\neleige una opcion:");
        scanf("%d",&menu);
    
    if(menu ==1)
    {
        do{
        
        printf("\ningresatu numero: ");
        scanf("%d", &numero);
        if(numero)
        {
            printf("\nel numero de ser entre 0 y 100\n");
        }
        }while(numero >= 0 & & numero <= 100);

        primera = rand() % 100;
        segunda = rand() % 100;
        tercera = rand() % 100;

        if(numero == primera)
        {
            printf("te sacaste en primera");
        }else if(numero == segunda){
            printf("te sacaste en segunda");
        }else if(numero == tercera){
            printf("te sacaste en tercera");
        }else{
            printf("\nte guallaste");

        }
        printf("\nprimera: %d", primera);
        printf("\nsegundo: %d", segunda);
        printf("\ntercera: %d", tercera);
        printf("\n");
    }
        }
        while(menu !=0);
return 0;
}
