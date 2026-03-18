using Xunit;
using Vikingos;

public class AscensoTests
{
    [Fact]
    public void RagnarAsciendeDeKarlAThrall()
    {
        var ragnar = new Soldado(new Karl(), 30, 5);

        ragnar.Ascender();

        Assert.IsType<Thrall>(ragnar.Casta);
    }
}
