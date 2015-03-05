using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	NavMeshAgent _navMeshAgent;
	public bool active;
	public Character currentCharacter;

	// Use this for initialization
	void Start () {
		_navMeshAgent = GetComponent<NavMeshAgent>();
		currentCharacter = Game.current.captain;
	}
	
	// Update is called once per frame
	void Update () {
		if ( active ) {
			this.ClickToMove(Input.GetMouseButtonDown (0));
		}
	}

	void ClickToMove(bool clicked = false) {
		if (clicked) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (ray, out hit, 1000)) {
				_navMeshAgent.SetDestination (hit.point);
			}
		}

		// If player is moving
		if (_navMeshAgent.velocity != Vector3.zero) {
			currentCharacter.Energy -= 0.05f;
		}
	}

	void ToggleActive() {
		this.active = !this.active;
	}
}
