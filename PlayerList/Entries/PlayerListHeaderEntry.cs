﻿using VRC;
using VRChatUtilityKit.Utilities;

namespace PlayerList.Entries
{
    class PlayerListHeaderEntry : EntryBase
    {
        public override string Name { get { return "PlayerList Header"; } }

        public override void Init(object[] parameters = null)
        {
            NetworkEvents.OnPlayerJoined += OnPlayerCountChanged;
            NetworkEvents.OnPlayerLeft += OnPlayerCountChanged;
        }
        private void OnPlayerCountChanged(Player player)
        {
            textComponent.text = OriginalText.Replace("{playercount}", PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0.Count.ToString());
        }
    }
}
