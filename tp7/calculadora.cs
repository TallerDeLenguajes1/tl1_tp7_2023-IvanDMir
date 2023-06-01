namespace EspacioCalculadora {
    public class calculadora {
        double resultado;
        public calculadora() => resultado = 0;
        public void Sumar(double expresion) => this.resultado += expresion;
        public void Restar(double expresion) => this.resultado -= expresion;
        public void Multiplicar(double expresion) => this.resultado *= expresion;
        public void Dividir(double expresion) {
            if(expresion == 0) {
                Console.WriteLine("\nSe intento dividir en 0\n");
                return;
            }
            this.resultado /= expresion;
        }
        public void ReestablecerResultado() => resultado = 0;
        public double obtenerResultado { get => resultado; }
    };
}