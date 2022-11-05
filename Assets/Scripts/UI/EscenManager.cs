using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenManager : MonoBehaviour{
    
    public void irAMenu(){
        SceneManager.LoadScene(0);
    }

    public void irANivel1(){
        SceneManager.LoadScene(1);
    }

    public void irAHowToPlay(){
        SceneManager.LoadScene(2);
    }

    public void irACreditos(){
        SceneManager.LoadScene(3);
    }

    public void salir(){
        Application.Quit();
    }

    public void AbrirUI(GameObject objectCanva){
        objectCanva.SetActive(true);
    }

    public void CerrarUI(GameObject objectCanva){
        objectCanva.SetActive(false);
    }

}