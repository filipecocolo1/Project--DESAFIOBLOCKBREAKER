using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerLife : MonoBehaviour
{
    public int VidaMaxima;
    public int VidaAtual;


    [SerializeField] Image vidaOn;
    [SerializeField] Image vidaOff;

    [SerializeField] Image vidaOn2;
    [SerializeField] Image vidaOff2;

    [SerializeField] Image vidaOn3;
    [SerializeField] Image vidaOff3;

    [SerializeField] Transform spawn;
    [SerializeField] GameObject ball; // PREFAB DA BOLA
    GameObject ballGame;

    SpawnBall SpawnBall = new SpawnBall();

    // Start is called before the first frame update
    void Start()
    {
        ballGame = SpawnBall.BallInstantiate(ball, spawn); // GUARDANDO A INSTANCIA DA BOLA EM UMA VARIAVEL PARA ELA SER DESTRUIDA
    }

    public void ReceberDano() // LÓGICA DO DANO DA BOLINHA
    {
        if (VidaAtual == 3)
        {
            vidaOn3.enabled = true;
            vidaOff3.enabled = false;
            VidaAtual -= 1;
            Destroy(ballGame);
            ballGame = SpawnBall.BallInstantiate(ball,spawn);
        }
        else if (VidaAtual == 2)
        {
            vidaOn2.enabled = true;
            vidaOff2.enabled = false;
            VidaAtual -= 1;
            Destroy(ballGame);
            ballGame = SpawnBall.BallInstantiate(ball, spawn);
        }
        //else if (VidaAtual == 1)
        //{
        //    vidaOn.enabled = true;
        //    vidaOff.enabled = false;
        //    VidaAtual -= 1;
        //    Destroy(ballGame);
        //    ballGame = SpawnBall.BallInstantiate(ball, spawn);
        //}
        else if (VidaAtual == 1)
        {
            vidaOn3.enabled = true;
            vidaOff3.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
