using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {
    public int coins = 0;
    public int hp = 10;
    public int maxHP = 10;
    public Transform attackPoint;
    public GameObject ball;
    public string sceneName;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ball, attackPoint.position,attackPoint.rotation);
        }
        if (coins < 6)
        {

        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
	}

    public void takeDamage()
    {
        hp--;
        if (hp > 0)
        {

        }
        else
        {
            int sceneIndexId = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndexId);
        }
    }
}
