using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public GameObject playerPrefab;

	void Awake() {
		Instantiate(playerPrefab);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
