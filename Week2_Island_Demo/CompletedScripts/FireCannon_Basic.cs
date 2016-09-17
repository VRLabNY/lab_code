using UnityEngine;
using System.Collections;

public class FireCannon_Basic : MonoBehaviour {

	public Rigidbody cannonballGO;
	public Transform cannonExit;
	public float launchForce;

	private float randomCannonPower;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
		if(Input.GetKeyDown("tab")){

			Fire();


		}

	}

	void Fire(){


		//For Launching Cannonballs
		Rigidbody cannonballInstance = Instantiate (cannonballGO, cannonExit.position, cannonExit.rotation) as Rigidbody;

		randomCannonPower = Random.Range(0.5f, 1.5f);

		cannonballInstance.velocity = launchForce * cannonExit.forward * randomCannonPower;




	}






}
