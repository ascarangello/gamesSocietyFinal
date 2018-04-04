using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    public Rigidbody2D rb;
    public GameObject floor;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
        float y = 0;
       
            
        if(Input.GetKeyDown("space") && Mathf.Abs(rb.position.y - floor.transform.position.y) < .5) 
        {

            rb.velocity = new Vector2(x, 10);
      
        }

        this.transform.rotation = new Quaternion(0, 0, 0, 1);

        transform.Translate(x, y, 0);
	}
}
