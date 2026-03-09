using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    int frame = 0;
    bool pulando = false;
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

        if (Input.GetKey("space")&&pulando == false && Physics.CheckSphere(transform.position, 0.98f))
        {
            pulando = true;
            InicioPulo = frame;
        }
        if (pulando && frame - InicioPulo > 100)
        {
            pulando = false;
        }
        if (pulando)
        {
            transform.Translate(0, 0.50f, 0);
        }
        {
            if (!Physics.CheckSphere(transform.position, 0.98f))
            {
                transform.Translate(0, 0.50f, 0);
            }
        }
        if (!Physics.CheckSphere(transform.position, 1.31f))
        {
            transform.Translate(0, -0.13f, 0);

        }
    }
}