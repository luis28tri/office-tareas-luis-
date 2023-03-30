//declaramos la librarias
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

//creamos la estructuras registro y declaramos la variables principales

struct registro {
char nombre[80];
char apellido[80];
int matricula[10];
int id;

};
    struct registro *registros = NULL;
    int total = 0;
    FILE *archivo = NULL;
//creamos la funciones del programa
    void cargar();
    void guardar();
    void agregar();
    void ver();
    void buscar();
    void eliminar();
// aqui fue necesario crear el menu de opciones principales del programa.
int main()  {
int opcion;
char temp[10];
cargar ();
do {
    printf("total de registros en la base de datos %i\n", total);
    printf("1) agregar\n");
    printf("2) buscar\n");
    printf("3) ver registro\n");
    printf("4) eliminar registro\n");
    printf("5) salir\n");
    printf("Ingrese su opcion: ");
    fgets(temp, 10, stdin);
    opcion = atoi(temp);
    switch(opcion) {
    // como podemos ver que en cada opcion (case) se etiqueta las funciones correspodiente.
        case 1:
            agregar();
            break;
        case 2:
            buscar();
            break;
        case 3:
            ver();
            break;
        case 4:
            eliminar();
            break;
    // en la opcion 5 (case), se coloco el comentario de opcion incorrecta cuando el comando digital no sea el indicado o no este dentro del  parametro
        case 5:
            break;
        default:
            printf("Opcion incorrecta %i\n", opcion);
            break;
    }
} while (opcion != 5);

// aqui hacemos uso de la funcion guardar que se encargar de almacenar en un espacio de la memoria los dato ingresado.
guardar ();
return 0;
}
// esta es la funcion de agregar los datos que se le ingreso a las variables.
void agregar(){
registros = realloc (registros,sizeof(struct registro)*(total+1));
memset(&registros [total],0,sizeof(struct registro));
printf("ingrese el nombre:  %i" ,total+1);
fgets(registros[total].nombre,80,stdin);
printf("ingrese el apellido:  %i" ,total+1);
fgets(registros[total].apellido,80,stdin);
printf("ingrese el matricula:  %d" ,total+1);
fgets(registros[total].matricula,10,stdin);
registros[total].id = total+1;
total++;
}

// aqui guardamos nuevamente en un espacio de la memoria que tiene como nombre registro.txt.
void guardar() {
    archivo = fopen("registro.txt", "wb");
    if (archivo != NULL) {
        fwrite(&total, sizeof(int), 1, archivo);
        fwrite(registros, sizeof(struct registro), total, archivo);
        fclose(archivo);
    } else {
        printf("Error de archivo\n");
    }
}
// aqui se encargar de verificar que los datos se carguen correctamente al archivo y si no no salga un enuciando diciendo que hubo un error
void cargar()   {
     archivo= fopen("registro.txt","rb");
    if (archivo != NULL)    {
        fread(&total, sizeof(int),1,archivo);
        registros = calloc(sizeof(struct registro), total);
        fread(registros, sizeof(struct registro),total,archivo);
        fclose(archivo);
    }
    else    {
        printf("error de archivo\n");
    }
}
//hacemos uso de la funcion ver, que nos permitirar acceder a los registro.
void ver () {
    int numero = 0;
     char temp[10];
     do{
    printf("que registro quiere ver menor o igual a %i  :\n",total);
    fgets (temp,10,stdin);
    numero = atoi(temp);
     }while(numero > total || numero <= 0);
    numero--;
        printf("registro numero %i \n", numero);
        printf("nombre  %s\n",registros [numero].nombre );
        printf("apellido  %s\n",registros [numero].apellido);
        printf("matricula  %s\n",registros [numero].matricula );
       
    }
    //utilizamos la funcion de buscar, podras buscar los datos con la variables que quieras.
void buscar()   {
    int opcion,i, index;
    bool encontrado,entrar;
    char temp[10];
    char buscar[80];
    do {
        entrar = true;
        encontrado = false;
        printf("como quiere buscar?\n");
        printf("1) por nombre\n");
        printf("2) por apellido\n");
        printf("3) por matricula\n");
        printf("4)volver al menu anterior \n");
        printf(" ingrese su opcion:  ");
         fgets(temp,10,stdin);
opcion = atoi(temp);
switch(opcion) {
    case 1:
        printf("ingrese el nombre a buscar  :");
        fgets(buscar,80,stdin);
        i = 0;
        while(i < total && !encontrado) {
            if(strcmp(buscar,registros[i].nombre) == 0) {
            printf("Nombre encontrado\n: ");
            entrar  = false;
            encontrado = true;
            index = i;
             } 
             i++;     
        }
    break;
    case 2:
        printf("ingrese el apellido :");
        fgets(buscar,80,stdin);
         i = 0;
        while(i < total && !encontrado) {
            if(strcmp(buscar,registros[i].apellido) == 0) {
            printf("apellido encontrado\n: ");
            entrar  = false;
            encontrado = true;
            entrar  = false;
            index = i;
             } 
             i++; 
        }  
    break;
    case 3:
       printf("ingrese el matricula: ");
        fgets(buscar,10,stdin);
         i = 0;
        while(i < total && !encontrado) {
            if(strcmp(buscar,registros[i].matricula) == 0) {
            printf("matricula encontrada\n: ");
            encontrado = true;
            entrar  = false;
            index = i;
            
             } 
             i++;
        }  
    break;
    case 4:
        entrar  = false;
     break;
    default:
        printf("opcion incorrecta %i\n");
    break;
    }
}while(entrar);
//luego de hacer la busqueda correcta se te imprimira los datos del indivisio que se alla almacenado.
if(encontrado)  {
        printf("registro encontrado: ");
        printf("registro numero %i\n",registros[index].id);
        printf("nombre  %s\n",registros [index].nombre);
        printf("apellido  %s\n",registros [index].apellido);
        printf("matricula  %s\n",registros [index].matricula);

    }
    else    {
        printf("registro no encontrado!\n");
    }
  
}
// aqui hacemos uso de la funcion eliminar para borrar datos no deseado.
void eliminar() {
    int numero = 0;
    char temp[10];
    do {
        // se te pregunta que datos deseas borrar( los datos al momento de agregarse se le agsina un numero de orden).
        // por eso debe indican en que orden se encuenta el dato que desea eliminar.
        printf("Que registro quiere eliminar menor o igual a %i :\n", total);
        fgets(temp, 10, stdin);
        numero = atoi(temp);
    } while (numero > total || numero <= 0);

    numero--;
    printf("Registro numero %i\n", numero);
    printf("Nombre: %s\n", registros[numero].nombre);
    printf("Apellido: %s\n", registros[numero].apellido);
    printf("Matricula: %s\n", registros[numero].matricula);

// aqui se te pregunta que si deseas seguir con la operacion de borrado.
    printf("Esta seguro de que desea eliminar este registro? (s/n)\n");
    fgets(temp, 10, stdin);
    if (temp[0] == 's' || temp[0] == 'S') {
        for (int i = numero; i < total - 1; i++) {
            registros[i] = registros[i + 1];
        }
        total--;
// aqui se te notifica de que le registro fue eliminado correctamente.
        printf("Registro eliminado correctamente.\n");
    } else {
        printf("Operacion cancelada.\n");
    }
}