using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public void ChangeToScene (int SceneToChangeTo) {
		Application.LoadLevel(SceneToChangeTo);
	}

	public void ChangeActiveCharacter(int CharacterToChangeTo) {
		foreach (GameObject character in GameObject.FindGameObjectsWithTag("Player")) {
			int tag = character.GetComponent<PlayerManager>().currentCharacter.Tag;
			bool activeChoice = (tag == CharacterToChangeTo);

			character.GetComponent<PlayerManager>().currentCharacter.Active = activeChoice;
		}
	}
}
