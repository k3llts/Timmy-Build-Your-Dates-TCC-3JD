using UnityEngine;

public class MovimentoP : MonoBehaviour
{
    public float velocidade = 5f;
    public PuloP Plar;

    private void Start()
    {
        PuloP Plar = GetComponent<PuloP>();
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

        Vector3 direcaoFinal = (frenteDaCamera * moverVertical) + (direitaDaCamera * moverHorizontal);

        transform.Translate(direcaoFinal * velocidade * Time.deltaTime, Space.World);


        if (Plar.chao == false)
        {
            velocidade = 8f;
        }
        else if (Plar.chao == true)
        {
            velocidade = 10f;
        }
    }
}
