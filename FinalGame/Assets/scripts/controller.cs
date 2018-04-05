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
       
            
        if(Input.GetKeyDown("space") && Mathf.Abs(rb.position.y - floor.transform.position.y) < 1.1) 
        {

            rb.velocity = new Vector2(x, jumpHeight);
      
        }

        this.transform.rotation = new Quaternion(0, 0, 0, 1);

        transform.Translate(x, y, 0);

        if(Input.GetKeyDown("left") && this.transform.localScale.x > 0)
        {
            this.Flip();
        }

        if (Input.GetKeyDown("right") && this.transform.localScale.x < 0)
        {
            this.Flip();
        }

    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
