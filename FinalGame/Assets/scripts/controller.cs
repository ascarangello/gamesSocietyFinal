using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    private Rigidbody2D rb;
    Animator animate;
    public GameObject floor;
    public GameObject duck;
    public float speed;
    public float jumpHeight;
    private Collider2D floorCollider;
    private Collider2D thisCollider;
    public bool touchingDuck;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        animate = gameObject.GetComponent<Animator>();
        floorCollider = floor.GetComponent<Collider2D>();
        thisCollider = this.GetComponent<Collider2D>();
	}

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime *speed;
        float y = 0;
       
            
        if(Input.GetKeyDown("space") && (thisCollider.IsTouching(floorCollider) || touchingDuck))  
        {

            rb.velocity = new Vector2(x, jumpHeight);
      
        }
        

        this.transform.rotation = new Quaternion(0, 0, 0, 1);

        if(x != 0)
        {
            animate.SetBool("isWalking", true);
        }
        else
        {
            animate.SetBool("isWalking", false);
        }

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Duck")
        {
            touchingDuck = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Duck")
        {
            touchingDuck = false;
        }

    }
}
