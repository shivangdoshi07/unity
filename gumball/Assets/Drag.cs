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
		if(Input.GetMouseButton(0)){
			var ray = camera.ScreenPointToRay(Input.mousePosition);
			var hit  = Physics.Raycast(ray.origin,ray.direction, out rayHit);
			if(hit){
				collideObj = rayHit.collider.gameObject;
				distance = rayHit.distance;
//				Debug.Log (collideObj.name);
				if(collideObj.tag == "Coin"){
					posObj = ray.origin + distance*ray.direction;
					float moveHorizontal = -0.58f;
					float moveVertical = 1.0f;
					Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
					collideObj.rigidbody.AddForce (movement * 1000 * Time.deltaTime);
				}
			}
		}
	
	}
}
