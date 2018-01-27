using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerManager : MonoBehaviour {
    public GameObject ComputerScreen;
    public GameObject NPCGuideDialogue;
    static ComputerManager _instance;

    public static ComputerManager Instance
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
    public void Awake()
    {
        _instance = this;
    }
    void StartNPCGuideDialogue()
    {
        NPCGuideDialogue.SetActive(true);
    }
    public void TurnOnComputer()
    {
        //StartNPCGuideDialogue();
        ComputerScreen.SetActive(true);
        TypingManager.Instance.DeactivateInputField();
        //TypingManager.Instance.PauseGame();
    }
    public void TurnOffComputer()
    {
        ComputerScreen.SetActive(false);
    }
}
