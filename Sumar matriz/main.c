#include <stdio.h>

void sumaMatrices(int matriz1[][3], int matriz2[][3], int resultado[][3], int filas, int columnas) {
    int i, j;
    for (i = 0; i < filas; i++) {
        for (j = 0; j < columnas; j++) {
            resultado[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }
}

void imprimirMatriz(int matriz[][3], int filas, int columnas) {
    int i, j;
    for (i = 0; i < filas; i++) {
        for (j = 0; j < columnas; j++) {
            printf("%d ", matriz[i][j]);
        }
        printf("\n");
    }
    printf("\n");
}

int main() {
    int matriz1[3][3] = {{2, 5, 8},
                         {3, 6, 9},
                         {4, 7, 10}};
    int matriz2[3][3] = {{1, 10, 100},
                         {2, 20, 10},
                         {3, 30, 15}};
    int resultado[3][3];

    int filas = 3;
    int columnas = 3;

    sumaMatrices(matriz1, matriz2, resultado, filas, columnas);

    printf("Matriz 1:\n");
    imprimirMatriz(matriz1, filas, columnas);

    printf("Matriz 2:\n");
    imprimirMatriz(matriz2, filas, columnas);

    printf("Resultado de la suma:\n");
    imprimirMatriz(resultado, filas, columnas);

    return 0;
}
