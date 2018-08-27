using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Tienda : MonoBehaviour {
    public int dinero;
    [SerializeField]
    private List<ItemTienda> item_Compra;
    [SerializeField]
    private BaseDatos DB;
    public GameObject contenedor_Item;
    public Text cartel_Dinero;
    public GameObject conf_Compra;
    public GameObject compra_Denegada;
    public GameObject compra_Realizada;



    // Use this for initialization
    void Start () {
        item_Compra = new List<ItemTienda>();
        for(int i=0; i<contenedor_Item.transform.childCount; i++)
        {
            item_Compra.Add(contenedor_Item.transform.GetChild(i).GetComponent<ItemTienda>());
        }
        conf_Compra.SetActive(false);
        compra_Denegada.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
        cartel_Dinero.text = "= " + dinero.ToString();
	}
    public void Comprar(int ItemID)
    {
        if(dinero>= item_Compra[ItemID].precio)
        {
            
            dinero -= item_Compra[ItemID].precio;
            
            item_Compra[ItemID].cantidad -= 1;
        }
        else
        {
            compra_Denegada.SetActive(true);
        }
    }
   
}
