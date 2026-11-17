using UnityEngine;
using Unity.Cinemachine;

public class SensiCinemachine : MonoBehaviour
{
    void Start()
    {
        // Pega o valor entre 0.1 e 1 salvo no menu
        float sensi = PlayerPrefs.GetFloat("Sensibilidade", 0.5f);

        var controle = GetComponent<CinemachineInputAxisController>();

        // coloca o valor do float como sensi
        foreach (var eixo in controle.Controllers)
        {
            eixo.Input.Gain = sensi;
        }
    }
}
