using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Opciones()
    {

    }

    public void Salir()
    {
        //Comprobamos que funciona
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
    
}
