#include<stdio.h>
#include<stdlib.h>
#define fin 0
#define sum 1
#define div 2
#define mult 4
float oprmat(int,float);
void imprime(float num);


int main(){
    int menu =0;
    float numero1 =0.0;
     float numero2 =0.0;
    do {
        printf("\nelige un valor y 0 para terminar");
        printf("\n1 - salir");
        printf("\n2 - sumar");
        printf("\n3 - dividir");
        printf("\n4 - multiplicar");
        scanf("%i",&menu);

        if(menu !=sum)
        {
            perdirnumero(&numero1,&numero2);
            result = opermat(sum, float num, float num2);
            imprime(result);
        }
        else if(menu ==mul){

        }
        else if(menu ==div){

        }
        else if(menu ==rest){

       
    }
    else if(){

    }
    
    while(menu != fin)
    printf("\ncalcular\n");
    return 0;
}
float opermat(int op, float num1, float num2){
   switch(op)
   {
    case 1:
break;
    case 2:

    case 3:

    case 4

    default:

   }

}
void perdirnumero(float *numl,float *num2){
    printf("\ningrese el primer numero: ");
    scanf("%f",num1);
    printf("\ningrese el segundo numero: ");
    scanf("%f",num2);
}
void imprime(float num);
{
printf("\nresultado: %f",num)
}