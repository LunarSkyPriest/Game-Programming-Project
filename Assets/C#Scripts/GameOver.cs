using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour {

    //text for the Game Over
    private Text gameOverText;

    //Bool Variable used to show restart message
    public static bool Over = false;



    void Start()
    {
        // Set up the reference.
        gameOverText = GetComponent<Text>();

        Over = false;
    }

    // Update is called once per frame
    void Update ()
    {
	    if (ColliderPushBall.ballDestroyed == true)
        {
            Over = true;
            gameOverText.text = "GAME OVER";
        }
        	
	}
}
