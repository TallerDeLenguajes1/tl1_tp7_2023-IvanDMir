using EspacioEmpleado;
Empleado primerEmpleado = new Empleado("Lionel", "Messi", new DateTime(1987, 06, 24), 'C', 'M', new DateTime(2015, 03, 23), 10000, Cargos.Auxiliar);
Empleado segundoEmpleado = new Empleado("Cristano", "ronaldo", new DateTime(1985, 02, 05), 'C', 'M', new DateTime(2011, 03, 23), 2010000, Cargos.Ingeniero);
Empleado tercerEmpleado = new Empleado(" Juan Roman", "Riquelme", new DateTime(1978, 06, 24), 'C', 'M', new DateTime(2010, 03, 23), 800000, Cargos.Especalista);
Empleado[] Empleados = {primerEmpleado, segundoEmpleado, tercerEmpleado};
Empleado EmpleadoMasLongevo = primerEmpleado;
Console.WriteLine("Salario total entre los Empleados: " + (primerEmpleado.Salario() + segundoEmpleado.Salario() + tercerEmpleado.Salario()));
foreach(Empleado Empleado in Empleados) {
    if(Empleado.AñosParaRetirarse() < EmpleadoMasLongevo.AñosParaRetirarse()) {
        EmpleadoMasLongevo = Empleado;
    }
}
Console.WriteLine("\nInformacion del Empleado mas viejo\n");
EmpleadoMasLongevo.Mostrar();
