using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneController : MonoBehaviour {
    private float airplanespeed = -2.3f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x <-5)
        {
            Destroy(this.gameObject);
        }

        if (PlayerController.gameover == false)
        {
            this.transform.Translate(airplanespeed * Time.deltaTime, 0, 0);
        }
    }
}
