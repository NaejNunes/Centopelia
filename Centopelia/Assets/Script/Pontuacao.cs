using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pontuacao : MonoBehaviour {

	public 	Text	 PontosTXT;
	public static int  Pontos;


	// Use this for initialization
	void Start () {

		Pontos = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
		PontosTXT.text = Pontos.ToString();

		if (Pontos > PlayerPrefs.GetInt ("Recorde")) {


			PlayerPrefs.SetInt ("Recorde", Pontos);

	}
		if (Pontos < 0) {

			Pontos = 0;

		}
}

}