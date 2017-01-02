using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems; 

public class NewGameController : MonoBehaviour, IPointerClickHandler {
	public NavigationManager navigationManager;

	public void OnPointerClick(PointerEventData eventData)
	{
		navigationManager.createNewGame ();
	}
}
