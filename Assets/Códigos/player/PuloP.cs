using UnityEngine;

public class PuloP : MonoBehaviour
{
    private Rigidbody rb;
    public float forcaPulo = 80.0f;
    public bool TocandoChao = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && TocandoChao)
        {
            Pular();
        }
    }

    void Pular()
    {
        rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        TocandoChao = false;
    }
}
