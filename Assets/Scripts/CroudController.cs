using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CroudController : MonoBehaviour {
   private GameObject rocket;

	// Use this for initialization
	void Start () {
        rocket = GameObject.Find("Rocket");
    }
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.y - rocket.transform.position.y <= -5)
        {
            Destroy(this.gameObject);
        }
    }
}
