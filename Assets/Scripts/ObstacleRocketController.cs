using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRocketController : MonoBehaviour {
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
    }
}
