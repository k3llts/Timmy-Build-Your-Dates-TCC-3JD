using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public float velocidade = 8f;
    public PuloP Plar;

    private void Start()
    {
        PuloP Plar = GetComponent<PuloP>();
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


        if (Plar.chao == false)
        {
            velocidade = 5f;
        }
        else if (Plar.chao == true)
        {
            velocidade = 8f;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            velocidade = velocidade+2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            velocidade = velocidade + 2;
        }
    }
}
