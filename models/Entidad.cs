namespace ConsoleApp1.models
{
		internal class Entidad<T>
		{
				public string? _Nombre { get; private set; }
				public string? _Roll { get; private set; }
				public Int16 _Atk { get; private set; }
				public Int16? _Hp { get; private set; }

				public Entidad(string name, string roll, Int16 atk, Int16 hp)
				{
						this._Nombre = name;
						this._Roll = roll;
						this._Atk = atk;
						this._Hp = hp;
				}

				//propios
				/// <summary>
				/// Recibe daño a un objeto, reduciendo su salud (_Hp).
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

			
				public bool RecibirDano(Int16 atk = 0)
				{
						try
						{
								_Hp -= Convert.ToInt16(atk);
								return true;
						}
						catch { return false; }
				}
				/// <summary>
				/// Realiza un ataque, generando un valor aleatorio entre _Atk - 5 y _Atk + 5.
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
										Convert.ToInt32(_Atk) - 5,
										Convert.ToInt32(_Atk) + 5
								)
						);
				}
				         
		}
}