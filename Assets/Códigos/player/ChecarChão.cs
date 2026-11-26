using UnityEngine;

public class ChecarChão : MonoBehaviour
{
    public PuloP CPulo;
    void Start()
    {
        CPulo = GameObject.FindFirstObjectByType<PuloP>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            TocouChao();   
        }
    }

    void TocouChao()
    {
        CPulo.TocandoChao = true;
    }
}
