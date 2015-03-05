using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game {

	public static Game current;
	public int dayNumber;
	public Character captain;

	public Game() {
		captain = new Character();
		captain.Energy = 200.0f;
		dayNumber = 1;
	}
}
