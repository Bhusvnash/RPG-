namespace ConsoleApp1.models
{
  internal class Entidad<T>
  {
    public string? Nombre { get; private set; }
    public string? Roll { get; private set; }
    public Int16 Atk { get; private set; }
    public Int16 Hp { get; private set; }

    public Entidad(string name, string roll, Int16 atk, Int16 hp)
    {
      this.Nombre = name;
      this.Roll = roll;
      this.Atk = atk;
      this.Hp = hp;
    }

    //propios
    /// <summary>
    /// Recibe daño a un objeto, reduciendo su salud (Hp).
    /// </summary>
    /// <param name="atk">El ataque que se aplica. El valor predeterminado es 0.</param>
    /// <returns>Un booleano que indica si el método pudo ejecutarse correctamente.</returns>
    /// <example>
    /// <code>
    /// var resultado = Objeto.RecibirDano(16);
    /// if (resultado)
    /// {
    ///   hp-=16
    /// }
    /// else
    /// {
    ///     Console.WriteLine("No se pudo recibir el daño.");
    /// }
    /// </example>

    public virtual bool RecibirDano(Int16 atk = 0)
    {
      try
      {
        Hp -= Convert.ToInt16(atk);
        return true;
      }
      catch { return false; }
    }

    /// <summary>
    /// Realiza un ataque, generando un valor aleatorio entre Atk - 5 y Atk + 5.
    /// </summary>
    /// <returns>Un short que representa el resultado del ataque. El ataque es entero pero se almacena como short.</returns>
    /// <example>
    /// <code>
    /// var ataque = Objeto.Atacar();
    /// Console.WriteLine($"Objeto realizó un ataque de {ataque} puntos.");
    /// </code>
    /// </example>
    public short Atacar()
    {
      return Convert.ToInt16(
              Program.random.Next(
                      Convert.ToInt32(Atk) - 5,
                      Convert.ToInt32(Atk) + 5
              )
      );
    }
  }
}