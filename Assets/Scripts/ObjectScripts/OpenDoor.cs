using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	public GameObject door;
	public GameObject ship;
	public bool isOpen = false;
	public float energyCost = 0.05f;

	void OnTriggerEnter(Collider other) {
		if (!isOpen && other.GetComponent<PlayerManager>().currentCharacter.HasEnoughEnergy(energyCost)) {
			this.Open ();
			// Example of the ship getting its energy reduced by a small small amount
			//ship.BroadcastMessage("reduceEnergy", energyCost);
		}
	}

	void Open() {
		door.transform.position = new Vector3(door.transform.position.x - 10, door.transform.position.y, door.transform.position.z);
		this.isOpen = true;
	}
}
