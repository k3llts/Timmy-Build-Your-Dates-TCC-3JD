using TMPro;
using UnityEngine;

public class ItensTexto : MonoBehaviour
{
    [Header("DIA DOS NAMORADOS")]
    public TextMeshProUGUI urso;
    public TextMeshProUGUI coracaixa;
    public TextMeshProUGUI bom;


    [Header("PASCOA")]
    public TextMeshProUGUI ovoAura;
    public TextMeshProUGUI coeio;
    public TextMeshProUGUI ovoMid;


    [Header("NATAL")]
    public TextMeshProUGUI globo;
    public TextMeshProUGUI pantelone;
    public TextMeshProUGUI bengala;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //dia dos namorados
        if (TelaInicio.ursin == true)
        {
            urso.text = "Ursinho, Presente maravilhoso:     " +
                "resuminho do pq a namorada gosta do urso";
        }
        if (TelaInicio.coracao == true)
        {
            coracaixa.text = "caixa de coração, Presente bom:       " +
                "resuminho do pq a namorada gosta do caixa de coração";
        }
        if (TelaInicio.bombom == true)
        {
            bom.text = "caixa de bombom, Presente ruim:     " +
                "resuminho do pq a namorada n gosta da caixa normal";
        }


        //pascoa
        if (TelaInicio.coolovo == true)
        {
            ovoAura.text = "Ovo bonito, Presente maravilhoso:       " +
                "resuminho do pq a namorada gosta do ovo";
        }
        if (TelaInicio.cueio == true)
        {
            coeio.text = "coelho de chocolate, Presente bom:        " +
                "resuminho do pq a namorada gosta do coelho";
        }
        if (TelaInicio.normalovo == true)
        {
            ovoMid.text = "Ovo normal, Presente ruim:       " +
                "resuminho do pq a namorada n gosta do ovo normal";
        }


        //natal
        if (TelaInicio.globo == true)
        {
            globo.text = "Globo de neve, Presente maravilhoso:      " +
                "resuminho do pq a namorada gosta do globo";
        }
        if (TelaInicio.pantelone == true)
        {
            pantelone.text = "panetone, Presente bom:       " +
                "resuminho do pq a namorada gosta do panetone (pq ela prefiria o de chocolate mas n tinha no mercado)";
        }
        if (TelaInicio.bengala == true)
        {
            bengala.text = "bengala doce, Presente ruim:        " +
                "resuminho do pq a namorada n gosta da bengala doce";
        }
    }
}
