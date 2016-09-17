using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {


	public AudioSource boing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		boing = GetComponent<AudioSource>();
		boing.Play();

		Destroy(gameObject, 0.5f);

	}
}
