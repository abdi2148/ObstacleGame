using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour {

    // Executes the GameManager's "Win" function once the player collides with the trophy
    void OnTriggerEnter()
    {
        GameManager.instance.Win();
    }

}

