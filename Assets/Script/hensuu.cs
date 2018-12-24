using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hensuu : MonoBehaviour {

    public InputField inputField;
    public GameObject[] hensu;

    private string str;
    private int i = 0;
    private Text text;
    private List<GameObject> myList = new List<GameObject>();
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void MS()
    {
        str = inputField.text;
        inputField.text = "";
        myList.Add(Instantiate(hensu[0]));
        myList[i].transform.Find("GameObject").GetComponent<TextMesh>().text = str;
        i++;
    }
}
