using UnityEngine;
using System.Collections;

public class SpanwControlePlayer : MonoBehaviour {


    public GameObject   PlayerAmarelo5, PlayerAzul5, PlayerMarrom5, PlayerVerde5, PlayerRosa5, PlayerRoxo5, PlayerVermelho5;
    public Transform Spawn;




    private int Item;
    // Use this for initialization
    void Start() {

        //Player Randomico ao iniciar o jogo.

         Item = Random.Range(1, 7);
        

         switch (Item)
        {


           case 1: GameObject Item1 = Instantiate(PlayerAmarelo5);
                Item1.transform.position = Spawn.position;
                break;

           case 2: GameObject Item2 = Instantiate(PlayerAzul5);
                Item2.transform.position = Spawn.position;
                break;

           case 3: GameObject Item3 = Instantiate(PlayerMarrom5);
                Item3.transform.position = Spawn.position;
                break;

           case 4: GameObject Item4 = Instantiate(PlayerVerde5);
                Item4.transform.position = Spawn.position;
                break;

           case 5: GameObject Item5 = Instantiate(PlayerRosa5);
                Item5.transform.position = Spawn.position;
                break;

           case 6: GameObject Item6 = Instantiate(PlayerRoxo5);
                Item6.transform.position = Spawn.position;
                break;

           case 7: GameObject Item7 = Instantiate(PlayerVermelho5);
                Item7.transform.position = Spawn.position;
                break;

           default: Debug.Log("Player não Instanciado!");
                break;
                
     }
    }

    // Update is called once per frame
    void Update () {

        }

   
         
        }








