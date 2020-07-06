using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {
    public GameObject player;

    public GameObject bird;
    public GameObject birdx;
    public GameObject baloon;
    public GameObject fire;
    public GameObject boom;
    public GameObject airplane;
    public GameObject reverseAirplane;
    public GameObject crowd;
    public GameObject obstaclerocket;
    public GameObject obstaclerocketR;
    public GameObject obstaclerocketL;
    public GameObject satellite;
    public GameObject reversesatellite;
    public GameObject ufo;
    public GameObject asteroid;
    public GameObject meteo;
    
    private bool firebool=false;
    private bool boombool = false;
    private bool asteroidbool = false;
    private float birdlastpos;
    private float ballonlastpos=94.0f;
    private float airplanelastpos = 191.0f;
    private float crowdlastpos = 292.0f;
    private float rocketlastpos = 396.5f;
    private float satellitelastpos=485.0f;
    private float ufolastpos = 595.0f;
    private float asteroidlastpos = 695.0f;
    private float meteolastpos = 792.5f;

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y >= 1000&&firebool==false)
        {
            GameObject go = Instantiate(fire) as GameObject;
            go.transform.position = new Vector3(player.transform.position.x, player.transform.position.y);
            firebool = true;
        }
        if (PlayerController.gameover == true&&boombool==false)
        {
            GameObject go = Instantiate(boom) as GameObject;
            go.transform.position = new Vector3(player.transform.position.x, player.transform.position.y);
            boombool = true;
        }

        if (player.transform.position.y <= 91)
        {
            if (player.transform.position.y - birdlastpos >= 5)
            {
                int i = Random.Range(0, 2);
                if (i == 0)
                {
                    GameObject go = Instantiate(bird) as GameObject;
                    go.transform.position = new Vector3(-5, player.transform.position.y + 9, 0);
                }
                else
                {
                    GameObject og = Instantiate(birdx) as GameObject;
                    og.transform.position = new Vector3(5, player.transform.position.y + 9, 0);
                }
                birdlastpos += 5;
            }
        }

        if (player.transform.position.y >= 100 && player.transform.position.y <= 191)
        {
            if (player.transform.position.y - ballonlastpos >= 6)
            {
                int i = Random.Range(0, 2);
                if (i == 0){
                    GameObject go = Instantiate(baloon) as GameObject;
                    go.transform.position = new Vector3(-1.35f, player.transform.position.y + 10, 0);
                }
                else
                {
                    GameObject go = Instantiate(baloon) as GameObject;
                    go.transform.position = new Vector3(1.35f, player.transform.position.y + 10, 0);
                }
                ballonlastpos += 6;
            }
        }

        if (player.transform.position.y >= 200 && player.transform.position.y <= 290)
        {
            if (player.transform.position.y - airplanelastpos >= 9)
            {
                int i = Random.Range(0, 2);
                if (i == 0)
                {
                    GameObject go = Instantiate(airplane) as GameObject;
                    go.transform.position = new Vector3(5, player.transform.position.y + 10, 0);
                }
                else
                {
                    GameObject og = Instantiate(reverseAirplane) as GameObject;
                    og.transform.position = new Vector3(-5, player.transform.position.y + 10, 0);
                }
                airplanelastpos += 9;
            }
        }

        if (player.transform.position.y >= 300 && player.transform.position.y <= 390)
        {
            if (player.transform.position.y - crowdlastpos >= 8.0)
            {
                int i = Random.Range(0, 2);
                if (i == 0)
                {
                    GameObject go = Instantiate(crowd) as GameObject;
                    go.transform.position = new Vector3(4.3f, player.transform.position.y + 12, 0);
                    GameObject og = Instantiate(crowd) as GameObject;
                    og.transform.position = new Vector3(-6.7f, player.transform.position.y + 12, 0);
                }
                else
                {
                    GameObject go = Instantiate(crowd) as GameObject;
                    go.transform.position = new Vector3(-4.3f, player.transform.position.y + 12, 0);
                    GameObject og = Instantiate(crowd) as GameObject;
                    og.transform.position = new Vector3(6.7f, player.transform.position.y + 12, 0);
                }
                crowdlastpos += 8.0f;
            }
        }

        if (player.transform.position.y >= 400 && player.transform.position.y <= 495)
        {
            if (player.transform.position.y - rocketlastpos >= 3.5)
            {
                int i = Random.Range(0, 3);
                if (i == 0)
                {
                    int j = Random.Range(0, 3);
                    if (j == 0)
                    {
                        GameObject go = Instantiate(obstaclerocket) as GameObject;
                        go.transform.position = new Vector3(0, player.transform.position.y + 10, 0);
                    }
                    else if(j==1)
                    {
                        GameObject go = Instantiate(obstaclerocket) as GameObject;
                        go.transform.position = new Vector3(-1.5f, player.transform.position.y + 10, 0);
                    }
                    else
                    {
                        GameObject go = Instantiate(obstaclerocket) as GameObject;
                        go.transform.position = new Vector3(1.5f, player.transform.position.y + 10, 0);
                    }
                }
                else if(i==1)
                {
                    GameObject og = Instantiate(obstaclerocketL) as GameObject;
                    og.transform.position = new Vector3(-5, player.transform.position.y + 11, 0);
                }
                else
                {
                    GameObject og = Instantiate(obstaclerocketR) as GameObject;
                    og.transform.position = new Vector3(5, player.transform.position.y + 11, 0);
                }
                rocketlastpos += 3.0f;
            }
        }

        if (player.transform.position.y >= 500 && player.transform.position.y <= 580)
        {
            if (player.transform.position.y - satellitelastpos >= 15)
            {
                int i = Random.Range(0, 2);
                if (i == 0)
                {
                    GameObject go = Instantiate(satellite) as GameObject;
                    go.transform.position = new Vector3(10, player.transform.position.y - 5, 0);
                }
                else
                {
                    GameObject og = Instantiate(reversesatellite) as GameObject;
                    og.transform.position = new Vector3(-10, player.transform.position.y - 5, 0);
                }
                satellitelastpos += 15;
            }
        }

        if (player.transform.position.y >= 600 && player.transform.position.y <= 690)
        {
            if (player.transform.position.y - ufolastpos >= 5)
            {
                int i = Random.Range(0, 3);
                if (i == 0)
                {
                    GameObject go = Instantiate(ufo) as GameObject;
                    go.transform.position = new Vector3(-2, player.transform.position.y + 10, 0);
                    GameObject og = Instantiate(ufo) as GameObject;
                    og.transform.position = new Vector3(0, player.transform.position.y + 10, 0);
                }
                else if(i==1)
                {
                    GameObject go = Instantiate(ufo) as GameObject;
                    go.transform.position = new Vector3(-2, player.transform.position.y + 10, 0);
                    GameObject og = Instantiate(ufo) as GameObject;
                    og.transform.position = new Vector3(2, player.transform.position.y + 10, 0);
                }
                else
                {
                    GameObject go = Instantiate(ufo) as GameObject;
                    go.transform.position = new Vector3(0, player.transform.position.y + 10, 0);
                    GameObject og = Instantiate(ufo) as GameObject;
                    og.transform.position = new Vector3(2, player.transform.position.y + 10, 0);
                }
                ufolastpos += 5;
            }
        }

        if (player.transform.position.y >= 700 && player.transform.position.y <= 791)
        {
            if (player.transform.position.y - asteroidlastpos >= 5&&asteroidbool==false)
            {
                GameObject go = Instantiate(asteroid) as GameObject;
                go.transform.position = new Vector3(2, player.transform.position.y + 15, 0);
                asteroidbool = true;
                asteroidlastpos += 5.0f;
            }
            if (player.transform.position.y - asteroidlastpos >= 5 && asteroidbool == true)
            {
                GameObject go = Instantiate(asteroid) as GameObject;
                go.transform.position = new Vector3(-3.5f, player.transform.position.y + 15, 0);
                asteroidbool = false;
                asteroidlastpos += 5.0f;
            }
        }

        if (player.transform.position.y >= 800 && player.transform.position.y <= 891)
        {
            if (player.transform.position.y - meteolastpos >= 7.5)
            {
                int i = Random.Range(0, 3);
                if (i == 0)
                {
                    GameObject go = Instantiate(meteo) as GameObject;
                    go.transform.position = new Vector3(8, player.transform.position.y + 30, 0);
                    GameObject og = Instantiate(meteo) as GameObject;
                    og.transform.position = new Vector3(8, player.transform.position.y + 20, 0);
                }
                else if (i == 1)
                {
                    GameObject og = Instantiate(meteo) as GameObject;
                    og.transform.position = new Vector3(8, player.transform.position.y + 20, 0);
                    GameObject goo = Instantiate(meteo) as GameObject;
                    goo.transform.position = new Vector3(8, player.transform.position.y + 40, 0);
                }
                else
                {
                    GameObject goo = Instantiate(meteo) as GameObject;
                    goo.transform.position = new Vector3(8, player.transform.position.y + 40, 0);
                    GameObject go = Instantiate(meteo) as GameObject;
                    go.transform.position = new Vector3(8, player.transform.position.y + 30, 0);
                }
                meteolastpos += 7.5f;
            }
        }
    }
}
