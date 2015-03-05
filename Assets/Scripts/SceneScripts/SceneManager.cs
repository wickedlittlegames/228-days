using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public GameObject playerPrefab;

	void Awake() {
		playerPrefab.GetComponent<PlayerManager>().currentCharacter.Energy = 100.0f;
		playerPrefab.GetComponent<PlayerManager>().currentCharacter.Name = "Todd Toddson";
		Instantiate(playerPrefab);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
