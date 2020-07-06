using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseSatelliteController : MonoBehaviour {
    private float satelliteverticalspeed = 7.5f;
    private float satellitehorizontalspeed = 3.25f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x > 7)
        {
            Destroy(this.gameObject);
        }

        if (PlayerController.gameover == false)
        {
            this.transform.Translate(satelliteverticalspeed * Time.deltaTime, -satellitehorizontalspeed * Time.deltaTime, 0);
        }
    }
}
