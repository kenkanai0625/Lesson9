using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoController : MonoBehaviour {
    private float meteospeed = 4.0f;

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
            this.transform.Translate(-meteospeed * Time.deltaTime, -meteospeed*Time.deltaTime, 0);
        }
    }
}
