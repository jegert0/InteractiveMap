using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CesiumForUnity;
using Unity.VisualScripting;

public class API : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject Ces;
    public string Key;
    
    void Update(){
        checkURL();
    }
    void checkURL(){
        if (Key != ""){
            var Source = Ces.GetComponent<Cesium3DTileset> ();
            Source.tilesetSource = CesiumDataSource.FromUrl;
            Source.url = "https://tile.googleapis.com/v1/3dtiles/root.json?key=" + Key;
            

        }
    }
}
