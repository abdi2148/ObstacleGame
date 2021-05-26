using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerSystem : MonoBehaviour {

    public Text timerText;
    public float timeLeftSeconds = 3F;
    public static bool TimesUp = false;
    public string SampleScene;

    void Start()
    {
        //startTime = Time.time 
        TimesUp = false;

    }

    void Update()
    {
        float t = timeLeftSeconds -= Time.deltaTime;

        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
        string milliseconds = ((int)(t * 100f) % 100).ToString("00");

        timerText.text = minutes + ":" + seconds + ":" + milliseconds;

        if (timeLeftSeconds <= 0)
        {
            timeLeftSeconds = 0;
            timerText.text = minutes + ":" + seconds;
            TimesUp = true;
        }

        if (TimesUp == true && Input.GetKeyDown("p"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (TimesUp == true && Input.GetKeyDown("m"))
            SceneManager.LoadScene(SceneManager.GetSceneByName("MenuScene").buildIndex);

    }

    void OnGUI()
    {
        if (TimesUp == true)
            GUI.Box(new Rect(0, 50, 250, 25), "You Lost, press 'P' to play again. Otherwise press 'M' to return back to menu");
    }

}
