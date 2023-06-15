#include <stdio.h>
const int TAM = 3;  /* Se define una constante TAM con valor 3, 
que representa el tamaño de las matrices cuadradas que se utilizarán en el programa.*/

void impresion(int M[][TAM], int F);  /*Se declara un prototipo de función llamada 
impresion que recibe una matriz de tamaño TAM y un entero F que representa el número de filas.*/

void valores(int M[][TAM], int F);  /* Se declara un prototipo de función llamada valores 
que recibe una matriz de tamaño TAM y un entero F que representa el número de filas.*/

void OP(int M[][TAM], int F);  /*Se declara un prototipo de función llamada OP 
que recibe una matriz de tamaño TAM y un entero F que representa el número de filas.*/

void main(void) /*Se define la función main, que es el punto de entrada del programa.*/
{

    int M1[TAM][TAM]; /*Se declara una matriz llamada M1 de tamaño TAM x TAM*/
    
    valores(M1, TAM);  /*Se llama a la función valores pasando la matriz M1 y el tamaño TAM. 
    Esta función solicita al usuario ingresar valores para cada posición de la matriz y los guarda en M1.*/
    
    OP(M1, TAM);  /*Se llama a la función OP pasando la matriz M1 y el tamaño TAM. 
    Esta función realiza operaciones con la matriz, calculando la suma de cada columna y la multiplicación de cada fila.*/

}

void valores(int M[][TAM], int F) /* Se define la función valores que recibe una matriz M y un entero F.*/
{
    for (int i = 0; i<F; i++) /*Se inicia un bucle for que itera 
    desde 0 hasta F-1 para recorrer las filas de la matriz.*/
    {
        for (int j = 0; j<F; j++) /*Se inicia un bucle for anidado que itera 
        desde 0 hasta F-1 para recorrer las columnas de la matriz.*/
        {
            printf("\nIngrese los valores para la posicion %d, %d: ", i+1, j+1); /*Muestra un mensaje 
            en la consola solicitando al usuario ingresar un valor para la posición (i+1, j+1) de la matriz.*/
            
            scanf("%d", &M[i][j]); /*Lee el valor ingresado 
            por el usuario y lo guarda en la posición (i, j) de la matriz.*/
        }
    }
}

void impresion(int M[][TAM], int F)
{
    for (int i = 0; i<F; i++)
    {
        for (int j = 0; j<TAM; j++)
        {
            printf("\nResultado Posicion %d %d: %d ", i, j, M[i][j]);

        }
    }
}


void impresionUNI(int M[], int F)
{
    for (int i = 0; i<F; i++)
    {
         printf("\nResultado Posicion %d: %d ", i, M[i]);
    }
}

void OP(int M[][TAM], int F)
{
    int r;
    int m;
    for (int i = 0; i<F; i++){
            r = 0;
            m = 1;
        for (int j = 0; j<F; j++){
          r += M[j][i];
          printf("\nr = %d", r);
          m *= M[i][j];
          printf("\nm = %d", m);
        }
        /*Las funciones impresion, impresionUNI y OP tienen 
        una estructura similar en cuanto a los bucles for y los cálculos realizados 
        en las matrices, pero con diferencias en las operaciones y en cómo se imprimen los resultados.*/
        printf("\nValor de la suma de la columna %d: %d", i, r);
        printf("\nValor de la multiplicacion de la fila %d: %d", i, m);

    }
    //impresionUNI(PreR, TAM);
}
