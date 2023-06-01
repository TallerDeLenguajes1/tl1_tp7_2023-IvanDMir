using EspacioCalculadora;

calculadora calculadora = new calculadora();
int OpcionCorrecta;
string? operando;
double validoperando;

do {
    Menu();
    string? opcion = Console.ReadLine();
    while(!int.TryParse(opcion, out OpcionCorrecta)) {
        Console.WriteLine("\nIngresar una opcion valida\n");
        Menu();
        opcion = Console.ReadLine();
    }
    switch(OpcionCorrecta) {
        case 1:
            Console.WriteLine("Ingresar un numero a sumar");
            operando = Console.ReadLine();
            while(!double.TryParse(operando, out validoperando)) {
                Console.WriteLine("\nIngresar un valor valido");
                Console.WriteLine("Ingresar un numero a sumar");
                operando = Console.ReadLine(); 
            }
            calculadora.Sumar(validoperando);
            break;
        case 2:
            Console.WriteLine("Ingresar un numero a restar");
            operando = Console.ReadLine();
            while(!double.TryParse(operando, out validoperando)) {
                Console.WriteLine("\nIngresar un valor valido");
                Console.WriteLine("Ingresar un numero a sumar");
                operando = Console.ReadLine(); 
            }
            calculadora.Restar(validoperando);
            break;
        case 3:
            Console.WriteLine("Ingresar un numero a multiplicar");
            operando = Console.ReadLine();
            while(!double.TryParse(operando, out validoperando)) {
                Console.WriteLine("\nIngresar un valor valido");
                Console.WriteLine("Ingresar un numero a sumar");
                operando = Console.ReadLine(); 
            }
            calculadora.Multiplicar(validoperando);
            break;
        case 4:
            Console.WriteLine("Ingresar un numero a dividir");
            operando = Console.ReadLine();
            while(!double.TryParse(operando, out validoperando)) {
                Console.WriteLine("\nIngresar un valor valido");
                Console.WriteLine("Ingresar un numero a sumar");
                operando = Console.ReadLine(); 
            }
            calculadora.Dividir(validoperando);
            break;
        default:
            Console.WriteLine("\nNo se encontro la opcion buscada\n");
            break;
    }
    Console.WriteLine("\nResultado guardado: " + calculadora.obtenerResultado);
    Console.WriteLine("\nPresionar tecla para continuar. Escape para salir\n");
} while (!(Console.ReadKey().Key == ConsoleKey.Escape));

void Menu() {
    Console.WriteLine("\n---MENU---\n");
    Console.WriteLine("1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir");
}
