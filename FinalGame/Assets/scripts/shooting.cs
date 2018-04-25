using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shooting : MonoBehaviour {
    Animator animate;
    public GameObject bullet;
    public Vector2 vel;
    public bool canShoot = true;
    public Vector2 offset = new Vector2(0.4f, 0.1f);
    public float cooldown = 1f;
    public int ammo;

	// Use this for initialization
	void Start () {
        animate = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if(ammo == 0)
        {
            canShoot = false;
        }

        if(Input.GetKeyDown(KeyCode.Z) && canShoot && ammo > 0 && SceneManager.GetActiveScene().buildIndex == 0) 
        {
            cooldown = 1.25f;  
			soundsplease.PlaySound ("HUnting Rifle");
            animate.SetTrigger("isShooting");
            Vector2 bullVector = new Vector2(transform.position.x + offset.x * transform.localScale.x, transform.position.y + offset.y);
                GameObject go = Instantiate(bullet, bullVector,
                     Quaternion.identity);

                go.GetComponent<Rigidbody2D>().velocity = new Vector2(vel.x * transform.localScale.x, vel.y);
                StartCoroutine(CanShoot());
            ammo--;
           

        }

        if (Input.GetKey(KeyCode.Z) && canShoot && ammo > 0 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            cooldown = 0f;
            soundsplease.PlaySound("HUnting Rifle");
            animate.SetTrigger("isShooting");
            Vector2 bullVector = new Vector2(transform.position.x + offset.x * transform.localScale.x, transform.position.y + offset.y);
            GameObject go = Instantiate(bullet, bullVector,
                 Quaternion.identity);

            go.GetComponent<Rigidbody2D>().velocity = new Vector2(vel.x * transform.localScale.x, vel.y);
            StartCoroutine(CanShoot());
            ammo--;


        }





    }



    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(cooldown);
        if (ammo > 0 && !youWin.isWin)
        {
            canShoot = true;
        }
    }
}
