using Xunit;
using Vikingos;

public class ExpedicionValeLaPenaTests
{
    [Fact]
    public void ExpedicionValeLaPenaSiTodosLosDestinosValen()
    {
        var expedicion = new Expedicion();

        var vikingo = new Soldado(new Karl(), 30, 5);
        expedicion.AgregarVikingo(vikingo);

        var aldea = new Aldea(20); // más de 15 monedas
        expedicion.AgregarDestino(aldea);

        bool resultado = expedicion.ValeLaPena();

        Assert.True(resultado);
    }
}