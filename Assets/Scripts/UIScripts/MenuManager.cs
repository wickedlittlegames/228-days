using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public void ChangeToScene (int SceneToChangeTo) {
		Application.LoadLevel(SceneToChangeTo);
	}
}
