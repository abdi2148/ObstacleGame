using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour {

    void OnTriggerEnter()
    {
        GameManager.instance.Win();
    }

}

