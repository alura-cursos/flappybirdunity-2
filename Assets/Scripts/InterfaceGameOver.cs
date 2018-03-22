using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour {
    [SerializeField]
    private GameObject imagemGameOver;
    [SerializeField]
    private Text valorRecorde;
    [SerializeField]
    private Image posicaoMedalha;
    [SerializeField]
    private Sprite medalhaOuro;
    [SerializeField]
    private Sprite medalhaPrata;
    [SerializeField]
    private Sprite medalhaBronze;

    private Pontuacao pontuacao;
    private int recorde;

    private void Start()
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    public void MostrarInterface()
    {
        this.AtualizarInterfaceGrafica();
        this.imagemGameOver.SetActive(true);
    }

    public void EsconderInterface()
    {
        this.imagemGameOver.SetActive(false);
    }

    private void AtualizarInterfaceGrafica()
    {
        this.recorde = PlayerPrefs.GetInt("recorde");
        this.valorRecorde.text = recorde.ToString();

        this.VerificarCorMeldalha();
    }

    private void VerificarCorMeldalha()
    {
        if (this.pontuacao.Pontos > this.recorde - 2)
        {
            //medalha de ouro
            this.posicaoMedalha.sprite = this.medalhaOuro;
        } else if (this.pontuacao.Pontos > this.recorde/2)
        {
            //medalha de prata
            this.posicaoMedalha.sprite = this.medalhaPrata;
        }
        else
        {
            //medalha de bronze
            this.posicaoMedalha.sprite = this.medalhaBronze;
        }
    }
}
