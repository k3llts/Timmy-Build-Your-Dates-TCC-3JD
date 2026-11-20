using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Config : MonoBehaviour
{
    public AudioMixer Audiio;
    public Slider volume;
    public Slider sensib;


    void Start()
    {
        //pega o valor salvo na memoria, se não tiver usa esse aqui
        float sensiSalva = PlayerPrefs.GetFloat("Sensibilidade", 0.5f);
        sensib.value = sensiSalva;

        volume.value = 1f;
        Volume(0.5f);
    }
    public void Sensibilidade(float valor)
    {
        //deixa o valor salvo na memoria, as outras cenas podem ler
        PlayerPrefs.SetFloat("Sensibilidade", valor);
    }

    public void Volume(float numero)
    {
        //muda o valor do slider para o do som
        Audiio.SetFloat("ParametroAudio", Mathf.Log10(numero) * 20);
    }



   public void Batata() 
    {
        QualitySettings.SetQualityLevel(0, true);
    }
    public void Low()
    {
        QualitySettings.SetQualityLevel(1, true);
    }
    public void Mid()
    {
        QualitySettings.SetQualityLevel(2, true);
    }
    public void Ultra()
    {
        QualitySettings.SetQualityLevel(3, true);
    }
}
