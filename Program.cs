using ConsoleApp1.models;
using ConsoleApp1;


internal class Program
{
		//referencia unica para carculos , todo depende de este
		public static Random random = new Random();

		public static void Main()
		{
				Console.Write("Ingresa tu nombre: ");
				Console.Clear();
				var name = "default";// Console.ReadLine();
				var jugador = new Player(name ?? "desconociado", "N/A", 10, 100, 10, 2);
				var enemigo = new Enemy("Enemigo", "Ra", 11, 100);
				TLI.PrintBarStatus(jugador, enemigo);
				do
				{
						var danio = jugador.Atacar();
						Console.WriteLine($"{jugador.Nombre} : Ataca[atk:{danio}]");
						enemigo.RecibirDano(danio);

						danio = enemigo.Atacar();
						Console.WriteLine($"{enemigo.Nombre} : Ataca[atk:{danio}]\n");
						jugador.RecibirDano(danio);
						
						Thread.Sleep(4000);
						TLI.PrintBarStatus(jugador, enemigo);
				}
				while (continuar(jugador, enemigo));
		}

		/// <summary>
		/// Mientras hp>0 y hpEnemigo>0, retorna true.
		/// </summary>
		/// <param name="p">El jugador.</param>
		/// <param name="e">El enemigo.</param>
		/// <returns>Un booleano que indica si el juego continúa (true) o no (false).</returns>
		/// <example>
		/// <code>
		/// bool continuar = continuar(jugador, enemigo);
		/// if (continuar)
		/// {
		///     Console.WriteLine("Juego Continua.");
		/// }
		/// else
		/// {
		///     Console.WriteLine("El juego ha terminado.");
		/// }
		/// </code>
		/// </example>
		private static Func<Player, Enemy, bool> continuar =
		(Player p, Enemy e) =>
		{
				return p.Hp > 0 && e.Hp > 0;
		};
}