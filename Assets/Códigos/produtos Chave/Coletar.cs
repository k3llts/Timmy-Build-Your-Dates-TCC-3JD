using UnityEngine;

public class Coletar : MonoBehaviour
{
    public dia12 day12;
    public Natal Natal;
    public Pascoa Pasco;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Destroy(gameObject);

            if (day12 != null) 
            {
                day12.coletou1 = true;
            }

            else if (Natal != null)
            {
                Natal.coletou1 = true;
            }

            else if (Pasco != null)
            {
                Pasco.coletou1 = true;
            }

        }
    }

}
