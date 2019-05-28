using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PontuacaoFinal : MonoBehaviour {

	public Text PontosFinaisTXT;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		PontosFinaisTXT.text = Pontuacao.Pontos.ToString ();
	}
}
