using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems; 

public class NewGameController : MonoBehaviour, IPointerClickHandler {
	public NavigationManager navigationManager;
	public Markermanager markermanager;

	public void OnPointerClick(PointerEventData eventData)
	{
		navigationManager.createNewGame ();
		markermanager.resetAfterNewGame ();
	}
}
