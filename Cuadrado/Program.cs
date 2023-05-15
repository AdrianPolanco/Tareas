

//Creando funcion para sacar cuadrado del numero que introduzcamos en la funcion
int Cuadrado(int numero)
{
    return numero * numero;
}

//Creando funcion que corra el programa
void correrPrograma() 
{   
    //Intentando correr el programa normalmente
    try {  
        Console.WriteLine("Introduce el número que deseas elevar al cuadrado:");
        //Convirtiendo el string en int
        int numeroElevar = int.Parse(Console.ReadLine());
        //Llamando a la funcion Cuadrado e igualandolo a la variable
        int resultado = Cuadrado(numeroElevar);
        //Mostrando el resultado de la función
        Console.WriteLine($"Resultado: {resultado}");
    }catch (Exception e) 
    {
        //En caso de que algo vaya mal, es decir, en caso de que el usuario introduzca cualquier cosa que no sea un número, saltara al catch y mostrara este mensaje
        Console.WriteLine("Error: El dato que introduciste NO es un número, porfavor, introduce un número, no seas bruto \n");
        //Volviendo a llamar la función para correr de nuevo el programa hasta que la ejecución sea totalmente exitosa
        correrPrograma();
    }
}

//Iniciando el programa
correrPrograma();

