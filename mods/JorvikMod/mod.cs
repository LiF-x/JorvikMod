/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxJorvikConversion))
{
    new ScriptObject(LiFxJorvikConversion)
    {
    };
}

package LiFxJorvikConversion

{
    function LiFxJorvikConversion::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, ConChanges, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, SmallWoodenShed, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, WoodenCross, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, WoodenBridge, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, StoneBridge, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, MetalCage, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, WoodenPier, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, WoodenBarricadeA, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, StoneAltar, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, WoodenTowerHouse, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, WoodenChurch, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, WoodenPierT, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, WoodenPierL, LiFxJorvikConversion);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, StoneTombCross, LiFxJorvikConversion); 
       
        // Register new objects
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenCross(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenBridge(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesStoneBridge(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesSmallWoodenshed(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesMetalCage(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenPier(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenBarricadeA(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenBarricade(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesStoneAltar(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenTowerHouse(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenChurch(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenPierT(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesWoodenPierL(), LiFxJorvikConversion);
        LiFx::registerObjectsTypes(LiFxJorvikConversion::ObjectsTypesStoneTombCross(), LiFxJorvikConversion);
    }
    function LiFxJorvikConversion::version() {
        return "1.0.1";
    }

    function LiFxJorvikConversion::ObjectsTypesWoodenCross() {
        return new ScriptObject(ObjectsTypesWoodenCross : ObjectsTypes)
        {
            id = 2400; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Cross";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_cross.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesWoodenBridge() {
        return new ScriptObject(ObjectsTypesWoodenBridge : ObjectsTypes)
        {
            id = 2401; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Bridge";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_bridge.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesStoneBridge() {
        return new ScriptObject(ObjectsTypesStoneBridge : ObjectsTypes)
        {
            id = 2402; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Stone Bridge";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/stone_bridge.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesSmallWoodenshed() {
        return new ScriptObject(ObjectsTypesSmallWoodenshed : ObjectsTypes)
        {
            id = 2403; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Small wooden shed";
            ParentID = 69;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 5000000;
            Length = 8; 
            MaxStackSize = 0;
            UnitWeight = 10000;
            BackgrndImage = "art\\\\images\\\\warehouse";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/small_wooden_shed.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = 194200;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    } 
    function LiFxJorvikConversion::ObjectsTypesMetalCage() {
        return new ScriptObject(ObjectsTypesSmallMetalCage : ObjectsTypes)
        {
            id = 2404; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Metal Cage";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 1;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/metal_cage.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesWoodenPier() {
        return new ScriptObject(ObjectsTypesWoodenPier : ObjectsTypes)
        {
            id = 2405; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Pier";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_pier.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesWoodenBarricadeA() {
        return new ScriptObject(ObjectsTypesWoodenBarricadeA : ObjectsTypes)
        {
            id = 2406; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Barricade";
            ParentID = 130;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 4; 
            MaxStackSize = 0;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_barricade.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = 2400;
            OwnerTimeout = 120;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxJorvikConversion::ObjectsTypesWoodenBarricade() {
        return new ScriptObject(ObjectsTypesWoodenBarricade : ObjectsTypes)
        {
            id = 2407; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Barricade";
            ParentID = 1902;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 2000;
            Length = 4; 
            MaxStackSize = 1;
            UnitWeight = 2000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_barricade.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesStoneAltar() {
        return new ScriptObject(ObjectsTypesStoneAltar : ObjectsTypes)
        {
            id = 2408; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Stone Altar";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_barricade.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesWoodenTowerHouse() {
        return new ScriptObject(ObjectsTypesWoodenTowerHouse : ObjectsTypes)
        {
            id = 2409; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Tower House";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 1;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 12;
            UnitWeight = 200000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "mods\JorvikMod\art\2D\objects\wooden_house_with_tower.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesWoodenChurch() {
        return new ScriptObject(ObjectsTypesWoodenChurch : ObjectsTypes)
        {
            id = 2410; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Church";
            ParentID = 72;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 1;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_church.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesWoodenPierT() {
        return new ScriptObject(ObjectsTypesWoodenPierT : ObjectsTypes)
        {
            id = 2411; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Pier T";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/pier_T.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesWoodenPierL() {
        return new ScriptObject(ObjectsTypesWoodenPierL : ObjectsTypes)
        {
            id = 2412; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Wooden Pier L";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/pier_T.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::ObjectsTypesStoneTombCross() {
        return new ScriptObject(ObjectsTypesStoneTombCross : ObjectsTypes)
        {
            id = 2413; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Stone Tomb Cross";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 1;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/stone_tomb_with_cross.png";
            Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxJorvikConversion::conChanges() {
      dbi.Update("INSERT IGNORE `objects_conversions` VALUES (NULL, 2406, 2407)");
      }

  function LiFxJorvikConversion::SmallWoodenShed() {
    dbi.Select(LiFxJorvikConversion, "SmallWoodenShedRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Small Wooden Shed', 'Object from Jorvik MOD pack \n CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK.', 32, 18, 60, 2403, 25, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/small_wooden_shed.png') RETURNING ID");
  }
  function LiFxJorvikConversion::SmallWoodenShedRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 20, 4, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  326, 0, 20, 40, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281, 0, 10, 40, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  1356, 0, 20, 10, 0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

  function LiFxJorvikConversion::WoodenCross() {
    dbi.Select(LiFxJorvikConversion, "WoodenCrossRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Wooden Cross', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 34, 54, 60, 2400, 25, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_cross.png') RETURNING ID");
  }
  function LiFxJorvikConversion::WoodenCrossRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 65, 2, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  34, 0, 10, 40, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  247, 0, 0, 1, 0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxJorvikConversion::WoodenBridge() {
    dbi.Select(LiFxJorvikConversion, "WoodenBridgeRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Wooden Bridge', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 18, 60, 2401, 10, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_bridge.png') RETURNING ID");
  }
  function LiFxJorvikConversion::WoodenBridgeRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  326, 0, 30, 18, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 20, 4, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  32, 0, 10, 15, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  262, 0, 20, 8, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281, 0, 20, 40, 0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

  function LiFxJorvikConversion::StoneBridge() {
    dbi.Select(LiFxJorvikConversion, "StoneBridgeRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Stone Bridge', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 19, 60, 2402, 10, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/stone_bridge.png') RETURNING ID");
  }
  function LiFxJorvikConversion::StoneBridgeRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  269, 0, 30, 100, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 20, 8, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  32, 0, 10, 15, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  528, 0, 20, 40, 0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxJorvikConversion::MetalCage() {
    dbi.Select(LiFxJorvikConversion, "MetalCageRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Metal Cage', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 19, 60, 2404, 35, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/metal_cage.png') RETURNING ID");
  }
  function LiFxJorvikConversion::MetalCageRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  282, 0, 20, 4, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  283, 0, 20, 2, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxJorvikConversion::WoodenPier() {
    dbi.Select(LiFxJorvikConversion, "WoodenPierRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Wooden Pier', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 18, 60, 2405, 10, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_pier.png') RETURNING ID");
  }
  function LiFxJorvikConversion::WoodenPierRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  326, 0, 30, 18, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 20, 8, 0)");//done
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  32, 0, 10, 25, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281, 0, 10, 40, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxJorvikConversion::WoodenBarricadeA() {
    dbi.Select(LiFxJorvikConversion, "WoodenBarricadeRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Wooden Barricade', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 36, 18, 60, 2406, 40, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_barricade.png') RETURNING ID");
  }
  function LiFxJorvikConversion::WoodenBarricadeRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 20, 3, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  1356, 0, 20, 4, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }
    function LiFxJorvikConversion::StoneAltar() {
    dbi.Select(LiFxJorvikConversion, "StoneAltarRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Stone Altar', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 19, 60, 2408, 10, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/stone_altar.png') RETURNING ID");
  }
  function LiFxJorvikConversion::StoneAltarRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  269, 0, 30, 80, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  32, 0, 10, 10, 0)");//done
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  528, 0, 20, 30, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  270, 0, 20, 4, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxJorvikConversion::WoodenTowerHouse() {
    dbi.Select(LiFxJorvikConversion, "WoodenTowerHouseRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Wooden Tower House', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 36, 18, 60, 2409, 10, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_house_with_tower.png') RETURNING ID");
  }
  function LiFxJorvikConversion::WoodenTowerHouseRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 30, 200, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281, 0, 10, 400, 0)");//done
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  286, 0, 10, 1, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  326, 0, 5, 230, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxJorvikConversion::WoodenChurch() {
    dbi.Select(LiFxJorvikConversion, "WoodenChurchRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Wooden Church', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 19, 60, 2410, 35, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_church.png') RETURNING ID");
  }
  function LiFxJorvikConversion::WoodenChurchRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 30, 250, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281, 0, 10, 400, 0)");//done
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  286, 0, 10, 2, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  288, 0, 5, 6, 0)");//done
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  326, 0, 5, 280, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxJorvikConversion::WoodenPierT() {
    dbi.Select(LiFxJorvikConversion, "WoodenPierTRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Wooden Pier T', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 18, 60, 2411, 10, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/pier_T.png') RETURNING ID");
  }
  function LiFxJorvikConversion::WoodenPierTRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  326, 0, 30, 36, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 20, 16, 0)");//done
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  32, 0, 10, 50, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281, 0, 10, 80, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxJorvikConversion::WoodenPierL() {
    dbi.Select(LiFxJorvikConversion, "WoodenPierLRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Wooden Pier L', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 18, 60, 2412, 10, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/pier_L.png') RETURNING ID");
  }
  function LiFxJorvikConversion::WoodenPierLRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  326, 0, 30, 36, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233, 0, 20, 16, 0)");//done
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  32, 0, 10, 50, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281, 0, 10, 80, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  } 

    function LiFxJorvikConversion::StoneTombCross() {
    dbi.Select(LiFxJorvikConversion, "StoneTombCrossRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Stone tomb with cross', 'Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK', 32, 19, 60, 2413, 10, 1, 0, 0, 'yolauncher/modpack/mods/Jorvik/art/2D/recipes/stone_tomb_with_cross.png') RETURNING ID");
  }
  function LiFxJorvikConversion::StoneTombCrossRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  269, 0, 30, 50, 0)");//no tool
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  528, 0, 20, 20, 0)");//done
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  
  }
};
activatePackage(LiFxJorvikConversion);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxJorvikConversion);