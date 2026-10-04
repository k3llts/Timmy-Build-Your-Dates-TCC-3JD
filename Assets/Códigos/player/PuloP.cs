using UnityEngine;

public class PuloP : MonoBehaviour
{

    public bool chao = true;
    private Rigidbody rb;
    public float ForçaPulo;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Jump = Input.GetAxis("Jump");
        Vector3 altura = new Vector3(0, Jump, 0);


        if (Input.GetAxis("Jump") > 0)
        {
            if (chao == true)
            {
                rb.AddForce(ForçaPulo * altura * 1);
                chao = false;
            }
        }

    }
}
