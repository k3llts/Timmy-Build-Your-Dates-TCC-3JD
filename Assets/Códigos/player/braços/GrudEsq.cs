using UnityEngine;

public class GrudEsq : MonoBehaviour
{
    [HideInInspector] public FixedJoint juntaPresa;
    public bool segurando = false;

    void Update()
    {
        // Se soltar o botão do mouse e estiver grudado, destrói a junta
        if (Input.GetMouseButtonUp(0) && juntaPresa != null)
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
        Destroy(juntaPresa);
        segurando = false;
    }
    void segurarMao(Collision collision) 
    {
        //quando clica o mouse e a junta não existe
        if (Input.GetMouseButton(0) && juntaPresa == null)
        {
            //impede de grudar no player
            if (collision.gameObject.CompareTag("Player")) return;

            //vai conectar no que foi tocado, mas se não tiver fisica(rigidbody) o player fica preso
            juntaPresa = gameObject.AddComponent<FixedJoint>();
            juntaPresa.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
            segurando = true;
        }
    }
}
