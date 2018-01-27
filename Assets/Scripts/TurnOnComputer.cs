using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnComputer : MonoBehaviour,IInteractable {
    public GameObject ComputerScreen;

	// Use this for initialization
	public void Interact()
    {
        ComputerManager.Instance.TurnOnComputer();
        TypingManager.Instance.DeactivateInputField();
        //ComputerScreen.SetActive(true);
        Debug.Log("turn on computer");
        //turn on computer
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger parent");
    }
}
