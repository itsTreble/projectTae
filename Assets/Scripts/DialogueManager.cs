using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {
    static DialogueManager _instance;
    public string start = "1";
    public string end = "1";
    public string dialoguePrefex = "EvilScript";
    public string dialoguePrefex2 = "EndScript";
    int currentRound = 0;

    public RPGTalk rpgVirusTalk;
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
    void OnEndTalk()
    {
        TypingManager.Instance.StartGame();
    }
    public void Talk()
    {
        // need to figure out how to have a talk and repsonse system for the different npcs
        rpgVirusTalk.NewTalk("2", "3");

        if (TypingManager.Instance.round >= 1)
        {
            rpgVirusTalk.OnEndTalk += OnEndTalk;
            //rpgVirusTalk.
            //rpgVirusTalk.callbackFunction += TypingManager.Instance.StartGame;

        }

    }
}
