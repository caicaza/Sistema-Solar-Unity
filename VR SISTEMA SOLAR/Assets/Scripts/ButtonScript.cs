using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject objMercurio;
    public GameObject objVenus;
    public GameObject objTierra;
    public GameObject objMarte;
    public GameObject objJupiter;
    public GameObject objSaturno;
    public GameObject objUrano;
    public GameObject objNeptuno;
    public Text textNamePlanet;
    public Text textInfoPlanet;
    public GameObject CanvasPlanet;
    private List<PlanetInfo> misPlanetas;

    bool openCanvas = false;

    private void Start()
    {
        strInfo infPlanets = new strInfo();

        misPlanetas = new List<PlanetInfo>();
        misPlanetas.Add(new PlanetInfo(1, "Mercurio", infPlanets.strMercurio, objMercurio));
        misPlanetas.Add(new PlanetInfo(2, "Venus", infPlanets.strVenus, objVenus));
        misPlanetas.Add(new PlanetInfo(3, "Tierra", infPlanets.strMercurio, objTierra));
        misPlanetas.Add(new PlanetInfo(4, "Marte", infPlanets.strMarte, objMarte));
        misPlanetas.Add(new PlanetInfo(5, "Jupiter", infPlanets.strMercurio, objJupiter));
        misPlanetas.Add(new PlanetInfo(6, "Saturno", infPlanets.strSaturno, objSaturno));
        misPlanetas.Add(new PlanetInfo(7, "Urano", infPlanets.strUrano, objUrano));
        misPlanetas.Add(new PlanetInfo(8, "Neptuno", infPlanets.strNeptuno, objNeptuno));

    }


    public void choosePlanet(int numberPlanet)
    {
        openCanvas = true;
        CanvasPlanet.SetActive(openCanvas);
        InactivePlanets();
        Debug.Log("Clic");

        if (numberPlanet > 0 && numberPlanet <= 8)
        {
            PlanetInfo miPlaneta = misPlanetas[numberPlanet - 1];
            miPlaneta.setActive();
            textNamePlanet.text = miPlaneta.nombre;
            textInfoPlanet.text = miPlaneta.informacion;
        }
        else
        {
            print("Coloque otro número");
        }

    }

    public void InactivePlanets()
    {
        for (int i = 0; i < misPlanetas.Count; i++)
        {
            misPlanetas[i].setInactive();
        }

    }


}
