using UnityEngine;
using System.Collections;

public class Player5Roxo : MonoBehaviour
{
	public 		GameObject 		PAmarelo, PAzul, PMarrom, PRosa, PVerde, PVermelho, PDiminue;
	private 	int 			Item;
    public	    AudioClip 		MudaCor;
	void update(){

	

	}
	void OnTriggerEnter(Collider BallMudaCor)
    {
		if (BallMudaCor.gameObject.tag == "BMudaCor")
        {

			AudioSource.PlayClipAtPoint(MudaCor, Camera.main.transform.position * Time.deltaTime);

            Destroy(gameObject);

            Item = Random.Range(1, 6);

            switch (Item)
            {


                case 1:
                    GameObject Item1 = Instantiate(PAmarelo) as GameObject;
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
                    GameObject Item6 = Instantiate(PVermelho) as GameObject;
                    break;
            }
        }
		else if(BallMudaCor.gameObject.tag == "BPreta"){

			Pontuacao.Pontos += 1;

		}
		else if (BallMudaCor.gameObject.tag == "BRoxo") {

			Pontuacao.Pontos +=10;

		}
		else {
			Destroy (gameObject);
			Instantiate (PDiminue);
		}

        }
    }

