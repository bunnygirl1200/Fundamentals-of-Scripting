using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour {
/*
	public class Bunnies
	{
		public int age;
		public Color color;
	
		public Bunnies(int _age, Color _color)
		{
			age = _age;
			color = _color;
		}
		
	}
	
	public Bunnies Sam = new Bunnies(5, Color.red);
	public Bunnies Chubbs = Sam;
	
}*/





public class Spells
{
	public int cure;
	
	public Spells (int c)
	{
		cure = c;
	} 
	
	public Spells ()
	{
		cure = 8;
	}

}
	
	public Spells mySpells = new Spells(12);	

void Start()
{
	Debug.Log (mySpells.cure);
}
}





public class Spells
{
	public int blizzard;

	public Spells()
	{
		blizzard = 5; 
	}
	
	public Spells(int blizz)
	{
		blizzard = blizz; 
	}
}
 	public Spells mySpells = new Spells(17);





public class Spells
{
	public int thunder;
	
	public Spells()
	{
		thunder = 6;
	}
	
	public Spells(int thu)
	{
		thunder = thu;
	}

}
	public Spells mySpells = new Spells(14);

