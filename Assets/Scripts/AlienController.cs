using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour {
    private float alienspeed = 3.0f;
    private float alienlastposx=2.3f;
    private bool alienbool=false;
    private GameObject player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Rocket");
    }
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.y - player.transform.position.y <= -5)
        {
           Destroy(this.gameObject);
        }

        if (this.transform.position.x + alienlastposx >= 4.6f)
        {
            alienbool = true;
        }
        if (this.transform.position.x + alienlastposx <=-4.6f)
        {
            alienbool = false;
        }

        if (alienbool == false&& PlayerController.gameover == false)
        {
            alienlastposx = 2.3f;
            this.transform.Translate(alienspeed * Time.deltaTime, 0, 0);
        }
        if(alienbool == true && PlayerController.gameover == false)
        {
            alienlastposx = -2.3f;
            this.transform.Translate(-alienspeed * Time.deltaTime, 0, 0);
        }
    }
}
