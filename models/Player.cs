using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.models
{
		internal class Player : Entidad<Player>
		{
				public Int16 _Curas { get; private set; }
				public Int16? _Def { get; private set; }

				public Player(
						String name, 
						string roll,
						short atk, short hp,
						short def, short curas)
				: base(name, roll, atk, hp)
				{
						this._Curas = curas;
						this._Def = def;
				}
		}
}