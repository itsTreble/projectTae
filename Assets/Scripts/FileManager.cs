using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileManager : MonoBehaviour
{
    public TextAsset words;
    static string[] dictionary;
    static FileManager _instance;
    //bool inGameMode = false;
    public static FileManager Instance
    {
        get
        {
            if (_instance == null)
            {
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
        dictionary = words.text.Split('\n');
    }
    public string GetRandomWord()
    {
        int rand = Random.Range(0, dictionary.Length);
        return dictionary[rand];
    }
}
	// Use this for initialization

