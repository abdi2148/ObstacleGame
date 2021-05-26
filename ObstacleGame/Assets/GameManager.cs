using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public GameObject WinText;
    public float resetDelay;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }

    public void Win()
    {
        WinText.SetActive(true);
        Time.timeScale = .5f;
        Invoke("NextScene", resetDelay);

    }

    void NextScene()
    {

        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Scene2");
    }
}
