using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems; 

public class SaveController : MonoBehaviour, IPointerClickHandler {
	public NavigationManager navigationManager;

	public void OnPointerClick(PointerEventData eventData)
	{
		navigationManager.saveGame ();
	}
}
