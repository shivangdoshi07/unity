using UnityEngine;
using System.Collections;

public class CollectibleController : MonoBehaviour {
	public JCar car;
	void OnTriggerEnter(Collider other){
		if (this.gameObject.name == "Capsule") {
			car.changeHealth (15);
		}
		if (this.gameObject.name == "Nitro") {
			car.enableNitrousBoost(true);
		}
		if (this.gameObject.name == "GodMode") {
			car.enableGodM(true);
		}

		Destroy (this.gameObject);
	}

}
