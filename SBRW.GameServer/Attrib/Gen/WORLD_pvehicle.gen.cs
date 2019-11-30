using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_pvehicle : CollectionWrapperBase {
        #region Field Names
        public const string Name_transmission = "transmission";
        public const string Name_TurboSND = "TurboSND";
        public const string Name_CLASS = "CLASS";
        public const string Name_BEHAVIOR_ORDER = "BEHAVIOR_ORDER";
        public const string Name_RiskCar_Tier = "RiskCar_Tier";
        public const string Name_Rating = "Rating";
        public const string Name_aivehicle = "aivehicle";
        public const string Name_RacingClass = "RacingClass";
        public const string Name_OnBottomOut = "OnBottomOut";
        public const string Name_brakes = "brakes";
        public const string Name_VerbalType = "VerbalType";
        public const string Name_BEHAVIOR_MECHANIC_SUSPENSION = "BEHAVIOR_MECHANIC_SUSPENSION";
        public const string Name_0x529B4433 = "0x529B4433";
        public const string Name_TopSpeed = "TopSpeed";
        public const string Name_BEHAVIOR_MECHANIC_EFFECTS = "BEHAVIOR_MECHANIC_EFFECTS";
        public const string Name_EventSequencer = "EventSequencer";
        public const string Name_chopperspecs = "chopperspecs";
        public const string Name_RandomOpponent = "RandomOpponent";
        public const string Name_OnScrapeWorld = "OnScrapeWorld";
        public const string Name_rigidbodyspecs = "rigidbodyspecs";
        public const string Name_WooshType = "WooshType";
        public const string Name_BEHAVIOR_MECHANIC_RESET = "BEHAVIOR_MECHANIC_RESET";
        public const string Name_frontend = "frontend";
        public const string Name_BEHAVIOR_MECHANIC_DAMAGE = "BEHAVIOR_MECHANIC_DAMAGE";
        public const string Name_SkidInfo = "SkidInfo";
        public const string Name_BreakerType = "BreakerType";
        public const string Name_ShiftSND = "ShiftSND";
        public const string Name_BEHAVIOR_MECHANIC_RIGIDBODY = "BEHAVIOR_MECHANIC_RIGIDBODY";
        public const string Name_MODEL = "MODEL";
        public const string Name_TrafficEngine = "TrafficEngine";
        public const string Name_Trailer = "Trailer";
        public const string Name_Audio = "Audio";
        public const string Name_CollectionName = "CollectionName";
        public const string Name_Acceleration = "Acceleration";
        public const string Name_BEHAVIOR_MECHANIC_ENGINE = "BEHAVIOR_MECHANIC_ENGINE";
        public const string Name_HornType = "HornType";
        public const string Name_DefaultPresetRide = "DefaultPresetRide";
        public const string Name_HandlingRating = "HandlingRating";
        public const string Name_chassis = "chassis";
        public const string Name_nos = "nos";
        public const string Name_BEHAVIOR_MECHANIC_DRAW = "BEHAVIOR_MECHANIC_DRAW";
        public const string Name_tires = "tires";
        public const string Name_damagespecs = "damagespecs";
        public const string Name_BEHAVIOR_MECHANIC_INPUT = "BEHAVIOR_MECHANIC_INPUT";
        public const string Name_0xC8F8F0D3 = "0xC8F8F0D3";
        public const string Name_induction = "induction";
        public const string Name_UpgradeLevel = "UpgradeLevel";
        public const string Name_Handling = "Handling";
        public const string Name_OnTireBlow = "OnTireBlow";
        public const string Name_OnHitGround = "OnHitGround";
        public const string Name_HitchHeat = "HitchHeat";
        public const string Name_OnScrapeGround = "OnScrapeGround";
        public const string Name_OnHitWorld = "OnHitWorld";
        public const string Name_0xE9C61840 = "0xE9C61840";
        public const string Name_0xEACB7696 = "0xEACB7696";
        public const string Name_PlayerUsable = "PlayerUsable";
        public const string Name_engine = "engine";
        public const string Name_TunedByProduction = "TunedByProduction";
        public const string Name_HasCoplights = "HasCoplights";
        public const string Name_BEHAVIOR_MECHANIC_AUDIO = "BEHAVIOR_MECHANIC_AUDIO";
        public const string Name_OnBottomScrape = "OnBottomScrape";
        #endregion

        public WORLD_pvehicle(VLTCollection collection) : base(collection) {}

        #region Getters
        public List<System.Single> Acceleration() {
            return GetArray<System.Single>("Acceleration");
        }
        public VaultLib.CodeGen.RefSpecWrapper aivehicle() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("aivehicle");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> Audio() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("Audio");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_AUDIO() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_AUDIO");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_DAMAGE() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_DAMAGE");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_DRAW() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_DRAW");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_EFFECTS() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_EFFECTS");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_ENGINE() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_ENGINE");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_INPUT() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_INPUT");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_RESET() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_RESET");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_RIGIDBODY() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_RIGIDBODY");
        }
        public VaultLib.ModernBase.StringKey BEHAVIOR_MECHANIC_SUSPENSION() {
            return GetValue<VaultLib.ModernBase.StringKey>("BEHAVIOR_MECHANIC_SUSPENSION");
        }
        public List<VaultLib.ModernBase.StringKey> BEHAVIOR_ORDER() {
            return GetArray<VaultLib.ModernBase.StringKey>("BEHAVIOR_ORDER");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> brakes() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("brakes");
        }
        public VaultLib.Support.World.VLT.EAIBreakerType BreakerType() {
            return GetValue<VaultLib.Support.World.VLT.EAIBreakerType>("BreakerType");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> chassis() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("chassis");
        }
        public VaultLib.CodeGen.RefSpecWrapper chopperspecs() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("chopperspecs");
        }
        public VaultLib.ModernBase.StringKey CLASS() {
            return GetValue<VaultLib.ModernBase.StringKey>("CLASS");
        }
        public System.String CollectionName() {
            return GetValue<System.String>("CollectionName");
        }
        public VaultLib.CodeGen.RefSpecWrapper damagespecs() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("damagespecs");
        }
        public System.String DefaultPresetRide() {
            return GetValue<System.String>("DefaultPresetRide");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> engine() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("engine");
        }
        public VaultLib.ModernBase.StringKey EventSequencer() {
            return GetValue<VaultLib.ModernBase.StringKey>("EventSequencer");
        }
        public System.Boolean field_0x529B4433() {
            return GetValue<System.Boolean>("0x529B4433");
        }
        public VaultLib.CodeGen.RefSpecWrapper field_0xC8F8F0D3() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("0xC8F8F0D3");
        }
        public VaultLib.Support.World.VLT.Sound.TriggeredAudioFeature field_0xE9C61840() {
            return GetValue<VaultLib.Support.World.VLT.Sound.TriggeredAudioFeature>("0xE9C61840");
        }
        public System.Boolean field_0xEACB7696() {
            return GetValue<System.Boolean>("0xEACB7696");
        }
        public VaultLib.CodeGen.RefSpecWrapper frontend() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("frontend");
        }
        public List<System.Single> Handling() {
            return GetArray<System.Single>("Handling");
        }
        public List<System.Single> HandlingRating() {
            return GetArray<System.Single>("HandlingRating");
        }
        public System.Boolean HasCoplights() {
            return GetValue<System.Boolean>("HasCoplights");
        }
        public List<VaultLib.Support.World.VLT.EffectLinkageRecord> HitchHeat() {
            return GetArray<VaultLib.Support.World.VLT.EffectLinkageRecord>("HitchHeat");
        }
        public List<System.Byte> HornType() {
            return GetArray<System.Byte>("HornType");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> induction() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("induction");
        }
        public VaultLib.ModernBase.StringKey MODEL() {
            return GetValue<VaultLib.ModernBase.StringKey>("MODEL");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> nos() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("nos");
        }
        public List<VaultLib.Support.World.VLT.EffectLinkageRecord> OnBottomOut() {
            return GetArray<VaultLib.Support.World.VLT.EffectLinkageRecord>("OnBottomOut");
        }
        public List<VaultLib.Support.World.VLT.EffectLinkageRecord> OnBottomScrape() {
            return GetArray<VaultLib.Support.World.VLT.EffectLinkageRecord>("OnBottomScrape");
        }
        public List<VaultLib.Support.World.VLT.EffectLinkageRecord> OnHitGround() {
            return GetArray<VaultLib.Support.World.VLT.EffectLinkageRecord>("OnHitGround");
        }
        public List<VaultLib.Support.World.VLT.EffectLinkageRecord> OnHitWorld() {
            return GetArray<VaultLib.Support.World.VLT.EffectLinkageRecord>("OnHitWorld");
        }
        public List<VaultLib.Support.World.VLT.EffectLinkageRecord> OnScrapeGround() {
            return GetArray<VaultLib.Support.World.VLT.EffectLinkageRecord>("OnScrapeGround");
        }
        public List<VaultLib.Support.World.VLT.EffectLinkageRecord> OnScrapeWorld() {
            return GetArray<VaultLib.Support.World.VLT.EffectLinkageRecord>("OnScrapeWorld");
        }
        public VaultLib.CodeGen.RefSpecWrapper OnTireBlow() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("OnTireBlow");
        }
        public System.Boolean PlayerUsable() {
            return GetValue<System.Boolean>("PlayerUsable");
        }
        public VaultLib.Support.World.VLT.GRace.RaceCarClass RacingClass() {
            return GetValue<VaultLib.Support.World.VLT.GRace.RaceCarClass>("RacingClass");
        }
        public System.Boolean RandomOpponent() {
            return GetValue<System.Boolean>("RandomOpponent");
        }
        public List<System.Single> Rating() {
            return GetArray<System.Single>("Rating");
        }
        public VaultLib.CodeGen.RefSpecWrapper rigidbodyspecs() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("rigidbodyspecs");
        }
        public List<VaultLib.Support.World.VLT.EffectLinkageRecord> RiskCar_Tier() {
            return GetArray<VaultLib.Support.World.VLT.EffectLinkageRecord>("RiskCar_Tier");
        }
        public List<VaultLib.Support.World.VLT.UpgradeSpecs> ShiftSND() {
            return GetArray<VaultLib.Support.World.VLT.UpgradeSpecs>("ShiftSND");
        }
        public VaultLib.CodeGen.RefSpecWrapper SkidInfo() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("SkidInfo");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> tires() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("tires");
        }
        public List<System.Single> TopSpeed() {
            return GetArray<System.Single>("TopSpeed");
        }
        public VaultLib.CodeGen.RefSpecWrapper TrafficEngine() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("TrafficEngine");
        }
        public VaultLib.CodeGen.RefSpecWrapper Trailer() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("Trailer");
        }
        public List<VaultLib.CodeGen.RefSpecWrapper> transmission() {
            return GetArray<VaultLib.CodeGen.RefSpecWrapper>("transmission");
        }
        public System.Boolean TunedByProduction() {
            return GetValue<System.Boolean>("TunedByProduction");
        }
        public List<VaultLib.Support.World.VLT.UpgradeSpecs> TurboSND() {
            return GetArray<VaultLib.Support.World.VLT.UpgradeSpecs>("TurboSND");
        }
        public System.Single UpgradeLevel() {
            return GetValue<System.Single>("UpgradeLevel");
        }
        public VaultLib.Support.World.VLT.Csis.Type_car_type VerbalType() {
            return GetValue<VaultLib.Support.World.VLT.Csis.Type_car_type>("VerbalType");
        }
        public VaultLib.Support.World.VLT.eDRIVE_BY_TYPE WooshType() {
            return GetValue<VaultLib.Support.World.VLT.eDRIVE_BY_TYPE>("WooshType");
        }
        #endregion

    }
}