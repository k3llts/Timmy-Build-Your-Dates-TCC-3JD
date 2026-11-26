using UnityEngine;

public class GrudDir : MonoBehaviour
{
    [HideInInspector] public FixedJoint junta;
    public bool segurando = false;

    void Update()
    {
        // Se soltar o botão do mouse e estiver grudado, destrói a junta
        if (Input.GetMouseButtonUp(1) && junta != null)
        {
            soltarMao();
        }
    }
    void OnCollisionStay(Collision collision)
    {
        segurarMao(collision);
    }



    void soltarMao()
    {
        Destroy(junta);
        segurando = false;
    }
    void segurarMao(Collision collision)
    {
        //quando clica o mouse e a junta não existe
        if (Input.GetMouseButton(1) && junta == null)
        {
            //não gruda no player
            if (collision.gameObject.CompareTag("Player")) return;

            //vai conectar no que foi tocado, mas se não tiver fisica(rigidbody) vai colar no player
            junta = gameObject.AddComponent<FixedJoint>();
            junta.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
            segurando = true;
        }
    }
}
