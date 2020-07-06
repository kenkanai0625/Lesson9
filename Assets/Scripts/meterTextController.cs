using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meterTextController : MonoBehaviour {
    public GameObject player;
    public GameObject meter;
    private float length;
    private float meterpercentage;

	// Use this for initialization
	void Start () {
        meter.GetComponent<Text>().text = "0%";
    }
	
	// Update is called once per frame
	void Update () {
        length = player.transform.position.y;
        meterpercentage = player.transform.position.y / 1000 * 100;
        if (length >= 0&&length<=1000)
        {
                meter.GetComponent<Text>().text = meterpercentage.ToString("F0") + "%";
        }
        if (length > 1000)
        {
            meter.GetComponent<Text>().text = "100%";
        }
	}
}
