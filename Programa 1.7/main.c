#include <stdio.h>

int main(void) {
    float PIE, LIB, MET, KIL;
    printf("Ingrese los datos del objeto: ");
    scanf("%f %f", &PIE, &LIB);
    MET = PIE * 0.3048;
    KIL = LIB * 0.453592;
    printf("\nDatos del objeto\nLongitud: %.2f metros\nPeso: %.2f kilogramos", MET, KIL);

    return 0;
}
