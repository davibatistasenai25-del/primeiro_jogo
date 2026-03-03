using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    int frame;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }
    
    // Update is called once per frame
    void Update()
    {

     frame = frame + 1;
     if(Input.GetKey("d"))
     {
        transform.Translate(0.05f,0,0);
     }
     if(Input.GetKey("a"))
        {
            transform.Translate(-0.05f,0,0);
        }
     if(Input.GetKey("w"))
        {
            transform.Translate(0,0.23f,0);
        } 

        if(!Physics.CheckSphere(transform.position, 1.31f))
        {
            transform.Translate(0,-0.13f,0); 
            
        }
        
    }
}
