using System;
using EliteKillerz.DotnetVcmp.RuntimeClient.VcmpSdk;

namespace EliteKillerz.DotnetVcmp.Rocketship
{
    public static partial class Interop
    {
        private static void BindEvents(ref PluginEvents events)
        {
            events.OnServerInitialize = OnServerInitialize;
            events.OnServerShutdown = OnServerShutdown;
            events.OnServerFrame = OnServerFrame;
            events.OnPluginCommand = OnPluginCommand;
            events.OnIncomingConnection = OnIncomingConnection;
            events.OnClientScriptData = OnClientScriptData;
            events.OnPlayerConnect = OnPlayerConnect;
            events.OnPlayerDisconnect = OnPlayerDisconnect;
            events.OnPlayerRequestClass = OnPlayerRequestClass;
            events.OnPlayerRequestSpawn = OnPlayerRequestSpawn;
            events.OnPlayerSpawn = OnPlayerSpawn;
            events.OnPlayerDeath = OnPlayerDeath;
            events.OnPlayerUpdate = OnPlayerUpdate;
            events.OnPlayerRequestEnterVehicle = OnPlayerRequestEnterVehicle;
            events.OnPlayerEnterVehicle = OnPlayerEnterVehicle;
            events.OnPlayerExitVehicleDelegate = OnPlayerExitVehicle;
            events.OnPlayerNameChange = OnPlayerNameChange;
            events.OnPlayerStateChange = OnPlayerStateChange;
            events.OnPlayerActionChange = OnPlayerActionChange;
            events.OnPlayerOnFireChange = OnPlayerOnFireChange;
            events.OnPlayerCrouchChange = OnPlayerCrouchChange;
            events.OnPlayerGameKeysChange = OnPlayerGameKeysChange;
            events.OnPlayerBeginTyping = OnPlayerBeginTyping;
            events.OnPlayerEndTyping = OnPlayerEndTyping;
            events.OnPlayerAwayChange = OnPlayerAwayChange;
            events.OnPlayerMessage = OnPlayerMessage;
            events.OnPlayerCommand = OnPlayerCommand;
            events.OnPlayerPrivateMessage = OnPlayerPrivateMessage;
            events.OnPlayerKeyBindDown = OnPlayerKeyBindDown;
            events.OnPlayerKeyBindUp = OnPlayerKeyBindUp;
            events.OnPlayerSpectate = OnPlayerSpectate;
            events.OnPlayerCrashReport = OnPlayerCrashReport;
            events.OnVehicleUpdate = OnVehicleUpdate;
            events.OnVehicleExplode = OnVehicleExplode;
            events.OnVehicleRespawn = OnVehicleRespawn;
            events.OnObjectShot = OnObjectShot;
            events.OnObjectTouched = OnObjectTouched;
            events.OnPickupPickAttempt = OnPickupPickAttempt;
            events.OnPickupPicked = OnPickupPicked;
            events.OnPickupRespawn = OnPickupRespawn;
            events.OnCheckpointEntered = OnCheckpointEntered;
            events.OnCheckpointExited = OnCheckpointExited;
            events.OnEntityPoolChange = OnEntityPoolChange;
            events.OnServerPerformanceReport = OnServerPerformanceReport;
            events.OnPlayerModuleList = OnPlayerModuleList;
        }

        private static byte OnServerInitialize()
        {
            throw new NotImplementedException();
        }

        private static void OnServerShutdown()
        {
            throw new NotImplementedException();
        }

        private static void OnServerFrame(float elapsedTime)
        {
            throw new NotImplementedException();
        }

        private static byte OnPluginCommand(uint commandIdentifier, string message)
        {
            throw new NotImplementedException();
        }

        private static byte OnIncomingConnection(string name, IntPtr nameBufferSize, string userPassword, string ipAddress)
        {
            throw new NotImplementedException();
        }
        
        private static void OnClientScriptData(int playerID, IntPtr data, IntPtr size)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerConnect(int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerDisconnect(int playerID, DisconnectReason disconnectReason)
        {
            throw new NotImplementedException();
        }

        private static byte OnPlayerRequestClass(int playerID, int offset)
        {
            throw new NotImplementedException();
        }

        private static byte OnPlayerRequestSpawn(int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerSpawn(int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerDeath(int playerID, int killerID, int reason, BodyPart bodyPart)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerUpdate(int playerID, PlayerUpdate updateType)
        {
            throw new NotImplementedException();
        }

        private static byte OnPlayerRequestEnterVehicle(int playerID, int vehicleID, int slotIndex)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerEnterVehicle(int playerID, int vehicleID, int slotIndex)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerExitVehicle(int playerID, int vehicleID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerNameChange(int playerID, string previousName, string currentName)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerStateChange(int playerID, PlayerState previousState, PlayerState currentState)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerActionChange(int playerID, int previousAction, int currentAction)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerOnFireChange(int playerID, bool isOnFire)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerCrouchChange(int playerID, bool isCrouching)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerGameKeysChange(int playerID, uint previousKeys, uint currentKeys)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerBeginTyping(int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerEndTyping(int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerAwayChange(int playerID, byte isAway)
        {
            throw new NotImplementedException();
        }

        private static byte OnPlayerMessage(int playerID, string message)
        {
            throw new NotImplementedException();
        }

        private static byte OnPlayerCommand(int playerID, string message)
        {
            throw new NotImplementedException();
        }

        private static byte OnPlayerPrivateMessage(int playerID, int targetPlayerID, string message)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerKeyBindDown(int playerID, int bindID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerKeyBindUp(int playerID, int bindID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerSpectate(int playerID, int targetPlayerID)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerCrashReport(int playerID, string report)
        {
            throw new NotImplementedException();
        }

        private static void OnVehicleUpdate(int vehicleID, VehicleUpdate updateType)
        {
            throw new NotImplementedException();
        }

        private static void OnVehicleExplode(int vehicleID)
        {
            throw new NotImplementedException();
        }

        private static void OnVehicleRespawn(int vehicleID)
        {
            throw new NotImplementedException();
        }

        private static void OnObjectShot(int objectID, int playerID, int weaponID)
        {
            throw new NotImplementedException();
        }

        private static void OnObjectTouched(int objectID, int playerID)
        {
            throw new NotImplementedException();
        }

        private static byte OnPickupPickAttempt(int pickupID, int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnPickupPicked(int pickupID, int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnPickupRespawn(int pickupID)
        {
            throw new NotImplementedException();
        }

        private static void OnCheckpointEntered(int checkpointID, int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnCheckpointExited(int checkpointID, int playerID)
        {
            throw new NotImplementedException();
        }

        private static void OnEntityPoolChange(EntityPool entityType, int entityID, byte isDeleted)
        {
            throw new NotImplementedException();
        }

        private static void OnServerPerformanceReport(IntPtr entryCount, IntPtr description, ulong times)
        {
            throw new NotImplementedException();
        }

        private static void OnPlayerModuleList(int playerID, string list)
        {
            throw new NotImplementedException();
        }
    }
}
