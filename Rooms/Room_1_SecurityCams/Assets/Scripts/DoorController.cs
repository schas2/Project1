using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool isClosed;

    void Awake()
    {
        isClosed = true;
    }

    public void OperateDoor()
    {
        if (isClosed)
        {
            gameObject.SetActive(false);
        }
    }
}
