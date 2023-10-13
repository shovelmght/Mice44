using UnityEngine;
using LesserKnown.Player;
using LesserKnown.Public;
using LesserKnown.Audio;
using SpriteGlow;
using TMPro;
using UnityEngine.UI;

namespace LesserKnown.Collectibles{
public class UICollectible : MonoBehaviour



{
    
    public bool is_GlowEnabled;
    public bool is_AnimShimmerEnabled;
    public bool is_coin;
    [SerializeField] private CharacterController2D[] players;
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteGlowEffect glow;
    [SerializeField] private Image _Image;
    [SerializeField] private SpriteRenderer _SpriteRenderer;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Color _Color;

    // Start is called before the first frame update
    void Start()
    {
        _StartColor = _text.color;
        if(glow)
            glow.enabled = false;
        anim.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        SetGlowByPlayer(is_GlowEnabled);
        SetAnimShimmerByPlayer(is_AnimShimmerEnabled);
        _Image.sprite = _SpriteRenderer.sprite;
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


    private Color _StartColor;
    
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
                        {
                            anim.enabled = true;
                            _text.color = _StartColor;
                            _SpriteRenderer.color = Color.white;
                            _Image.color =Color.white;
                            
                        }

                        else
                        {
                            anim.enabled = false;
                            _text.color = _Color;
                            _Image.color =_Color;
                        }
                            
                    }
                    else
                    {
                        if (is_coin)
                        {
                            anim.enabled = true;
                            _text.color = _StartColor;
                            _SpriteRenderer.color = Color.white;
                            _Image.color =Color.white;
                        }
                            
                        else
                        {
                            anim.enabled = false;
                            _text.color = _Color;
                            _Image.color =_Color;
                     
                        }
                            
                    }
                }
            }
        }

    }

}
}