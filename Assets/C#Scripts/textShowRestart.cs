using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class textShowRestart : MonoBehaviour {

    //Will be used to show how to restart. Will be used for the Pause and Game Over screens
    private Text restartText;

    // Use this for initialization
    void Start () {

        restartText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Pause.paused == true || GameOver.Over == true)
        {
            restartText.text = "Press 'R' to restart"; //restart message
        }
        else
            restartText.text = ""; //restart message

        //Restarting the scene
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Rese0tting the variables
            Pause.paused = false;
            GameOver.Over = false;
            ColliderPushBall.ballDestroyed = false;
            Time.timeScale = 1;
            //Load Main Game scene
            SceneManager.LoadScene("MainGame");
        }
    }
}
