using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,IInteractable {
    public void Interact()
    {
        OpenDoor();
    }
    void OpenDoor()
    {
        gameObject.SetActive(false);
    }
    // Use this for initialization
 //   void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
