using UnityEngine;
using System.Collections;

public class GumballMachine : ScriptableObject {
	public static bool hasCoinEntered;
	public static string nameOfCoin;
	void Update(){
		if (hasCoinEntered) {
			Debug.Log(nameOfCoin);
		}
	}
}
