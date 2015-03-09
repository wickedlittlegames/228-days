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
			character.GetComponent<PlayerManager>()._Highlight(activeChoice);
		}
	}

	public void NewGame() {
		// Make a new Game
		Application.LoadLevel(1);
	}

	public void SaveGame() {

	}

	public void LoadGame() {
		// Load an existing game!
		Application.LoadLevel(1);
	}
}
