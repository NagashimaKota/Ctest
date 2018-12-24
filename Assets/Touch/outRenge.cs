using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outRenge : MonoBehaviour {

    private Transform c1;    //操作する対象
    
    // Use this for initialization
    void Start () {
        c1 = this.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {

        //画面の最大値、最小値をワールド座標に変換したやつ
        Vector3 max = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector3 min = Camera.main.ScreenToWorldPoint(Vector3.zero);
        //操作対象をUIの座標へ変換
        Vector3 c1_worldPos = RectTransformUtility.WorldToScreenPoint(Camera.main, c1.position);

        //画面外へ出たかの判定
        if (c1_worldPos.x < 0)
        {
            c1.position = new Vector3(min.x + (c1.localScale.x / 2), c1.position.y, 0);
        }
        else if (c1_worldPos.x > Screen.width)
        {
            c1.position = new Vector3(max.x - (c1.localScale.x / 2), c1.position.y, 0);
        }
        else if (c1_worldPos.y < 0)
        {
            c1.position = new Vector3(c1.position.x, min.y + (c1.localScale.y / 2), 0);
        }
        else if (c1_worldPos.y > Screen.height)
        {
            c1.position = new Vector3(c1.position.x, max.y - (c1.localScale.y / 2), 0);
        }
    }
}
