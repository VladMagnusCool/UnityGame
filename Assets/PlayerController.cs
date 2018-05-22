using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public Text ScoreText;
    private int Score;
	// Use this for initialization
	void Start ()
    {
        Score = 0;
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(h, 0, v);
        rb.AddForce(dir);
        Vector3 r = new Vector3(0, 0, 0);

        if(Input.GetKey("m"))
        {
            //rb.drag = 0.5f;
            //rb.drag = 0.0f;
            rb.velocity = r;
        }
        else
        {
            //rb.drag = 0.0f;rb.velocity = 0;
        }
        ScoreText.text = Score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            Score++;
        }
    }

}