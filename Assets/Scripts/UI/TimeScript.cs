﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {

	private int _timeRemaining;
	//private Text _timeRemainingText;
	private Slider slider;

	void Awake () 
	{
		//_timeRemainingText = GetComponent<Text> ();

		startGame();
	}

	public void startGame()
	{
		slider = gameObject.GetComponent<Slider>();
		slider.maxValue = 100;
		_timeRemaining = 100;
		InvokeRepeating ("timeDown", 1f, 1f);
		//_timeRemainingText.text =  "Time: " + _timeRemaining;// + timeRemaining;	//timeRemaining.ToString();
	}
	
	public void timeDown()
	{
		if(_timeRemaining == 0)
		{
			CancelInvoke();

			startGame();

			//_timeRemainingText.text =  null;
			//CancelInvoke();
			//Application.LoadLevel("Shop");
			Debug.Log("Died");
		}
		else
		{
			_timeRemaining --;
			//_timeRemainingText.text =  "Time: " + _timeRemaining;
			slider.value = _timeRemaining;
		}
	}

	void OnLevelWasLoaded(int level) 
	{
		//prepare each scene for startup.
		if(level != 1)
		{
			startGame();
		}
	}
}