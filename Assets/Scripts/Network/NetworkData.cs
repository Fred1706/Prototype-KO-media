using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetworkData : NetworkBehaviour
{

     [SerializeField]
    private InfosPlayer infoPlayer1;

    [SerializeField]
    private InfosPlayer infoPlayer2;

    [SerializeField]
    private InfosTime timer;



    private void Update()
    {
        if (IsServer)
        {
            // Assure-toi que le serveur a les données initiales du ScriptableObject
            UpdateClientsWithGameData();
        }
    }

    [ServerRpc(RequireOwnership = false)]
    public void UpdateGameDataServerRpc(int newLife1, int newLife2)
    {
        // Mise à jour des données côté serveur
        infoPlayer1.life = newLife1;
        infoPlayer2.life = newLife2;

        // Envoyer les données mises à jour à tous les clients
        UpdateClientsWithGameData();
    }

    private void UpdateClientsWithGameData()
    {
        // Envoyer les données du ScriptableObject aux clients via un ClientRpc
        UpdateGameDataClientRpc(infoPlayer1.life, infoPlayer2.life);
    }

    [ClientRpc]
    private void UpdateGameDataClientRpc(int updatedLife1, int updatedLife2)
    {
        // Mettre à jour les données côté client
        infoPlayer1.life = updatedLife1;
        infoPlayer2.life = updatedLife2;
    }
}
