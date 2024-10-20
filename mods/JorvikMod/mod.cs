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
        

        // Register new recipes
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeSmallWoodenShed(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeWoodenCross(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeWoodenBridge(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeStoneBridge(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeMetalCage(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeWoodenPier(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeWoodenBarricadeA(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeStoneAltar(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeWoodenTowerHouse(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeWoodenChurch(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeWoodenPierT(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeWoodenPierL(), LiFxJorvikConversion);
        LiFx::registerRecipe(LiFxJorvikConversion::RecipeStoneTombCross(), LiFxJorvikConversion);
        

    }
    function LiFxJorvikConversion::version() {
        return "1.2.0";
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
          FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/wooden_cross.png";
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
          FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/wooden_bridge.png";
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
          FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/stone_bridge.png";
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
          FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/small_wooden_shed.png";
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
          FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/metal_cage.png";
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
          FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/wooden_pier.png";
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
          FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/wooden_barricade.png";
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
        FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/wooden_barricade.png";
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
        FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/wooden_barricade.png";
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
        FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/wooden_house_with_tower.png";
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
        FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/wooden_church.png";
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
        FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/pier_T.png";
        Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
        BasePrice = 0;
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
        FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/pier_T.png";
        Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
        BasePrice = 0;
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
        FaceImage = "yolauncher/modpack/mods/Jorvik/art/2D/objects/stone_tomb_with_cross.png";
        Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
        BasePrice = 0;
        OwnerTimeout = NULL;
        AllowExportFromRed = 0;
        AllowExportFromGreen = 0;
    };
  }
  function LiFxJorvikConversion::conChanges() {
    dbi.Update("INSERT IGNORE `objects_conversions` VALUES (NULL, 2406, 2407)");
  }
  function LiFxJorvikConversion::RecipeSmallWoodenShed(%this)
  {
    %recipe =  new ScriptObject(RecipeSmallWoodenShed : Recipes)
    {
      RecipeName = "Small Wooden Shed";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 18;
      SkillLevel = 60;
      ResultObjectTypeID = 2403;
      SkillDepends = 25;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/small_wooden_shed.png";
      Requirements = JettisonArray("RecipeSmallWoodenShedRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 20;
        Quantity = 4;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 326;
        Quality = 0;
        Influence = 20;
        Quantity = 40;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 281;
        Quality = 0;
        Influence = 15;
        Quantity = 40;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 1356;
        Quality = 0;
        Influence = 20;
        Quantity = 10;
        IsRegionalItemRequired = 0; 
    });
    // %recipe.Requirements.Push(RecipeRequirements, LiFx::RecipeRequirement(1356,0,20,10,0));
    return %recipe;
  }
  function LiFxJorvikConversion::RecipeWoodenCross(%this) 
  {
    %recipe =  new ScriptObject(RecipeWoodenCross : Recipes)
    {
      RecipeName = "Wooden Cross";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 34;
      SkillTypeID = 54;
      SkillLevel = 60;
      ResultObjectTypeID = 2400;
      SkillDepends = 25;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_cross.png";
      Requirements = JettisonArray("RecipeWoodenCrossRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 65;
        Quantity = 2;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 34;
        Quality = 0;
        Influence = 10;
        Quantity = 40;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 247;
        Quality = 0;
        Influence = 0;
        Quantity = 1;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }
  
  function LiFxJorvikConversion::RecipeWoodenBridge() {
    %recipe =  new ScriptObject(RecipeWoodenBridge : Recipes)
    {
      RecipeName = "Wooden Bridge";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 18;
      SkillLevel = 60;
      ResultObjectTypeID = 2401;
      SkillDepends = 10;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_bridge.png";
      Requirements = JettisonArray("RecipeWoodenBridgeRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 20;
        Quantity = 4;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 326;
        Quality = 0;
        Influence = 30;
        Quantity = 40;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 281;
        Quality = 0;
        Influence = 15;
        Quantity = 40;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 262;
        Quality = 0;
        Influence = 15;
        Quantity = 8;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 10;
        Quantity = 15;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }

  function LiFxJorvikConversion::RecipeStoneBridge() {
    %recipe =  new ScriptObject(RecipeStoneBridge : Recipes)
    {
      RecipeName = "Stone Bridge";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 19;
      SkillLevel = 60;
      ResultObjectTypeID = 2402;
      SkillDepends = 10;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/stone_bridge.png";
      Requirements = JettisonArray("RecipeStoneBridgeRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 269;
        Quality = 0;
        Influence = 30;
        Quantity = 100;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 20;
        Quantity = 8;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 20;
        Quantity = 15;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 528;
        Quality = 0;
        Influence = 20;
        Quantity = 40;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }

  function LiFxJorvikConversion::RecipeMetalCage() {
    %recipe =  new ScriptObject(RecipeMetalCage : Recipes)
    {
      RecipeName = "Metal Cage";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 19;
      SkillLevel = 60;
      ResultObjectTypeID = 2404;
      SkillDepends = 35;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/metal_cage.png";
      Requirements = JettisonArray("RecipeMetalCageRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 282;
        Quality = 0;
        Influence = 30;
        Quantity = 4;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 283;
        Quality = 0;
        Influence = 30;
        Quantity = 2;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 5;
        Quantity = 2;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }


  function LiFxJorvikConversion::RecipeWoodenPier() {
    %recipe =  new ScriptObject(RecipeWoodenPier : Recipes)
    {
      RecipeName = "Wooden Pier";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 18;
      SkillLevel = 60;
      ResultObjectTypeID = 2405;
      SkillDepends = 10;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_pier.png";
      Requirements = JettisonArray("RecipeWoodenPierRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 326;
        Quality = 0;
        Influence = 35;
        Quantity = 18;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 25;
        Quantity = 8;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 10;
        Quantity = 25;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 281;
        Quality = 0;
        Influence = 20;
        Quantity = 40;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }


  function LiFxJorvikConversion::RecipeWoodenBarricadeA() {
    %recipe =  new ScriptObject(RecipeWoodenBarricadeA : Recipes)
    {
      RecipeName = "Wooden Barricade";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 36;
      SkillTypeID = 18;
      SkillLevel = 60;
      ResultObjectTypeID = 2406;
      SkillDepends = 40;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_barricade.png";
      Requirements = JettisonArray("RecipeWoodenBarricadeRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 20;
        Quantity = 3;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 1356;
        Quality = 0;
        Influence = 20;
        Quantity = 4;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 36;
        Quality = 0;
        Influence = 20;
        Quantity = 4;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }


  function LiFxJorvikConversion::RecipeStoneAltar() {
    %recipe =  new ScriptObject(RecipeStoneAltar : Recipes)
    {
      RecipeName = "Stone Altar";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 19;
      SkillLevel = 60;
      ResultObjectTypeID = 2408;
      SkillDepends = 10;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/stone_altar.png";
      Requirements = JettisonArray("RecipeStoneAltarRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 269;
        Quality = 0;
        Influence = 30;
        Quantity = 80;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 20;
        Quantity = 10;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 528;
        Quality = 0;
        Influence = 20;
        Quantity = 30;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 270;
        Quality = 0;
        Influence = 20;
        Quantity = 4;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }


  function LiFxJorvikConversion::RecipeWoodenTowerHouse() {
    %recipe =  new ScriptObject(RecipeWoodenTowerHouse : Recipes)
    {
      RecipeName = "Wooden Tower House";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 36;
      SkillTypeID = 18;
      SkillLevel = 60;
      ResultObjectTypeID = 2409;
      SkillDepends = 10;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_house_with_tower.png";
      Requirements = JettisonArray("RecipeWoodenTowerHouseRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 40;
        Quantity = 20;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 281;
        Quality = 0;
        Influence = 20;
        Quantity = 20;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 286;
        Quality = 0;
        Influence = 20;
        Quantity = 1;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 326;
        Quality = 0;
        Influence = 5;
        Quantity = 5;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 36;
        Quality = 0;
        Influence = 5;
        Quantity = 5;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }


  function LiFxJorvikConversion::RecipeWoodenChurch() {
    %recipe =  new ScriptObject(RecipeWoodenChurch : Recipes)
    {
      RecipeName = "Wooden Church";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 19;
      SkillLevel = 60;
      ResultObjectTypeID = 2410;
      SkillDepends = 35;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/wooden_church.png";
      Requirements = JettisonArray("RecipeWoodenChurchRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 30;
        Quantity = 250;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 281;
        Quality = 0;
        Influence = 10;
        Quantity = 400;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 286;
        Quality = 0;
        Influence = 10;
        Quantity = 2;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 288;
        Quality = 0;
        Influence = 5;
        Quantity = 6;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 326;
        Quality = 0;
        Influence = 5;
        Quantity = 280;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 5;
        Quantity = 280;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }

  function LiFxJorvikConversion::RecipeWoodenPierT() {
    %recipe =  new ScriptObject(RecipeWoodenPierT : Recipes)
    {
      RecipeName = "Wooden Pier T";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 18;
      SkillLevel = 60;
      ResultObjectTypeID = 2411;
      SkillDepends = 10;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/pier_T.png";
      Requirements = JettisonArray("RecipeWoodenPierTRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 326;
        Quality = 0;
        Influence = 40;
        Quantity = 36;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 30;
        Quantity = 16;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 10;
        Quantity = 50;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 281;
        Quality = 0;
        Influence = 10;
        Quantity = 80;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }


  function LiFxJorvikConversion::RecipeWoodenPierL() {
    %recipe =  new ScriptObject(RecipeWoodenPierL : Recipes)
    {
      RecipeName = "Wooden Pier L";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 18;
      SkillLevel = 60;
      ResultObjectTypeID = 2412;
      SkillDepends = 10;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/pier_L.png";
      Requirements = JettisonArray("RecipeWoodenPierLRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 326;
        Quality = 0;
        Influence = 35;
        Quantity = 36;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 25;
        Quantity = 16;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 15;
        Quantity = 50;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 281;
        Quality = 0;
        Influence = 15;
        Quantity = 80;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }


  function LiFxJorvikConversion::RecipeStoneTombCross() {
    %recipe =  new ScriptObject(RecipeStoneTombCross : Recipes)
    {
      RecipeName = "Stone tomb with cross";
      Description = "Object from Jorvik MOD pack CONVERTED TO LIFX AND YO LAUNCHER FRAMEWORK";
      StartingToolsID = 32;
      SkillTypeID = 19;
      SkillLevel = 60;
      ResultObjectTypeID = 2413;
      SkillDepends = 10;
      Quantity = 1;
      Autorepeat = 0;
      IsBlueprint = 0;
      ImagePath = "yolauncher/modpack/mods/Jorvik/art/2D/recipes/stone_tomb_with_cross.png";
      Requirements = JettisonArray("RecipeStoneTombCrossRequirements");

    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){
        MaterialObjectTypeID = 269;
        Quality = 0;
        Influence = 45;
        Quantity = 50;
        IsRegionalItemRequired = 0; 
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 528;
        Quality = 0;
        Influence = 35;
        Quantity = 20;
        IsRegionalItemRequired = 0; 
    });
    
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements){ 
        MaterialObjectTypeID = 32;
        Quality = 0;
        Influence = 10;
        Quantity = 20;
        IsRegionalItemRequired = 0; 
    });
    return %recipe;
  }
};
activatePackage(LiFxJorvikConversion);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxJorvikConversion);