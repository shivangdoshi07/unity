using UnityEngine;
using System.Collections;

public class PickerController : AlienController {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void createAGum(GameObject gobj, Color clr){

		GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere.renderer.material.color = clr;
		sphere.transform.position = new Vector3(gobj.transform.position.x, 1.5F, gobj.transform.position.z );
		Rigidbody sphereRigidBody = sphere.AddComponent<Rigidbody>(); // Add the rigidbody.

		Vector3 movement = new Vector3 (1.0f,1.5f,1.0f);
		sphereRigidBody.AddForce (movement * 5000 * Time.deltaTime);
	}
}
