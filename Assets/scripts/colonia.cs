using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colonia : MonoBehaviour
{
    public int cantidadInfantiles;
    public int cantidadJuveniles;
    int profesorJuvenil;
    int profesorInfantil;
    int coordinador;
    int listaEsperaJuv;
    int listaEsperaInf;
    int listaEspera;
    // Start is called before the first frame update
    void Start()
    {
        if(cantidadJuveniles <0 || cantidadJuveniles >100 || cantidadInfantiles < 0 || cantidadInfantiles > 100)
        {
            Debug.Log("tus datos no son correctos");
            return;
       
        }
        profesorInfantil = cantidadInfantiles / 10;
        Debug.Log("Se necesitan " + profesorInfantil + " profesores para los inscriptos infantiles");
        profesorJuvenil = cantidadJuveniles / 20;
        Debug.Log("Se necesitan " + profesorJuvenil + " profesores para los inscriptos juveniles");

        coordinador = (profesorInfantil + profesorJuvenil) / 5;

        listaEsperaJuv = cantidadJuveniles % 20 ;
        listaEsperaInf = cantidadInfantiles % 10;





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
