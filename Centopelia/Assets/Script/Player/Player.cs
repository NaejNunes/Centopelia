using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public		 GameObject 	 PAzul, PMarrom, PRosa, PRoxo, PVerde, PVermelho, PAumenta, PDiminue;
    public 		 AudioClip 		 MudaCor;
	private		 int 			 Item;
    public static Animator PlYellow;
	void update(){
     


	}

	//Detecta Colisão
	 void OnTriggerEnter(Collider BallMudaCor) {

		//Tocando na Fruta
		if (BallMudaCor.gameObject.tag == "BMudaCor")
        {

			//Aciona Audio p/ troca de cor
			AudioSource.PlayClipAtPoint(MudaCor, Camera.main.transform.position * Time.deltaTime);

            Destroy(gameObject);

			//Randomiza a troca de cor do player
            Item = Random.Range(1, 6);

            switch (Item)
            {

                case 1:
                    //GameObject Item1 = Instantiate(PVermelho) as GameObject;
                    break;

                case 2:
                    GameObject Item2 = Instantiate(PAzul) as GameObject;                    
                    break;

                case 3:
                    GameObject Item3 = Instantiate(PMarrom) as GameObject;                   
                    break;

                case 4:
                    GameObject Item4 = Instantiate(PVerde) as GameObject;
                    break;

                case 5:
                    GameObject Item5 = Instantiate(PRosa) as GameObject;                   
                    break;

				case 6:
					GameObject Item6 = Instantiate (PRoxo) as GameObject;                   
					break;
            }
        }
		else if(BallMudaCor.gameObject.tag == "BPreta"){

			Pontuacao.Pontos += 1;

		}
		else if(BallMudaCor.gameObject.tag == "BAmarela")
        {

			Pontuacao.Pontos += 5;
            Destroy(gameObject);
            Instantiate(PAumenta);

        }
        else
        {
            Destroy(gameObject);
            Instantiate(PDiminue);
        }

    }
}