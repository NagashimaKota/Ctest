using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private Vector3 cylinder;
    private float xPos = -13;

    // Use this for initialization
	void Start () {
        cylinder = GameObject.Find("Cylinder").GetComponent<Transform>().position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PositionCAM()
    {
        cylinder = GameObject.Find("Cylinder").GetComponent<Transform>().position;
        this.transform.position = new Vector3(cylinder.x, this.transform.position.y, this.transform.position.z);
    }
}
