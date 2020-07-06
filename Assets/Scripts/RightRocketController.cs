using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRocketController : MonoBehaviour {
    private float obstaclerocketspeed = 3.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x < -5)
        {
            Destroy(this.gameObject);
        }

        if (PlayerController.gameover == false)
        {
            this.transform.Translate(0,obstaclerocketspeed * Time.deltaTime, 0);
        }
    }
}
