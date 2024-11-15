using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGameCollection.Games2024.Team07
{
    public class LevelManager : MonoBehaviour
    {
        public GameObject[] possibleLevel;
        private GameObject currentLevel;
        private int randomNum;
        // Start is called before the first frame update
        void Start()
        {
            currentLevel = null;
        }

        // Update is called once per frame
        void Update()
        {
            if (currentLevel == null){
                randomNum = Random.Range(0, possibleLevel.Length);
                currentLevel = possibleLevel[randomNum];
                currentLevel.SetActive(true);
            }
        }
    }
}
