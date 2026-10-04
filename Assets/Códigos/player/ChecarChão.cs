using UnityEngine;

public class ChecarChão : MonoBehaviour
{
    public PuloP Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindFirstObjectByType<PuloP>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chao")) {
            Player.chao = true;
        }

        
    }

}
