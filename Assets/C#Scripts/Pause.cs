using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pause : MonoBehaviour {

    //text for the pause
    private Text pauseText;

    //Bool Variable used to show restart message
    public static bool paused = false;

    void Start()
    {
        // Set up the reference.
        pauseText = GetComponent<Text>();
        paused = false;

    }

    void Update()
    {
        //Cant pause if the game is over
        if(GameOver.Over == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Time.timeScale == 1) // if not pause, then pause the game
                {
                    Time.timeScale = 0;
                    pauseText.text = "PAUSED"; //pause message
                    paused = true;
                }
                else
                {
                    Time.timeScale = 1; //else resume the game
                    pauseText.text = ""; //empty
                    paused = false;
                }

            }
        }


        //Timescale is the speed of the whole game
        //1 is normal speed. 0 is stop. 0.5 is half speed, etc. 
    }
}
