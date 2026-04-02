bool continuar = true;
// abro un ciclo while para que el usuario decida cuando quiere salir del menu
while (continuar)
{
//menu    
Console.WriteLine("--- Centro de Entrenamiento Técnico ---");
Console.WriteLine("Nivel 1: Suma y validación numérica");
Console.WriteLine("Nivel 2: Cálculo y condicionales");  
Console.WriteLine("Nivel 3: Manipulación de Cadenas");
Console.WriteLine("Nivel 4: Operaciones Lógicas (Calculadora)");
Console.WriteLine("Nivel 5: Análisis Numérico (Listas de enteros)");
Console.WriteLine("Nivel 6: Gestión de Tareas (Listas de cadenas)");
Console.WriteLine("Nivel 7: Arreglos y Búsqueda");
Console.WriteLine("Nivel 8: Programación Orientada a Objetos (Clases)");
Console.WriteLine("Nivel 9: CRUD de Objetos (Listas de objetos)");
Console.WriteLine("10. Salir");

Console.WriteLine("seleccione un nivel para empezar");
//opcion del menu
string nivel = Console.ReadLine();


// uso un switch para cada caso del menu
    switch (nivel)
    {
        //suma y validaciones numericas
        case "1":
            Console.WriteLine("en este nivel deberas ingresar dos numeros enteros y se vera el resultado");
            Console.WriteLine("ingrese el primer numero entero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero entero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 + numero2);
            break;
        //calculo y condicionales
        case "2":
            Console.WriteLine("ingrese la primera nota");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la segunda nota");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la tercera nota");
            double nota3 = double.Parse(Console.ReadLine());

            double prom = (nota1 + nota2 + nota3) / 3;
            if (prom >= 3.0)
            {
                Console.WriteLine(prom);
                Console.WriteLine("aprobado");
            }
            else
            {
                Console.WriteLine(prom);
                Console.WriteLine("desaprobado");
            }

            break;
        //manipulacion de cadenas
        case "3":
            Console.WriteLine("ingrese su nombre");
            string Nombre = Console.ReadLine();

            Console.WriteLine("ingrese la apellido");
            string Apellido = Console.ReadLine();
            Console.WriteLine($" bienvenido {Nombre} {Apellido}!");

            break;
        //operaciones logicas
        case "4":
            Console.WriteLine("por favor ingrese el operador ");
            string operador = Console.ReadLine();

            Console.WriteLine("por favor ingrese primer numero ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("por favor ingrese primer numero ");
            int num2 = int.Parse(Console.ReadLine());
            switch (operador)
            {
                case "*":

                    int resultado = num1 * num2;
                    Console.WriteLine(resultado);
                    break;

                case "/":
                    if (num2 == 0 || num1 == 0)
                    {
                        Console.WriteLine("no se puede dividir entre cero por favor ingrese un numero valido");
                    }
                    else
                    {
                        int resultado1 = num1 / num2;
                        Console.WriteLine(resultado1);
                    }

                    break;

                case "-":
                    int resultado2 = num1 - num2;
                    Console.WriteLine(resultado2);
                    break;

                case "+":
                    int resultado3 = num1 + num2;
                    Console.WriteLine(resultado3);
                    break;
            }

            break;
        //Analisis numericos
        case "5":
            List<int> numeros = new List<int>();
            int mayor = 0;
            int menor = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("ingrese el numero");
                int entrada = int.Parse(Console.ReadLine());
                numeros.Add(entrada);
            }

            menor = numeros[0];

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
                if (mayor < num)
                {
                    mayor = num;
                }

                if (menor > num)
                {
                    menor = num;
                }
            }

            Console.WriteLine(mayor);
            Console.WriteLine(menor);



            break;
        //gestion de tareas
        case "6":
            List<string> tareasPendientes = new List<string>();
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("1. agregar tarea");
                Console.WriteLine("2. ver tarea");
                Console.WriteLine("3. eliminar tarea por indice");
                Console.WriteLine("4. salir");
                Console.WriteLine("seleccione una opcion para empezar");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("ingrese la tarea");
                        string entrada = Console.ReadLine();

                        tareasPendientes.Add(entrada);
                        break;
                    case "2":
                        Console.WriteLine("ingrese el nombre de la tarea");
                        string nombreBuscar = Console.ReadLine();
                        bool finded = false;
                        foreach (var tarea in tareasPendientes)
                        {
                            if (tarea == nombreBuscar)
                            {
                                Console.WriteLine(tarea);
                                finded = true;
                            }
                        }

                        break;
                    case "3":
                        Console.WriteLine("ingrese la tarea");
                        string entrada1 = Console.ReadLine();

                        tareasPendientes.Remove(entrada1);
                        break;
                    case "4":
                        Continue = false;
                        break;
                }
            }

            break;
        //arreglos y busquedas
        case "7":
            string[] ciudades = { "medellin","bogota","cali","barranquilla","bucaramanga"};
            Console.WriteLine("porfavor ingrese la ciudad");
            string ciudad = Console.ReadLine();
            string ciudadEncontrada = "";
            
                foreach (var find in ciudades)
                {
                    if (find == ciudad)
                    {
                        ciudadEncontrada = "encontrado";
                        break;
                    }
                    else
                    {
                        ciudadEncontrada = "no encontrado";
                    }
                }
            
            
            Console.WriteLine(ciudadEncontrada);
            break;
        case "8":
            break;
        //salir del menu
        case "9":
            continuar = false;
            break;
    }
}    