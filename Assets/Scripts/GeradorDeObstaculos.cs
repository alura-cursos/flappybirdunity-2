using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {
    [SerializeField]
    private float tempoParaGerarFacil;
    [SerializeField]
    private float tempoParaGerarDificil;

    [SerializeField]
    private GameObject manualDeIntrucoes;
    private float cronometro;
    private ControleDeDificuldade controleDeDificuldade;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerarFacil;    
    }

    private void Start()
    {
        this.controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }

    void Update () {
       
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
           GameObject.Instantiate(this.manualDeIntrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = Mathf.Lerp(this.tempoParaGerarFacil,
                                         this.tempoParaGerarDificil,
                                         this.controleDeDificuldade.Dificuldade
                );
        }
       




    }
}
