using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touch : MonoBehaviour {

    private Text debug1, debug2;  //デバッグ用
    private Transform c1, c2;    //操作する対象
    private float speed = 2;     //操作対象の動くスピード

    // Use this for initialization
    void Start () {
        debug1 = GameObject.Find("Text").GetComponent<Text>();   //デバッグ用
        debug2 = GameObject.Find("Text2").GetComponent<Text>();  //デバッグ用

        c1 = GameObject.Find("Cube").GetComponent<Transform>();   //操作する対象１
        c2 = GameObject.Find("Cube1").GetComponent<Transform>();  //操作する対象２
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.touchCount > 0)
        {
            foreach (Touch t in Input.touches)
            {
                //操作対象１・２のドラッグに対する移動量
                float x1 = 0;
                float x2 = 0;
                float y1 = 0;
                float y2 = 0;

                //画面の最大値をワールド座標に変換したやつ
                Vector3 max = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
                Vector3 min = Camera.main.ScreenToWorldPoint(Vector3.zero);

                //操作対象をUIの座標へ変換
                Vector3 c1_worldPos = RectTransformUtility.WorldToScreenPoint(Camera.main, c1.position);
                Vector3 c2_worldPos = RectTransformUtility.WorldToScreenPoint(Camera.main, c2.position);


                /*デバッグ用
                if (t.phase == TouchPhase.Began)
                {
                    debug1.text = "fid=" + t.fingerId + " x=" + t.position.x + " y=" + t.position.y;
                }
                */

                //１回目のタッチの時の操作
                if (t.phase == TouchPhase.Moved && t.fingerId == 0)
                {
                    //タッチした場所で操作する対象を変える（ PL1 or PL2 ）
                    if (t.position.x <= Screen.width / 2)
                    {
                        x1 = t.deltaPosition.x / Screen.width * speed;
                        y1 = t.deltaPosition.y / Screen.height * speed;
                        c1.position = new Vector3(c1.position.x + x1, c1.position.y + y1, 0);
                        /*画面外へ出たかの判定
                        if (c1_worldPos.x < 0)
                        {
                            c1.position = new Vector3(min.x + (c1.localScale.x / 2), c1.position.y + y1, 0);
                        }
                        else if (c1_worldPos.x > Screen.width)
                        {
                            c1.position = new Vector3(max.x - (c1.localScale.x / 2), c1.position.y + y1, 0);
                        }
                        else if (c1_worldPos.y < 0)
                        {
                            c1.position = new Vector3(c1.position.x + x1, min.y + (c1.localScale.y / 2), 0);
                        }
                        else if (c1_worldPos.y > Screen.height)
                        {
                            c1.position = new Vector3(c1.position.x + x1, max.y - (c1.localScale.y / 2), 0);
                        }
                        else
                        {
                            
                        }
                        */
                        //debug2.text = "fid=" + t.fingerId + " x=" + t.position.x + " y=" + t.position.y;
                        //debug2.text = c1_worldPos.ToString();
                    }
                    else
                    {
                        x2 = t.deltaPosition.x / Screen.width * speed;
                        y2 = t.deltaPosition.y / Screen.height * speed;
                        c2.position = new Vector3(c2.position.x + x2, c2.position.y + y2, 0);
                        /*画面外へ出たかの判定
                        if (c2_worldPos.x < 0)
                        {
                            c2.position = new Vector3(min.x + (c2.localScale.x / 2), c2.position.y + y1, 0);
                        }
                        else if (c2_worldPos.x > Screen.width)
                        {
                            c2.position = new Vector3(max.x - (c2.localScale.x / 2), c2.position.y + y1, 0);
                        }
                        else if (c2_worldPos.y < 0)
                        {
                            c2.position = new Vector3(c2.position.x + x1, min.y + (c2.localScale.y / 2), 0);
                        }
                        else if (c2_worldPos.y > Screen.height)
                        {
                            c2.position = new Vector3(c2.position.x + x2, max.y - (c2.localScale.y / 2), 0);
                        }
                        else
                        {
                            
                        }
                        */

                    }


                }

                //２回目のタッチの時の操作
                if (t.phase == TouchPhase.Moved && t.fingerId == 1)
                {
                    //タッチした場所で操作する対象を変える（ PL1 or PL2 ）
                    if (t.position.x <= Screen.width / 2)
                    {
                        x1 = t.deltaPosition.x / Screen.width * speed;
                        y1 = t.deltaPosition.y / Screen.height * speed;
                        c1.position = new Vector3(c1.position.x + x1, c1.position.y + y1, 0);

                        /*画面外へ出たかの判定
                        if (c1_worldPos.x < 0)
                        {
                            c1.position = new Vector3(min.x + (c1.localScale.x / 2), c1.position.y + y1, 0);
                        }
                        else if (c1_worldPos.x > Screen.width)
                        {
                            c1.position = new Vector3(max.x - (c1.localScale.x / 2), c1.position.y + y1, 0);
                        }
                        else if (c1_worldPos.y < 0)
                        {
                            c1.position = new Vector3(c1.position.x + x1, min.y + (c1.localScale.y / 2), 0);
                        }
                        else if (c1_worldPos.y > Screen.height)
                        {
                            c1.position = new Vector3(c1.position.x + x1, max.y - (c1.localScale.y / 2), 0);
                        }
                        else
                        {
                            
                        }
                        */

                    }
                    else
                    {
                        x2 = t.deltaPosition.x / Screen.width * speed;
                        y2 = t.deltaPosition.y / Screen.height * speed;
                        c2.position = new Vector3(c2.position.x + x2, c2.position.y + y2, 0);

                        /*画面外へ出たかの判定
                        if (c2_worldPos.x < 0)
                        {
                            c2.position = new Vector3(min.x + (c2.localScale.x / 2), c2.position.y + y1, 0);
                        }
                        else if (c2_worldPos.x > Screen.width)
                        {
                            c2.position = new Vector3(max.x - (c2.localScale.x / 2), c2.position.y + y1, 0);
                        }
                        else if (c2_worldPos.y < 0)
                        {
                            c2.position = new Vector3(c2.position.x + x1, min.y + (c2.localScale.y / 2), 0);
                        }
                        else if (c2_worldPos.y > Screen.height)
                        {
                            c2.position = new Vector3(c2.position.x + x2, max.y - (c2.localScale.y / 2), 0);
                        }
                        else
                        {
                            
                        }
                        */

                    }


                }
            }
            
        }
	}
}
