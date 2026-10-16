using UnityEngine;

public class MaoGrudar : MonoBehaviour
{
    public int botaoMouse = 0; // 0 para botão esquerdo, 1 para botão direito
    private FixedJoint junta;

    void Update()
    {
        // Se soltar o botão do mouse e estiver grudado, destrói a junta
        if (Input.GetMouseButtonUp(botaoMouse) && junta != null)
        {
            Destroy(junta);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        //quando clica o mouse e a junta não existe
        if (Input.GetMouseButton(botaoMouse) && junta == null)
        {
            //não gruda no player
            if (col.gameObject.CompareTag("Player")) return;

            //vai conectar no que foi tocado mas se não tiver fisica(rigidbody) vai colar no player
            junta = gameObject.AddComponent<FixedJoint>();
            junta.connectedBody = col.gameObject.GetComponent<Rigidbody>();
        }
    }
}
