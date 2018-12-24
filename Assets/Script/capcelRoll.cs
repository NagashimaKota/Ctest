using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capcelRoll : MonoBehaviour {

    public GameObject boll;

    private Vector2 touchPos = Vector2.zero;
    private float theta = 0;
    private float power = 500;
    private Transform cylinder;
    private Vector3 force = new Vector3(1,1,0);

    // Use this for initialization
    void Start () {
        cylinder = GameObject.Find("Cylinder").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Roll(Input.GetTouch(0).position);
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Canceled)
        {

        }
        if (Input.GetMouseButton(0))
        {
            Roll(Input.mousePosition);
        }
	}

    void Roll(Vector2 pos)
    {
        Vector2 selfScreenPos = Camera.main.WorldToScreenPoint(cylinder.position);
        touchPos = selfScreenPos - pos;
        theta = Mathf.Atan2(touchPos.y, touchPos.x)*Mathf.Rad2Deg - 90f;
        cylinder.transform.eulerAngles = new Vector3(0, 0,theta);
    }

    public void TouchUp()
    {
        GameObject ins;
        ins = GameObject.Instantiate(boll) as GameObject;
        ins.transform.position = cylinder.position;
        force.x = Mathf.Cos((theta+90) * Mathf.Deg2Rad) * power;
        force.y = Mathf.Sin((theta+90) * Mathf.Deg2Rad) * power;

        ins.GetComponent<Rigidbody>().AddForce(force);
    }
}
