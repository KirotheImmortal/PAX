﻿using UnityEngine;
using System.Collections;

public class GameStateProtoManager: MonoBehaviour
{

    void Awake()
    {
        Messenger.AddListener<string>("transition", StateChanges);
        Messenger.AddListener<string>("win", Winning);
        Messenger.MarkAsPermanent("transition");
        Messenger.MarkAsPermanent("win");
    }

    void StateChanges(string msg)
    {
        print(msg);

        if (msg == "play->pause")
            Time.timeScale = 0;
        else if (msg == "pause->play")
            Time.timeScale = 1;

        else if (msg == "play->gameover" || msg == "pause->start")
            BroadcastMessage("maketransition", STATES.START);
        else if (msg == "gameover->start")
            Application.LoadLevel(Application.loadedLevel);

    }
    void Winning(string msg)
    {
        BroadcastMessage("maketransition", STATES.GAMEOVER);
    }

    void OnDisable()
    {
        Messenger.RemoveListener<string>("transition", StateChanges);
        Messenger.RemoveListener<string>("win",Winning);

    }


}
