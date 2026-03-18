namespace Vikingos;

public class Soldado : Vikingo
{
    private int vidasCobradas;
    public int Armas { get; set; }

    public Soldado(Casta casta, int vidas, int armas) : base(casta)
    {
        vidasCobradas = vidas;
        Armas = armas;
    }

    public override bool EsProductivo()
    {
        return vidasCobradas > 20 && Armas > 0;
    }

    public override bool PuedeIrExpedicion()
    {
        return base.PuedeIrExpedicion();
    }

    public bool TieneArmas()
    {
        return Armas > 0;
    }

    public void CobrarVida()
    {
        vidasCobradas++;
    }
}