using UnityEngine;
using System.Collections;

public class BolinhaPreta : MonoBehaviour
{
	public 		AudioClip		 Estouro;
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
		Velocidade.speed += -0.2f;
		AudioSource.PlayClipAtPoint(Estouro, Camera.main.transform.position * Time.deltaTime);
        Destroy(gameObject);
    }
	public void Began(){

		Pontuacao.Pontos += 5;
		Velocidade.speed += -0.5f;
		CenarioMove.speed2 += 0.03f;
		AudioSource.PlayClipAtPoint(Estouro, Camera.main.transform.position * Time.deltaTime);
		Destroy(gameObject);

	}
}