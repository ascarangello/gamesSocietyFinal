using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHit : MonoBehaviour {
    public GameObject bullet;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "bullet 1(Clone)")
        {
            soundsplease.PlaySound ("angry duck death");
            GameObject.Destroy(gameObject);
            killCounter.start += 1;
            
        }
    }
}
