using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems; 
using UnityEngine.UI;

public class MarkerHandler : MonoBehaviour
								, IPointerEnterHandler
								, IPointerExitHandler
								, IPointerClickHandler
{
	public NavigationManager navigationManager;
	public Sprite onHoverSprite;
	private Sprite defaultSprite;
	public int levelId;

	public void Start ()
	{ 
		GetComponent<Image> ().sprite = defaultSprite;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (levelId == 5) {
			navigationManager.goTutorial ();
		} else if (levelId == 1) {
			navigationManager.goLevel1 ();
		} else if (levelId == 2) {
			navigationManager.goLevel2 ();
		} else if (levelId == 3) {
			navigationManager.goLevel3 ();
		} else if (levelId == 4) {
			navigationManager.goOutro ();
		} else {
			Debug.LogError ("Levelid nicht bekannt.");
		}
		
	}

	public void OnPointerEnter(PointerEventData eventData)
	{ 
		defaultSprite = GetComponent<Image> ().sprite;
		GetComponent<Image> ().sprite = onHoverSprite;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		GetComponent<Image> ().sprite = defaultSprite;
	}
}
