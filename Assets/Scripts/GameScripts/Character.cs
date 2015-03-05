﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Character {

	public string Name;
	public float Health;
	public float Energy;

	public Character() {
		this.Name = "";
	}
}