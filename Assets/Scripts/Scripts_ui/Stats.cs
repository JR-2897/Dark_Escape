/*
 * Scripts pour afficher les stats du joueur
 * Par Jean RAGUENEAU
 * Créer le 17/06/2019
 * Inspiré par le tuto Créer un inventaire avec Unity3D : https://www.youtube.com/watch?v=mR47TBbmsAI
 * 
 * v0.01 : création du fichier et initialisation du script le 17/06/2019
*/

//Bibliothéques unity nécessaire
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    //Déclaration des variables permettant de récupérer et initialisé les champs munitions et clés
    public Text TxtAmmunitions;
    public Text TxtKeys;
    public int ammunition = 10;
    public int key = 0;

    /* Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        TxtAmmunitions.text = "Munitions : " + ammunition;
        TxtKeys.text = "Clés : " + key;
    }
}
