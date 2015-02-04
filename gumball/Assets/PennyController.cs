using UnityEngine;
using System.Collections;

public class PennyController : CoinController {
	
	void OnTriggerEnter(Collider other) {
		base.onEnteringGumball(other);
	}
}