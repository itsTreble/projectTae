using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorWinAction : MonoBehaviour, IWinAction
{
    public float timeInvoke = 1.7f;
    public GameObject targetDoor;
    public void WinAction()
    {
        Invoke("HideDoor", timeInvoke);
        //targetDoor.SetActive(false);
    }
    void HideDoor()
    {
        targetDoor.SetActive(false);

    }
}
