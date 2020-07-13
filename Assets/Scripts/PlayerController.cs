using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rigidbody2D;
    public GameObject cleartext;
    public GameObject gameovertext;
    public GameObject onemorebutton;
    public GameObject countdowntext;
    public GameObject starttext;
    private float rocketspeed = 5.0f;
    private float posy;
    public static bool gameover;
    public static bool countdownbool;
    private float countdown = 3.0f;
    public static bool onemorebool;
    public static bool startbool;
   
    // Use this for initialization
    void Start () {
        this.rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (startbool == false)
        {
            starttext.SetActive(true);
            if (Input.GetMouseButton(0))
            {
                Destroy(starttext);
                startbool = true;
            }
        }

        if (onemorebool == false&&startbool==true)
        {
            countdown -= Time.deltaTime;
            if (countdown > 2 && countdown <= 3)
            {
                countdowntext.GetComponent<Text>().text = "3";
            }
            if (countdown > 1 && countdown <= 2)
            {
                countdowntext.GetComponent<Text>().text = "2";
            }
            if (countdown > 0 && countdown <= 1)
            {
                countdowntext.GetComponent<Text>().text = "1";
            }
            if (countdown <= 0)
            {
                Destroy(countdowntext);
                countdownbool = true;
            }
        }

        if (gameover == false && countdownbool == true)
        {
            this.transform.Translate(0,rocketspeed * Time.deltaTime, 0);
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
            this.transform.position = new Vector3(this.transform.position.x, posy);
        }
           
        foreach(var touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2 && this.transform.position.x > -2.8 && this.transform.position.y < 1000 && gameover == false && countdownbool == true)
                    {
                        this.transform.Translate(-rocketspeed * Time.deltaTime, 0, 0);
                    }
                    if (touch.position.x > Screen.width / 2 && this.transform.position.x <2.8 && this.transform.position.y < 1000 && gameover == false && countdownbool == true)
                    {
                        this.transform.Translate(rocketspeed * Time.deltaTime, 0, 0);
                    }
                        break;
                case TouchPhase.Stationary:
                    if (touch.position.x < Screen.width / 2 && this.transform.position.x > -2.8 && this.transform.position.y < 1000 && gameover == false && countdownbool == true)
                    {
                        this.transform.Translate(-rocketspeed * Time.deltaTime, 0, 0);
                    }
                    if (touch.position.x > Screen.width / 2 && this.transform.position.x <2.8 && this.transform.position.y < 1000 && gameover == false && countdownbool == true)
                    {
                        this.transform.Translate(rocketspeed * Time.deltaTime, 0, 0);
                    }
                    break;
                case TouchPhase.Moved:
                    if (touch.position.x < Screen.width / 2 && this.transform.position.x > -2.8 && this.transform.position.y < 1000 && gameover == false && countdownbool == true)
                    {
                        this.transform.Translate(-rocketspeed * Time.deltaTime, 0, 0);
                    }
                    if (touch.position.x > Screen.width / 2 && this.transform.position.x < 2.8 && this.transform.position.y < 1000 && gameover == false && countdownbool == true)
                    {
                        this.transform.Translate(rocketspeed * Time.deltaTime, 0, 0);
                    }
                    break;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x > -2.8 && this.transform.position.y < 1000 && gameover == false && countdownbool == true)
        {
            this.transform.Translate(-rocketspeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x < 2.8 && this.transform.position.y < 1000 && gameover == false && countdownbool == true)
        {
            this.transform.Translate(rocketspeed * Time.deltaTime, 0, 0);
        }

        if (this.transform.position.y <0)
        {
            rigidbody2D.velocity =Vector2.zero ;
            this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
        }
        if (this.transform.position.y >= 1000)
        {
            cleartext.GetComponent<Text>().text = "クリア";
            rigidbody2D.velocity = Vector2.zero;
            this.transform.position = new Vector3(this.transform.position.x, 1000, this.transform.position.z);
            onemorebutton.SetActive(true);
        }
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameovertext.GetComponent<Text>().text = "ゲームオーバー";
        gameover = true;
        posy = this.transform.position.y;
        onemorebutton.SetActive(true);
    }
}
