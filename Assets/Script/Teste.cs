using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Teste : MonoBehaviour {
	public Transform lock_position;
	private Vector2 vector_lock;
	private Vector3 vector_ini;
	public ControllerLevelLocal controllerLevelLocal;
	void Start(){
		vector_lock = lock_position.position;
		vector_ini = transform.position;
	}
	public void SeguirCursor(){
		transform.position = (Vector2)(Camera.main.ScreenToWorldPoint (Input.mousePosition));
	}
	private void OnDisable(){
		transform.position = vector_ini;
		GetComponent<Button> ().interactable = true;
	}
	public void OnDeselect(){
		UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject (null);
		float distance = Vector2.Distance (transform.position, vector_lock);
		if (distance <= 1f) {
			GetComponent<Button> ().interactable = false;
			transform.position = vector_lock;
			controllerLevelLocal.Encaixou ();
		} else {
			transform.position = vector_ini;
		}
	}
}
