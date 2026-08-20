using System.Diagnostics.Contracts;

namespace ConsoleApp1.models
{
  internal class Player : Entidad<Player>
  {
    public Int16 Curas { get; private set; }
    public Int16? Def { get; private set; }
    public bool Defendiendo { get; set; } = false;

    public Player(
            string name,
            string roll,
            short atk, short hp,
            short def, short curas)
    : base(name, roll, atk, hp)
    {
      this.Curas = curas;
      this.Def = def;
    }

    public override bool RecibirDano(short atk = 0)
    {
      if (!Defendiendo)
      {
        return base.RecibirDano();
      }
      return Defender();

    }

    /// <summary>
    /// Recibe daño al jugador. Si el jugador está defendiendo, reduce el daño recibido.
    /// </summary>
    /// <param name="atk">El ataque recibido.</param>
    /// <returns>Un booleano que indica si el jugador ha sido afectado por el daño (true) o no (false).</returns>
    /// <example>
    /// <code>
    /// bool result = jugador.RecibirDano(10);
    /// if (result)
    /// {
    ///     Console.WriteLine("El jugador ha recibido daño.");
    /// }
    /// else
    /// {
    ///     Console.WriteLine("El jugador se ha defendido y no ha sido afectado por el daño.");
    /// }
    /// </code>
    /// </example>
    public bool Defender()
    {
      if (!Defendiendo)
      {
        Defendiendo = true
      }
      else
      {
        return base.RecibirDano((short)Math.Max(0, Convert.ToInt32(Atk - Def)));

      }
      Defender = !Defendiendo;
      return !Defendiendo;
    }
  }
}