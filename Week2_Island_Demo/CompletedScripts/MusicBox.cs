using UnityEngine;
using System.Collections;

public class MusicBox : MonoBehaviour {

	public AudioSource partyMusic;

	// Use this for initialization
	void Start () {
	
		partyMusic = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		
		partyMusic.Play();
	}

	void OnTriggerExit (Collider other){
		partyMusic.Pause();
	}
}
