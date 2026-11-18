using UnityEngine;
using Unity.Cinemachine;

public class SensiCinemachine : MonoBehaviour
{
    private CinemachineInputAxisController controle;
    void Start()
    {
        controle = GetComponent<CinemachineInputAxisController>();
    }

    private void FixedUpdate()
    {
        float sensi = PlayerPrefs.GetFloat("Sensibilidade", 0.5f);


        controle.Controllers[0].Input.Gain = sensi;

        controle.Controllers[1].Input.Gain = sensi * -1;
    }
}
