using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour {

    void OnTriggerEnter()
    {
        GameManager.instance.Win();
    }

}

