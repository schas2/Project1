using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigationManager : MonoBehaviour {

	public void goMainScene(){
		Debug.Log ("dfasdf");
		SceneManager.LoadScene(0);
	}

	public void goLevel1(){
		SceneManager.LoadScene(1);
	}

	public void goLevel2(){
		SceneManager.LoadScene(2);
	}

	public void goLevel3(){
		SceneManager.LoadScene(3);
	}
}
