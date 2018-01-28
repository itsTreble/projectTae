using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingManager : MonoBehaviour {
    public Text helperText;
    string currentStringToType = "password";
    static TypingManager _instance;
    public InputField inputField;
    public RPGTalk rpgTalk;
    //public RPGTalkArea rpgTalk;
    public Image loadingBar;
    public int correctWord = 0;
    public int maxScore = 3;
    public int wrongCount = 0;
    int maxWrong = 3;
    public GameObject compDialogue;
    public TurnOnComputer turnOnComputer;
    public int round = 0;
    Timer timer;
    IWinAction win;

    //bool inGameMode = false;
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
    public void SetWinAction(IWinAction winA)
    {
        this.win = winA;
    }
    public void AddWrong()
    {
        wrongCount++;
        if(wrongCount >= maxWrong)
        {
            helperText.text = "Argh! he's kicking me off!";
            Invoke("Lose", 1.4f);
        }
    }
    public void StartTimer()
    {
        timer.StartTimer();
    }

    public void StartGame()
    {
        wrongCount = 0;
        correctWord = 0;
        helperText.enabled = true;
        inputField.enabled = true;
        helperText.text = currentStringToType;
        inputField.ActivateInputField();
        StartTimer();
    }
    public void PauseGame()
    {
        timer.PauseTimer();
    }


    public void ActivateInputField()
    {
        inputField.ActivateInputField();
    }
    public void EnterString(string input)
    {
        if(wrongCount == maxWrong)
        {
            helperText.text = "Argh! he's kicking me off!";
            Invoke("Lose", 1.4f);
        }
        else
        {
            inputField.ActivateInputField();
            if (input.Equals(helperText.text) && !timer.pause)
            {
                correctWord++;
                ChangeString();
                if (correctWord == maxScore)
                {
                    win.WinAction();
                    Win();
                }
            }
            else
            {
                wrongCount++;
            }
        }
        inputField.text = "";



    }
    public void Lose()
    {
        helperText.text = "";
        ComputerManager.Instance.TurnOffComputer();
    }
    public void Win()
    {
        round++;
        timer.pause = true;
        helperText.text = "YES! Thank you!";
        Invoke("ClearText", 1.2f);
        ComputerManager.Instance.Invoke("TurnOffComputer", 1.2f);
        CharacterController.Instance.SetMoveTrue();
        ComputerManager.Instance.talkArea.GetComponent<BoxCollider2D>().enabled = false;
        turnOnComputer.win = true;
    }
    void ClearText()
    {
        helperText.text = "";

    }
    public void ChangeString()
    {
        StartTimer();
        currentStringToType = "mai" + Random.Range(1,100);
        helperText.text = currentStringToType;
    }
    private void Awake()
    {
        _instance = this;
    }
    void OnEditInputField(InputField input)
    {
        if(timer.pause)
        {
            //input.text = "";
        }
    }
    void Start () {
        inputField.onEndEdit.AddListener(delegate { OnEditInputField(inputField); });
        inputField.ActivateInputField();
        helperText.text = currentStringToType;
        timer = GetComponentInChildren<Timer>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("escape"))
            Application.Quit();
    }
}
