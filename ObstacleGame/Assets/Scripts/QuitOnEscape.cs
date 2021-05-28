using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitOnEscape : MonoBehaviour {

    // Simply quits the stage and loads back to the menu
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
