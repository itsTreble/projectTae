using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour {
    string inGameSceneName = "ComputerScreen";
    public void StartGame()
    {
        SceneManager.LoadScene("ComputerScreen");

    }
}
