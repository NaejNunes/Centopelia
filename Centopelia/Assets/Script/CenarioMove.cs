using UnityEngine;
using System.Collections;

public class CenarioMove : MonoBehaviour {

    private Material     CurrentMaterial;
	public   static  float      speed2;
    private float        offSet;

	// Use this for initialization
	void Start () {
        CurrentMaterial = GetComponent<Renderer>().material;
		speed2 = 0.2f;
	}
	
	// Update is called once per frame
	void Update () {

        offSet += speed2 * Time.deltaTime;

        CurrentMaterial.SetTextureOffset("_MainTex", new Vector2(offSet,0));
	}
}
