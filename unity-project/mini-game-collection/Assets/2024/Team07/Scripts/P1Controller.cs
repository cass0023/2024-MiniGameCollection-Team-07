using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  MiniGameCollection.Games2024.Team07
{
    public class P1Controller : MonoBehaviour
    {
        public float moveSpeed = 5f;
        float y;
        float x;
        void Update(){
            x = ArcadeInput.Player1.AxisX;
            y = ArcadeInput.Player1.AxisY;
        }
        void FixedUpdate()
        {
            Vector3 movement = new Vector3(x, 0, y).normalized;
            transform.Translate (movement * moveSpeed * Time.deltaTime);
        }
    }
}
