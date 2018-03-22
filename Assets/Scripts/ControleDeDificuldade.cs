using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeDificuldade : MonoBehaviour {
    [SerializeField]
    private float tempoParaDicifuldadeMaxima;
    private float tempoPassado;
    public float Dificuldade { get; private set; }

	void Update () {
        this.tempoPassado += Time.deltaTime;
        this.Dificuldade = this.tempoPassado / this.tempoParaDicifuldadeMaxima;
        this.Dificuldade = Mathf.Min(1, this.Dificuldade);
        
	}
}
