using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  MiniGameCollection.Games2024.Team07
{
    public class P2Controller : MonoBehaviour
    {
        private float moveSpeed = 5f;
        float y;
        float x;
        void Update(){
            x = ArcadeInput.Player2.AxisX;
            y = ArcadeInput.Player2.AxisY;
        }
        void FixedUpdate()
        {
            transform.Translate(x * Time.fixedDeltaTime * moveSpeed, 0, y * Time.fixedDeltaTime * moveSpeed);
        }
    }
}
