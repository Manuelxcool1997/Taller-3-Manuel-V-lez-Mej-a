using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class redirecciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void enviarAPrimeraparte()
{
SceneManager.LoadScene("parte 1");
}
public void enviarASegundaparte()
{
SceneManager.LoadScene("parte 2");
}
public void enviarTerceraparte()
{
SceneManager.LoadScene("parte 3");
}

public void enviarSalaPrincipalparte()
{
SceneManager.LoadScene("Sala principal");
}

public void salir()
{
Application.Quit();
}
}
