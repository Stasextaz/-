using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.takeDamage();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
