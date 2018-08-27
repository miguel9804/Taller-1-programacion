    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;



public class ItemTienda : MonoBehaviour, IPointerClickHandler {

    public BaseDatos DB;
    public Manager_Tienda MT;
    public int ID;
    public int precio;
    public int cantidad;
    public bool acumulable;
    private Image imagen;
    public Text text_Precio;
    public Text text_Cantidad;
    private GameObject confi_compra;
	// Use this for initialization
	void Start () {
        acumulable = DB.Base_de_Datos[ID].acumulable;
        confi_compra = MT.conf_Compra;
        precio = DB.Base_de_Datos[ID].precio;
        imagen = GetComponent<Image>();
        imagen.sprite = DB.Base_de_Datos[ID].imagen;
        text_Precio.text = precio.ToString();
	}
	

    public void OnPointerClick(PointerEventData eventData)
    {
        confi_compra.SetActive(true);
        confi_compra.GetComponent<Confirmacion_Compra>().ID = ID;
        confi_compra.GetComponent<Confirmacion_Compra>().compra = true;
       
    }
    void Update()
    {
        if(ID<=6)
        {
            imagen.enabled = true;
            text_Precio.enabled = true;
            text_Cantidad.enabled = true;
        }
        else
        {
            imagen.enabled = false;
            text_Precio.enabled = false;
            text_Cantidad.enabled = false;
        }
        if(cantidad<= 0)
        {
            cantidad = 0;
            this.gameObject.SetActive(false);

        }
        else
        {
            this.gameObject.SetActive(true);
            text_Cantidad.text = cantidad.ToString();
        }
    }

    public void ActualizarItem()
    {
        acumulable = DB.Base_de_Datos[ID].acumulable;
        precio = DB.Base_de_Datos[ID].precio;
        imagen = GetComponent<Image>();
        imagen.sprite = DB.Base_de_Datos[ID].imagen;
        text_Precio.text = precio.ToString();
    }
}
