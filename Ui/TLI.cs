using ConsoleApp1.models;

namespace ConsoleApp1
{
		internal static class TLI
		{
				/// <summary>
				/// Diccionario de colores con funciones correspondientes para cambiar el color del texto en la consola.
				/// </summary>
				/// <remarks>
				/// Este diccionario contiene acciones que cambian el color del texto en la consola a partir de un código específico.
				/// Los códigos utilizados son:
				/// - 'B' para Blanco
				/// - 'R' para Rojo
				/// - 'V' para Verde
				/// - 'A' para Azul
				/// </remarks>
				/// <param name="color">El código del color a cambiar. Debe ser uno de los siguientes: B, R, V, A.</param>
				/// <example>
				/// <code>
				/// Colores["B"]?.Invoke(); // Cambia el color del texto a blanco
				/// Colores["R"]?.Invoke(); // Cambia el color del texto a rojo
				/// Colores["G"]?.Invoke(); // Cambia el color del texto a verde
				/// Colores["A"]?.Invoke(); // Cambia el color del texto a azul
				/// </code>
				/// </example>

				public static Dictionary<string, Action> Color = new Dictionary<string, Action>()
				{
						["B"] = () => Console.ForegroundColor = ConsoleColor.White,
						["R"] = () => Console.ForegroundColor = ConsoleColor.Red,
						["V"] = () => Console.ForegroundColor = ConsoleColor.Green,
						["A"] = () => Console.ForegroundColor = ConsoleColor.Blue
				};

				/// <summary>
				/// Imprime la barra de estado de dos entidades en la consola.
				/// </summary>
				/// <param name="p">La entidad jugador.</param>
				/// <param name="e">La entidad enemigo.</param>
				/// <example>
				/// <code>
				/// var player = new Entidad<Player>();
				/// var enemy = new Entidad<Enemy>();
				/// PrintBarStatus(player, enemy);
				/// </code>
				/// </example>
				public static void PrintBarStatus(Entidad<Player> p, Entidad<Enemy> e)
				{
						int sizeWindow = Console.WindowWidth;

						Color["V"]?.Invoke();
						Console.WriteLine(new string('-', sizeWindow));
						Console.Write("\n");
						Console.ResetColor();

						//player
						Console.Write("{");
						Color["B"]?.Invoke(); Console.Write($"{p._Nombre?.Trim()} ");
						Color["V"]?.Invoke(); Console.Write($"[HP:{p._Hp}]");
						Color["R"]?.Invoke(); Console.Write($"[ATK:{p._Atk}]");
						Console.ResetColor();
						Console.Write("}");

						Console.ResetColor();
						//enemigo
						Console.SetCursorPosition(sizeWindow / 2, Console.CursorTop);
						Console.Write("{");
						Color["B"]?.Invoke(); Console.Write($"{e._Nombre?.Trim()} ");
						Color["V"]?.Invoke(); Console.Write($"[HP:{e._Hp}]");
						Color["R"]?.Invoke(); Console.Write($"[ATK:{e._Atk}]");
						Console.ResetColor();
						Console.Write("}");

						Console.WriteLine("\n");
						Color["V"]?.Invoke();
						Console.WriteLine(new string('-', sizeWindow));
						Console.ResetColor();

						//text-center
						//string centeredText = @"hello";
						//int startX = (sizeWindow - centeredText.Length) / 2;
						//Console.SetCursorPosition(startX, Console.CursorTop);
						//Console.WriteLine(centeredText);
						return;
				}
		}
}