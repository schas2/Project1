﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
		DontDestroyOnLoad(this);
	}

	public static void save() {
		Debug.Log (Application.persistentDataPath);
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream fs = File.Create (savedGamePath);
		bf.Serialize (fs, gameState);
		fs.Close ();
		gameState.print ();
	}

	public static void load() {
		if (File.Exists (savedGamePath)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream fs = File.Open (savedGamePath, FileMode.Open);
			gameState = (SerializableGameState)bf.Deserialize (fs);
			fs.Close ();
			gameState.print ();
		} else {
			gameState.roomStates.Add(0, new Room0State());
			gameState.roomStates.Add(1, new StartedRoom1());
			gameState.roomStates.Add(2, new StartedRoom2());
			gameState.roomStates.Add(3, new StartedRoom3());
			gameState.roomStates.Add(4, new StartedOutro());
		}
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

	public static void setRoom1State(Room1State state) {
		gameState.roomStates [1] = state;
	}

	public static void setRoom2State(Room2State state) {
		gameState.roomStates [2] = state;
	}

	public static void setRoom3State(Room3State state) {
		gameState.roomStates [3] = state;
	}
}
