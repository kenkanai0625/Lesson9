using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseBirdController : MonoBehaviour {
    private float birdspeed = 2.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x <- 5)
        {
            Destroy(this.gameObject);
        }

        if (PlayerController.gameover == false)
        {
            this.transform.Translate(birdspeed * Time.deltaTime, 0, 0);
        }
    }
}
