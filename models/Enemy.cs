namespace ConsoleApp1.models
{
		internal class Enemy : Entidad<Enemy>
		{	
				public Enemy(string name, string raza, short atk, short hp)
						: base(name, raza, atk, hp)
				{
				}
		}
}