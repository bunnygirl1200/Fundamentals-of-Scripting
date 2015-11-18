//Instructions, Identify and explain each line in this script using comments.
//What it is using to run the code.
using UnityEngine;
//Same.
using System.Collections;
//Public means it can be used in other scripts and be accessed from inside unity. Class is declaring a class. Midterm is the name.
public class MidTerm : MonoBehaviour {
	//Public is what I said above. Int is declaring the variable. myInt is the name of the variable. 
	public int myInt = 6;
	//float is declaring the type of variable.
	float coffeeTemperature = 85.0f;
	//private can only be accessed in this script. Float is declaring the type of variable.
	private float hotLimitTemperature = 70.0f;
	//Public means it can be used in other scripts and be accessed from inside unity. Float is declaring the type of variable.
	public float coldLimitTemperature = 40.0f;
	//Int is the type of variable. 
	int numEnemies = 3;
	//private can only be accessed in this script. MidTerm is the name of the class.
	private MidTerm myMidterm;
	//Public means it can be used in other scripts and be accessed from inside unity. GameObject[] is an array. players is the name of the array.
	public GameObject[] players;
	//void doesn't return anything. Start is starting the function.
	void Start ()
	{
		//
		TemperatureTest();
		//Return myInt.
		Debug.Log (myInt);
		//for is a conditional. int is declaring the type of variable. i is index.
		for(int i = 0; i < numEnemies; i++)
		{
			//Returns Creating enemy number and a number.
			Debug.Log("Creating enemy number: " + i);
		}
		//
		myMidterm = GetComponent<MidTerm>();
		//for is a conditional. int is declaring the type of variable. i is index.
		for(int i = 0; i < players.Length; i++)
		{
			//Returns Player Number # is named (player's name).
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}
		//Direction is the type. myDirection is the name.
		Direction myDirection;
		//
		myDirection = Direction.North;
		//ReverseDirection is the type. Returns myDirection.
		ReverseDirection (myDirection);
		
	}
	//void returns nothing. Update declaring starting the function.
	void Update ()
	{
		//if is a conditional. Everything in the () is the conditional statement.
		if(Input.GetKeyDown(KeyCode.Space))
			//The output of the conditional.
			TemperatureTest();
		//Makes coffeeTemperature equal to Time.deltaTime multiplied by 5.
		coffeeTemperature -= Time.deltaTime * 5f;
	}
	//void returns nothing. TemperatureTest is declaring what is going to happen, starts the function.
	void TemperatureTest ()
	{
		//string is a sentence. tooHot is the type.
		string tooHot = "Coffee is too hot.";
		//if is a conditional. Everything in the () is the conditional statement.
		if(coffeeTemperature > hotLimitTemperature)
		{
			//Will type the comment "tooHot"
			print(tooHot);
		}
	}
	//enum is a collection. Direction is the type. The directions are the variables.
	enum Direction{North, East, South, West};
	// void doesn't return anything. ReverseDirection is what the code is going to do. Direction is the type. dir is what it is returning.
	void ReverseDirection (Direction dir)
	{
		//if is a conditional. dir is Direction.North.
		if(dir == Direction.North)
			//Makes dir equal to Direction.South.
			dir = Direction.South;
		
		
	}
	//void doesn't return anything, greet starts the function
	void Greet()
	{
		//switch compares a variable against constants, myInt is the variable
		switch (myInt)
		{
		//declares the first constant
		case 5:
			//will type the comment in the parantheses
			print ("Why hello there good sir! Let me teach you about Trigonometry!");
			//stops the loop
			break;
		case 4:
			print ("Hello and good day!");
			break;
		case 3:
			print ("Whadya want?");
			break;
		case 2:
			print ("Grog SMASH!");
			break;
		case 1:
			print ("Ulg, glib, Pblblblblb");
			break;
		default:
			print ("Incorrect intelligence level.");
			break;
		}
	}
