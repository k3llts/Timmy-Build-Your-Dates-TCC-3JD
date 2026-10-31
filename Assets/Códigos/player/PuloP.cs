using UnityEngine;

public class PuloP : MonoBehaviour
{
    private Rigidbody rb; // Mude para Rigidbody2D se estiver fazendo um jogo 2D
    public float forcaDoPulo = 80.0f;
    public bool chao = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Use GetComponent<Rigidbody2D>() no 2D
    }

    void Update()
    {
        // Pula quando a tecla Espaço é pressionada e o personagem está no chão
        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {
            Pular();
        }
    }

    void Pular()
    {
        // Aplica força para cima usando Impulse
        rb.AddForce(Vector3.up * forcaDoPulo, ForceMode.Impulse); // No 2D use Vector2.up e ForceMode2D.Impulse
        chao = false;
    }
}
