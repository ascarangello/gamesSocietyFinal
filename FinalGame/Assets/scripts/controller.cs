using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    private Rigidbody2D rb;
    public GameObject floor;
    public float speed;
    public float jumpHeight;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime *speed;
        float y = 0;
       
            
        if(Input.GetKeyDown("space") && Mathf.Abs(rb.position.y - floor.transform.position.y) < .5) 
        {

            rb.velocity = new Vector2(x, jumpHeight);
      
        }

        this.transform.rotation = new Quaternion(0, 0, 0, 1);

        if (x < 0)
        {
            transform.Translate(x, y, 0);
            transform.Rotate(0, 180, 0);
        }
        
        else
        {
            transform.Translate(x, y, 0);
        }
	}
}
