using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;
using UnityEngine;
namespace MiniGameCollection.Games2024.Team07{
public class Interact : MonoBehaviour
{
    private Transform door;
    // Start is called before the first frame update
    void Start()
    {
        door = this.transform.Find("Door");
    }
    private void OnTriggerEnter(Collider collider){
        door.gameObject.SetActive(false);
    }
    /*
    private void OnTriggerExit(Collider collider){
        Invoke("SetDoorTrue", 5f);
    }
    void SetDoorTrue(){
        door.gameObject.SetActive(true);
    }
    */
}
}

