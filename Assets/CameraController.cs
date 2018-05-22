using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector3 offset;
    public GameObject target;
    public bool b;

	// Use this for initialization
	void Start () {
        offset = target.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = target.transform.position - offset;
        //Input.GetButton("if(");
        if(Input.GetKeyDown("c"))
        {
            if (b)
                b = false;
            else
                b = true;
                    
        }
        

        if(b)
            transform.position = target.transform.position - offset;
        else
            transform.position = target.transform.position;

    }
}
