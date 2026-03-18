using Xunit;
using Vikingos;
using System;

public class ExpedicionTests
{
    [Fact]
    public void NoDebeSubirVikingoSiNoPuedeIrAExpedicion()
    {
        var expedicion = new Expedicion();

        // soldado no productivo
        var vikingo = new Soldado(new Karl(), 10, 0);

        Assert.Throws<InvalidOperationException>(() =>
        {
            expedicion.AgregarVikingo(vikingo);
        });
    }
}