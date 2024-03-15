using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionMusical : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;
    //public GameObject cubo;

    public TMPro.TMP_Dropdown dropdown;
    public AudioClip[] audioClips;


    public void Start(){
        //dropdown = cubo.GetComponent<Dropdown>();
    }
    
    public void CambiarVolumen(){
        audioSource.volume = slider.value;
    }

    public void PlayMusica(){
        int selectedIndex = dropdown.value;
        if (dropdown.value != -1){
            if (selectedIndex >= 0 && selectedIndex < audioClips.Length){
                audioSource.clip = audioClips[selectedIndex];
                audioSource.Play();
            }
            else{
                Debug.LogWarning("El índice seleccionado está fuera del rango de clips de audio.");
            }
        }
        else{
            Debug.LogWarning("Por favor, selecciona una opción antes de reproducir la música.");
        }
    }
}
