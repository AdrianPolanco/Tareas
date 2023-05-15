
void correrPrograma() {

    try 
    { 
        Console.WriteLine("Porfavor, introduzca su nombre:");
        //Introduciendo el nombre de la persona
        string nombrePersona = Console.ReadLine();
 
        //Si se introduce un string vacío, saltara al metodo ErrorNombre de la clase estatica Errores
        if (nombrePersona == "")
        {
            Errores.ErrorNombre();
        }
        Console.WriteLine("¿Es usted hombre o mujer? Escriba 'M' si es hombre o 'F' si es mujer:");
        //Introduciendo el sexo, M o F
        string sexoPersona = Console.ReadLine();
        //En caso de que el valor introducido sea cualquier letra diferente de M o F, saltara el metodo ErrorSexo de la clase Errores
        if(sexoPersona != "M" && sexoPersona != "F")
        {
            //Mostrando error
            Errores.ErrorSexo(sexoPersona);
        }
        //En caso de que todo vaya bien, creara una instancia de la clase Persona con los datos que introducimos antes
        Persona persona = new Persona(nombrePersona, sexoPersona);
        //Ejecutará el metodo Saludar del objeto persona actual
        persona.Saludar();
    }catch(Exception e) 
    { 
        //En caso de que algo vaya mal, saltara a este catch, mostrara el mensaje de la excepcion que creamos y volvera a ejecutar el programa
        Console.WriteLine (e.Message);
        correrPrograma();   
    }
}

correrPrograma();


 class Persona
{
    //Creando los atributos de la clase
    private string nombre;
    private string sexo;

    //Creando el constructor de la clase (osea, su estado inicial)
    public Persona(string nombre, string sexo)
    {
        this.nombre = nombre;
       
        //Transformando cual sea la letra que el usuario introdujo a mayuscula, para no provocar un BUG en el método saludar
        this.sexo = sexo.ToUpper();  
    }


    public void Saludar()
    {
        //Si el sexo es M mostrara un mensaje y sino mostrará otro
        if (this.sexo == "M")
        {
            Console.WriteLine($"Hola {nombre}, bienvenido a Fundamentos de Programación");
        }
        else {
            Console.WriteLine($"Hola {nombre}, bienvenida a Fundamentos de Programación");
        }    
    }
}

//Creando clase estatica
public static class Errores
{
    //Creando metodos estaticos que devuelvan un error
    public static Exception ErrorSexo(string sexoError)
    {
        throw new Exception(message: $"Error: El 'sexo' {sexoError} NO es válido, se espera uno de los dos sexos existentes: Masculino(M) o Femenino(F). \n");
    }

    public static Exception ErrorNombre()
    {
        throw new Exception(message: "Error: Se espera un nombre. \n");
    }
}
 