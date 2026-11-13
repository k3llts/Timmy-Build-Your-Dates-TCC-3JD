using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public float velocidade = 10f;
    public PuloP Plar;

    public GrudDir maoDireita; 
    public GrudEsq maoEsquerda; 
    public float forcaSubida = 20f;// Força para puxar o corpo para cima
    private Rigidbody rb;

    private void Start()
    {
        Plar = GetComponent<PuloP>();
        rb = GetComponent<Rigidbody>(); // Pega o Rigidbody automaticamente

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 frenteDaCamera = Camera.main.transform.forward;
        Vector3 direitaDaCamera = Camera.main.transform.right;

        frenteDaCamera.y = 0;
        direitaDaCamera.y = 0;
        frenteDaCamera.Normalize();
        direitaDaCamera.Normalize();

        Vector3 direcaoFinal = (-1 * frenteDaCamera * moverVertical) + (direitaDaCamera * moverHorizontal);

        transform.Translate(direcaoFinal * velocidade * Time.deltaTime, Space.World);
    }

    void FixedUpdate()
    {
        //olha se as duas mãos estão grudadas usando seus outros scripts
        bool duasMaosPresas = maoDireita.Grudou && maoEsquerda.Grudou;

        //olha se a câmera está olhando para baixo
        float anguloCamera = Camera.main.transform.localEulerAngles.x;
        bool olhandoParaBaixo = (anguloCamera > 30f && anguloCamera < 85f);

        //se tudo for verdade, empurra o corpo para cima e um pouco para frente
        if (duasMaosPresas && olhandoParaBaixo)
        {
            rb.AddForce(Vector3.up * forcaSubida, ForceMode.Acceleration);
            rb.AddForce(transform.forward * (forcaSubida * 0.3f), ForceMode.Acceleration);
        }
    }
}
