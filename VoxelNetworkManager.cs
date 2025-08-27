// File: VoxelNetworkManager.cs
using Mirror;
using UnityEngine;

public class VoxelNetworkManager : NetworkManager {
    public override void OnServerAddPlayer(NetworkConnectionToClient conn) {
        GameObject player = Instantiate(playerPrefab);
        NetworkServer.AddPlayerForConnection(conn, player);
    }
}
