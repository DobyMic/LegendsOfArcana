using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler
{

    [HideInInspector] public Transform parentAfterDrag;
    public Image image;


    public void Start ()
    {

        string classTag = image.gameObject.tag;
        HandleClassTags (classTag);


    }
    public void HandleClassTags ( string tag )
    {
        switch ( tag )
        {

            case "Cleric":
                if ( GameManager . Cleric <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "Wizard":
                if ( GameManager . Wizard <= 0)
                {
                    Destroy (image);
                }

                break;
            case "Monk":
                if ( GameManager . Monk <= 0)
                {
                    Destroy (image);
                }

                break;
            case "Druid":
                if ( GameManager . Druid <= 0 )
                {
                    Destroy (image);
                }
                break;
            case "Alchemist":
                if ( GameManager . Alchemist <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "Rogue":
                if ( GameManager . Rogue <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "Paladin":
                if ( GameManager . Paladin <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "Necromancer":
                if ( GameManager . Necromancer <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "PlagueDoctor":
                if ( GameManager . Plague <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "SpiritMaster":
                if ( GameManager . Master <= 0)
                {
                    Destroy (image);
                }

                break;
            case "Merchant":
                if (GameManager.Merchant <= 0)
                {
                    Destroy(image);
                }

                break;
            case "Candle":
                if ( GameManager . Candle <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "Bard":
                if ( GameManager . Bard <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "Puppeteer":
                if ( GameManager . Puppeteer <= 0 )
                {
                    Destroy (image);
                }

                break;
            case "FortNight":
                if ( GameManager . Fortnight <= 0 )
                {
                    Destroy (image);
                }

                break;
            default:
         
                break;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

  
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {

    
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }


 
}
