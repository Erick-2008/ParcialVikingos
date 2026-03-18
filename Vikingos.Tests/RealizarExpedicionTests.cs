using Xunit;
using Vikingos;

public class RealizarExpedicionTests
{
    [Fact]
    public void BotinSeDivideEntreLosVikingos()
    {
        var expedicion = new Expedicion();

        var v1 = new Soldado(new Karl(), 30, 5);
        var v2 = new Soldado(new Karl(), 30, 5);

        expedicion.AgregarVikingo(v1);
        expedicion.AgregarVikingo(v2);

        var aldea = new Aldea(20);
        expedicion.AgregarDestino(aldea);

        double botin = expedicion.RealizarExpedicion();

        Assert.Equal(10, botin);
    }
}