using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigationManager : MonoBehaviour {

	public void goMainScene(){
		GameMemory.getCurrentRoomState().leave ();
		GameMemory.setCurrentSceneId(0);
		GameMemory.getCurrentRoomState().arrive ();
		SceneManager.LoadScene(0);
	}

	public void goLevel1(){
		GameMemory.getCurrentRoomState ().leave ();
		GameMemory.setCurrentSceneId (1);
		GameMemory.getCurrentRoomState ().arrive ();
		SceneManager.LoadScene(1);
	}

	public void goLevel2(){
		GameMemory.getCurrentRoomState ().leave ();
		GameMemory.setCurrentSceneId (2);
		GameMemory.getCurrentRoomState ().arrive ();
		SceneManager.LoadScene(2);
	}

	public void goLevel3(){
		GameMemory.getCurrentRoomState ().leave ();
		GameMemory.setCurrentSceneId (3);
		GameMemory.getCurrentRoomState ().arrive ();
		SceneManager.LoadScene(3);
	}

	public void goOutro(){
		GameMemory.getCurrentRoomState().leave();
		GameMemory.setCurrentSceneId(4);
		GameMemory.getCurrentRoomState().arrive();
		SceneManager.LoadScene(4);
	}

	public void goTutorial(){
		GameMemory.getCurrentRoomState().leave();
		GameMemory.setCurrentSceneId(5);
		GameMemory.getCurrentRoomState().arrive();
		SceneManager.LoadScene(5);
	}

	public void saveGame() {
		GameMemory.save ();
	}

	public void createNewGame() {
		GameMemory.createNewGame ();
	}
}
