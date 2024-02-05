using System.Timers;

int tamano = 2;
string[] nombre = new string[tamano];
int[] edad = new int[tamano];
string[] cita = new string[tamano];
int opcion;

Menu();

void Inicializar()
{
    nombre = Enumerable.Repeat(" ", tamano).ToArray<string>();
    edad = Enumerable.Repeat(0, tamano).ToArray<int>();
    cita = Enumerable.Repeat(" ", tamano).ToArray<string>();
    Console.WriteLine("Arreglos inicializados correctamente");
    Console.WriteLine("Presione enter para continuar");
    Console.ReadKey();
    Console.Clear();
}

void Agregar()
{
    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine("Ingrese el nombre: "); nombre[i] = Console.ReadLine();
        Console.WriteLine("Ingrese la edad: "); edad[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Datos agregados correctamente");
    Console.WriteLine("Presione enter para continuar");
    Console.ReadKey();
    Console.Clear();
}

void Reporte()
{
    Console.WriteLine("Nombre       Edad");
    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine($"  {nombre[i]}      {edad[i]}");  
    }
    Console.ReadKey();
    Console.Clear();
}
Console.WriteLine();

void Consulta()
{
    bool encontrado = false;
    Console.WriteLine("Digite el nombre a buscar.");
    string nomb = Console.ReadLine();
    for (int i = 0; i < nombre.Length; i++)
    {
        if (nomb.Equals(nombre[i]))
        {
            Console.WriteLine($"La edad de {nomb} es {edad[i]}");
            Console.WriteLine("Presione enter para continuar");
            encontrado = true;
        }
    }

    if (encontrado == false)
    {
        Console.WriteLine($"El cliente {nomb} no existe en la base de datos.");
    }
    Console.ReadKey();
    Console.Clear();
}Console.WriteLine("Presione enter para continuar");


void AsignarCitas()
{
    bool encontrado = false;
    Console.WriteLine("Digite el nombre para asignar una cita.");
    string nomb = Console.ReadLine();
    for (int i = 0; i < nombre.Length; i++)
    {
        if (nomb.Equals(nombre[i]))
        {   
            
            Console.WriteLine($"Introduce la fecha y hora (yyyy-MM-dd HH:mm:ss): ");
            string fechaYHora = Console.ReadLine();
            encontrado = true;
            if (DateTime.TryParseExact(fechaYHora, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime fechaHora))
            {
                Console.WriteLine("Fecha y hora introducidas: " + fechaHora);
                cita[i] = fechaYHora;
                Console.WriteLine($"Cita guardada correctamente para: {nombre[i]} {cita[i]}");
                Console.WriteLine("Presione enter para continuar");
            }
            else
            {
                Console.WriteLine("Formato de fecha y hora incorrecto. Asegúrate de usar el formato correcto (yyyy-MM-dd HH:mm:ss).");
                Console.WriteLine("Presione enter para continuar");
            }
        }
    }
    if (encontrado == false)
    {
        Console.WriteLine($"El cliente {nomb} no existe en la base de datos.");
        Console.WriteLine("Presione enter para continuar");
    }
    Console.ReadKey();
    Console.Clear();

}



void Menu()
{
    do
    {
        Console.WriteLine("******* CONSULTORIO MEDICO *******");
        Console.WriteLine("2- Inicializar arreglos.");
        Console.WriteLine("2- Ingresar un paciente.");
        Console.WriteLine("3- consultar un paciente.");
        Console.WriteLine("4- Reporte.");
        Console.WriteLine("5- Asignar citas");
        Console.WriteLine("6- Salir.");
        Console.WriteLine("Digite la opcion deseada.");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: Inicializar(); break ;
            case 2: Agregar(); break;
            case 3: Consulta(); break;
            case 4: Reporte(); break;
            case 5: AsignarCitas(); break;
            case 6:Console.WriteLine("Gracias por utilizar nuestro sistema, cierre la ventana para salir.");
                break;
        }
        } while (opcion<6);

    if (opcion>6)
    {
        Console.WriteLine("El numero digitado no corresponde a ninguna de las opciones, cierre el programa y vuelva a abrirlo para intentarlo de nuevo.");
    }
    Console.ReadLine();
}
