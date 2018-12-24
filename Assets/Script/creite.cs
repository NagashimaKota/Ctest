using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creite : MonoBehaviour {

    public GameObject canvas2;
    private bool canvas_bool = false;

    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CanvasUP()
    {
        if (canvas_bool == false)
        {
            canvas2.SetActive(true);
            canvas_bool = true;
        }
        else
        {
            canvas2.SetActive(false);
            canvas_bool = false;
        }
    }
}
