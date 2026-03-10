using UnityEditor.UI;
using UnityEngine;


public class Movimentacao : MonoBehaviour
{
    bool pulando = false;
    int frame = 0;
    int InicioPulo = 0;
    public LayerMask chao;
    public static bool vivo = true;

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
            if (!Physics.CheckSphere(transform.position, 0.97f, chao))
            {
                transform.Translate(0.10f, 0, 0);
            }
        }
        if (Input.GetKey("a"))
        {
            if (!Physics.CheckSphere(transform.position, 0.96f, chao))
            {
                transform.Translate(-0.10f, 0, 0);
            }
        }
        if (Input.GetKey("w"))
        {
            if (Physics.CheckSphere(transform.position, 0.98f, chao))
            {
                transform.Translate(0, 0.23f, 0);
            }
        }

            if (Input.GetKey("space") && pulando == false && Physics.CheckSphere(transform.position, 1.31f, chao))
            { 
                pulando = true;
                InicioPulo = frame;
            }
         

             if (pulando && frame - InicioPulo > 30)
             {
            pulando = false;
             }
            if (pulando)
             {
            this.transform.Translate(0, 0.25f, 0);
                
            }

            if (!pulando && !Physics.CheckSphere(transform.position, 1.31f, chao))
            {
                transform.Translate(0, -0.35f, 0);
            }

        }
    }

