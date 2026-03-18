namespace Vikingos;

public class Jarl : Casta
{
    public override void Ascender(Vikingo v)
    {
        v.CambiarCasta(new Karl());

        if (v is Soldado s)
            s.Armas += 10;

        if (v is Granjero g)
        {
            g.Hijos += 2;
            g.Hectareas += 2;
        }
    }

    public override bool PuedeIrExpedicion(Vikingo v)
    {
        if (v is Soldado s && s.TieneArmas())
            return false;

        return true;
    }
}