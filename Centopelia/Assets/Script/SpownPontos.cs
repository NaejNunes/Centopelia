using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpownPontos : MonoBehaviour {

	public Text PontosFinaisTXT;
	public GameObject NovoRecorde, PontosAtuais;
	public Transform Spawn;
	public AudioClip Recorde;
	// Use this for initialization
	void Start () {

		PontosFinaisTXT.text = Pontuacao.Pontos.ToString ();
	
		if (Pontuacao.Pontos < PlayerPrefs.GetInt ("Recorde", Pontuacao.Pontos)) {

			Instantiate (PontosAtuais);
			PontosAtuais.transform.position = Spawn.position;

		} else {
			Instantiate (NovoRecorde);
			AudioSource.PlayClipAtPoint(Recorde, Camera.main.transform.position * Time.deltaTime);
			NovoRecorde.transform.position = Spawn.position;
			PlayerPrefs.SetInt ("Recorde", Pontuacao.Pontos);

		}

	}
	
	// Update is called once per frame
	void Update () {
		


	
	}
}
