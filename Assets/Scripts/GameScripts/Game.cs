using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 

[System.Serializable]
public class Game {

	public static Game current;
	public static List<Character> characterList = new List<Character>();

	public Game() {
	}
}
