using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class ItensImagem : MonoBehaviour
{
    [Header("DIA DOS NAMORADOS")]
    public RawImage SemUrso;
    public Texture2D Urso;

    public RawImage SemCoraCaixa;
    public Texture2D CoraCaixa;

    public RawImage SemBomBom;
    public Texture2D BomBom;


    [Header("PASCOA")]
    public RawImage SemCoolOvo;
    public Texture2D CoolOvo;

    public RawImage SemCueio;
    public Texture2D Cueio;

    public RawImage SemOvobase;
    public Texture2D OvoBase;


    [Header("NATAL")]
    public RawImage SemGlobo;
    public Texture2D Globo;

    public RawImage SemPantelone;
    public Texture2D Pantelone;

    public RawImage SemBengala;
    public Texture2D Bengala;


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //Dia dos namorados
        if (TelaInicio.ursin == true) 
        {
            Ursar();
        }
        if (TelaInicio.coracao == true)
        {
            Coracar();
        }
        if (TelaInicio.bombom == true)
        {
            Bombar();
        }


        //Natal
        if (TelaInicio.globo == true)
        {
            Globar();
        }
        if (TelaInicio.pantelone == true)
        {
            Chocolatone();
        }
        if (TelaInicio.bengala == true)
        {
            Bengalar();
        }


        //Pascoa
        if (TelaInicio.coolovo == true)
        {
            OvoAura();
        }
        if (TelaInicio.cueio == true)
        {
            Coelio();
        }
        if (TelaInicio.normalovo == true)
        {
            OvoNormar();
        }
    }

    //Funções

    //Dia dos namorados
    public void Ursar() 
    {
        SemUrso.texture = Urso;
    }
    public void Coracar()
    {
        SemCoraCaixa.texture = CoraCaixa;
    }
    public void Bombar()
    {
        SemBomBom.texture = BomBom;
    }


    //Natal
    public void Globar()
    {
        SemGlobo.texture = Globo;
    }
    public void Chocolatone()
    {
        SemPantelone.texture = Pantelone;
    }
    public void Bengalar()
    {
        SemBengala.texture = Bengala;
    }


    //Pascoa
    public void OvoAura()
    {
        SemCoolOvo.texture = CoolOvo;
    }
    public void Coelio()
    {
        SemCueio.texture = Cueio;
    }
    public void OvoNormar()
    {
        SemOvobase.texture = OvoBase;
    }

}
