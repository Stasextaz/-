using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour {
    public float speed = 0;
    public Vector3 direction;

    public bool active = true;

    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Stop")
        {
            direction = direction * -1;
        }
        if (other.tag == "Player")
        {
            active = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        active = false;
    }
    void Update () {
		if (active)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
	}
}
