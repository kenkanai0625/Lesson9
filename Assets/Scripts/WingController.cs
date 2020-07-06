using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingController : MonoBehaviour {
    private GameObject player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Rocket");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Animator>().SetTrigger("WingTrigger");
        }
        if (player.transform.position.y >= 0)
        {
            this.transform.position = new Vector2(this.transform.position.x, player.transform.position.y);
        }
    }
}
