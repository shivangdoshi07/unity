using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {
	private RaycastHit rayHit;
	private GameObject collideObj;
	private float distance;
	private Vector3 posObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			var ray = camera.ScreenPointToRay(Input.mousePosition);
			var hit  = Physics.Raycast(ray.origin,ray.direction, out rayHit);
			if(hit){
				collideObj = rayHit.collider.gameObject;
				if(collideObj.tag == "Coin"){
					Vector3 movement = new Vector3 (-0.58f,0.0f,1.0f);
					collideObj.rigidbody.AddForce (movement * 3000 * Time.deltaTime);
				}
				if(collideObj.tag == "GumballMachine"){
					GumballMachine.hasCrankTurned = true;
				}
			}
		}
	
	}
}
