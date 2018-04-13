using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundsplease : MonoBehaviour {

	public static AudioClip duckQuack, angryQuack, bullet;
	static AudioSource audios;
	// Use this for initialization
	void Start () {
		duckQuack = Resources.Load<AudioClip> ("Quack Quack");
		angryQuack = Resources.Load<AudioClip> ("angry duck death");
		bullet = Resources.Load<AudioClip> ("HUnting Rifle");

		audios = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public static void PlaySound(string clip) {
		switch (clip) {
		case "Quack Quack":
			audios.PlayOneShot (duckQuack);
			break;
		case "angry duck death":
			audios.PlayOneShot (angryQuack);
			break;
		case "HUnting Rifle":
			audios.PlayOneShot (bullet);
			break;
		}
	}
}
