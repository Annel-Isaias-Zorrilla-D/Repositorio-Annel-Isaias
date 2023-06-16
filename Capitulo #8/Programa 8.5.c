#include <stdio.h>
#include <string.h>

/* Uniones.
El programa muestra la manera en que se declara una unión, así como la forma de
acceso a los campos de las variables de tipo unión, tanto para asignación
de valores como para lectura y escritura. */

union datos /* Declaración de una unión. */
{
    char celular[15];
    char correo[20];
};

typedef struct /* Declaración de una estructura utilizando typedef. */
{
    int matricula;
    char nombre[20];
    char carrera[20];
    float promedio;
    union datos personales;
    /* Observa que uno de los campos de la estructura "alumno" es una unión. */
} alumno;

void Lectura(alumno *a); /* Prototipo de función. */

int main(void)
{
    alumno a1 = {120, "Maria", "Contabilidad", 8.9, .personales.celular = "5-158-40-50"};
    alumno a0, a2, a3;

    /* Para que puedas observar las diferentes formas en que los campos de las
    variables de tipo estructura "alumno" reciben valores, ingresamos los valores
    de los campos de tres formas diferentes. Los campos de a1 reciben valores
    directamente, los campos de a2 se leen en el programa principal, y los campos
    de a3 reciben valores a través de una función. */

    printf("Alumno 2\n");
    printf("Ingrese la matricula: ");
    scanf("%d", &a2.matricula);
    fflush(stdin);

    printf("Ingrese el nombre: ");
    fgets(a2.nombre, sizeof(a2.nombre), stdin);
    a2.nombre[strcspn(a2.nombre, "\n")] = '\0';
    fflush(stdin);

    printf("Ingrese la carrera: ");
    fgets(a2.carrera, sizeof(a2.carrera), stdin);
    a2.carrera[strcspn(a2.carrera, "\n")] = '\0';

    printf("Ingrese el promedio: ");
    scanf("%f", &a2.promedio);
    fflush(stdin);

    printf("Ingrese el correo electronico: ");
    fgets(a2.personales.correo, sizeof(a2.personales.correo), stdin);
    a2.personales.correo[strcspn(a2.personales.correo, "\n")] = '\0';

    /* Observa que en la variable a2 de tipo estructura "alumno", el segundo campo de la
    unión recibe un valor. */

    printf("Alumno 3\n");
    Lectura(&a3); /* Se llama a una función para leer los campos de la variable a3. */

    /* Impresión de resultados. */
    printf("\nDatos del alumno 1\n");
    printf("%d\n", a1.matricula);
    printf("%s\n", a1.nombre);
    printf("%s\n", a1.carrera);
    printf("%.2f\n", a1.promedio);
    printf("%s\n", a1.personales.celular);
    /* Observa que imprime el valor del teléfono celular asignado. */
    printf("%s\n", a1.personales.correo);
    /* Observa que si tratamos de imprimir el campo correo, imprime basura. */

    strcpy(a0.personales.correo, "hgimenez@hotmail.com");
    /* Se ingresa ahora un valor al segundo campo de la unión de la variable a0. */
    printf("%s\n", a0.personales.celular);
    /* Ahora imprime basura en el campo del teléfono celular. */
    printf("%s\n", a0.personales.correo);
    /* Imprime el contenido del campo (hgimenez@hotmail.com). */

    printf("\nDatos del alumno 2\n");
    printf("%d\n", a2.matricula);
    printf("%s\n", a2.nombre);
    printf("%s\n", a2.carrera);
    printf("%.2f\n", a2.promedio);
    printf("%s\n", a2.personales.celular); /* Imprime basura. */
    printf("%s\n", a2.personales.correo); /* Imprime el contenido del segundo campo. */
    printf("Ingrese el teléfono celular del alumno 2: ");

    fflush(stdin);
    fgets(a2.personales.celular, sizeof(a2.personales.celular), stdin);
    a2.personales.celular[strcspn(a2.personales.celular, "\n")] = '\0';
    printf("%s\n", a2.personales.celular); /* Imprime el teléfono celular ingresado. */
    printf("%s\n", a2.personales.correo); /* Ahora imprime basura. */

    printf("\nDatos del alumno 3\n");
    printf("%d\n", a3.matricula);
    printf("%s\n", a3.nombre);
    printf("%s\n", a3.carrera);
    printf("%.2f\n", a3.promedio);
    printf("%s\n", a3.personales.celular);
    printf("%s\n", a3.personales.correo); /* Imprime basura. */
}

void Lectura(alumno *a)
/* La función Lectura se utiliza para leer los campos de una variable de tipo
estructura "alumno". */
{
    printf("\nIngrese la matricula: ");
    scanf("%d", &(a->matricula));
    fflush(stdin);

    printf("Ingrese el nombre: ");
    fgets(a->nombre, sizeof(a->nombre), stdin);
    a->nombre[strcspn(a->nombre, "\n")] = '\0';
    fflush(stdin);

    printf("Ingrese la carrera: ");
    fgets(a->carrera, sizeof(a->carrera), stdin);
    a->carrera[strcspn(a->carrera, "\n")] = '\0';

    printf("Ingrese el promedio: ");
    scanf("%f", &(a->promedio));
    fflush(stdin);

    printf("Ingrese el teléfono celular: ");
    fgets(a->personales.celular, sizeof(a->personales.celular), stdin);
    a->personales.celular[strcspn(a->personales.celular, "\n")] = '\0';
}
