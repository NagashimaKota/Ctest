using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMove : MonoBehaviour {

    private int n = 0;
    private Transform pl;
    private CameraMove cam;

    // Use this for initialization
	void Start () {
        pl = GameObject.Find("Cylinder").GetComponent<Transform>();
        cam = GameObject.Find("Main Camera").GetComponent<CameraMove>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground" && n > 3)
        {
            pl.transform.position = new Vector3(this.transform.position.x, pl.transform.position.y, pl.transform.position.z);
            Destroy(this.gameObject);
            cam.PositionCAM();

        }
        else if (col.gameObject.tag == "Ground")
        {
            n++;
        }
        
    }
}
