using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingManager : MonoBehaviour {
    public Text helperText;
    string currentStringToType = "password";
    static TypingManager _instance;
    public InputField inputField;

    public Image loadingBar;
    public int correctWord = 0;
    public int maxScore = 3;
    public int wrongCount = 0;
    int maxWrong = 3;
    public GameObject compDialogue;
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
    }
    public void StartTimer()
    {
        timer.StartTimer();
    }
    public void StartGame()
    {
        Debug.Log("called start game");
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
        inputField.ActivateInputField();
        if (input.Equals(helperText.text) && !timer.pause)
        {
            StartTimer();
            correctWord++;
            ChangeString();
            if(correctWord == maxScore)
            {
                win.WinAction();
                Win();
            }
        }
        else
        {
            wrongCount++;
        }
        inputField.text = "";

    }
    public void Lose()
    {

        ComputerManager.Instance.TurnOffComputer();
        // lose screen
    }
    public void Win()
    {

        helperText.text = "Good job you destroyed him!";
        ComputerManager.Instance.Invoke("TurnOffComputer", 1.2f);
        CharacterController.Instance.SetMoveTrue();
        //helperText.text = "";

        //Invoke(ComputerManager.Instance.)
    }
    public void ChangeString()
    {
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
