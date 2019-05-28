using UnityEngine;
using System.Collections;

public class SpanwController : MonoBehaviour
{

	public GameObject Bolinha1, Bolinha2, Bolinha3, Bolinha4, Bolinha5, Bolinha6, Bolinha7, Bolinha8, Bolinha9, Bolinha10;
    public float rateSpawn;
    public float currentTime;
    private int Item;
    public Transform Spawn;
    // Use this for initialization




    void Start()
    {

        currentTime = 0;

    }

    // Update is called once per frame
    void Update()
    {

        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            rateSpawn = Random.Range(0.5f, 1f);
            Item = Random.Range(1, 12);
            switch (Item)
            {


                case 1:

                    currentTime = 0;
                    GameObject Item1 = Instantiate(Bolinha1) as GameObject;
				Item1.transform.position = Spawn.position; 

                    break;

                case 2:


                    currentTime = 0;
                    GameObject Item2 = Instantiate(Bolinha2) as GameObject;
				Item2.transform.position = Spawn.position; 

                    break;

                case 3:

                    currentTime = 0;
                    GameObject Item3= Instantiate(Bolinha3) as GameObject;
				Item3.transform.position = Spawn.position;

                    break;

                case 4:


                    currentTime = 0;
                    GameObject Item4 = Instantiate(Bolinha4) as GameObject;
				Item4.transform.position = Spawn.position;
                   

                    break;

                case 5:


                    currentTime = 0;
                    GameObject Item5 = Instantiate(Bolinha5) as GameObject;
				Item5.transform.position = Spawn.position;
                    

                    break;

                case 6:


                    currentTime = 0;
                    GameObject Item6 = Instantiate(Bolinha6) as GameObject;
				Item6.transform.position = Spawn.position;
                    break;

                case 7:


                    currentTime = 0;
                    GameObject Item7 = Instantiate(Bolinha7) as GameObject;
				Item7.transform.position = Spawn.position;

                    break;

                case 8:


                    currentTime = 0;
                    GameObject Item8 = Instantiate(Bolinha8) as GameObject;
				Item8.transform.position = Spawn.position;

                    break;

                case 9:


                    currentTime = 0;
                    GameObject Item9 = Instantiate(Bolinha8) as GameObject;
                    Item9.transform.position = Spawn.position;

                    break;

                case 10:


                    currentTime = 0;
                    GameObject Item10 = Instantiate(Bolinha9) as GameObject;
                    Item10.transform.position = Spawn.position;

                    break;

			case 11:
				
				currentTime = 0;
				GameObject Item11 = Instantiate(Bolinha10) as GameObject;
				Item11.transform.position = Spawn.position;

				break;

               
            }
        }

    }
}
        
	
	

