using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGameCollection.Games2024.Team07
{
    public class PlayerController : MonoBehaviour
    {
        //player movement based on key input from both players that i changed from 2d to 3d input
        //-cc
        public Transform player;
        public KeyCode up;
        public KeyCode down;
        public KeyCode left;
        public KeyCode right;
        public float moveSpeed = 10f;
        public bool facingRight = true;
        public void ChangeDirection(){
            //changes the players x scale to -1 so the sprite flips when changing direction -cc
            //www.youtube.com/watch?v=Cr-j7EoM8bg
            Vector3 currentScale = gameObject.transform.localScale;
            currentScale.x *= -1;
            gameObject.transform.localScale = currentScale;
            facingRight = !facingRight;
        }

        private void FixedUpdate()
        {
            //Move controls
            if (Input.GetKey(down))
            {
                transform.Translate(new Vector3(0, 0,-1) * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(up))
            {
                transform.Translate(new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(right))
            {
                transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
                if(!facingRight){
                    ChangeDirection();
                }
            }
            if (Input.GetKey(left))
            {
                transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);
                if (facingRight) {
                    ChangeDirection();
                }
            }
        }
    }
}
