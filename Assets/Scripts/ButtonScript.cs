﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReplayGame()
    {
        SceneManager.LoadScene("MainScene");
        PlayerController.gameover = false;
        PlayerController.onemorebool = true;
        PlayerController.countdownbool = true;
        PlayerController.startbool = true;
    }
}
