#include <stdio.h>
#include <stdlib.h>
#define tirePerf 45000 //Km
#define anualKm 15000 //Km
#define oilChKm 25000 //Km

/*Estas son las definiciones de macros
que asignan valores constantes a tirePerf,
anualKmy oilChKm. Estas constantes
se utilizan en los cálculos más adelante en el programa.*/

float gComb(float D, float eMx, float eMn, float fl);
float vCost(float D, float tireCost, float ensCost, float oilCost);
void getInfo();
void print();

struct tabla
{
    char nombre[20];
    float distance;
    float gFuel;
    float gVar;
    float total; /*Esta es la definición de una estructura
    llamada tabla. La estructura tiene cinco miembros: nombre,
    distance, gFuel, gVary total. Esta estructura se utiliza
    para almacenar los datos relacionados con el cálculo de costos.*/
};

float dist;
struct tabla tabla0;

void main()
{
    int con = 1;
    float comb, eMax, eMin, tireC, ensC, oilChange;
    /*Se declaran varias variables de tipo entero y
    flotante para almacenar los datos ingresados ​​por el
    usuario, como el precio del combustible, la eficiencia máxima y
    mínima del vehículo, el costo de las llantas,
    el costo del seguro anual y el costo del cambio de aceite .*/

    printf("\nCalculo de costo por visita.");
    printf("\nIngrese los siguientes datos.");
    printf("\nPrecio del Combustible (RD$xGal): ");
    scanf("%f", &comb);
    printf("\nEficiencia Maxima del Vehiculo (L/100km): ");
    scanf("%f", &eMax);
    printf("\nEficiencia Minima del Vehiculo (L/100km): ");
    scanf("%f", &eMin);
    printf("\nPrecio de la llantas (RD$xUnidad): ");
    scanf("%f", &tireC);
    printf("\nCosto del Seguro Anual (RD$): ");
    scanf("%f", &ensC);
    printf("\nCosto de Cambio de Aceite (RD$): ");
    scanf("%f", &oilChange);
    /*Estas líneas de código muestran mensajes en la consola y
    luego utilizan la función scanf()para leer los datos ingresados
    ​​por el usuario y almacenarlos en las variables correspondientes.*/

    while (con)
    {
    getInfo();
    tabla0.gFuel = gComb(dist, eMax, eMin, comb);
    tabla0.gVar = vCost(dist, tireC, ensC, oilChange);
    tabla0.total = tabla0.gFuel+tabla0.gVar;
    print();

    printf("\n¿Desea hacer un nuevo calculo?\n 1- Si\t 0- No\n");
    scanf("%d", &con);
    }



}
void getInfo()
{
    char name[20];

    printf("\nNombre del cliente: ");
    fflush(stdin);
    gets(name);
    strcpy(tabla0.nombre, name);
    fflush(stdin);
    printf("\nDistancia a recorrer (Km): ");
    scanf("%f", &dist);
    tabla0.distance = dist;

}

float gComb(float D, float eMx, float eMn, float fl)
{
    float newCombPrice = fl/3.71;

    float eProm;
    eProm = ((eMx+eMn)/2)/100;
    float finalComb = newCombPrice*eProm*D;

    return finalComb;

    /*Esta es la definición de la función gComb()que
    calcula los gastos de combustible. Toma como argumentos
    la distancia a recorrer ( D), la eficiencia máxima y
    mínima del vehículo ( eMxy eMn) y el precio del combustible por
    galón ( fl). Realice los cálculos necesarios y devuelva el costo final de combustible.*/

}

float vCost(float D, float tireCost, float ensCost, float oilCost)
{
    //Costo Llanta
    float totalTireC = 4*tireCost;
    float tirePerKM = totalTireC/tirePerf;

    //Seguro
    float ensPerKm = ensCost/anualKm;

    //Aceite
    float oilCostPerKm = oilCost/oilChKm;

    return tirePerKM+ensPerKm+oilCostPerKm;
    /*Esta es la definición de la función vCost()que
    calcula los gastos varios. Toma como argumentos la
    distancia a recorrer ( D), el costo de las llantas
    ( tireCost), el costo del seguro anual ( ensCost) y e
    l costo del cambio de aceite ( oilCost). Realiza los
    cálculos necesarios y devuelve el costo total de los gastos varios.*/
}

void print()
{
    printf("\nNombre:\t %s", tabla0.nombre);
    printf("\n----------------------------");
    printf("\nDistancia:\t %5.2f", tabla0.distance);
    printf("\n----------------------------");
    printf("\nGastos Promedios:\t %5.2f", tabla0.gFuel);
    printf("\nEn Combustible");
    printf("\n----------------------------");
    printf("\nGastos Varios:\t %5.2f", tabla0.gVar);
    printf("\n----------------------------");
    printf("\nTotal:\t %5.2f", tabla0.total);
    printf("\n----------------------------");

    /*Esta es la definición de la función print()que
    muestra los resultados en la consola. Imprima el
    nombre del cliente, la distancia, los gastos promedio
    de combustible, los gastos varios y el costo total.*/
}
