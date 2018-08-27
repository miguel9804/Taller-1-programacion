using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir : MonoBehaviour {
    public GameObject TiendaUI;
    public GameObject InventarioUI;
    // Use this for initialization
    void Start () {
        TiendaUI.SetActive(false);
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Space))
        {
            TiendaUI.SetActive(true);
        }
        if (Input.GetKey(KeyCode.I))
        {
            InventarioUI.SetActive(true);
        }
    }
}
