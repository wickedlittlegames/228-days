﻿using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public GameObject playerPrefab;

	void Awake() {
		new Game();

		foreach(Character character in Game.characterList) {
			playerPrefab.GetComponent<PlayerManager>().currentCharacter = character;
			playerPrefab.transform.position = character.StartPosition;
			Instantiate(playerPrefab);
		}
	}
	
	void Start () {
	
	}
	
	void Update () {
	
	}
}
