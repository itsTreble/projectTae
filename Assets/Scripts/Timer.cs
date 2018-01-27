using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Image img;
    float currTime;
    float maxTime = 10;
    public bool pause = true;
	// Use this for initialization
	void Start () {
        currTime = maxTime;
	}
	public void StartTimer()
    {
        pause = false;
        currTime = maxTime;
    }
    public void PauseTimer()
    {
        pause = true;
    }
	// Update is called once per frame
	void Update () {
		if(currTime > 0 && pause == false)
        {
            currTime -= Time.deltaTime;
            img.fillAmount = currTime / maxTime;
        }
        else if(currTime <= 0)
        {
            TypingManager.Instance.AddWrong();
            TypingManager.Instance.ChangeString();
        }
	}
}
