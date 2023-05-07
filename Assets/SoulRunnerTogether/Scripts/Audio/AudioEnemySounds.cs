using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LesserKnown.Audio {
    public class AudioEnemySounds : MonoBehaviour
    {
        AudioSource enemySource;

        [Header(" Audio Clips")]
        public AudioClip[] mushAttack;
        public AudioClip[] mushDeath;
        public AudioClip[] mushDeath2;
        public AudioClip[] mushAppear;
        public AudioClip[] mushHit;
        public AudioClip[] mushPoisonExplo;
        private Dictionary<string, AudioClip[]> soundEvtDict_AI = new Dictionary<string, AudioClip[]>();


        void Start()
        {
            enemySource = GetComponent<AudioSource>();
            _Init_AudioAnimEventsRefs();
        }

        void Update()
        {
        }

        public void PlayPoisonCloud()
        {
            PlayEnemySound(mushPoisonExplo);
        }
        public void PlayDead()
        {
            PlayEnemySound(mushDeath);
        }
        public void PlayDead2()
        {
            PlayEnemySound(mushDeath2);
        }

        public void PlaySndEventAI(string call)
        {
            PlayEnemySound(soundEvtDict_AI[call]);
        }

        public void PlayEnemySound(AudioClip[] clipArray)
        {
            SetRandomVariations(0.8f, 1);
            enemySource.PlayOneShot(PickRandomClip(clipArray));
        }
        private void _Init_AudioAnimEventsRefs()
        {
            soundEvtDict_AI["appear"] = mushAppear;
            soundEvtDict_AI["attack"] = mushAttack;
            soundEvtDict_AI["death"] = mushDeath;
            soundEvtDict_AI["hurt"] = mushHit;
        }

        void SetRandomVariations(float vol, float pitch)
        {

            enemySource.pitch = (float)Random.Range(0.8f, 1.2f);
            enemySource.volume = (float)Random.Range(0.05f, 0.1f);
        }

        AudioClip PickRandomClip(AudioClip[] clipArray)
        {
            if (clipArray != null)
                return clipArray[Random.Range(0, clipArray.Length - 1)];
            else
                return null;
        }

        //destroy on death?
    }
}