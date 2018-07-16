using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLevelGlobal : MonoBehaviour {
	private int nivelAtual=0;
	public GameObject[] fases;
	public GameObject incentivo;
	public void PassouDeNivel(){
		incentivo.SetActive (true);
	}
	public void MudarFase(){
		nivelAtual++;
		if (nivelAtual == fases.Length) {
			nivelAtual = 0;
		}
		for (int cont = 0; cont < fases.Length; cont++) {
			fases [cont].SetActive (false);
		}
		fases [nivelAtual].SetActive (true);
		incentivo.SetActive (false);
	}
}
