using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingManager : MonoBehaviour {
    public Text helperText;
    string currentStringToType = "password";
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
        Debug.Log("enteredstring");
        if (input.Equals(helperText.text))
        {
            Debug.Log("hey its equal");
            ChangeString();
        }
    }
    public void ChangeString()
    {
        currentStringToType = "mai";
        helperText.text = currentStringToType;
    }
    private void Awake()
    {
        _instance = this;
    }
    void Start () {
        helperText.text = currentStringToType;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
