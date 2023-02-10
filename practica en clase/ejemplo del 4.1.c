int  cubo(int);
int sumaInt (int a, int b);
 void main (void)
{
    int I;
    int B;
    int r;
    int CUB;

    for(I = 1, B = 100; I <= 10; I++, B--)
    {
        r = sumaInt(I,B);
        CUB = cubo(I);
        printf("\el cubo de %i es: %i", I, CUB);
        printf("\n la sima de %i mas %i es: %i", I,B,r);
    }
 }
 int cubo (int a){
    return (a*a*a);
 }
 int sumaInt(int a, int b)
 {
    return a+b;
 }