using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour {

    // Creates private field in our inspector panel
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    // Once the player collides with the floor it will transport the player back to their respawn point 
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawn_point.transform.position;
    }

}
