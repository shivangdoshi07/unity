using UnityEngine;
using System.Collections;

public class GreenPickerController : PickerController {
	public GameObject gpa;
	public static bool askedToGive = false;
	// Update is called once per frame
	void FixedUpdate () {
		if (askedToGive) {
			askedToGive = false;
			base.createAGum(gpa,Color.green);
		}
	}
}
