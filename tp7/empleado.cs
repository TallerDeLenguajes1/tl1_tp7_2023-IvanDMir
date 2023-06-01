namespace EspacioEmpleado{ 
public enum Cargos { Auxiliar, Administrativo, Ingeniero, Especalista, Investigador }

public class Empleado {
    string Nombre, apellido;
    DateTime FechaDeCumpleaños;
    char EstadoCivil;
    char Genero;
    DateTime Inicio;
    double SalarioBasico;
    Cargos cargo;

    public Empleado(string Nombre, string Apellido, DateTime FechaDeCumpleaños, char EstadoCivil, char Genero, DateTime Inicio, double SalarioBasico, Cargos cargo) {
        this.Nombre = Nombre;
        this.apellido = Apellido;
        this.FechaDeCumpleaños = FechaDeCumpleaños;
        this.EstadoCivil = EstadoCivil;
        this.Genero = Genero;
        this.Inicio = Inicio;
        this.SalarioBasico = SalarioBasico;
        this.cargo = cargo;
    }
    public int CalcularAntiguedad() { return DateTime.Now.Year - Inicio.Year; } 
    public int CalcularEdad() { return DateTime.Now.Year - FechaDeCumpleaños.Year; }
    public int AñosParaRetirarse() { 
        if(Genero == 'M') {
            return 65 - CalcularEdad(); 
        }
        return 60 - CalcularEdad();
    }
    public double Salario() {
        double Incremento = CalcularAntiguedad() > 20 ? Incremento = SalarioBasico * 0.25 : Incremento = (SalarioBasico * 0.1) * 20;
        if(cargo == Cargos.Ingeniero || cargo == Cargos.Especalista) {
            Incremento *= 1.50;
        }
        if(EstadoCivil == 'M') {
            Incremento += 15000;
        }
        return SalarioBasico + Incremento;
    }
    public void Mostrar() {
        Console.WriteLine("Nombre: " + this.Nombre);
        Console.WriteLine("Apellido: " + this.apellido);
        Console.WriteLine("Fecha de nacimiento: " + this.FechaDeCumpleaños.ToString());
        Console.WriteLine("Edad: " + this.CalcularEdad());
        Console.WriteLine("Estado civil: " + this.EstadoCivil);
        Console.WriteLine("Genero: " + this.Genero);
        Console.WriteLine("Fecha de ingreso a la empresa: " + this.Inicio.ToString());
        Console.WriteLine("Salario basico: " + this.SalarioBasico);
        Console.WriteLine("Cargo: " + this.cargo.ToString());
        Console.WriteLine("Antiguedad en la empresa: " + this.CalcularAntiguedad());
        Console.WriteLine("Anios para jubilarse: " + this.AñosParaRetirarse());
        Console.WriteLine("Salario: " + this.Salario());
    }
}
}