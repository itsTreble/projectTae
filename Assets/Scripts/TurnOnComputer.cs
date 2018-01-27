using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnComputer : MonoBehaviour,IInteractable {
    public GameObject ComputerScreen;

	// Use this for initialization
	public void Interact()
    {
        ComputerManager.Instance.TurnOnComputer(GetComponent<BoxCollider2D>());
        //TypingManager.Instance.DeactivateInputField();
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponentInChildren<BoxCollider2D>().enabled = false;
        //ComputerScreen.SetActive(true);
        Debug.Log("turn on computer");
        //turn on computer
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger parent");
    }
}
