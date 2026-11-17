using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Config : MonoBehaviour
{
    public AudioMixer Audiio;
    public Slider sensib;

    void Start()
    {
        //pega o valor salvo na memoria, se não tiver usa esse aqui
        float sensiSalva = PlayerPrefs.GetFloat("Sensibilidade", 0.5f);
        sensib.value = sensiSalva;
    }
    public void MudarSensibilidade(float valor)
    {
        //deixa o valor salvo na memoria, as outras cenas podem ler
        PlayerPrefs.SetFloat("Sensibilidade", valor);
    }

    public void Volume(float valorDoSlider)
    {
        //muda o valor do slider para o do som
        Audiio.SetFloat("ParametroAudio", Mathf.Log10(valorDoSlider) * 20);
    }
}
