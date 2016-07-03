﻿// Copyright (c) Cragon. All rights reserved.

namespace GF.GrainInterface.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Orleans;
    using GF.Unity.Common;

    [Serializable]
    public class MethodData
    {
        public short method_id;
        public byte[] param1;
        public byte[] param2;
        public byte[] param3;
        public byte[] param4;
    }

    public interface IGFPlayer : IGrainWithGuidKey
    {
        //---------------------------------------------------------------------
        // 进入游戏世界
        Task<EntityData> EnterWorld();

        //---------------------------------------------------------------------
        // 离开游戏世界
        Task LeaveWorld();
    }
}