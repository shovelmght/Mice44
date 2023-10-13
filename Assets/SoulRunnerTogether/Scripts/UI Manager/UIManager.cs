using System;
using UnityEngine;
using LesserKnown.Player;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;
using LesserKnown.Public;

namespace LesserKnown.UI
{
    public class UIManager: MonoBehaviour
    {    
        private bool menu_display;


        [SerializeField] private ScoreManager _ScoreManager;
        [SerializeField] private Animator _Animator;
        [SerializeField] private TMP_Text _ScoreText;
        [SerializeField] private TMP_Text _HiScoreText;
        public CanvasGroup menu_ui;
        public CanvasGroup first_message;

        [Header("Collectibles UI")]
        public TextMeshProUGUI coin_text;
        public TextMeshProUGUI heart_text;
        private static readonly int UpdateScore1 = Animator.StringToHash("UpdateScore");


        private void Start()
        {
            menu_ui.alpha = 0f;
            menu_ui.gameObject.SetActive(false);
            _ScoreManager.OnUpdateScore = UpdateScore;
            /*Debug.Log("Hi Score = " + _ScoreManager.GetIscore());
            Debug.Log("Score = " + _ScoreManager.GetScore());
            if (_ScoreManager.GetIscore() < _ScoreManager.GetScore())
            {
                _ScoreManager.SethIscore(_ScoreManager.GetScore());
                Debug.Log("Hi Score = " + _ScoreManager.GetIscore());
                
            }

            _HiScoreText.text = _ScoreManager.GetIscore().ToString();*/
            _ScoreManager.SetScore(0); 
        }

        private void OnDisable()
        {
            /*Debug.Log("Score = " + _ScoreManager.GetScore());
 
            if (_ScoreManager.GetIscore() < _ScoreManager.GetScore())
            {
                _ScoreManager.SethIscore(_ScoreManager.GetScore());
                Debug.Log("Hi Score = " + _ScoreManager.GetIscore());
            }*/
        }

        private void Update()
        {
            Collection_Manager();
        }

        private void UpdateScore(int point)
        {
            _ScoreManager.SetScore(_ScoreManager.GetScore()+ point);
            _ScoreText.text =_ScoreManager.GetScore().ToString();
            _Animator.SetTrigger(UpdateScore1);
        }
        private void Collection_Manager()
        {
            coin_text.text = $"{PublicVariables.COINS:0} / {PublicVariables.MAX_COLLECTIBLES:0}";
            heart_text.text = $"{PublicVariables.APPLES:0} / {PublicVariables.MAX_COLLECTIBLES:0}";
        }

        public void Display_Options()
        {

        }

        public void Resume_Game()
        {

        }

        public void Quit_Game()
        {
            Application.Quit();
        }

        public void Continue()
        {
            StartCoroutine(ContinueIE());
        }

        private IEnumerator ContinueIE()
        {
            while(first_message.alpha > 0)
            {
                first_message.alpha -= Time.deltaTime;
                yield return null;
            }
            first_message.gameObject.SetActive(false);
        }

        public ScoreManager GetScore()
        {
            return _ScoreManager;
        }
    }
}
