#include <stdio.h>
/* N�mina.
El programa, al recibir los salarios de 15 profesores, obtiene el total de la
n�mina de la universidad.
I: variable de tipo entero.
SAL y NOM: variables de tipo real. */
int main(void)
{
    int I;
    float SAL, NOM;
    NOM = 0;
    for (I = 1; I <= 15; I++)
    {
        printf("\nIngrese el salario del profesor %d: ", I);
        scanf("%f", &SAL);
        NOM += SAL;
    }
    printf("\nEl total de la nomina es : %.2f", NOM);
}
