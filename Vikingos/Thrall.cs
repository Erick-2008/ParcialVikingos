namespace Vikingos;

public class Thrall : Casta
{
    public override void Ascender(Vikingo v)
    {
        // no asciende más
    }

    public override bool PuedeIrExpedicion(Vikingo v)
    {
        return true;
    }
}