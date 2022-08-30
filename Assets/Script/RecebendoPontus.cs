using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;

public class RecebendoPontus : MonoBehaviour
{

    public static int score;
    public Text _score;
  
    SavePontos savePontos = new SavePontos();// instancia da classe que salvará os pontos
    void Start()
    {
        
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _score.text = score.ToString();
        _score.text = "Score:" + score;

        if (score >1)
        {
            Save(score);
          
        }
        if (score > 40) {

            SceneManager.LoadScene("Ganhou", LoadSceneMode.Single);


        }
    
    }


    public static void SetPoints(int point, GameObject obj)
    {
        score = score + point;
       
        Destroy(obj);
    }



    public void Save(int pontos)
    {
        savePontos.pontos = pontos; // passando o valor dos pontos para a classe
        string outPutpontos = JsonUtility.ToJson(savePontos); // convertendo a classe em JSON e salvando em uma string
        File.WriteAllText(Application.dataPath + "/Dados/pontos.text",outPutpontos); // escrevendo no arquivo de texto
        
    }

}
