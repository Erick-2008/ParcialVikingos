using System;
using System.Collections.Generic;
using System.Linq;

namespace Vikingos;

public class Expedicion
{
    private List<Vikingo> vikingos = new();
    private List<Lugar> destinos = new();

    public void AgregarVikingo(Vikingo v)
    {
        if (!v.PuedeIrExpedicion())
            throw new InvalidOperationException("El vikingo no puede ir a la expedición");

        vikingos.Add(v);
    }

    public void AgregarDestino(Lugar l)
    {
        destinos.Add(l);
    }

    public int CantidadVikingos()
    {
        return vikingos.Count;
    }

    public int VikingosProductivos()
    {
        return vikingos.Count(v => v.EsProductivo());
    }

    public bool ValeLaPena()
    {
        return destinos.All(d => d.ValeLaPena(this));
    }

    public double BotinTotalEstimado()
    {
        return destinos.Sum(d => d.CalcularBotin(this));
    }

    public double RealizarExpedicion()
    {
        double botinTotal = BotinTotalEstimado();

        if (vikingos.Count == 0)
            return 0;

        double botinPorVikingo = botinTotal / vikingos.Count;

        return botinPorVikingo;
    }
}
