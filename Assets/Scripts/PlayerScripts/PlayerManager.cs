using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	NavMeshAgent _navMeshAgent;
	public Character currentCharacter;

	void Awake () {
		_navMeshAgent = GetComponent<NavMeshAgent>();
	}
	
	void Update () {
		if ( currentCharacter.Active ) {
			if ( Input.GetMouseButtonDown (0) ) {
				this.Move();
			}
			this.CheckStats();
		}
	}

	void Move() {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		
		if (Physics.Raycast (ray, out hit, 1000)) {
			_navMeshAgent.SetDestination (hit.point);
		}
	}

	void CheckStats() {
		if (_navMeshAgent.velocity != Vector3.zero) {
			currentCharacter.Energy -= 0.005f;
		}
	}
}
