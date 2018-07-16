using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLevelLocal : MonoBehaviour {
	public int quantEncaixesInicial;
	private int quantEncaixesAtual;
	void Start(){
		quantEncaixesAtual = quantEncaixesInicial;
	}
	public void Encaixou(){
		quantEncaixesAtual--;
		if (quantEncaixesAtual <= 0) {
			GameObject.Find ("Fases").GetComponent<ControllerLevelGlobal> ().PassouDeNivel ();
		}
	}
	private void OnDisable(){
		quantEncaixesAtual = quantEncaixesInicial;
	}

}
