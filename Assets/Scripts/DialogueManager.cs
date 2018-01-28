using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {
    static DialogueManager _instance;
    public string start = "1";
    public string end = "1";

    public RPGTalk rpgTalk;
    public static DialogueManager Instance
    {
        get
        {
            if (_instance == null)
            {
            }
            return _instance;
        }
    }
    public void Talk()
    {
        rpgTalk.NewTalk(start, end);
    }
}
