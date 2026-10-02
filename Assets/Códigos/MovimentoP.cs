using UnityEngine;

public class Movimento : MonoBehaviour
{

    private Rigidbody rb;
    public float velocidade;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");


        Vector3 direcao = new Vector3(moveH, 0, moveV);


        rb.AddForce(velocidade * direcao * -1);






    }
}
