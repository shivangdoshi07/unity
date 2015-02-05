using UnityEngine;
using System.Collections;

public class InspectorController : AlienController {

	public static string typeOfCoin;
	public GameObject ia;
	public GUIText speechBubble;
	// Update is called once per frame
	void Update () {
		if (GumballMachine.hasCoinEntered && GumballMachine.hasCrankTurned && typeOfCoin.Length > 1) {
			if(typeOfCoin == "FakeQuater"){
				speechBubble.text = "It's a Fake Coin!";
			}else if(typeOfCoin == "Penny"){
				speechBubble.text = "It's a Penny! Not Enough Money!";
			}else if(typeOfCoin == "Quater"){
				speechBubble.text = "Alright! You get a Gum!!";
				if(Random.Range(7,77) >= 41){
					RandomPickerController.askedToGive = true;
					GreenPickerController.askedToGive = false;
				}else{
					GreenPickerController.askedToGive = true;
					RandomPickerController.askedToGive = false;
				}
			}
			GumballMachine.hasCrankTurned = false;
			GumballMachine.hasCoinEntered = false;
			InspectorController.typeOfCoin = "";
		}
	}
}
