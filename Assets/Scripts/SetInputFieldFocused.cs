using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetInputFieldFocused : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<InputField>().ActivateInputField();
		
	}
	
	// Update is called once per frame
	void Update () {
        //this.GetComponent<InputField>().ActivateInputField();


    }
}
