#include <stdio.h>

int main(void) {
    float ECA;
    printf("Ingrese la extensi�n de la estancia: ");
    scanf("%f", &ECA);
    ECA = ECA * 4047 / 10000;
    printf("\nExtensi�n de la estancia en hectareas: %.2f", ECA);

    return 0;
}
