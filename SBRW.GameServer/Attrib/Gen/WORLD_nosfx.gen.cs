using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_nosfx : CollectionWrapperBase {
        #region Field Names
        public const string Name_0x170476A4 = "0x170476A4";
        public const string Name_AlwaysActive = "AlwaysActive";
        public const string Name_DebugMode = "DebugMode";
        public const string Name_Tint = "Tint";
        public const string Name_NOSEffect = "NOSEffect";
        public const string Name_Intensity = "Intensity";
        public const string Name_Texture = "Texture";
        #endregion

        public WORLD_nosfx(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Boolean AlwaysActive() {
            return GetValue<System.Boolean>("AlwaysActive");
        }
        public System.Boolean DebugMode() {
            return GetValue<System.Boolean>("DebugMode");
        }
        public System.Single field_0x170476A4() {
            return GetValue<System.Single>("0x170476A4");
        }
        public System.Single Intensity() {
            return GetValue<System.Single>("Intensity");
        }
        public VaultLib.CodeGen.RefSpecWrapper NOSEffect() {
            return GetValue<VaultLib.CodeGen.RefSpecWrapper>("NOSEffect");
        }
        public System.Int32 Texture() {
            return GetValue<System.Int32>("Texture");
        }
        public VaultLib.Core.Types.Attrib.Types.Vector4 Tint() {
            return GetValue<VaultLib.Core.Types.Attrib.Types.Vector4>("Tint");
        }
        #endregion

    }
}