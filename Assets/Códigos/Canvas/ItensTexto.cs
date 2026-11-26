using System;
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
            Debug.Log("Passou aqui ó");
            urso.text = "Ursinho, Presente maravilhoso:         " +
                "ursinho de pelucinha super fofinho, otimo como presente para o dia dos namorados.";
        }
        if (TelaInicio.coracao == true)
        {
            Debug.Log("Passou aqui ó");
            coracaixa.text = "caixa de coração, Presente bom:           " +
                "uma caixa de bombom em formato de coração, mostra o quanto você ama o(a) seu(sua) namorado(a).";
        }
        if (TelaInicio.bombom == true)
        {
            Debug.Log("Passou aqui ó");
            bom.text = "caixa de bombom, Presente ruim:         " +
                "Uma caixa... de bombom de marca... super genérica... pro dia dos Namorados.";
        }


        //pascoa
        if (TelaInicio.coolovo == true)
        {
            Debug.Log("Passou aqui ó");
            ovoAura.text = "Ovo Fofinho, Presente maravilhoso:           " +
                "Um ovo em formato de coelho, o chocolate é gostoso, " +
                "e possui muitas memórias.";
        }
        if (TelaInicio.cueio == true)
        {
            Debug.Log("Passou aqui ó");
            coeio.text = "Coelho Choculatudinho, Presente bom:          " +
                "Ovo de pascoa de supermercado em forma de coelho, " +
                "um ótimo presente para quem gosta de chocolate.";
        }
        if (TelaInicio.normalovo == true)
        {
            Debug.Log("Passou aqui ó");
            Cesta.text = "'Cesta de Ovos coloridos, Presente ruim:          " +
                "Uma opção de presente de pascoa caso você esteja mais apertado esse mês.";
        }


        //natal
        if (TelaInicio.globo == true)
        {
            Debug.Log("Passou aqui ó");
            globo.text = "Globo de neve, Presente maravilhoso:          " +
                "Um globo de natal, perfeito para presentear alguém especial no Natal.";
        }
        if (TelaInicio.pantelone == true)
        {
            Debug.Log("Passou aqui ó");
            pantelone.text = "panetone, Presente bom:               " +
                "Panetone, daqueles de frutinhas, é pro natal (O de chocolate seria melhor).";
        }
        if (TelaInicio.bengala == true)
        {
            Debug.Log("Passou aqui ó");
            bengala.text = "bengala doce, Presente ruim:                " +
                "ebaa, vc vai presentear alguém que te considera bastante com um único doce... " +
                "que só tem gosto de açúcar. Parabéns";
        }
    }
}
