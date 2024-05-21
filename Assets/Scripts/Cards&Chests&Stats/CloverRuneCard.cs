using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloverRuneCard : MonoBehaviour
{
    public GameObject Card;
    public AudioClip newRuneSfx;
    // Start is called before the first frame update
    void Start ( )
    {

        SoundManager . Instance . PlaySound (newRuneSfx);
        string classTag = Card.gameObject.tag;
        HandleClassTags (classTag);

    }
    public void HandleClassTags ( string tag )
    {
        switch ( tag )
        {

            case "Magical":
                GameManager . RUNEmagic +=1;
                Destroy (Card , 1.8f);
                break;
            case "Physical":
                GameManager . RUNEphysical += 1;
                Destroy (Card , 1.8f);
                break;
            case "Summoning":
                GameManager . RUNEsummon += 1;
                Destroy (Card , 1.8f);
                break;
            case "Healing":
                GameManager . RUNEhealing += 1;
                Destroy (Card , 1.8f);
                break;
            case "Unique":
                GameManager . RUNEunique += 1;
                Destroy (Card , 1.8f);
                break;
            case "Cosmo":
                GameManager . RUNEcosmo += 1;
                Destroy (Card , 1.8f);
                break;

            case "Armor":
                GameManager . RUNEArmor += 1;
                Destroy (Card , 1.8f);
                break;
            case "Critical":
                GameManager . RUNEcritChance += 1;
                Destroy (Card , 1.8f);
                break;

            default:
                Debug . Log ("Didn't Contain tag");
                break;
        }
    }
    // Update is called once per frame



}
