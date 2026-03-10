using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    bool pulando = false;
    int frame = 0;
    int InicioPulo = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        frame = frame + 1;
        if (Input.GetKey("d"))
        {
            if (!Physics.CheckSphere(transform.position, 0.97f))
            {
                transform.Translate(0.05f, 0, 0);
            }
        }
        if (Input.GetKey("a"))
        {
            if (!Physics.CheckSphere(transform.position, 0.96f))
            {
                transform.Translate(-0.05f, 0, 0);
            }
        }
        if (Input.GetKey("q"))
        {
            if (Physics.CheckSphere(transform.position, 0.98f))
            {
                transform.Translate(0, 0.23f, 0);
            }
        }
        if (!Physics.CheckSphere(transform.position, 1.31f))
        {
            transform.Translate(0, -0.13f, 0);

        }

        bool noChao = Physics.CheckSphere(transform.position, 1.0f);

        // INÍCIO DO PULO: Só entra aqui se apertar, não estiver pulando e estiver no chão
        if (Input.GetKey("space") && !pulando && noChao)
        {
            pulando = true;
            InicioPulo = frame;
        }

        // EXECUÇÃO DO PULO: Sobe até atingir a diferença de frames que você definiu
        if (pulando)
        {
            transform.Translate(0, 0.30f, 0);

            // Se atingir o tempo limite (100 frames), desliga o pulo para começar a cair
            if (frame - InicioPulo > 20)
            {
                pulando = false;
            }
        }
        else if (!noChao)
        {
            // GRAVIDADE: Só puxa para baixo se o pulo já acabou (pulando == false)
            transform.Translate(0, -0.13f, 0);
        }
    }
}

 