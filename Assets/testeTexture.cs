using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeTexture : MonoBehaviour {

	public Texture2D textura;
	public Color coor;
	void Start () {
		/*for (int largura = 0; largura < textura.width; largura++) {
			for(int cont2 =0; cont2<textura.height; cont2++){
				textura.SetPixel (largura, 640, Color.green);

			}
				
		}
		textura.Apply ();*/
		int cont = 0;
		Color cor;
		for (int largura = 0; largura < textura.width; largura++) {
			for(int altura =0; altura<textura.height; altura++){
				cor = textura.GetPixel (largura, altura);
				if (cor.r>0.5&&cor.b<0.2&&cor.g<0.2){
					textura.SetPixel (largura, altura, Color.green);
					cont++;
				}

			}

		}
		textura.Apply();
		float porcent = (cont * 100) / (textura.width * textura.height);
		print (porcent);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
