using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour {
    
    private Aviao aviao;
    private Pontuacao pontucao;
    private InterfaceGameOver interfaceGameOver;



    private void Start()
    {
        this.aviao = GameObject.FindObjectOfType<Aviao>();
        this.pontucao = GameObject.FindObjectOfType<Pontuacao>();
        this.interfaceGameOver = GameObject.FindObjectOfType<InterfaceGameOver>();
 
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        
        this.pontucao.SalvarRecorde();
        this.interfaceGameOver.MostrarInterface();

    }

    public void ReiniciarJogo()
    {
        this.interfaceGameOver.EsconderInterface();
        Time.timeScale = 1;
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
        this.pontucao.Reiniciar();
        
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }

}
