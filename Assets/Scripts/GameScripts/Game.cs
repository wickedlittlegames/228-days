using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game {

	public static Game current;
	public int dayNumber;
	public Character player;

	public Game() {
		player = new Character();
		player.Name = "Captain!";
		player.Energy = 200.0f;
		dayNumber = 1;
	}
}
