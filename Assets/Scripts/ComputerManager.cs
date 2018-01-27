using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerManager : MonoBehaviour {
    public GameObject ComputerScreen;
    public GameObject NPCGuideDialogue;
    static ComputerManager _instance;
    BoxCollider2D currBoxCollider;
    RPGTalkArea talkArea;
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
    public void TurnOnComputer(RPGTalkArea talkA)
    {
        talkArea = talkA;
        talkArea.enabled = false;
        ComputerScreen.SetActive(true);
        TypingManager.Instance.inputField.enabled = false;
        //currBoxCollider = collider;
    }
    public void TurnOffComputer()
    {
        //currBoxCollider.en
        talkArea.enabled = true;
        ComputerScreen.SetActive(false);
        CharacterController.Instance.SetMoveTrue();
    }
}
