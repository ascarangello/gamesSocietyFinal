using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thequackingplease : MonoBehaviour {

	private Random randomQuack;
	private AudioSource quack;
	//Play the music
	bool Play;
	//Detect when you use the toggle, ensures music isn’t played multiple times
	bool ToggleChange;


	// Use this for initialization
	void Start () {
		quack = GetComponent<AudioSource>();
		Play = true;
		ToggleChange = true;
	}

	// Update is called once per frame
	void Update () {
		//Check to see if you just set the toggle to positive
		if (Play == true && ToggleChange == true)
		{
			//Play the audio you attach to the AudioSource component
			quack.Play();
			//Ensure audio doesn’t play more than once
			ToggleChange = false;
		}
		//Check if you just set the toggle to false
		if (Play == true && ToggleChange == false)
		{
			//Stop the audio
			quack.Stop();
			//Ensure audio doesn’t play more than once
			ToggleChange = true;
		}
	}
}
