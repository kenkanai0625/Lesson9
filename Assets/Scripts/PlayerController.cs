using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rigidbody2D;
    public GameObject cleartext;
    public GameObject gameovertext;
    public GameObject onemorebutton;
    private float rocketspeed = 5.0f;
    private float posy;
    public static bool gameover = false;
   
    // Use this for initialization
    void Start () {
        this.rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (gameover == false)
        {
            this.transform.Translate(0,rocketspeed * Time.deltaTime, 0);
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
            this.transform.position = new Vector3(this.transform.position.x, posy);
        }
           

        if (Input.GetKey(KeyCode.LeftArrow)&&this.transform.position.x>-2.8&&this.transform.position.y<1000&&gameover==false)
        {
            this.transform.Translate(-rocketspeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x <2.8 && this.transform.position.y < 1000&&gameover==false)
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
