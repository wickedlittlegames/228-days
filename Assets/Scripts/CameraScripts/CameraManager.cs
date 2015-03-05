using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.3f;
	
//	private Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		Vector3 goalPos = target.position;
//		goalPos.y = transform.position.y;
//		goalPos.x = target.position.x - 15f;
//		goalPos.z = target.position.z - 15f;
//		transform.position = Vector3.SmoothDamp (transform.position, goalPos, ref velocity, smoothTime);
	}
}