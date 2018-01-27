using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorWinAction : MonoBehaviour,IWinAction {
    public GameObject targetDoor;
    public void WinAction()
    {
        targetDoor.SetActive(false);
        //throw new System.NotImplementedException();
    }

 //   // Use this for initialization
 //   void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
