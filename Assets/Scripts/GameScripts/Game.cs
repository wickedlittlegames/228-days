using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 

[System.Serializable]
public class Game {

	public static List<Character> characterList = new List<Character>();

	public Game() {
		Debug.Log ("Game Init");

		Character captain = new Character();
		captain.Name = "Todd Toddson";
		captain.Energy = 100.0f;
		captain.Active = true;
		captain.Tag = 0;
		captain.StartPosition = new Vector3(3,0,0);

		Character engineer = new Character();
		engineer.Name ="Elizabeth Engee";
		engineer.Energy = 50.0f;
		engineer.Active = false;
		engineer.Tag = 1;
		engineer.StartPosition = new Vector3(-3,0,0);

		characterList.Add(captain);
		characterList.Add(engineer);
	}
}
