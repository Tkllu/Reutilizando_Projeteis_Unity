using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Novo_Objeto_Bala : MonoBehaviour {

	public static Novo_Objeto_Bala acessar_Bala;
	public GameObject bala;
	public int quant_max_bala;
	public List<GameObject> list_Bala;
	public int i = 0;
	void Awake(){
		acessar_Bala = this;
	}

	void Start () {
		
		list_Bala = new List<GameObject> ();
		for(int i = 0; i < quant_max_bala; i++){

			GameObject obj = (GameObject)Instantiate (bala);
			obj.SetActive (false);
			list_Bala.Add (obj);
		}

	}

	public GameObject RetornaObj(){

		if (i < quant_max_bala) {

			if (!list_Bala [i].activeInHierarchy) {
				return list_Bala [i];
			}
			i = i + 1;
		} else {
			i = 0;
		}

		return null;
	}

}
