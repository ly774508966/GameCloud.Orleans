﻿using System;
using System.Collections.Generic;
using GameCloud.Unity.Common;

public class EtAutoPatcher : EntityDef
{
    //-------------------------------------------------------------------------
    public override void declareAllComponent(byte node_type)
    {
        declareComponent<DefAutoPatcher>();
    }
}
