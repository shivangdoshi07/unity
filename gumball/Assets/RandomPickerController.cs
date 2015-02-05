using UnityEngine;
using System.Collections;

public class RandomPickerController : PickerController {
	public GameObject rpa;
	public static bool askedToGive = false;
	// Update is called once per frame
	void FixedUpdate () {
		if (askedToGive) {
			Color thingyColor=new Color(Random.value,Random.value,Random.value);
			askedToGive = false;
			base.createAGum(rpa,thingyColor);
		}
	}
}

