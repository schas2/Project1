using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[RequireComponent(typeof(AudioSource))]
public class GameMemory : MonoBehaviour {
	private static SerializableGameState gameState = new SerializableGameState();
	private static int currentSceneId = 0;
	private static string savedGamePath;

	// Use this for initialization
	void Start () {
		savedGamePath = Application.persistentDataPath + "/spielstand.gd";
		Debug.Log ("Game will be saved and loaded from " + savedGamePath);
		gameState.roomStates.Clear ();
		load ();
		// Not working yet...
		AudioSource audio = GetComponent<AudioSource>();
		audio.PlayOneShot (audio.clip);
		DontDestroyOnLoad(this);
	}

	public static void save() {
		Debug.Log ("Save game to: " + Application.persistentDataPath);
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream fs = File.Create (savedGamePath);
		bf.Serialize (fs, gameState);
		fs.Close ();
	}

	public static void load() {
		if (File.Exists (savedGamePath)) {
			Debug.Log ("Load Game From: " + Application.persistentDataPath);
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream fs = File.Open (savedGamePath, FileMode.Open);
			gameState = (SerializableGameState)bf.Deserialize (fs);
			fs.Close ();
			gameState.print ();
		} else {
			createNewGame ();
		}
	}

	public static void createNewGame() {
		Debug.Log ("Create new Game at: " + Application.persistentDataPath);
		gameState.roomStates.Clear ();
		gameState.roomStates.Add(0, new Room0State());
		gameState.roomStates.Add(1, new NotAllowedRoom1());
		gameState.roomStates.Add(2, new NotAllowedRoom2());
		gameState.roomStates.Add(3, new NotAllowedRoom3());
		gameState.roomStates.Add(4, new NotAllowedOutro());
		gameState.roomStates.Add(5, new NotStartedTutorial());
		gameState.scores.Clear ();
		gameState.scores.Add (0, -1);
		gameState.scores.Add (1, -1);
		gameState.scores.Add (2, -1);
		gameState.scores.Add (3, -1);
	}

	public static int getCurrentSceneId() {
		return currentSceneId;
	}

	public static void setCurrentSceneId(int newSceneId) {
		currentSceneId = newSceneId;
	}

	public static BaseState getRoomState(int sceneId) {
		return gameState.roomStates [sceneId];
	}

	public static BaseState getCurrentRoomState() {
		return gameState.roomStates [currentSceneId];
	}

	public static Room1State getRoom1State() {
		return (Room1State) gameState.roomStates [1];
	}

	public static Room2State getRoom2State() {
		return (Room2State) gameState.roomStates [2];
	}

	public static Room3State getRoom3State() {
		return (Room3State) gameState.roomStates [3];
	}

	public static TutorialState getIntroState() {
		return (TutorialState) gameState.roomStates [5];
	}

	public static OutroState getOutroState() {
		return (OutroState) gameState.roomStates [4];
	}

	public static void setRoom1State(Room1State state) {
		Debug.Log ("setRoom1State to " + state);
		gameState.roomStates [1] = state;
	}

	public static void setRoom2State(Room2State state) {
		Debug.Log ("setRoom2State to " + state);
		gameState.roomStates [2] = state;
	}

	public static void setRoom3State(Room3State state) {
		Debug.Log ("setRoom3State to " + state);
		gameState.roomStates [3] = state;
	}

	public static void setOutroState(OutroState state) {
		Debug.Log ("setOutroState to " + state);
		gameState.roomStates [4] = state;
	}

	public static void setTutorialState(TutorialState state) {
		Debug.Log ("setTutorialState to " + state);
		gameState.roomStates [5] = state;
	}

	public static int getScore() {
		int sum = 0;
		int levelsPlayed = 0;
		if (gameState.scores [0] != -1 && gameState.scores [0] <= 100) {
			sum += gameState.scores [0];
			levelsPlayed++;
		}
		if (gameState.scores [1] != -1 && gameState.scores [1] <= 100) {
			sum += gameState.scores [1];
			levelsPlayed++;
		}
		if (gameState.scores [2] != -1 && gameState.scores [2] <= 100) {
			sum += gameState.scores [2];
			levelsPlayed++;
		}
		if (gameState.scores [3] != -1 && gameState.scores [3] <= 100) {
			sum += gameState.scores [3];
			levelsPlayed++;
		}
		if (levelsPlayed != 0) {
			return sum / levelsPlayed;
		}
		return 0;
	}

	public static void addScoreForLevel(int level, int score) {
		Debug.Log("addScoreForLevel(int "+level+", int "+score+")");
		if ((level == 0 || level == 1 || level == 2 || level == 3) && score >= 0 && score <= 100) {
			gameState.scores [level] = score;
		}
	}
}
