using UnityEngine;
using System.Collections;

[System.Serializable]
public class Character {

	public string 	Name;
	public float 	Energy;
	public int		Tag;
	public bool 	Active;

	public Character() {
		Debug.Log ("Character Init");
	}

	public void ReduceEnergy(float amount) {
		this.Energy -= amount;
	}
	public void IncreaseEnergy(float amount) {
		this.Energy += amount;
	}
	public bool HasEnoughEnergy(float required) {
		return (this.Energy >= required);
	}
}
