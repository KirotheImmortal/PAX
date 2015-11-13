﻿using UnityEngine;
using System.Collections;

 public class GameStateManager : MonoBehaviour
{
	void Awake()
	{
		Messenger.AddListener<string>("gamestatechanged", TransitionMade);
	}
	void TransitionMade(string transition)
	{
		if(transition.Contains("->pause") || transition.Contains("->start"))
			Time.timeScale = 0;
		else if(transition.Contains("->play"))
			Time.timeScale = 1;
		else if(transition.Contains("->term"))
			Application.Quit();
	}

	static public void ToStart()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	static public void ToPlay()
	{
		Messenger.Broadcast("changegamestate", STATES.PLAY);
	}
	static public void ToPause()
	{
		Messenger.Broadcast("changegamestate",STATES.PAUSE);
	}
	static public void ToGameover()
	{
		Messenger.Broadcast("changegamestate",STATES.GAMEOVER);
	}
	static public void ToEnd()
	{
		Messenger.Broadcast("changegamestate",STATES.END);
	}
	static public void ToTerm()
	{
		Messenger.Broadcast("changegamestate",STATES.TERM);
	}
}
