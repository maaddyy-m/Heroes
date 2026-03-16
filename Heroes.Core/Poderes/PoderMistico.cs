namespace Heroes.Core.Poderes;

public class PoderMistico : Poder
{
    public IEnumerable<Poder> Poderes { get; set; } = [];

    internal override void GanarPelea(Empleado oponente)
        => Poderes.Append(oponente.OtorgarPorDerrota());

    internal override ushort Potencia(Heroe heroe)
        => (ushort)Poderes.Sum(p => p.Potencia(heroe));
}
