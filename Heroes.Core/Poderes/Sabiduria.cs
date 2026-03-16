namespace Heroes.Core.Poderes;
public class Sabiduria : Poder
{
    internal override void GanarPelea(Empleado oponente) {}    

    internal override ushort Potencia(Heroe heroe)
        => (ushort)(heroe.Oponentes.Count() * 3);
}
