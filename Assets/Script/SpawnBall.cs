using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject BallInstantiate(GameObject ball, Transform spawn) // INSTANCIANDO A BOLA, TODAS AS REFERENCIAS S�O CHAMADAS DE FORA
    {
        GameObject ballGame = Instantiate(ball, spawn.position, spawn.transform.rotation);
        return ballGame;

    }
}
