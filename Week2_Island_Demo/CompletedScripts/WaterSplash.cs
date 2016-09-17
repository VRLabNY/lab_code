using UnityEngine;
using System.Collections;

public class WaterSplash : MonoBehaviour {


	public AudioSource splashSFX;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		splashSFX = GetComponent<AudioSource>();
		splashSFX.Play();
		Destroy(other);  //This line will destroy the other object upon collision

	}
}
