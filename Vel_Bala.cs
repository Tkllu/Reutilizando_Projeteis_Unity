using UnityEngine;
using System.Collections;

public class Vel_Bala : MonoBehaviour {

	public int vel_tiro;

	void Start (){

	}

	void Update () {
		
		transform.Translate (0,0, vel_tiro * Time.deltaTime);

		if (transform.position.x > 40) {
			Destruir ();
		}
	}

	void OnTriggerEnter(Collider outro){

		if(outro.CompareTag("Meteoro")){
			Destruir ();
		}
		if(outro.CompareTag("Inimigo")){
			Destruir ();
		}
	}

	void Destruir(){

		gameObject.SetActive (false);

	}

	}
