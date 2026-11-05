using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Gestionaire de la collecte des piece et UI
/// </summary>
public class GestionPiece : MonoBehaviour
{
    [SerializeField, Tooltip("Référence aux objets de charge que le joueur peut utiliser.")]
    private GameObject[] objetsPiece;

    [SerializeField, Tooltip("Référence au texte affichant la texteVitesse.")]
    TextMeshProUGUI textePiece;

    // Le nombre de charges disponibles pour le joueur.
    private int nombrePiece = 5; // test

    private void Update()
    {
        textePiece.text = $"{nombrePiece}";
    }

    public void AjouterPiece()
    {
            nombrePiece++;
    }


    public bool UtiliserPiece()
    {
        if (nombrePiece < 5)
        {
            return false;
        }

        nombrePiece= nombrePiece - 5;
        return true;
    }
}
