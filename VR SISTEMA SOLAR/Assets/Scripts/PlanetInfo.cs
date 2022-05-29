using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetInfo
{
    public int id;
    public string nombre;
    public string informacion;
    public GameObject planetObject;
    public bool isActive = false;

    public PlanetInfo(int newid, string newNombre, string newInformacion, GameObject newPlanetObject)
    {
        id = newid;
        nombre = newNombre;
        informacion = newInformacion;
        planetObject = newPlanetObject;
    }

    public void setActive()
    {
        isActive = true;
        planetObject.SetActive(isActive);
    }

    public void setInactive()
    {
        isActive = false;
        planetObject.SetActive(isActive);
    }



}
