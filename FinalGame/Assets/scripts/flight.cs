using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flight : MonoBehaviour {
    public float maxX;
    public float minX;
    public float minY;
    public float maxY;
    private float tChange;
    public float speed;
    private float randomX;
    private float randomY;

    private BoxCollider2D bc;

	// Use this for initialization
	void Start () {
        bc = this.GetComponent<BoxCollider2D>();
        bc.size = new Vector2(.5f, .5f);
        bc.offset = new Vector2(.006f, .15f);
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= tChange)
        {
			randomX = Random.Range(-2.0f, 2.0f); // with float parameters, a random float
            randomY = Random.Range(-2.0f, 2.0f); //  between -2.0 and 2.0 is returned
                                               // set a random interval between 0.5 and 1.5
            tChange = Time.time + Random.Range(0.5f, 1.5f);
        }
        transform.Translate(new Vector3(randomX, randomY, 0) * speed * Time.deltaTime);

        if (transform.position.x >= maxX || transform.position.x <= minX)
        {
            randomX = -randomX;
        }
        if (transform.position.y >= maxY || transform.position.y <= minY)
        {
			soundsplease.PlaySound ("duck Quack 1");
            randomY = -randomY;
        }


        Vector2 pos = transform.position;
        // make sure the position is inside the borders
        pos.x = Mathf.Clamp(transform.position.x, minX, maxX);
        pos.y = Mathf.Clamp(transform.position.y, minY, maxY);
    }
}

