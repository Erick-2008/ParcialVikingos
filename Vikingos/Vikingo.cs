namespace Vikingos;

public abstract class Vikingo
{
    protected Casta casta;

    public Vikingo(Casta casta)
    {
        this.casta = casta;
    }

    public Casta Casta => casta;

    public abstract bool EsProductivo();

    public virtual bool PuedeIrExpedicion()
    {
        return EsProductivo() && casta.PuedeIrExpedicion(this);
    }

    public void Ascender()
    {
        casta.Ascender(this);
    }

    public void CambiarCasta(Casta c)
    {
        casta = c;
    }
}
