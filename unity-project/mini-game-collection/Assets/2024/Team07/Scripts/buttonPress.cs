using MiniGameCollection.Games2024.Team07;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGAmeCollection.Games2024.Team07
{
    public class buttonPress : MonoBehaviour
    {
        //private void OnTriggerEnter(Collider other)
        //{
            //bool isTag = other.GetComponentInChildren<TagPlayer>() != null;
            //if (isTag)
            //{
                //onStart();
           // }
        //}

        public static float pressDistance = 2f;
        public static KeyCode interactKey = KeyCode.E;

        private Transform player1;
        public static bool inRange = false;
        //public GameObject playerObject;

        public void PressButton()
        {
            Debug.Log("Pressed");
        }


        private void Start()
        {


           GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

           player1 = playerObject.transform;
           Debug.Log("Player found: " + playerObject.name);



        }


        // Update is called once per frame
        private void Update()
        {
            if (player1 == null) return;
            float distance = Vector3.Distance(player1.position, transform.position);
            inRange = distance <= pressDistance;

            if (inRange && Input.GetKeyDown(interactKey))
            {
                PressButton();
            }
        }

        //void onStart()
        //{
            //player1 = playerObject.transform;
           // Debug.Log("Player found: " + playerObject.name);
        //}

    }

}

