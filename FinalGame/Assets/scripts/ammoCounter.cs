using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoCounter : MonoBehaviour {
    public GameObject player;
    private shooting behavior;
    public Text myText;
    private int ammo;
	// Use this for initialization
	void Start () {
        
        behavior = player.GetComponent<shooting>();
        ammo = player.GetComponent<shooting>().ammo;
        myText.text = "Ammo: " + ammo.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        ammo = player.GetComponent<shooting>().ammo;
        myText.text = "Ammo: " + ammo.ToString();
	}
}
