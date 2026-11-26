using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public float velocidade = 10f;

    public GrudDir maoDireita; 
    public GrudEsq maoEsquerda; 
    public float forcaSubida = 20f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //pega os controles no teclado(wasd)
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        //pega os valores da camera, frente e direita
        Vector3 frenteDaCamera = Camera.main.transform.forward;
        Vector3 direitaDaCamera = Camera.main.transform.right;

        /*retira o movimento em y dos valores para eles serem ignorados
        e arruma para que os inputs continuem funcionando*/
        frenteDaCamera.y = 0;
        direitaDaCamera.y = 0;
        frenteDaCamera.Normalize();
        direitaDaCamera.Normalize();

        //faz o calculo da direção com os valores de cima
        Vector3 direcaoFinal = (-1 * frenteDaCamera * moverVertical) + (direitaDaCamera * moverHorizontal);

        //executa o movimento
        transform.Translate(direcaoFinal * velocidade * Time.deltaTime, Space.World);
    }

    void FixedUpdate()
    {
        //ve se as duas mãos tão grudadas
        bool duasMaosPresas = maoDireita.segurando && maoEsquerda.segurando;

        //olha se a câmera está olhando para baixo
        float anguloCamera = Camera.main.transform.localEulerAngles.x;
        bool olhandoParaBaixo = (anguloCamera > 45f && anguloCamera < 85f);

        
        if (duasMaosPresas && olhandoParaBaixo)
        {
            rb.AddForce(Vector3.up * forcaSubida, ForceMode.Acceleration);
            rb.AddForce(transform.forward * (forcaSubida * 0.3f), ForceMode.Acceleration);
        }
    }
}
