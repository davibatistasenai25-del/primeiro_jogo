using UnityEngine;

public class Deus : MonoBehaviour
{
    public float tamanho = 5;
    public LayerMask puta;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.CheckSphere(transform.position, tamanho, puta))
        {
            Movimentacao.vivo = false;

        }
    }
}
