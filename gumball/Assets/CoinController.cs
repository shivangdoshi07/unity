using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	public void onEnteringGumball(Collider other){
		if (other.gameObject.tag == "GumballMachine") {
			GumballMachine.nameOfCoin = this.gameObject.name;
			this.gameObject.SetActive(false);
			GumballMachine.hasCoinEntered =true;
		}
	}
}