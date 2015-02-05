using UnityEngine;
using System.Collections;

public class GumballMachine : ScriptableObject {
	public static bool hasCoinEntered;
	public static bool hasCrankTurned;
	public GUIText speechBubble;
	public static string nameOfCoin;
	void Update(){
		if (hasCoinEntered) {
			speechBubble.text = "Has Coin!";
			if(hasCrankTurned){
				speechBubble.text = "Crank Turned!";
				InspectorController.typeOfCoin = nameOfCoin;
			}
		}
	}
}
