using UnityEngine;
using System.Collections;

public class OrbitalSpin : MonoBehaviour {

	public float speed = 2f;
	
	void Update () {
		transform.Rotate(Vector3.right, speed * Time.deltaTime);	
	}
}
