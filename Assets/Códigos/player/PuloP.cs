using UnityEngine;

public class PuloP : MonoBehaviour
{
    private Rigidbody rb;
    public float forcaDoPulo = 80.0f;
    public bool chao = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {
            Pular();
        }
    }

    void Pular()
    {
        rb.AddForce(Vector3.up * forcaDoPulo, ForceMode.Impulse);
        chao = false;
    }
}
