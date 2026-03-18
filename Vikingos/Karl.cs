namespace Vikingos;

public class Karl : Casta
{
    public override void Ascender(Vikingo v)
    {
        v.CambiarCasta(new Thrall());
    }

    public override bool PuedeIrExpedicion(Vikingo v)
    {
        return true;
    }
}