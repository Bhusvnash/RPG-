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
				/// Cambia el color del texto en la consola según el código proporcionado.
				/// </summary>
				/// <remarks>
				/// <param name="key"></param>
				/// <example>
				/// <code>
				/// SetColor('R'); // Cambia el color del texto a rojo
				/// </code>
				/// </example>
				/// </remarks>
				public static void SetColor(char key)
				{
						if (Color.ContainsKey(key.ToString().ToUpper()))
						{
								Color[key.ToString()]?.Invoke();
						}
				}

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

						SetColor('V');
						Console.WriteLine(new string('-', sizeWindow));
						Console.Write("\n");
						Console.ResetColor();

						//player
						Console.Write("{");
						SetColor('B'); Console.Write(p.Nombre?.Trim()); Console.Write(" ");
						SetColor('V'); Console.Write($"[HP:{p.Hp}]");
						SetColor('R'); Console.Write($"[ATK:{p.Atk}]");
						Console.ResetColor();
						Console.Write("}");

						//enemigo
						int cursorTop = Console.CursorTop;
						int enemyPos = sizeWindow / 2;
						if (enemyPos < 0) enemyPos = 0;
						if (enemyPos >= sizeWindow) enemyPos = Math.Max(0, sizeWindow - 1);
						Console.SetCursorPosition(enemyPos, cursorTop);
						Console.Write("{");
						SetColor('B'); Console.Write(e.Nombre?.Trim()); Console.Write(" ");
						SetColor('V'); Console.Write($"[HP:{e.Hp}]");
						SetColor('R'); Console.Write($"[ATK:{e.Atk}]");
						Console.ResetColor();
						Console.Write("}");

						Console.WriteLine("\n");
						SetColor('V');
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