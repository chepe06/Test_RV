using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpcionesMenu : MonoBehaviour
{

    public void CargarEscena(int numero){
        SceneManager.LoadScene(numero);
    }

    public void SalirApp(){
        Application.Quit();
    }
    
}
