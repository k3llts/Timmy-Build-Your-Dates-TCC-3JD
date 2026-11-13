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
    public TextMeshProUGUI Cesta;


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
                "ursinho de pelucinha super fofinho, otimo como presente para o dia dos namorados.";
        }
        if (TelaInicio.coracao == true)
        {
            coracaixa.text = "caixa de coração, Presente bom:       " +
                "uma caixa de bombom em formato de coração, mostra o quanto você ama o(a) seu(sua) namorado(a).";
        }
        if (TelaInicio.bombom == true)
        {
            bom.text = "caixa de bombom, Presente ruim:     " +
                "Uma caixa... de bombom de marca... super genetica... pro dia dos Namorados.";
        }


        //pascoa
        if (TelaInicio.coolovo == true)
        {
            ovoAura.text = "The cooler ovo de pascoa, Presente maravilhoso: " +
                "resuminho do pq a namorada gosta do ovo";
        }
        if (TelaInicio.cueio == true)
        {
            coeio.text = "Coelho Choculatudinho, Presente bom:        " +
                "Ovo de pascoa de supermercado com orelhas de coelho, um exelente presente de pascoa para quem gosta de chocolate.";
        }
        if (TelaInicio.normalovo == true)
        {
            Cesta.text = "'Cesta de Ovos Coloridinhos, Presente ruim:    " +
                "Uma opção de presente de pascoa caso você esteja mais apertado esse mês.";
        }


        //natal
        if (TelaInicio.globo == true)
        {
            globo.text = "Globo de neve, Presente maravilhoso:      " +
                "Um globo de natal, perfeito para presentear alguém especial no Natal.";
        }
        if (TelaInicio.pantelone == true)
        {
            pantelone.text = "panetone, Presente bom:       " +
                "Penetone, daqueles de frutinhas, é pro natal (O de chocolate seria melhor).";
        }
        if (TelaInicio.bengala == true)
        {
            bengala.text = "bengala doce, Presente ruim:        " +
                "resuminho do pq a namorada n gosta da bengala doce";
        }
    }
}
