using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class MovimentaçãoDoTomate : MonoBehaviour
{
    public Rigidbody tomate;
    public float forca = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        tomate.AddForce(Vector3.right * forca, ForceMode.Acceleration);

    }
    
}
