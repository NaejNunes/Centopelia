using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CarregaCena : MonoBehaviour {

    public void CarregaCenas(string Nome) {

       SceneManager.LoadScene(Nome);


    }

}
