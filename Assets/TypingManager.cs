using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingManager : MonoBehaviour {
    public Text helperText;
    string currentStringToType = "Mai is so cool";
    // Use this for initialization
    static TypingManager _instance;

    public static TypingManager Instance
    {
        get
        {
            if (_instance == null)
            {
                //GameObject go = new GameObject("TypingManager");
                //go.AddComponent<SoundManager>();
            }
            return _instance;
        }
    }
    public bool CheckEqual(string input)
    {
        //if(inpu)
        if(input.Equals(currentStringToType))
        {
            return true;
        }
        return false;
    }
    public void EnterString(string input)
    {

    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
