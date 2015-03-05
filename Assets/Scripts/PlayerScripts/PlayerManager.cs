using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	
	public Character currentCharacter;
	NavMeshAgent _navMeshAgent;
	Color originalColor;

	void Awake () {
		_navMeshAgent = GetComponent<NavMeshAgent>();
		originalColor = GetComponent<Renderer> ().material.color;
	}

	void Start() {
		this._Highlight(currentCharacter.Active);
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

	public void _Highlight(bool isActive) {
		if(isActive) {
			GetComponent<Renderer>().material.color = Color.red;
		} else {
			GetComponent<Renderer>().material.color = originalColor;
		}
	}
}
