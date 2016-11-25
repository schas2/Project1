using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigationManager : MonoBehaviour {

	public void goMainScene(){
		GameMemory.room2State.leave ();
		// testing
		GameMemory.room2State = new FinishedRoom2 ();
		SceneManager.LoadScene(0);
	}

	public void goLevel1(){
		SceneManager.LoadScene(1);
	}

	public void goLevel2(){
		GameMemory.room2State.arrive();
		SceneManager.LoadScene(2);
	}

	public void goLevel3(){
		SceneManager.LoadScene(3);
	}
}
