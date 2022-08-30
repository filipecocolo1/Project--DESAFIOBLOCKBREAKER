using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ComandController : MonoBehaviour
{
    public void Button()
    {
        SceneManager.LoadScene("Fase1", LoadSceneMode.Single);
    }
    public void Button2()
    {

        SceneManager.LoadScene("Menu", LoadSceneMode.Single);

    }
    public void Button3()
    {

        SceneManager.LoadScene("ProximaFase", LoadSceneMode.Single);

    }
    public void Button4()
    {
        SceneManager.LoadScene("Instrution", LoadSceneMode.Single);




    }
    public void Button5()
    {
        SceneManager.LoadScene("Fase2", LoadSceneMode.Single);


    }

    public void Button6()
    {
        SceneManager.LoadScene("Level", LoadSceneMode.Single);


    }
}