using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
    Animator animate;
    public GameObject bullet;
    public Vector2 vel;
    bool canShoot = true;
    public Vector2 offset = new Vector2(0.4f, 0.1f);
    public float cooldown = 1f;

	// Use this for initialization
	void Start () {
        animate = gameObject.GetComponent<Animator>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Z) && canShoot)
        {
            animate.SetTrigger("isShooting");
            Vector2 bullVector = new Vector2(transform.position.x + offset.x * transform.localScale.x, transform.position.y + offset.y);
                GameObject go = Instantiate(bullet, bullVector,
                     Quaternion.identity);

                go.GetComponent<Rigidbody2D>().velocity = new Vector2(vel.x * transform.localScale.x, vel.y);
                StartCoroutine(CanShoot());
            

        }
        



    }



    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    
    }
}
