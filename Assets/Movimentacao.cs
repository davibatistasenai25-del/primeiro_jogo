using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Translate(0,-0.05f,0);
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey("d"))
     {
        transform.Translate(0.10f,0,0);
     }
     if(Input.GetKey("a"))
        {
            transform.Translate(-0.10f,0,0);
        }
     if(Input.GetKey("w"))
        {
            transform.Translate(0,0.50f,0);
        } 

        if(!Physics.CheckSphere(transform.position, 1.30f))
        {
            transform.Translate(0,-0.1f,0); 
            
        }
        
    }
}
