using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int notes = 0;

    [SerializeField] Text NotesText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Notes"))
        {
            Destroy(other.gameObject);
            notes++;
            NotesText.text = "Notes: " + notes;
        }
    }

}
