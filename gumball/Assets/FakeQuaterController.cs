using UnityEngine;
using System.Collections;

public class FakeQuaterController : CoinController {

	void OnTriggerEnter(Collider other) {
		base.onEnteringGumball(other);
	}

}
