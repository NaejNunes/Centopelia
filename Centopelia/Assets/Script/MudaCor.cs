using UnityEngine;
using System.Collections;

public class MudaCor : MonoBehaviour
{
	public 		AudioClip		 SomCor;
    private	    float	 x;

    // Use this for initialization
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

        //Velocidade em que a bolinha ira se mover

        x = transform.position.x;

        x += Velocidade.speed * Time.deltaTime;

        transform.position = new Vector3(x, transform.position.y);

        //Destroi a bolinha se ela sair da area limitada.

        if (x <= -7)
        {
            Destroy(transform.gameObject);
        }
    }
    public void OnTriggerEnter()
    {
		Pontuacao.Pontos += 10;
		AudioSource.PlayClipAtPoint(SomCor, Camera.main.transform.position * Time.deltaTime);
        Destroy(gameObject);
    }
}