using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGameCollection.Games2024.Team07
{
    public class LevelManager : MonoBehaviour
    {
        public GameObject[] possibleLevel;
        public P1Controller p1Controller;
        public MiniGameManager miniGameManager;
        public GameObject winCondition;
        public GameObject failCondition;
        private GameObject currentLevel;
        private int randomNum;
        // Start is called before the first frame update
        void Start()
        {
            currentLevel = null;
            miniGameManager.StartGame();
        }

        // Update is called once per frame
        void Update()
        {
            if(miniGameManager.IsTimerExpired && !p1Controller.hasFinished){
                failCondition.SetActive(true);
            }
            if(p1Controller.hasFinished){
               winCondition.SetActive(true);
               miniGameManager.StopGame();
            }
            if (currentLevel == null){
                randomNum = Random.Range(0, possibleLevel.Length);
                currentLevel = possibleLevel[randomNum];
                currentLevel.SetActive(true);
            }
        }
    }
}
