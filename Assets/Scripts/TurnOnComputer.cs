using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnComputer : MonoBehaviour,IInteractable {
    public GameObject ComputerScreen;

	// Use this for initialization
	public void Interact()
    {
        CharacterController.Instance.SetMoveFalse();
        ComputerManager.Instance.TurnOnComputer(GetComponent<BoxCollider2D>());
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponentInChildren<BoxCollider2D>().enabled = false;
        TypingManager.Instance.SetWinAction(GetComponent<IWinAction>());
        Debug.Log("turn on computer");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger parent");
    }
}
