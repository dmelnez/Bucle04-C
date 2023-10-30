
using Bucle04.Servicios;
/// <summary>
/// Clase Principal por la cual el programa se Inicia
/// <autor>30/10/2023 - DMN</autor>
/// </summary>
class Program
{
    /// <summary>
    /// Metodo por el cual la aplicacion se inicializa
    /// <autor>30/10/2023 - DMN</autor>
    /// </summary>
    /// <param name="args"></param>
    public static void Main(String[] args)
    {

        MenuInterfaz mi = new MenuImplementacion();

        int numeroUsu = mi.solNum();

        CalculoInterfaz mi1 = new CalculoImplentacion();

        int resultado = mi1.calculoCase(numeroUsu);




    }
}