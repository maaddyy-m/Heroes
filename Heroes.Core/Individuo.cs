using Heroes.Core.Poderes;

namespace Heroes.Core;

public class Individuo : Empleado
{
    private static readonly ushort _maxNivel = 1_000;
    public override void GanarPelea(Empleado oponente)
    {
        if (Entrenamiento<_maxNivel)
            Entrenamiento++;
    }

    public override Poder OtorgarPorDerrota()
        => new SuperFuerza(5);
}
