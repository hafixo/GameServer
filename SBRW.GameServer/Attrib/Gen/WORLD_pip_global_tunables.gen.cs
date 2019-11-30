using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_pip_global_tunables : CollectionWrapperBase {
        #region Field Names
        public const string Name_initial_threshold = "initial_threshold";
        public const string Name_crash_force = "crash_force";
        public const string Name_0x3CD2C5BE = "0x3CD2C5BE";
        public const string Name_idle_speed = "idle_speed";
        public const string Name_frequency_factor = "frequency_factor";
        public const string Name_start_delay = "start_delay";
        public const string Name_0xBAEEDDB7 = "0xBAEEDDB7";
        public const string Name_0xD09F5DAD = "0xD09F5DAD";
        public const string Name_time_factor = "time_factor";
        public const string Name_idle_time = "idle_time";
        public const string Name_percent_complete = "percent_complete";
        public const string Name_0xE5EF60EB = "0xE5EF60EB";
        public const string Name_0xF5B2B15B = "0xF5B2B15B";
        #endregion

        public WORLD_pip_global_tunables(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.Single crash_force() {
            return GetValue<System.Single>("crash_force");
        }
        public System.Single field_0x3CD2C5BE() {
            return GetValue<System.Single>("0x3CD2C5BE");
        }
        public System.Single field_0xBAEEDDB7() {
            return GetValue<System.Single>("0xBAEEDDB7");
        }
        public System.Single field_0xD09F5DAD() {
            return GetValue<System.Single>("0xD09F5DAD");
        }
        public List<System.Single> field_0xE5EF60EB() {
            return GetArray<System.Single>("0xE5EF60EB");
        }
        public System.Single field_0xF5B2B15B() {
            return GetValue<System.Single>("0xF5B2B15B");
        }
        public System.Single frequency_factor() {
            return GetValue<System.Single>("frequency_factor");
        }
        public System.Single idle_speed() {
            return GetValue<System.Single>("idle_speed");
        }
        public System.Single idle_time() {
            return GetValue<System.Single>("idle_time");
        }
        public System.Single initial_threshold() {
            return GetValue<System.Single>("initial_threshold");
        }
        public System.Single percent_complete() {
            return GetValue<System.Single>("percent_complete");
        }
        public System.Single start_delay() {
            return GetValue<System.Single>("start_delay");
        }
        public System.Single time_factor() {
            return GetValue<System.Single>("time_factor");
        }
        #endregion

    }
}