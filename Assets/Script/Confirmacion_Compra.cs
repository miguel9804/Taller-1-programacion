using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confirmacion_Compra : MonoBehaviour {
    [SerializeField]
    private Manager_Tienda MT;
    [SerializeField]
    public int ID;
    public bool compra = true;

    public void Aceptar()
    {
        if (compra == true)
        {
            MT.Comprar(ID);

        }
        this.gameObject.SetActive(false);
        
    }

    public void Cancelar()
    {
        this.gameObject.SetActive(false);
        

    }
}
