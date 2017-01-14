using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class StoryController : MonoBehaviour {
	public GameObject player;
	public GameObject dialogHolder;
	public NavigationManager naviManager;
	public Camera rotateCamera;
	public GameObject container;
	public GameObject textPanel;
	public GameObject inputPanel;
	public Text textContainer;

	private float seconds = 0;
	// Texte für dialog als array
	String[] textStory = {
		"[ Drück die Leertaste, um den nächsten Text anzuzeigen ]",
		"Standard Humanoid-Roboter XA709-qi wurde in der Ladekammer bereitgestellt.",
		"K.I. wird auf Festplatte geladen...",
		"Ladevorgang abgeschlossen.",
		"Wissenschaftler Herbert: Hallo! Kannst du mich hören?",
		"Wissenschaftler Herbert: Oh, das hatte ich vergessen.",
		"Treiber für die Soundsensoren werden geladen...",
		"Laden der Treiber abgeschlossen.",
		"Wissenschaftler Herbert: So, nun kannst du mich besser hören.",
		"Wissenschaftler Herbert: Der grosse Tag ist da! Du wirst auf Herz und... Ich meine... Egal, auf jeden Fall steht dein Test bevor!",
		"Wissenschaftler Herbert: Ich habe die letzten Jahre mit deiner Entwicklung verbracht und hoffe, dass ich dich auf alle Eventualitäten vorbereitet habe.",
		"Wissenschaftler Herbert: Du wirst jetzt einer Prüfung unterzogen, die deine Entscheidungsfindung und Anpassungsfähigkeit bestimmt.",
		"Wissenschaftler Herbert: Wenn ich gute Arbeit geleistet habe, wirst du repliziert und kannst bald auf allen Welten des Terra-Imperiums spannende Arbeiten verrichten.",
		"Wissenschaftler Herbert: Mir wiederum werden die im intergalaktischen Arbeitsrecht festgelegten zwei Zusatzwochen Ferien zuteil! *Räusper* Win-Win!",
		"Wissenschaftler Herbert: Bist du nur Mittelmass, muss ich erneut in die Tasten greifen und du wirst terminiert...",
		"Wissenschaftler Herbert: Nun, das sollte dich doch ausreichend motivieren, nicht?",
		"Wissenschaftler Herbert: Viel Glück!",
		"[ Du erinnerst dich, dass du dich mit Klicken fortbewegen kannst ]",
		"[ Klicke Objekte an, um Informationen zu erhalten ]"
	};
	int i = 0;
	bool skipText = false;


	void Start () {
		seconds = Time.time;
		// Aktualisiere Status (nur, wenn das Level nicht schon abgeschlossen ist)
		if (!(GameMemory.getRoomState (5) is LevelCompleted)) {
			GameMemory.setTutorialState (new StartedTutorial ());
			GameMemory.save ();
		}
		container.SetActive (true);
		textPanel.SetActive (true);
		inputPanel.SetActive (false);

		textContainer.text = textStory [i++];

		Camera.main.enabled = false;
		rotateCamera.enabled = true;
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (i >= textStory.Length) {
				// Schliesse Tutorial ab
				GameMemory.setTutorialState (new FinishedTutorial ());
				// Ermögliche, dass Level 1 spielbar wird
				if (GameMemory.getRoom1State () is NotAllowedRoom1) {
					GameMemory.setRoom1State (new NotStartedRoom1 ());
					// Setze die Punktzahl
					GameMemory.addScoreForLevel (0, 100);
				}
				GameMemory.save ();
				StartCoroutine(naviManager.goMainScene (5));
			} else {
				textContainer.text = textStory [i++];
			}
		}


	}
}
