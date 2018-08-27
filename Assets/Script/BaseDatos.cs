using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventario", menuName = "Lista/Inventario" , order =1)]
public class BaseDatos : ScriptableObject {

    [System.Serializable]
    public struct ObjetosInventario
    {
        public string Nombre;
        public int ID;
        public int precio;
        public int cantidad;
        public Sprite imagen;
        public Tipo tipo;
        public bool acumulable;

    }

    public enum Tipo
    {
        consumible,
        no_consumible
    }

    public ObjetosInventario[] Base_de_Datos;
}
