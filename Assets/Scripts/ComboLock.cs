﻿using UnityEngine;
using System.Collections;

public class ComboLock : MonoBehaviour
{
    //Correct Combo to the lock
    public string LockCombo;
    //Objects that represent a value the user will input as a combo to the lock
    int i = 0;
    public string input;
    string[] value = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public GameObject[] keys;
    bool checking = false;

    void Awake()
    {
        Callback<string> stuff = UserInput;
        Messenger.AddListener<string>(name.ToLower(), UserInput);
    }

    void Start()
    {
        SetKeyValues();
    }

    

    void UserInput(string s)
    {
        if(checking == false)
        {

        }
        input += s;
    }

    void SetKeyValues()
    {
        foreach(GameObject g in keys)
        {
            g.GetComponent<PressurePlate>().stringArgument1 = value[i];
            g.GetComponent<PressurePlate>().messageToPublish = "Ramp";
            Debug.Log(value[i]);
            i += 1;
        }
    }
}