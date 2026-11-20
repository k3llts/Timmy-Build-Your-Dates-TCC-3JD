using UnityEngine;

public class GrudEsq : MonoBehaviour
{
    public int botaoMouse = 0; // 0 para botão esquerdo, 1 para botão direito
    [HideInInspector] public FixedJoint juntaPresa;
    public bool segurando = false;

    void Update()
    {
        // Se soltar o botão do mouse e estiver grudado, destrói a junta
        if (Input.GetMouseButtonUp(botaoMouse) && juntaPresa != null)
        {
            soltarMao();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        segurarMao(collision);
    }



    void soltarMao() 
    {
        Destroy(juntaPresa);
        segurando = false;
    }
    void segurarMao(Collision collision) 
    {
        //quando clica o mouse e a junta não existe
        if (Input.GetMouseButton(botaoMouse) && juntaPresa == null)
        {
            //não gruda no player
            if (collision.gameObject.CompareTag("Player")) return;

            //vai conectar no que foi tocado, mas se não tiver fisica(rigidbody) vai colar no player
            juntaPresa = gameObject.AddComponent<FixedJoint>();
            juntaPresa.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
            segurando = true;
        }
    }
}
