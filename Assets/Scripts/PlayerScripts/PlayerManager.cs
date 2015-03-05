using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	
	public Character currentCharacter;
	NavMeshAgent _navMeshAgent;

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

	void CheckStats() {
		if (this.isMoving()) {
			currentCharacter.ReduceEnergy(0.05f);
		}
	}

	void Move() {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		
		if (Physics.Raycast (ray, out hit, 100)) {
			_navMeshAgent.SetDestination (hit.point);
		}
	}

	bool isMoving() {
		return (_navMeshAgent.velocity != Vector3.zero);
	}
}
