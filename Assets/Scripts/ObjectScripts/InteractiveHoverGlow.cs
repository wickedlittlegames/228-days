using UnityEngine;
using System.Collections;

public class ObjectHoverGlow : MonoBehaviour {

	Color originalColor;
	public Color highlightColor;

	// Use this for initialization
	void Start () {
		originalColor = GetComponent<Renderer> ().material.color;
	}
	
	// Update is called once per frame
	void OnMouseEnter() {
		GetComponent<Renderer>().material.color = highlightColor;
	}
	
	void OnMouseExit() {
		GetComponent<Renderer>().material.color = originalColor;
	}
}
