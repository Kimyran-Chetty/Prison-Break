using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text textArea_text;

	// Use this for initialization
	void Start () {
		textArea_text.text = "Hello World";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			textArea_text.text = "space key pressed";
		}
	}
}
