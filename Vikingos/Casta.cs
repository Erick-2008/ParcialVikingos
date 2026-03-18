namespace Vikingos;

public abstract class Casta
{
    public abstract void Ascender(Vikingo v);

    public virtual bool PuedeIrExpedicion(Vikingo v)
    {
        return true;
    }
}
