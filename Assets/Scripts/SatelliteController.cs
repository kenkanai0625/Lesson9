using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteController : MonoBehaviour {
    private float satelliteverticalspeed = 7.5f;
    private float satellitehorizontalspeed=3.25f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x <- 7)
        {
            Destroy(this.gameObject);
        }

        if (PlayerController.gameover == false)
        {
            this.transform.Translate(-satellitehorizontalspeed * Time.deltaTime, satelliteverticalspeed*Time.deltaTime, 0);
        }
    }
}
