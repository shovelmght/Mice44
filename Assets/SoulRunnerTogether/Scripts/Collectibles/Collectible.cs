using UnityEngine;
using LesserKnown.Player;
using LesserKnown.Public;
using LesserKnown.Audio;
using SpriteGlow;

namespace LesserKnown.Collectibles
{
    public class Collectible : MonoBehaviour
    {
        public AudioClip[] appleSnd;
        public AudioClip[] coinSnd;
        private CharacterController2D[] players;
        public bool is_coin;
        public bool is_picked;
        public bool is_GlowEnabled;
        public bool is_AnimShimmerEnabled;
        [SerializeField] private bool _IsUI_Only;


        [SerializeField] private Animator anim;
        private AudioSource playerSource;
        private SpriteGlowEffect glow;

        private void Start()
        {
            anim = GetComponent<Animator>();
            glow = GetComponent<SpriteGlowEffect>();
            players = FindObjectsOfType<CharacterController2D>();
            if(glow)
                glow.enabled = false;
            anim.enabled = true;
        }

        private void Update()
        {
            SetGlowByPlayer(is_GlowEnabled);
            SetAnimShimmerByPlayer(is_AnimShimmerEnabled);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(_IsUI_Only) {return;}
            
            if (other.tag == "Player")
            {
                CharacterController2D player = other.GetComponent<CharacterController2D>();

                if (player.is_fighter && !is_coin)
                {
                    if (!is_picked)
                    {
                        UI_Collectible.Instance.SetCollectibleAnimator("Apple");
                        if (PublicVariables.APPLES < PublicVariables.MAX_COLLECTIBLES)
                            PublicVariables.APPLES++;
                        playerSource = other.GetComponent<AudioSource>();
                        anim.SetTrigger("Collect");
                        is_picked = true;
                        Destroy(gameObject, .5f);
                    }
                }

                else if (!player.is_fighter && is_coin)
                {
                    if (!is_picked)
                    {
                        UI_Collectible.Instance.SetCollectibleAnimator("Coin");
                        if (PublicVariables.COINS < PublicVariables.MAX_COLLECTIBLES)
                            PublicVariables.COINS++;
                        playerSource = other.GetComponent<AudioSource>();
                        anim.SetTrigger("Collect");
                        is_picked = true;
                        Destroy(gameObject, .5f);
                    }
                }
            }
        }

        public void PlaySoundApple()
        {
            SetRandomVariations();
            playerSource.PlayOneShot(appleSnd[Random.Range(0, appleSnd.Length - 1)]);
        }
        public void PlaySoundCoin()
        {
            SetRandomVariations();
            AudioClip soundCoins = coinSnd[Random.Range(0, coinSnd.Length - 1)];
            playerSource.clip = soundCoins;
            playerSource.Play();
        }
        private void SetRandomVariations()
        {
            playerSource.pitch = 1f;
            playerSource.volume = (float)Random.Range(0.5f, 0.7f);
        }

        private void SetGlowByPlayer(bool FXenabled)
        {
            //GLOW OU PAS SELON PLAYER ACTIVE QUI PEUT RAMASSER
            //en ce moment affect les couleurs des anims de COLLECT aussi

            if (FXenabled)
            {
                foreach (var player in players)
                {
                    if (player.is_active)
                    {
                        if (player.is_fighter)
                        {
                            if (!is_coin)
                                glow.enabled = true;
                            else
                                glow.enabled = false;
                        }
                        else
                        {
                            if (is_coin)
                                glow.enabled = true;
                            else
                                glow.enabled = false;
                        }
                    }
                }
            }
        }
        private void SetAnimShimmerByPlayer(bool FXenabled)
        {
            if (FXenabled)
            {
                anim.enabled = false;

                foreach (var player in players)
                {
                    if (player.is_active)
                    {
                        if (player.is_fighter)
                        {
                            if (!is_coin)
                                anim.enabled = true;
                            else
                                anim.enabled = false;
                        }
                        else
                        {
                            if (is_coin)
                                anim.enabled = true;
                            else
                                anim.enabled = false;
                        }
                    }
                }
            }

        }
    }
}
