using UnityEngine;
using System.Collections;

public class QuaterController : CoinController {
	
	void OnTriggerEnter(Collider other) {
		base.onEnteringGumball(other);
	}
}