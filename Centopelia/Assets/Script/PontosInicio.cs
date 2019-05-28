using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PontosInicio : MonoBehaviour {

	public Text RecordeTXT;

	// Use this for initialization
	void Start () {

	
		RecordeTXT.text = PlayerPrefs.GetInt("Recorde").ToString ();

	}
	
	// Update is called once per frame
	void Update () {
	


	}
}
