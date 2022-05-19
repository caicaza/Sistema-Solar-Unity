 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AparecerDesaparecer : MonoBehaviour
{
    public GameObject object1;
    bool active = true;

    public void choosePlanet(int numberPlanet)
    {
        Debug.Log("Planeta número "+ numberPlanet+ " seleccionado");
        Text txt = transform.Find("0").GetComponent<Text>();
        txt.text = numberPlanet.ToString();
        active = !active;
        object1.SetActive(active);
        
    }
}
