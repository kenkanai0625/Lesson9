using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;

    public float defaultWidth = 10.0f;
    public float defaultHeight = 16.0f;

    // Use this for initialization
    void Start () {
        //camera.mainを変数に格納
        Camera mainCamera = Camera.main;
        //最初に作った画面のアスペクト比 
        float defaultAspect = defaultWidth / defaultHeight;
        //実際の画面のアスペクト比
        float actualAspect = (float)Screen.width / (float)Screen.height;
        //実機とunity画面の比率
        float ratio = actualAspect / defaultAspect;
        //サイズ調整
        mainCamera.orthographicSize /= ratio;
    }

    // Update is called once per frame
    void Update () {
       if (player.transform.position.y >= 0)
            {
                if (this.transform.position.y >= 1000)
                {
                    this.transform.position = new Vector3(this.transform.position.x, 1000, -30);
                }
                else
                {
                    this.transform.position = new Vector3(this.transform.position.x, 3 + player.transform.position.y, -30);
                }
            }
	}
}
